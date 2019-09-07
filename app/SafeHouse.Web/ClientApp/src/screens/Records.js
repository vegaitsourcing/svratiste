import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import Cartons from '../components/cartons/Cartons';
import Constants from '../components/common/constants';

import LoginStore from '../stores/LoginStore';

class Records extends Component {
	constructor(props) {
		super(props);
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
			<Layout name="Lista korisnika usluga" showSearch>
				<Cartons cartons={Constants.cartons} title="Lista svih korisnika" icon="assignment" path="/records/" />
			</Layout>
		);
	}
}

export default Records;