import React, { Component } from 'react';

import TableData from './TableData';
import TableHeader from './TableHeader';

import AddCartonSide from '../AddCartonSide';


class CartonTable extends Component {
    constructor(props) {
        super(props);

        this.state = {
            rows: [
                { FirstName: 'Mark', LastName: 'Otto', notifications: '5' },
                { FirstName: 'Jacob', LastName: 'Thornton', notifications: '2' },
                { FirstName: 'Larry', LastName: 'the Bird', notifications: '1' }
            ],
            showAddSide: false
        };

        this.onItemSelected = this.onItemSelected.bind(this);
        this.showAddSide = this.showAddSide.bind(this);
    }

    onItemSelected(row) {
        console.log(row);
    }

    showAddSide() {
        this.setState({ showAddSide: true });
    }

    render() {
        return (
            <main className="main">
                <div className="container wrap">
                    <div className="table-carton">
                        <table className="table table-position">

                            <TableHeader />

                            <TableData 
                                data={this.state.rows}
                                selectItem={this.onItemSelected} />

                        </table>
                    </div>
                    
                    <button 
                        type="button" className="btn btn-info btn-inverse"
                        onClick={this.showAddSide} >
                        Dodaj
                    </button>

                </div>
                
                <AddCartonSide open={this.state.showAddSide} />

                <div className="carton-table-edit">
                </div>
            </main>
        );
    };
}

export default CartonTable;