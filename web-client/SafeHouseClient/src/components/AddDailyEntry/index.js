import React, { Component } from 'react';

import * as DailyEntyActions from '../../actions/DailyEntryActions';
import * as CardboardActions from '../../actions/CardboardActions';

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
            cartonGuid: '',
            clothes: 0,
            mediationWriting: 0,
            mediationWritingDescription: '',
            mediationSpeaking: 0,
            mediationSpeakingDescription: '',
            psihosocialSupport: '',
            parentsContact: '',
            medicalInterventions: 0,
            pageNumber: props.pageNumber
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleCheckboxChange = this.handleCheckboxChange.bind(this);
        this.onClose = this.onClose.bind(this);
        this.onSave = this.onSave.bind(this);
    }

    componentDidMount() {
        const { firstName, lastName, gender } = this.props.data;
        const cartonGuid = this.props.data.id;
        this.setState({ firstName, lastName, gender, cartonGuid });
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
                                onChange={this.handleCheckboxChange}/></td>
                        </tr>                       
                        <tr>
                            <td className="info">Doručak:</td>
                            <td><input type="checkbox"
                                name="breakfast"
                                defaultChecked={this.state.breakfast}
                                onChange={this.handleCheckboxChange}/></td>
                        </tr>
                        <tr>
                            <td className="info">Ručak:</td>
                            <td><input type="checkbox"
                                name="lunch"
                                defaultChecked={this.state.lunch}
                                onChange={this.handleCheckboxChange}/></td>
                        </tr>
                        <tr>
                            <td className="info">Večera:</td>
                            <td><input type="checkbox"
                                name="diner"
                                defaultChecked={this.state.diner}
                                onChange={this.handleCheckboxChange}/></td>
                        </tr>
                        <tr>
                            <td className="info">Kupanje:</td>
                            <td><input type="checkbox"
                                name="bath"
                                defaultChecked={this.state.bath}
                                onChange={this.handleCheckboxChange}/></td>
                        </tr>
                        <tr>
                            <td className="info">Devaširanje:</td>
                            <td><input type="checkbox"
                                name="liecesRemoval"
                                defaultChecked={this.state.liecesRemoval}
                                onChange={this.handleCheckboxChange}/></td>
                        </tr>
                        <tr>
                            <td className="info">Odeća i obuća:</td>
                            <td><input type="number"
                                name="clothes"
                                defaultChecked={this.state.clothes}
                                onChange={this.handleInputChange}/></td>
                        </tr>
                        <tr>
                        <td className="info">Pismeno Obraćanje:</td>
                        <td>
                            <select className="combobox"
                                name="mediationWriting"
                                onChange={this.handleInputChange}
                                value={this.state.mediationWriting}
                                required>
                                <option></option>
                                <option value="1">Centar za socijalni rad</option>
                                <option value="2">Obrazovanje</option>
                                <option value="4">Udruženje gradjana</option>
                                <option value="8">Zdravstvene ustanove</option>
                                <option value="16">Policija</option>
                                <option value="32">Ostalo</option>
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
                                <option></option>
                                <option value="1">Centar za socijalni rad</option>
                                <option value="2">Obrazovanje</option>
                                <option value="4">Udruženje gradjana</option>
                                <option value="8">Zdravstvene ustanove</option>
                                <option value="16">Policija</option>
                                <option value="32">Ostalo</option>
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
                            <td className="info">Psihosocijalna podrška:</td>
                            <td><input type="checkbox"
                                name="psihosocialSupport"
                                defaultChecked={this.state.psihosocialSupport}
                                onChange={this.handleCheckboxChange} /></td>
                        </tr>
                        <tr>
                            <td className="info">Kontakt sa roditeljima:</td>
                            <td><input type="text"
                                name="parentsContact"
                                defaultChecked={this.state.parentsContact}
                                onChange={this.handleInputChange} /></td>
                        </tr>
                    <tr>
                        <td className="info">Usmeno Obraćanje:</td>
                        <td>
                            <select className="combobox"
                                name="medicalInterventions"
                                onChange={this.handleInputChange}
                                value={this.state.medicalInterventions}
                                required>
                                <option></option>
                                <option value="1">Intervencija u svratištu</option>
                                <option value="2">Savetovanje</option>
                                <option value="4">Lekovi</option>
                            </select>
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