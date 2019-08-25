import React, { Component } from 'react';

import Layout from '../hoc/Layout';
import DailyRecord from '../components/DailyRecord';

class Record extends Component {
	constructor(props) {
		super(props);
		this.state = {
		};
	}
	render() {
		return (
			<Layout name="Dnevni unos">
				<DailyRecord />
			</Layout>
		);
	}
}

export default Record;