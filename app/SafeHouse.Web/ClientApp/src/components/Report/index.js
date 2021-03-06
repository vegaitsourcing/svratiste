import React, { Component } from 'react';

import * as ReportActions from '../../actions/ReportActions';
import ReportStore from '../../stores/ReportStore';

import TableData from './TableData';
import TableHeader from './TableHeader';

class Report extends Component {
    constructor(props) {
        super(props);

        this.state = {
            from: new Date('1995-12-17T03:24:00'),
            to: new Date('1995-12-17T03:24:00'),
            reportData: {}
        };

        this.getReports = this.getReports.bind(this);
    }

    componentWillMount() {
        ReportStore.on("fetched_reports", this.getReports);
    }

    componentDidMount() {
        ReportActions.getReports(this.state.reportData);
    }

    componentWillUnmount() {
        ReportStore.removeListener("fetched_reports", this.getReports);
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    getReports() {
        this.setState({
            reportData: ReportStore.getAll()
        });
    }

    render() {
        return (
            <main className="main">
                <div className="container wrap">
                    <div className="reports">
                        <div className="report">
                            <input type="date"
                                name="from"
                                onChange={this.handleCheckboxChange} />/>
                            <input type="date" name="to"
                                onChange={this.handleCheckboxChange}/>
			            </div>
                        <div className="table-carton">
                            <table className="table table-position">
                                <TableHeader />

                                <TableData
                                    data={this.state.reportData}
                                    selectItem={this.onItemSelected} />
                            </table>
                        </div>
		            </div>
                </div>
            </main>
        );
    }
}

export default Report;
