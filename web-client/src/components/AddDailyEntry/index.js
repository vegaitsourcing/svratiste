import React, { Component } from 'react';
import Select from 'react-select';

import * as DailyEntyActions from '../../actions/DailyEntryActions';
import * as CardboardActions from '../../actions/CardboardActions';
import * as EnumerationActions from '../../actions/EnumerationActions';

import * as DailyEntryService from '../../services/DailyEntryService';

import EnumerationStore from '../../stores/EnumerationStore';

class AddDailyEntry extends Component {
    constructor(props) {
        super(props);

        this.state = {
            firstName: '',
            lastName: '',
            gender: '',
            stay: false,
            breakfast: false,
            lunch: false,
            bath: false,
            liecesRemoval: false,
            cartonId: '',
            clothes: 0,
            mediationWriting: 0,
            mediationWritingDescription: '',
            mediationSpeaking: 0,
            mediationSpeakingDescription: '',
            lifeSkills: 0,
            schoolAcivities: 0,
            workshops: [],
            psihosocialSupport: false,
            parentsContact: false,
            medicalInterventions: 0,
            arrival: '',
            pageNumber: props.pageNumber,

            // enumerations
            mediationWritingsEnum: [],
            mediationSpeakingsEnum: [],
            lifeSkillsEnum: [],
            workshopTypesEnum: [],
            schoolActivitiesEnum: [],
            medicalInterventionsEnum: []
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleInputChangeWorkshop = this.handleInputChangeWorkshop.bind(this);
        this.handleCheckboxChange = this.handleCheckboxChange.bind(this);
        this.onClose = this.onClose.bind(this);
        this.onSave = this.onSave.bind(this);

        this.getMediationWritings = this.getMediationWritings.bind(this);
        this.getMediationSpeakings = this.getMediationSpeakings.bind(this);
        this.getLifeSkills = this.getLifeSkills.bind(this);
        this.handleLifeSkillsChange = this.handleLifeSkillsChange.bind(this);
        this.getWorkshopTypes = this.getWorkshopTypes.bind(this);
        this.handleWorkshopTypesChange = this.handleWorkshopTypesChange.bind(this);
        this.getSchoolActivities = this.getSchoolActivities.bind(this);
        this.handleSchoolActivitiesChange = this.handleSchoolActivitiesChange.bind(this);
        this.handleMedicalInterventionsChange = this.handleMedicalInterventionsChange.bind(this);
        this.getMedicalInterventions = this.getMedicalInterventions.bind(this);
    }

    componentWillMount() {
        EnumerationStore.on("fetched_mediation_writings", this.getMediationWritings);
        EnumerationStore.on("fetched_mediation_speakings", this.getMediationSpeakings);
        EnumerationStore.on("fetched_life_skills", this.getLifeSkills);
        EnumerationStore.on("fetched_workshop_types", this.getWorkshopTypes);
        EnumerationStore.on("fetched_school_activities", this.getSchoolActivities);
        EnumerationStore.on("fetched_medical_intervetions", this.getMedicalInterventions);
    }

    componentWillUnmount() {
        EnumerationStore.removeListener("fetched_mediation_writings", this.getMediationWritings);
        EnumerationStore.removeListener("fetched_mediation_speakings", this.getMediationSpeakings);
        EnumerationStore.removeListener("fetched_life_skills", this.getLifeSkills);
        EnumerationStore.removeListener("fetched_workshop_types", this.getWorkshopTypes);
        EnumerationStore.removeListener("fetched_school_activities", this.getSchoolActivities);
        EnumerationStore.removeListener("fetched_medical_intervetions", this.getMedicalInterventions);
    }

    componentDidMount() {
        const { firstName, lastName, gender } = this.props.data;
        const cartonId = this.props.data.id;
        this.setState({ firstName, lastName, gender, cartonId });

        //
        EnumerationActions.getMediationWritings();
        EnumerationActions.getMediationSpeakings();
        EnumerationActions.getLifeSkills();
        EnumerationActions.getWorkshopTypes();
        EnumerationActions.getSchoolActivities();
        EnumerationActions.getMedicalInterventions();
    }

    getMediationWritings() {
        this.setState({
            mediationWritingsEnum: EnumerationStore.getMediationWritings()
        });
    }

    getMediationSpeakings() {
        this.setState({
            mediationSpeakingsEnum: EnumerationStore.getMediationSpeakings()
        });
    }

    getLifeSkills() {
        this.setState({
            lifeSkillsEnum: EnumerationStore.getLifeSkills()
        });
    }

    getWorkshopTypes() {
        this.setState({
            workshopTypesEnum: EnumerationStore.getWorkshopTypes()
        });
    }

    getSchoolActivities() {
        this.setState({
            schoolActivitiesEnum: EnumerationStore.getSchoolActivities()
        });
    }

    getMedicalInterventions() {
        this.setState({
            medicalInterventionsEnum: EnumerationStore.getMedicalIntervetions()
        });
    }

    handleCheckboxChange(event) {
        const { target } = event;
        const { name, checked } = target;

        this.setState({ [name]: checked });
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    handleInputChangeWorkshop(item, event) {
        const { target } = event;
        const { name, value } = target;

        const newWorkshops = DailyEntryService.correctWorkshop(this.state.workshops, item.WorkshopType, name, value);

        this.setState({
            workshops: newWorkshops
        });
    }

    handleLifeSkillsChange(items) {
        let lifeSkills = items.reduce(function (prev, cur) {
            return prev + cur.value;
        }, 0);
        this.setState({ lifeSkills });
    }

    handleSchoolActivitiesChange(items) {
        let schoolAcivities = items.reduce(function (prev, cur) {
            return prev + cur.value;
        }, 0);
        this.setState({ schoolAcivities });
    }

    handleMedicalInterventionsChange(items) {
        let medicalInterventions = items.reduce(function (prev, cur) {
            return prev + cur.value;
        }, 0);
        this.setState({ medicalInterventions });
    }

    handleWorkshopTypesChange(items) {
        let oldWorkshops = this.state.workshops;
        let selectedWorkshops = items.map((workshop) => {
            let currentIndex = oldWorkshops.find(ws => ws.WorkshopType == workshop.value);

            return {
                WorkshopType: workshop.value,
                Number: currentIndex ? currentIndex.Number : 0,
                label: workshop.name
            }
        });

        this.setState({ workshops: selectedWorkshops });
    }

    onClose() {
        CardboardActions.hideAddDailyEntryBar();
        CardboardActions.hideEditBar();
        CardboardActions.hideAddBar();
    }

    onSave() {
        DailyEntyActions.addDailyEntry(this.state);
    }

    render() {
        let className = 'side-items side-items-create';
        if (this.props.open) {
            className += ' opened';
        }

        return (<div className="carton-table">
            <div className={className}>
                <h2><font color="white">{this.state.firstName} {this.state.lastName}</font></h2>
                <table className="table table-position">
                    <thead className="thead-light">
                        <tr>
                            <th scope="col">Stavka</th>
                            <th scope="col">#</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td className="info">Boravak:</td>
                            <td><input type="checkbox"
                                name="stay"
                                defaultChecked={this.state.stay}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Doručak:</td>
                            <td><input type="checkbox"
                                name="breakfast"
                                defaultChecked={this.state.breakfast}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Ručak:</td>
                            <td><input type="checkbox"
                                name="lunch"
                                defaultChecked={this.state.lunch}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Večera:</td>
                            <td><input type="checkbox"
                                name="diner"
                                defaultChecked={this.state.diner}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Kupanje:</td>
                            <td><input type="checkbox"
                                name="bath"
                                defaultChecked={this.state.bath}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Devaširanje:</td>
                            <td><input type="checkbox"
                                name="liecesRemoval"
                                defaultChecked={this.state.liecesRemoval}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Odeća i obuća:</td>
                            <td><input type="number"
                                name="clothes"
                                defaultChecked={this.state.clothes}
                                onChange={this.handleInputChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Pismeno Obraćanje:</td>
                            <td>
                                <select className="combobox"
                                    name="mediationWriting"
                                    onChange={this.handleInputChange}
                                    value={this.state.mediationWriting}
                                    required>

                                    {this.state.mediationWritingsEnum.map((mediationWr) => (
                                        <option key={mediationWr.value} value={mediationWr.value}>
                                            {mediationWr.name}
                                        </option>
                                    ))}
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td className="info">Pismeno Obraćanje opis:</td>
                            <td><input type="text"
                                name="mediationWritingDescription"
                                defaultChecked={this.state.mediationWritingDescription}
                                onChange={this.handleInputChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Usmeno Obraćanje:</td>
                            <td>
                                <select className="combobox"
                                    name="mediationSpeaking"
                                    onChange={this.handleInputChange}
                                    value={this.state.mediationSpeaking}
                                    required>

                                    {this.state.mediationSpeakingsEnum.map((mediationSp) => (
                                        <option key={mediationSp.value} value={mediationSp.value}>
                                            {mediationSp.name}
                                        </option>
                                    ))}
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td className="info">Usmeno Obraćanje opis:</td>
                            <td><input type="text"
                                name="mediationSpeakingDescription"
                                defaultChecked={this.state.mediationSpeakingDescription}
                                onChange={this.handleInputChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Životne veštine:</td>
                            <td>
                                <Select
                                    options={this.state.lifeSkillsEnum}
                                    onChange={this.handleLifeSkillsChange}
                                    isMulti />
                            </td>
                        </tr>
                        <tr>
                            <td className="info">Tip radionice:</td>
                            <td>
                                <Select
                                    options={this.state.workshopTypesEnum}
                                    onChange={this.handleWorkshopTypesChange}
                                    isMulti />

                                {this.state.workshops.map((workshop, index) => (
                                    <div key={index}>
                                        <label>{workshop.label}</label>
                                        <input
                                            type="text"
                                            name="Number"
                                            onChange={(e) => this.handleInputChangeWorkshop(workshop, e)}
                                            value={workshop.Number} />
                                    </div>
                                ))}
                            </td>
                        </tr>
                        <tr>
                            <td className="info">Školske radionice:</td>
                            <td>
                                <Select
                                    options={this.state.schoolActivitiesEnum}
                                    onChange={this.handleSchoolActivitiesChange}
                                    isMulti />
                            </td>
                        </tr>
                        <tr>
                            <td className="info">Psihosocijalna podrška:</td>
                            <td><input type="checkbox"
                                name="psihosocialSupport"
                                defaultChecked={this.state.psihosocialSupport}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Kontakt sa roditeljima:</td>
                            <td><input type="checkbox"
                                name="parentsContact"
                                defaultChecked={this.state.parentsContact}
                                onChange={this.handleInputChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Medicinske intervencije:</td>
                            <td>
                                <Select
                                    options={this.state.medicalInterventionsEnum}
                                    onChange={this.handleMedicalInterventionsChange}
                                    isMulti />
                            </td>
                        </tr>
                        <tr>
                            <td className="info">Dolazak:</td>
                            <td>
                                <input
                                    type="date" name="arrival"
                                    value={this.state.arrival}
                                    onChange={this.handleInputChange}
                                    required />
                            </td>
                        </tr>
                    </tbody>
                </table>
                <button
                    type="button" className="btn btn-custom"
                    onClick={this.onSave}>
                    Sačuvaj
                    </button>
                <button
                    type="button" className="btn btn-warning btn-back"
                    onClick={this.onClose}>
                    Otkaži
                    </button>
            </div>
        </div>
        );
    }
}

export default AddDailyEntry;