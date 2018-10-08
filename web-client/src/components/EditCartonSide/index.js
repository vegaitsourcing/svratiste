import React, { Component } from 'react';

import * as CardboardActions from '../../actions/CardboardActions';


class EditCartonSide extends Component {
    constructor(props) {
        super(props);

        this.state = {
            id: '',
            firstName: '',
            lastName: '',
            nickname: '',
            gender: '',
            dateOfBirth: '',
            addressStreetName: '',
            addressStreetNumber: '',
            fathersName: '',
            mothersName: '',
            disableEdit: true,
            pageNumber: props.pageNumber
        };

        this.onSave = this.onSave.bind(this);
        this.onClose = this.onClose.bind(this);
        this.onEnableEdit = this.onEnableEdit.bind(this);
        
        this.handleInputChange = this.handleInputChange.bind(this);
    }

    componentDidMount() {
        const { id, firstName, lastName, 
                nickname, gender, dateOfBirth, 
                addressStreetName, addressStreetNumber,
                fathersName, mothersName } = this.props.data;

        this.setState({
            id, firstName, lastName, nickname, gender, addressStreetName, addressStreetNumber, fathersName, mothersName,
            dateOfBirth: this.formatDate(dateOfBirth)
        });
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    onSave() {
        CardboardActions.editCarton(this.state);
    }

    onEnableEdit() {
        this.setState({ disableEdit: !this.state.disableEdit });
    }

    onClose() {
        CardboardActions.hideEditBar();
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
        let className = 'side-items side-items-create';
        if (this.props.open) {
            className += ' opened';
        }

        return (
            <div className="carton-table">
                <div className={className}>
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
                                <td>
                                    <input 
                                        name="firstName" type="text"
                                        value={this.state.firstName}
                                        onChange={this.handleInputChange}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Prezime</td>
                                <td>
                                    <input 
                                        name="lastName" type="text"
                                        value={this.state.lastName}
                                        onChange={this.handleInputChange}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Nadimak</td>
                                <td>
                                    <input 
                                        name="nickname" type="text" 
                                        value={this.state.nickname}
                                        onChange={this.handleInputChange} 
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Pol</td>
                                <td>
                                    <select className="combobox" 
                                        name="gender" onChange={this.handleInputChange}
                                        value={this.state.gender}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required>
                                        <option></option>
                                        <option value="1">M</option>
                                        <option value="0">Ž</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Datum rođenja</td>
                                <td>
                                    <input 
                                        type="date" name="dateOfBirth"
                                        value={this.state.dateOfBirth}
                                        onChange={this.handleInputChange}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Adresa stanovanja</td>
                                <td>
                                    <input 
                                    name="addressStreetName" type="text"
                                    value={this.state.addressStreetName}
                                    onChange={this.handleInputChange}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Broj ulice</td>
                                <td>
                                    <input 
                                        name="addressStreetNumber" type="text"
                                        value={this.state.addressStreetNumber}
                                        onChange={this.handleInputChange}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Ime oca</td>
                                <td>
                                    <input 
                                        name="fathersName" type="text"
                                        value={this.state.fathersName}
                                        onChange={this.handleInputChange}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Ime majke</td>
                                <td>
                                    <input 
                                        name="mothersName" type="text"
                                        value={this.state.mothersName}
                                        onChange={this.handleInputChange}
                                        disabled={(this.state.disableEdit) ? "disabled" : ""}
                                        required/>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <button
                        type="button" className="btn btn-custom"
                        onClick={this.onEnableEdit}>
                        Izmeni
                    </button>
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
    };
}

export default EditCartonSide;