import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import Cartons from '../components/cartons/Cartons';
import Constants from '../components/common/constants';

class Records extends Component {
	constructor(props) {
		super(props);
		this.state = {
		};
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