import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

import * as CardboardActions from '../../actions/CardboardActions';
import CardboardStore from '../../stores/CardboardStore';

import TableData from './TableData';
import TableHeader from './TableHeader';
import Pagination from '../Pagination';

import AddCartonSide from '../AddCartonSide';
import EditCartonSide from '../EditCartonSide';
import AddDailyEntry from '../AddDailyEntry';

class CartonTable extends Component {
    constructor(props) {
        super(props);

        this.state = {
            catons: [],
            currentPage: 1,
            totalPages: 0,
            selectedRow: {},
            showAddSide: false,
            showEditSide: false,
            showAddDailyEntry: false
        };

        this.getCartons = this.getCartons.bind(this);
        this.hideAddBar = this.hideAddBar.bind(this);
        this.hideEditBar = this.hideEditBar.bind(this);
        this.hideAddDailyEntryBar = this.hideAddDailyEntryBar.bind(this);

        this.onItemSelected = this.onItemSelected.bind(this);
        this.showAddSide = this.showAddSide.bind(this);
        this.evaluation = this.evaluation.bind(this);
        this.showAddDailyEntry = this.showAddDailyEntry.bind(this);
        this.redirectToLogin = this.redirectToLogin.bind(this);

        // pagination
        this.onPreviousClick = this.onPreviousClick.bind(this);
        this.onPageClick = this.onPageClick.bind(this);
        this.onNextClick = this.onNextClick.bind(this);
        this.getNumOfPages = this.getNumOfPages.bind(this);
    }

    componentWillMount() {
        CardboardStore.on("fetched_cartons", this.getCartons);
        CardboardStore.on("fetched_pages_count", this.getNumOfPages);
        CardboardStore.on("hide_add_bar", this.hideAddBar);
        CardboardStore.on("hide_edit_bar", this.hideEditBar);
        CardboardStore.on("hide_add_daily_entry_bar", this.hideAddDailyEntryBar);
        CardboardStore.on("unauthorized", this.redirectToLogin);
    }

    componentDidMount() {
        CardboardActions.getCartonsPageCount();
        CardboardActions.getCartons(1);
    }

    componentWillUnmount() {
        CardboardStore.removeListener("fetched_cartons", this.getCartons);
        CardboardStore.removeListener("fetched_pages_count", this.getNumOfPages);
        CardboardStore.removeListener("hide_add_bar", this.hideAddBar);
        CardboardStore.removeListener("hide_edit_bar", this.hideEditBar);
        CardboardStore.removeListener("hide_add_daily_entry_bar", this.hideAddDailyEntryBar);
        CardboardStore.removeListener("unauthorized", this.redirectToLogin);
    }

    redirectToLogin() {
        localStorage.clear();
        this.props.history.push('/login');
    }

    getCartons() {
        this.setState({
            catons: CardboardStore.getAll()
        });
    }

    evaluation() {
        if (this.state.selectedRow.id) {
            this.props.history.push('/evaluation/' + this.state.selectedRow.id);
        }
    }

    getNumOfPages() {
        this.setState({ totalPages: CardboardStore.getNumOfPages() });
    }

    hideAddBar() {
        this.setState({ showAddSide: false });
    }

    hideAddDailyEntryBar() {
        this.setState({ showAddDailyEntry: false });
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

    showAddDailyEntry() {
        if (this.state.selectedRow.id) {
            this.setState({ showAddDailyEntry: true });
        }
    }

    onPreviousClick() {
        let { currentPage } = this.state;
        
        if (currentPage > 1) {
            this.setState({ currentPage: --currentPage });
        }

        CardboardActions.getCartons(currentPage);
    }

    onPageClick(page) {
        
        this.setState({ currentPage: page });
        CardboardActions.getCartons(page);
    }

    onNextClick() {
        let { currentPage, totalPages } = this.state;
        
        if (currentPage < totalPages) {
            this.setState({ currentPage: ++currentPage });
        }

        CardboardActions.getCartons(currentPage);
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
                        onClick={this.showAddDailyEntry}>
                        Dodaj dnevni unos za gosta
                    </button>
                    <button 
                        type="button" className="btn color-secondary btn-inverse"
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
                
                <AddCartonSide
                    open={this.state.showAddSide}
                    pageNumber={this.state.currentPage}/>
                {this.state.showEditSide && <EditCartonSide 
                    open={this.state.showEditSide}
                    data={this.state.selectedRow}
                    pageNumber={this.state.currentPage} />}

                {this.state.showAddDailyEntry && <AddDailyEntry
                    open={this.state.showAddDailyEntry}
                    data={this.state.selectedRow}
                    pageNumber={this.state.currentPage}
                    />}

                <div className="carton-table-edit">
                </div>
            </main>
        );
    };
}

export default withRouter(CartonTable);