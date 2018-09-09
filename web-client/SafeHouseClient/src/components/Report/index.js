import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

class Report extends Component {
    constructor(props) {
        super(props);

        this.state = {
            from: "",
            to:""
        };
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    render() {
        return (
            <main class="main">
                <div class="container wrap">
                    <div class="reports">
                        <div class="report">
                            <input type="date"
                                name="from"
                                onChange={this.handleCheckboxChange} />/>
                            <input type="date" name="to"
                                onChange={this.handleCheckboxChange}/>
			            </div>
                        <div class="table-carton">
                            <table class="table table-position">
                                <thead class="thead-light">
                                    <tr>
                                        <th scope="col">Broj posetilaca</th>
                                        <th scope="col">Broj muskih posetilaca</th>
                                        <th scope="col">Broj zenskih posetilaca</th>
                                        <th scope="col">Broj poseta</th>
                                        <th scope="col">Broj obroka</th>
                                        <th scope="col">Broj kupanja</th>
                                        <th scope="col">Broj devansiranja</th>
                                        <th scope="col">Odeca i obuca</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr class="table-details">
                                        <td>text</td>
                                        <td>text</td>
                                        <td>text</td>
                                        <td>text</td>
                                        <td>text</td>
                                        <td>text</td>
                                        <td>text</td>
                                        <td>text</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
		            </div>
                </div>
            </main>
        );
    }
}

export default Report;
