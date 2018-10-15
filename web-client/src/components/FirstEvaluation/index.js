import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

import * as EvaluationActions from '../../actions/EvaluationActions';
import EvaluationStore from '../../stores/EvaluationStore';


class FirstEvaluation extends Component {
    constructor(props) {
        super(props);

        this.state = {
            id: '',
            cartonId: '',
            otherChildernName: '',
            otherMembersName: '',
            guardiansName: '',
            livingSpace: '',
            schoolAndGrade: '',
            languages: '',
            healthCard: false,
            caseLeaderName: '',
            capability: false,
            onTheWaitingList: false,
            serviceStart: '',
            directedToName: '',
            individualMovementAbility: '',
            verbalComunicationAbility: '',
            physicalDescription: '',
            diagnosedDisease: '',
            priorityNeeds: '',
            attitude: '',
            expectations: '',
            directedFromName: '',
            other: '',
            startedEvaluation: '',
            finishedEvaluation: '',
            evaluationDoneBy: '',
            evaluationRevisedBy: '',
            suitabilityId: '',
        };

        this.redirectToLogin = this.redirectToLogin.bind(this);
        this.getEvaluation = this.getEvaluation.bind(this);

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleCheckboxChange = this.handleCheckboxChange.bind(this);

        this.onSave = this.onSave.bind(this);
    }

    componentWillMount() {
        EvaluationStore.on("fetched_first_evaluation", this.getEvaluation);
        EvaluationStore.on("unauthorized", this.redirectToLogin);
    }

    componentDidMount() {
        this.setState({ cartonId: this.props.cartonId });
        EvaluationActions.getFirstEvaluation(this.props.cartonId);
    }

    componentWillUnmount() {
        EvaluationStore.removeListener("fetched_first_evaluation", this.getEvaluation);
        EvaluationStore.removeListener("unauthorized", this.redirectToLogin);
    }

    onSave() {
        EvaluationActions.createFirstEvaluation(this.state);
    }

    getEvaluation() {
        let evaluation = EvaluationStore.getFirstEvaluation();
        if (evaluation) {
            const {
                id,
                otherChildernName,
                otherMembersName,
                guardiansName,
                livingSpace,
                schoolAndGrade,
                languages,
                healthCard,
                caseLeaderName,
                suitabilityId,
                capability,
                onTheWaitingList,
                serviceStart,
                directedToName,
                individualMovementAbility,
                verbalComunicationAbility,
                physicalDescription,
                diagnosedDisease,
                priorityNeeds,
                attitude,
                expectations,
                directedFromName,
                other,
                startedEvaluation,
                finishedEvaluation,
                evaluationDoneBy,
                evaluationRevisedBy } = evaluation;

            this.setState({
                id,
                otherChildernName,
                otherMembersName,
                guardiansName,
                livingSpace,
                schoolAndGrade,
                languages,
                healthCard,
                caseLeaderName,
                suitabilityId,
                capability,
                onTheWaitingList,
                serviceStart: this.formatDate(serviceStart),
                directedToName,
                individualMovementAbility,
                verbalComunicationAbility,
                physicalDescription,
                diagnosedDisease,
                priorityNeeds,
                attitude,
                expectations,
                directedFromName,
                other,
                startedEvaluation: this.formatDate(startedEvaluation),
                finishedEvaluation: this.formatDate(finishedEvaluation),
                evaluationDoneBy,
                evaluationRevisedBy
            });
        }
    }

    formatDate(date) {
        var d = new Date(date),
            month = '' + (d.getMonth() + 1),
            day = '' + d.getDate(),
            year = d.getFullYear();
    
        if (month.length < 2) month = '0' + month;
        if (day.length < 2) day = '0' + day;
    
        return [year, month, day].join('-');
    }

