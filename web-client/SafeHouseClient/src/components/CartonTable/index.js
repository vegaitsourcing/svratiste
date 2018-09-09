import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

import * as CardboardActions from '../../actions/CardboardActions';
import CardboardStore from '../../stores/CardboardStore';

import TableData from './TableData';
import TableHeader from './TableHeader';
import Pagination from '../Pagination';

import AddCartonSide from '../AddCartonSide';
import EditCartonSide from '../EditCartonSide';


class CartonTable extends Component {
    constructor(props) {
        super(props);

        this.state = {
            catons: [
                { 
                    Id: '123',
                    FirstName: 'Mark',
                    LastName: 'Otto',
                    Nickname: 'otot',
                    Gender: '1',
                    DateOfBirth: '2018-09-13',
                    AddressStreetName: 'test',
                    AddressStreetNumber: '22',
                    FathersName: 'tata',
                    MothersName: 'Mama',
                    notifications: '2'
                },
                { FirstName: 'Jacob', LastName: 'Thornton', notifications: '2' },
                { FirstName: 'Larry', LastName: 'the Bird', notifications: '1' }
            ],
            currentPage: 5,
            totalPages: 5,
            selectedRow: {},
            showAddSide: false,
            showEditSide: false
        };

        this.getCartons = this.getCartons.bind(this);
        this.hideAddBar = this.hideAddBar.bind(this);
        this.hideEditBar = this.hideEditBar.bind(this);

        this.onItemSelected = this.onItemSelected.bind(this);
        this.showAddSide = this.showAddSide.bind(this);
        this.evaluation = this.evaluation.bind(this);

        // pagination
        this.onPreviousClick = this.onPreviousClick.bind(this);
        this.onPageClick = this.onPageClick.bind(this);
        this.onNextClick = this.onNextClick.bind(this);
    }

    componentWillMount() {
        CardboardStore.on("fetched_cartons", this.getCartons);
        CardboardStore.on("fetched_pages_count", this.getNumOfPages);
        CardboardStore.on("hide_add_bar", this.hideAddBar);
        CardboardStore.on("hide_edit_bar", this.hideEditBar);
    }

    componentDidMount() {
        //CardboardActions.getCartons(1);
    }

    componentWillUnmount() {
        CardboardStore.removeListener("fetched_cartons", this.getCartons);
        CardboardStore.removeListener("fetched_pages_count", this.getNumOfPages);
        CardboardStore.removeListener("hide_add_bar", this.hideAddBar);
        CardboardStore.removeListener("hide_edit_bar", this.hideEditBar);
    }

    getCartons() {
        this.setState({
            catons: CardboardStore.getAll()
        });
    }

    evaluation() {
        if (this.state.selectedRow.Id) {
            this.props.history.push('/evaluation/' + this.state.selectedRow.Id);
        }
    }

    getNumOfPages() {
        this.setState({ totalPages: CardboardStore.getNumOfPages() });
    }

    hideAddBar() {
        this.setState({ showAddSide: false });
    }

    hideEditBar() {
        this.setState({ showEditSide: false });
    }

    onItemSelected(selectedRow) {
        this.setState({ selectedRow, showEditSide: true });
    }

    showAddSide() {
        this.setState({ showAddSide: true });
    }

    onPreviousClick() {
        let { currentPage } = this.state;
        
        if (currentPage > 1) {
            this.setState({ currentPage: --currentPage });
        }
    }

    onPageClick(page) {
        this.setState({ currentPage: page });
    }

    onNextClick() {
        let { currentPage, totalPages } = this.state;
        
        if (currentPage < totalPages) {
            this.setState({ currentPage: ++currentPage });
        }
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
                        type="button" className="btn color-secondary"
                        onClick={this.showAddSide}>
                        Dodaj karton
                    </button>
                    <button 
                        type="button" className="btn btn-info btn-inverse"
                        onClick={this.evaluation} >
                        Procena
                    </button>

                    <Pagination 
                        totalPages={this.state.totalPages}
                        previousClick={this.onPreviousClick}
                        pageClick={this.onPageClick}
                        nextClick={this.onNextClick}
                        currentPage={this.state.currentPage} />

                </div>
                
                <AddCartonSide open={this.state.showAddSide} />
                {this.state.showEditSide && <EditCartonSide 
                    open={this.state.showEditSide}
                    data={this.state.selectedRow}/>}

                <div className="carton-table-edit">
                </div>
            </main>
        );
    };
}

export default withRouter(CartonTable);