import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import Carton from '../components/Carton';

class Dashboard extends Component {
	constructor(props) {
		super(props);
		this.state = { counter: 0 };
	}
	componentDidMount () {
		const { id } = this.props.match.params;
		console.log(id);
	}
	render() {
		return (
			<Layout name="Kreiraj novi karton">
				<Carton />
			</Layout>
		);
	}
}

export default Dashboard;
