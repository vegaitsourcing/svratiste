import React, { Component } from 'react';

import * as CardboardActions from '../../actions/CardboardActions';
import CardboardStore from '../../stores/CardboardStore';

import TableData from './TableData';
import TableHeader from './TableHeader';

import AddCartonSide from '../AddCartonSide';


class CartonTable extends Component {
    constructor(props) {
        super(props);

        this.state = {
            catons: [
                { FirstName: 'Mark', LastName: 'Otto', notifications: '5' },
                { FirstName: 'Jacob', LastName: 'Thornton', notifications: '2' },
                { FirstName: 'Larry', LastName: 'the Bird', notifications: '1' }
            ],
            showAddSide: false
        };

        this.getCartons = this.getCartons.bind(this);
        this.hideAddBar = this.hideAddBar.bind(this);

        this.onItemSelected = this.onItemSelected.bind(this);
        this.showAddSide = this.showAddSide.bind(this);
    }

    componentWillMount() {
        CardboardStore.on("fetched_cartons", this.getCartons);
        CardboardStore.on("hide_add_bar", this.hideAddBar);
    }

    componentDidMount() {
        //CardboardActions.getCartons(1);
    }

    componentWillUnmount() {
        CardboardStore.removeListener("fetched_cartons", this.getCartons);
        CardboardStore.removeListener("hide_add_bar", this.hideAddBar);
    }

    getCartons() {
        this.setState({
            catons: CardboardStore.getAll()
        });
    }

    hideAddBar() {
        this.setState({ showAddSide: false });
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
                                data={this.state.catons}
                                selectItem={this.onItemSelected} />

                        </table>
                    </div>
                    
                    <button 
                        type="button" className="btn btn-info btn-inverse"
                        onClick={this.showAddSide} >
                        Dodaj
                    </button>

                    <div className="pages">
                        <nav aria-label="Page navigation example">
                            <ul className="pagination">
                                <li className="page-item"><a className="page-link  color-secondary active-page" href="#">Previous</a></li>
                                <li className="page-item"><a className="page-link  color-secondary" href="#">1</a></li>
                                <li className="page-item"><a className="page-link color-secondary" href="#">2</a></li>
                                <li className="page-item"><a className="page-link color-secondary" href="#">3</a></li>
                                <li className="page-item"><a className="page-link color-secondary" href="#">Next</a></li>
                            </ul>
                        </nav>
                    </div>

                </div>
                
                <AddCartonSide open={this.state.showAddSide} />

                <div className="carton-table-edit">
                </div>
            </main>
        );
    };
}

export default CartonTable;