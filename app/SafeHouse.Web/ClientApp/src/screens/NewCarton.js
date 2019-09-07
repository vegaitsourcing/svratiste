import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import Carton from '../components/Carton';

import LoginStore from '../stores/LoginStore';

class Dashboard extends Component {
	constructor(props) {
		super(props);
		this.state = { counter: 0, id: this.props.match.params.id };
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
			<Layout name="Kreiraj novi karton">
				<Carton id={ this.state.id } />
			</Layout>
		);
	}
}

export default Dashboard;
