import React, { Component } from 'react';

import * as CardboardActions from '../actions/CardboardActions';
import CardboardStore from '../stores/CardboardStore';

import Layout from '../hoc/Layout';
import Cartons from '../components/cartons/Cartons';
import Constants from '../components/common/constants';

class Dashboard extends Component {
	constructor(props) {
		super(props);
		this.state = {
			catons: [],
			currentPage: 1,
			totalPages: 1,
		};
	}
	redirectToLogin = () => {
		localStorage.clear();
		this.props.history.push("/login");
	}
	
	getCartons = () => {
		this.setState({
			catons: CardboardStore.getAll()
		});
	}
	getNumOfPages = () => {
		this.setState({ totalPages: CardboardStore.getNumOfPages() });
	}
	onPreviousClick = () => {
		let { currentPage } = this.state;
		if (currentPage > 1) {
			this.setState({ currentPage: --currentPage });
		}
		CardboardActions.getCartons(currentPage);
	}
	onPageClick = (page) => {
		this.setState({ currentPage: page });
		CardboardActions.getCartons(page);
	}
	onNextClick = () => {
		let { currentPage, totalPages } = this.state;
		if (currentPage < totalPages) {
			this.setState({ currentPage: ++currentPage });
		}
		CardboardActions.getCartons(currentPage);
	}
	render() {
		return (
			<Layout name="Korisnici" showSearch>
				<Cartons
					cartons={Constants.cartons}
					title="Lista svih korisnika"
					icon="assignment"
					path="/users/"
					pageNumbers={this.state.totalPages}
					pageClicked={this.onPageClick}
					previous={this.onPreviousClick}
					next={this.onNextClick}
					current={this.state.currentPage}
					showPagination
					/>
			</Layout>
		);
	}
}

export default Dashboard;