    redirectToLogin() {
        localStorage.clear();
        this.props.history.push('/login');
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    handleCheckboxChange(event) {
        const { target } = event;
        const { name, checked } = target;

        this.setState({ [name]: checked });
    }

    render() {
        const { addressName, addressNumber, dateofBirth } = this.props;

        return (
            <div>
                <div className="side-items side-items-create">
                    <table className="table table-position">
                        <thead className="thead-light">
                            <tr>
                                <th scope="col">Stavka</th>
                                <th scope="col">#</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td className="info">Imena roditelja/staratelja:</td>
                                <td><input type="text" name="guardiansName" onChange={this.handleInputChange}
                                    value={this.state.guardiansName} /></td>
                            </tr>
                            <tr>
                                <td className="info">Imena druge dece iz porodici:</td>
                                <td><input type="text" name="otherChildernName" onChange={this.handleInputChange} 
                                    value={this.state.otherChildernName} /></td>
                            </tr>
                            <tr>
                                <td className="info">Imena i srodstvo drugih članova domaćinstva:</td>
                                <td><input type="text" name="otherMembersName" onChange={this.handleInputChange} 
                                    value={this.state.otherMembersName} /></td>
                            </tr>
                            <tr>
                                <td className="info">Datum Rodjenja:</td>
                                <td><p>{dateofBirth}</p></td>
                            </tr>
                            <tr>
                                <td className="info">Adresa Stanovanja:</td>
                                <td><p>{addressName + ' ' + addressNumber}</p></td>
                            </tr>
                            <tr>
                                <td className="info">Živi u:</td>
                                <td><input type="text" name="livingSpace" onChange={this.handleInputChange} 
                                    value={this.state.livingSpace} /></td>
                            </tr>
                            <tr>
                                <td className="info">Škola i razred:</td>
                                <td><input type="text" name="schoolAndGrade" onChange={this.handleInputChange} 
                                    value={this.state.schoolAndGrade} /></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" name="languages" onChange={this.handleInputChange} 
                                    value={this.state.languages} /></td>
                            </tr>
                            <tr>
                                <td className="info">Zdravstvena knjižica:</td>
                                <td><input type="checkbox" name="healthCard" onChange={this.handleCheckboxChange} 
                                    checked={this.state.healthCard} /></td>
                            </tr>
                            <tr>
                                <td className="info">Voditelj slučaja:</td>
                                <td><input type="text" name="caseLeaderName" onChange={this.handleInputChange} 
                                    value={this.state.caseLeaderName} /></td>
                            </tr>
                            <tr>
                                <td className="info">Postoje kapaciteti usluge da zadovolji potrebe korisnika:</td>
                                <td><input type="checkbox" name="capability" onChange={this.handleCheckboxChange} 
                                    checked={this.state.capability} /></td>
                            </tr>
                            <tr>
                                <td className="info">Na listi čekanja:</td>
                                <td><input type="checkbox" name="onTheWaitingList" onChange={this.handleCheckboxChange} 
                                    checked={this.state.onTheWaitingList} /></td>
                            </tr>
                            <tr>
                                <td className="info">Datum početka korišćenja usluge:</td>
                                <td><input type="date" onChange={this.handleInputChange} name="serviceStart"
                                    value={this.state.serviceStart} /></td>
                            </tr>
                            <tr>
                                <td className="info">Kome je upućen:</td>
                                <td><input type="text" name="directedToName" onChange={this.handleInputChange} 
                                    value={this.state.directedToName} /></td>
                            </tr>
                            <tr>
                                <td className="info">Sposobnost samostalnog kretanja:</td>
                                <td><input type="text" name="individualMovementAbility" onChange={this.handleInputChange} 
                                    value={this.state.individualMovementAbility} /></td>
                            </tr>
                            <tr>
                                <td className="info">Sposobnost verbalne komunikacije:</td>
                                <td><input type="text" name="verbalComunicationAbility" onChange={this.handleInputChange} 
                                    value={this.state.verbalComunicationAbility} /></td>
                            </tr>
                            <tr>
                                <td className="info">Kratak opis fizičkog izgleda:</td>
                                <td><input type="text" name="physicalDescription" onChange={this.handleInputChange} 
                                    value={this.state.physicalDescription} /></td>
                            </tr>
                            <tr>
                                <td className="info">Dijagnostikofana bolest, alergija:</td>
                                <td><input type="text" name="diagnosedDisease" onChange={this.handleInputChange} 
                                    value={this.state.diagnosedDisease} /></td>
                            </tr>
                            <tr>
                                <td className="info">Propritetne potrebe korisnika:</td>
                                <td><input type="text" name="priorityNeeds" onChange={this.handleInputChange} 
                                    value={this.state.priorityNeeds} /></td>
                            </tr>
                            <tr>
                                <td className="info">Stav:</td>
                                <td><input type="text" name="attitude" onChange={this.handleInputChange} 
                                    value={this.state.attitude} /></td>
                            </tr>
                            <tr>
                                <td className="info">Očekivanja:</td>
                                <td><input type="text" name="expectations" onChange={this.handleInputChange} 
                                    value={this.state.expectations} /></td>
                            </tr>
                            <tr>
                                <td className="info">Upućen od strane:</td>
                                <td><input type="text" name="directedFromName" onChange={this.handleInputChange} 
                                    value={this.state.directedFromName} /></td>
                            </tr>
                            <tr>
                                <td className="info">Ostalo:</td>
                                <td><input type="text" name="other" onChange={this.handleInputChange} 
                                    value={this.state.other} /></td>
                            </tr>
                            <tr>
                                <td className="info">Prijem Započet:</td>
                                <td><input type="date" name="startedEvaluation" onChange={this.handleInputChange} 
                                    value={this.state.startedEvaluation} /></td>
                            </tr>
                            <tr>
                                <td className="info">Prijem Završen:</td>
                                <td><input type="date" name="finishedEvaluation" onChange={this.handleInputChange} 
                                    value={this.state.finishedEvaluation} /></td>
                            </tr>
                            <tr>
                                <td className="info">Prijem uradio:</td>
                                <td><input type="text" name="evaluationDoneBy" onChange={this.handleInputChange} value={this.state.evaluationDoneBy} /></td>
                            </tr>
                            <tr>
                                <td className="info">Pregledao:</td>
                                <td><input type="text" name="evaluationRevisedBy" onChange={this.handleInputChange} value={this.state.evaluationRevisedBy} /></td>
                            </tr>
                        </tbody>
                    </table>
                    <button type="button" onClick={this.onSave} className="btn btn-custom">Save</button>
                </div>
                <div className="buttons">
                    <button type="button" className="btn color-primary">Print</button>
                    <button type="button" onClick={this.onSave} className="btn color-primary">Save</button>
                </div>
            </div>
        );
    }
}

export default withRouter(FirstEvaluation);