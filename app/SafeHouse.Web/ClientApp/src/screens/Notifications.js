import React, { Component } from 'react';
import styled from 'styled-components';

import Layout from '../hoc/Layout';
import Cartons from '../components/cartons/Cartons';
import Constants from '../components/common/constants';
import Colours from '../components/common/colours';

const Wrapper = styled.div`
	display: flex;
	flex-wrap: wrap;
	& > div {
		width: calc(100%/2 - 38px);
		margin: 16px 11px 20px;
		padding: 0 8px;
		background-color: ${Colours.white};
		box-shadow: 0 0 2rem 0 rgba(136, 152, 170, 0.15);
		border-radius: 7px;
		border-bottom: 2px solid ${Colours.lochmara};
	}
`;
class Notifications extends Component {
	state = {  }
	render() {
		return (
			<Layout name="Notifikacije">
				<Wrapper>
					<Cartons cartons={Constants.cartons} title="Uraditi prijemnu procenu" icon="assignment" path="/users/" />
					<Cartons cartons={Constants.cartons} title="Uraditi individualni plan" icon="done" path="/users/" />
					<Cartons cartons={Constants.cartons} title="Revidirati individualni plan" icon="assignment_late" path="/users/"/>
					<Cartons cartons={Constants.cartons} title="Korisnici koji su napunili 18 godina" icon="cake" path="/users/" />
				</Wrapper>
			</Layout>
		);
	}
}

export default Notifications;