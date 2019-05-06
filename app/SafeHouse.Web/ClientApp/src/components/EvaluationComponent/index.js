import React, { Component } from 'react';

import EvaluationStore from '../../stores/EvaluationStore';


class EvaluationComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
        };

        this.redirectToLogin = this.redirectToLogin.bind(this);

        this.onSave = this.onSave.bind(this);
        this.onPrint = this.onPrint.bind(this);
    }

    componentWillMount() {
        EvaluationStore.on("unauthorized", this.redirectToLogin);
    }

    componentDidMount() {
    }

    componentWillUnmount() {
        EvaluationStore.removeListener("unauthorized", this.redirectToLogin);
    }
    
    redirectToLogin() {
        localStorage.clear();
        this.props.history.push('/login');
    }

    onSave() {
        console.log('Save');
    }

    onPrint() {
        console.log('Print');
    }

    render(){
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
                                <td className="info">Ime</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">Prezime</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">text</td>
                                <td><input type="text"/></td>
                            </tr>
                            <tr>
                                <td className="info">Godina</td>
                                <td><input type="text"/></td>
                            </tr>
                        </tbody>
                    </table>
                    <button type="button" onClick={this.onSave} className="btn btn-custom">Save</button>
                </div>
                <div className="buttons">
                    <button type="button" onClick={this.onPrint} className="btn color-primary">Print</button>
                    <button type="button" onClick={this.onSave} className="btn color-primary">Save</button>
                </div>
                </div>                
        );
    }
}

export default EvaluationComponent;