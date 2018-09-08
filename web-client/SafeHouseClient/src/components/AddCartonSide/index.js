import React, { Component } from 'react';


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
            MothersName: ''
        };

        this.onSave = this.onSave.bind(this);

        this.handleInputChange = this.handleInputChange.bind(this);
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    onSave() {
        console.log(this.state);
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
                                        onChange={this.handleInputChange} />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Prezime</td>
                                <td>
                                    <input 
                                        name="LastName" type="text"
                                        onChange={this.handleInputChange} />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Nadimak</td>
                                <td>
                                    <input 
                                        name="Nickname" type="text" 
                                        onChange={this.handleInputChange} />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Pol</td>
                                <td>
                                    <select className="combobox" name="Gender" onChange={this.handleInputChange} >
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
                                        onChange={this.handleInputChange} />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Adresa stanovanja</td>
                                <td>
                                    <input 
                                    name="AddressStreetName" type="text"
                                    onChange={this.handleInputChange} />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Broj ulice</td>
                                <td>
                                    <input 
                                        name="AddressStreetNumber" type="text"
                                        onChange={this.handleInputChange} />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Ime oca</td>
                                <td>
                                    <input 
                                        name="FathersName" type="text"
                                        onChange={this.handleInputChange} />
                                </td>
                            </tr>
                            <tr>
                                <td className="info">Ime majke</td>
                                <td>
                                    <input 
                                        name="MothersName" type="text"
                                        onChange={this.handleInputChange} />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <button 
                        type="button" className="btn btn-custom"
                        onClick={this.onSave}>
                            Save
                    </button>
                </div>
            </div>
        );
    };
}

export default AddCartonSide;