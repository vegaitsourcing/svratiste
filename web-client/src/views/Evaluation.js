import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

import FirstEvaluation from '../components/FirstEvaluation';
import EvaluationComponent from '../components/EvaluationComponent';
import IndividualPlan from '../components/IndividualPlan';

import * as CardboardActions from '../actions/CardboardActions';
import CardboardStore from '../stores/CardboardStore';


class Evaluation extends Component {
    constructor(props) {
        super(props);

        this.state = {
            activeTab: 1,
            FirstName: "Test",
            LastName: "Testing",
            AddressStreetName: "neka ulica",
            AddressStreetNumber: "123",
            DateOfBirth: "11/12/2018"
        };

        this.onTabClick = this.onTabClick.bind(this);

        this.getCarton = this.getCarton.bind(this);
    }

    componentWillMount() {
        CardboardStore.on("fetched_carton", this.getCarton);
    }

    componentDidMount() {
        CardboardActions.getCartonById(this.props.match.params.id);
    }

    componentWillUnmount() {
        CardboardStore.removeListener("fetched_carton", this.getCarton);
    }

    getCarton() {
        const { firstName, lastName, addressStreetName, addressStreetNumber, dateOfBirth } = CardboardStore.getCarton();
        this.setState({
            FirstName: firstName,
            LastName: lastName,
            AddressStreetName: addressStreetName,
            AddressStreetNumber: addressStreetNumber,
            DateOfBirth: this.formatDate(dateOfBirth)
        });
    }

    onTabClick(tab) {
        this.setState({ activeTab: tab });
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

    render() {
        const { id } = this.props.match.params;
        const { activeTab } = this.state;
        const { FirstName, LastName, AddressStreetName, AddressStreetNumber, DateOfBirth } = this.state; 

        return (
            <main className="main">
                <div className="container wrap">
                    <div className="evaluation">
                        <div className="ev-input">
                            <h2><font color="white">{FirstName} {LastName}</font></h2>
                        </div>
                        <div className="tabs" id="tabs">
                            <ul>
                                <li className={activeTab === 1 ? "active" : ""}><a onClick={() => this.onTabClick(1)}>Prijemna Procena</a></li>
                                <li className={activeTab === 2 ? "active" : ""}><a onClick={() => this.onTabClick(2)}>Procena</a></li>
                                <li className={activeTab === 3 ? "active" : ""}><a onClick={() => this.onTabClick(3)}>Individualni Plan</a></li>
                            </ul>
                            {(activeTab === 1) && <div className="tab show">
                                <div className="tab-content">
                                    <FirstEvaluation 
                                        cartonId={id}
                                        addressName={AddressStreetName}
                                        addressNumber={AddressStreetNumber}
                                        dateofBirth={DateOfBirth} />
                                </div>
                            </div>}
                            {(activeTab === 2) && <div className="tab show">
                                <div className="tab-content">
                                    <EvaluationComponent />
                                </div>
                            </div>
                            }
                            {(activeTab === 3) && <div className="tab">
                                <div className="tab-content">
                                    <IndividualPlan />
                                </div>
                            </div>
                            }
                        </div>
                    </div>
                </div>
            </main>
        );
    };
}

export default withRouter(Evaluation);