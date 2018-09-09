import React, { Component } from 'react';

import * as DailyEntyActions from '../../actions/DailyEntryActions';
import * as CardboardActions from '../../actions/CardboardActions';

class AddDailyEntry extends Component {
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

        this.handleInputChange = this.handleInputChange.bind(this);
        this.onClose = this.onClose.bind(this);
    }

    componentDidMount() {
        const { id, firstName, lastName,
            nickname, gender, dateOfBirth,
            addressStreetName, addressStreetNumber,
            fathersName, mothersName } = this.props.data;

        this.setState({
            id, firstName, lastName, nickname, gender, dateOfBirth, addressStreetName, addressStreetNumber, fathersName, mothersName
        });
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    onClose() {
        CardboardActions.hideAddDailyEntryBar();
        CardboardActions.hideEditBar();
    }

    render() {
        let className = 'side-items side-items-create';
        if (this.props.open) {
            className += ' opened';
        }

        return (<div className="carton-table">
            <div className={className}>
                <h2><font color="white">{this.state.firstName} {this.state.lastName}</font></h2>
                <table className="table table-position">
                    <thead className="thead-light">
                        <tr>
                            <th scope="col">Stavka</th>
                            <th scope="col">#</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td className="info">Boravak</td>
                            <td>
                                <input
                                    name="FirstName" type="text"
                                    value={this.state.FirstName}
                                    onChange={this.handleInputChange} />
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

export default AddDailyEntry;