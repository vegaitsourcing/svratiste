import React, { Component } from 'react';

import * as CardboardActions from '../actions/CardboardActions';
import CardboardStore from '../stores/CardboardStore';

import Layout from '../hoc/Layout';
import Cartons from '../components/cartons/Cartons';

class Dashboard extends Component {
	constructor(props) {
		super(props);
		this.state = {
			cartons: [],
			currentPage: 1,
			totalPages: 1,
		};
	}


	componentWillMount() {
		CardboardStore.on("fetched_cartons", this.getCartons.bind(this));
		CardboardStore.on("fetched_pages_count", this.getNumOfPages);
		CardboardStore.on("unauthorized", this.redirectToLogin);
	}

	componentDidMount() {
		CardboardActions.getCartonsPageCount();
		CardboardActions.getCartons(1);
	}

	componentWillUnmount() {
		CardboardStore.removeListener("fetched_cartons", this.getCartons);
		CardboardStore.removeListener("fetched_pages_count", this.getNumOfPages);
		CardboardStore.removeListener("unauthorized", this.redirectToLogin);
	}
	getCartons() {
		this.setState({
			cartons: CardboardStore.getCartons()
		});
	}
	getNumOfPages = () => {
		this.setState({ totalPages: CardboardStore.getNumOfPages() });
	}
	redirectToLogin = () => {
		localStorage.clear();
		this.props.history.push("/login");
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
					cartons={this.state.cartons}
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
