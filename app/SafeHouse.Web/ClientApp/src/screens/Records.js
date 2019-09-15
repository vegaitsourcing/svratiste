import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import Cartons from '../components/cartons/Cartons';

import styled from 'styled-components';
import Colours from '../components/common/colours';

import * as CardboardActions from '../actions/CardboardActions';
import CardboardStore from '../stores/CardboardStore';
import LoginStore from '../stores/LoginStore';


const SearchInput = styled.input`
	display: inline-block;
	min-width: 270px;
	height: 30px;
	border: 0;
	border-bottom: 2px solid #0775c3;
	outline: none;
	padding-left: 10px;
	background-color: ${Colours.blackSqueeze};
	&::placeholder {
		color: #adadad;
	}
`;

class Records extends Component {
	constructor(props) {
		super(props);
		this.onSearchChange = this.onSearchChange.bind(this);
		this.state = {
			cartons: [],
			currentPage: 1,
			totalPages: 1,
			searchParams: "",
			searchResults: []
		};
	}

	componentWillMount() {
		CardboardStore.on("fetched_cartons", this.getCartons.bind(this));
		CardboardStore.on("fetched_pages_count", this.getNumOfPages);
		CardboardStore.on("unauthorized", this.redirectToLogin);
		LoginStore.on("unauthorized", this.redirectToLogin);
	}

	componentDidMount() {
		CardboardActions.getCartonsPageCount();
		CardboardActions.getCartons(1);
	}

	componentWillUnmount() {
		CardboardStore.removeListener("fetched_cartons", this.getCartons);
		CardboardStore.removeListener("fetched_pages_count", this.getNumOfPages);
		CardboardStore.removeListener("unauthorized", this.redirectToLogin);
		LoginStore.removeListener("unauthorized", this.redirectToLogin);
	}

	getCartons() {
		const cartons = CardboardStore.getCartons();
		this.setState({cartons});
		this.setState({searchResults: cartons});
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

	onSearchChange = (event) => {
		const params =  event.target.value;
		this.setState({searchParams: params});
		const results = this.state.cartons.filter((item) => {
			const fullName = item.firstName + ' ' + item.lastName + ' ' + item.firstName;
			if (fullName.indexOf(params) != -1) {
				return true;
			}
			else {
				return false;
			}
		});
		this.setState({ searchResults: results });
	}
	
	render() {
		return (
			<Layout name="Lista korisnika usluga">
				<SearchInput placeholder="Search user" value={this.state.searchParams} onChange={this.onSearchChange}/>
				<Cartons cartons={this.state.searchResults} title="Lista svih korisnika" icon="assignment" path="/records/carton-id/" />
			</Layout>
		);
	}
}

export default Records;