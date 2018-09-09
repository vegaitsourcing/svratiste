import React, { Component } from 'react';

import * as CardboardActions from '../../actions/CardboardActions';


class AddCartonSide extends Component {
    constructor(props) {
        super(props);

        this.state = {
            FirstName: '',
            LastName: '',
            Nickname: '',
            Gender: '',
            DateOfBirth: '',
            AddressStreetName: '',
            AddressStreetNumber: '',
            FathersName: '',
            MothersName: '',
            pageNumber: props.pageNumber
        };

        this.onSave = this.onSave.bind(this);
        this.onClose = this.onClose.bind(this);
        this.initState = this.initState.bind(this);
        this.handleInputChange = this.handleInputChange.bind(this);
    }

    initState() {
        this.setState({
            FirstName: '',
            LastName: '',
            Nickname: '',
            Gender: '',
            DateOfBirth: '',
            AddressStreetName: '',
            AddressStreetNumber: '',
            FathersName: '',
            MothersName: ''
        });
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    onSave() {
        CardboardActions.addCarton(this.state);
        this.initState();
    }

    onClose() {
        CardboardActions.hideAddBar();
        this.initState();
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
                                        name="FirstName" type="text"
                                        value={this.state.FirstName}
                                        onChange={this.handleInputChange}
                                        required />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Prezime</td>
                                <td>
                                    <input 
                                        name="LastName" type="text"
                                        value={this.state.LastName}
                                        onChange={this.handleInputChange}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Nadimak</td>
                                <td>
                                    <input 
                                        name="Nickname" type="text" 
                                        value={this.state.Nickname}
                                        onChange={this.handleInputChange}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Pol</td>
                                <td>
                                    <select className="combobox" 
                                        name="Gender" onChange={this.handleInputChange}
                                        value={this.state.Gender}
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
                                        type="date" name="DateOfBirth"
                                        value={this.state.DateOfBirth}
                                        onChange={this.handleInputChange}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Adresa stanovanja</td>
                                <td>
                                    <input 
                                    name="AddressStreetName" type="text"
                                    value={this.state.AddressStreetName}
                                        onChange={this.handleInputChange}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Broj ulice</td>
                                <td>
                                    <input 
                                        name="AddressStreetNumber" type="text"
                                        value={this.state.AddressStreetNumber}
                                        onChange={this.handleInputChange}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Ime oca</td>
                                <td>
                                    <input 
                                        name="FathersName" type="text"
                                        value={this.state.FathersName}
                                        onChange={this.handleInputChange}
                                        required/>
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Ime majke</td>
                                <td>
                                    <input 
                                        name="MothersName" type="text"
                                        value={this.state.MothersName}
                                        onChange={this.handleInputChange}
                                        required/>
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

export default AddCartonSide;