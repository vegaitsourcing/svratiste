import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import DailyRecord from '../components/DailyRecord';

import LoginStore from '../stores/LoginStore';

class Record extends Component {
	constructor(props) {
		super(props);
		this.state = {
			id: this.props.match.params.id
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
				<DailyRecord cartonId={ this.state.id } />
			</Layout>
		);
	}
}

export default Record;