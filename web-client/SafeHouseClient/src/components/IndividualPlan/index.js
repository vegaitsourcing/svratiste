import React, { Component } from 'react';

class EvaluationComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
        };
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

export default EvaluationComponent;