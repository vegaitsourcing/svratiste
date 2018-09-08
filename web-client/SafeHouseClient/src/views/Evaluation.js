import React, { Component } from 'react';
import FirstEvaluation from '../components/FirstEvaluation';
import EvaluationComponent from '../components/EvaluationComponent';
import IndividualPlan from '../components/IndividualPlan';


class Evaluation extends Component {
    constructor(props) {
        super(props);

        this.state = {
            FirstName: "Test",
            LastName: "Testing",
            AddressStreetName:"neka ulica",
            AddressStreetNumber:"123",
            DateOfBirth: "11/12/2018",
            FirstEvaluation111: {
                OtherChildernName: "ChildrenTesting",
                OtherMembersName: "MembersTesting",
                GuardiansName: "GuarTesting",
                LivingSpace: "LSTesting",
                SchoolAndGrade: "SCHTesting",
                Languages: "LanTesting",
                HealthCard: true,
                CaseLeaderName: "casTesting",
                SuitabilityId: "SuitTesting",
                Capability: false,
                OnTheWaitingList: false,
                ServiceStart: "11-12-2016",
                DirectedToName: "fdfTesting",
                IndividualMovementAbility: "asdasdTesting",
                VerbalComunicationAbility: "Tevcsting",
                PhysicalDescription: "Testing",
                DiagnosedDisease: "Testing",
                PriorityNeeds: "Testing",
                Attitude: "Testing",
                Expectations: "Testing",
                DirectedFromName: "Testing",
                Other: "Testing",
                StartedEvaluation: "11-12-2018",
                FinishedEvaluation: "11-12-2018",
                EvaluationDoneBy: "Testing",
                EvaluationRevisedBy: "Testing",
            }
        };
    }

    render() {
        const { 
            FirstName, 
            LastName,
            FirstEvaluation111
        } = this.state; 

        return (
            <main className="main">
                <div className="container wrap">
                    <div className="evaluation">
                        <div className="ev-input">
                            <h2><font color="white">{FirstName} {LastName}</font></h2>
                        </div>
                        <div className="tabs" id="tabs">
                            <ul>
                                <li className="active"><a href="#tabs-1">Prijemna Procena</a></li>
                                <li><a href="#tabs-2">Procena</a></li>
                                <li><a href="#tabs-3">Individualni Plan</a></li>
                            </ul>
                            <div className="tab show" id="tabs-1">
                                <div className="tab-content">
                                    <FirstEvaluation 
                                        data={FirstEvaluation111}
                                        addressName={this.state.AddressStreetName}
                                        addressNumber={this.state.AddressStreetNumber}
                                        dateOfBirth={this.state.DateOfBirth} />
                                </div>
                            </div>
                            <div className="tab" id="tabs-2">
                                <div className="tab-content">
                                    <EvaluationComponent />
                                </div>
                            </div>
                            <div className="tab" id="tabs-3">
                                <div className="tab-content">
                                    <IndividualPlan />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        );
    };
}

export default Evaluation;