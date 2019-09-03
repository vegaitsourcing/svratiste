import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import Carton from '../components/Carton';

class Dashboard extends Component {
	constructor(props) {
		super(props);
		this.state = { counter: 0, id: this.props.match.params.id };
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
