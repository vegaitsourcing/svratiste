import React, { Component } from 'react';

class FirstEvaluation extends Component {
    constructor(props) {
        super(props);

        this.state = {}
        this.state.data = props.data;
        
    }

    render(){
        const {addressName, addressNumber, dateofBirth} = this.props;

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
                                <td><input type="text" defaultValue={this.state.data.GuardiansName}/></td>
                            </tr>
                            <tr>
                                <td className="info">Imena druge dece iz porodici:</td>
                                <td><input type="text" defaultValue={this.state.data.OtherChildernName}/></td>
                            </tr>
                            <tr>
                                <td className="info">Imena i srodstvo drugih članova domaćinstva:</td>
                                <td><input type="text" defaultValue={this.state.data.OtherMembersName}/></td>
                            </tr>
                            <tr>
                                <td className="info">Adresa Stanovanja:</td>
                                <td><p>{addressName} {addressNumber}</p></td>
                            </tr>
                            <tr>
                                <td className="info">Živi u:</td>
                                <td><input type="text" defaultValue={this.state.data.LivingSpace}/></td>
                            </tr>
                            <tr>
                                <td className="info">Škola i razred:</td>
                                <td><input type="text" defaultValue={this.state.data.SchoolAndGrade}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Zdravstvena knjižica:</td>
                                <td><input type="checkbox" checked={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Datum Rodjenja:</td>
                                <td><input type="date" defaultValue={this.state.dateofBirth}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                            <tr>
                                <td className="info">Maternji i drugi jezici:</td>
                                <td><input type="text" defaultValue={this.state.data.Languages}/></td>
                            </tr>
                        </tbody>
                    </table>
                    <button type="button" className="btn btn-custom">Save</button>
                </div>
                <div className="buttons">
                    <button type="button" className="btn color-primary">Print</button>
                    <button type="button" className="btn color-primary">Save</button>
                </div>
                </div>
        );
    }
}

export default FirstEvaluation;