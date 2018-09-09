import React, { Component } from 'react';

import * as DailyEntyActions from '../../actions/DailyEntryActions';

class AddDailyEntry extends Component {
    constructor(props) {
        super(props);

        this.state = {
        };

        this.handleInputChange = this.handleInputChange.bind(this);
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    render() {
        let className = 'side-items side-items-create';
        if (this.props.open) {
            className += ' opened';
        }

        return (<div className="carton-table">
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