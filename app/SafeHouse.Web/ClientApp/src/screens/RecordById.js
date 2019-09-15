import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import DailyRecord from '../components/DailyRecord';

import LoginStore from '../stores/LoginStore';

class RecordById extends Component {
	constructor(props) {
		super(props);
		this.state = {
			id: this.props.match.params.id,
			cartonId: this.props.match.params.cartonId
		};
	}

	componentWillMount() {
		LoginStore.on("unauthorized", this.redirectToLogin);
	}

	componentWillUnmount() {
		LoginStore.removeListener("unauthorized", this.redirectToLogin);
	}

	redirectToLogin = () => {
		localStorage.clear();
		this.props.history.push("/login");
	}
	
	render() {
		return (
			<Layout name="Dnevni unos">
				<DailyRecord id={ this.state.id } cartonId={ this.state.cartonId } />
			</Layout>
		);
	}
}

export default RecordById;