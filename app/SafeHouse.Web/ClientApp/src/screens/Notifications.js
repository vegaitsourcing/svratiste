import React, { Component } from 'react';
import styled from 'styled-components';

import Layout from '../hoc/Layout';
import Cartons from '../components/cartons/Cartons';
import Colours from '../components/common/colours';

import * as CardboardActions from '../actions/CardboardActions';
import CardboardStore from '../stores/CardboardStore';
import LoginStore from '../stores/LoginStore';

const Wrapper = styled.div`
	display: flex;
	flex-wrap: wrap;
	& > div {
		width: 100%;
		margin: 16px 11px 20px;
		padding: 0 8px;
		background-color: ${Colours.white};
		box-shadow: 0 0 2rem 0 rgba(136, 152, 170, 0.15);
		border-radius: 7px;
		border-bottom: 2px solid ${Colours.lochmara};
	}
`;

class Notifications extends Component {
	constructor(props) {
		super(props);
		this.state = {
			readyForInitialEvaluation: [],
			overEighteen: [],
		};
	}

	componentWillMount() {
		CardboardStore.on("fetched_cartons_over_eighteen", this.getCartonsOverEighteen.bind(this));
		// CardboardStore.on("fetched_cartons_ready_for_initial_evaluation", this.getCartonsReadyForInitialEvaluation.bind(this));
		CardboardStore.on("unauthorized", this.redirectToLogin);
		LoginStore.on("unauthorized", this.redirectToLogin);
	}

	componentDidMount() {
		CardboardActions.getCartonsOverEighteen();
		// CardboardActions.getCartonsReadyForInitialEvaluation();
	}

	componentWillUnmount() {
		CardboardStore.removeListener("fetched_cartons_over_eighteen", this.getCartonsOverEighteen);
		// CardboardStore.removeListener("fetched_cartons_ready_for_initial_evaluation", this.getCartonsReadyForInitialEvaluation);
		CardboardStore.removeListener("unauthorized", this.redirectToLogin);
		LoginStore.removeListener("unauthorized", this.redirectToLogin);
	}

	getCartonsOverEighteen() {
		this.setState({
			overEighteen: CardboardStore.getCartonsOverEighteen()
		});
	}

	getCartonsReadyForInitialEvaluation() {
		this.setState({
			readyForInitialEvaluation: CardboardStore.getCartonsReadyForInitialEvaluation()
		});
	}

	redirectToLogin = () => {
		localStorage.clear();
		this.props.history.push("/login");
	}

	render() {
		return (
			<Layout name="Notifikacije">
				<Wrapper>
					{/* <Cartons cartons={this.state.readyForInitialEvaluation} title="Uraditi prijemnu procenu" icon="assignment" path="/users/" /> */}
					<Cartons cartons={this.state.overEighteen} title="Korisnici koji su napunili 18 godina" icon="cake" path="/users/" />
				</Wrapper>
			</Layout>
		);
	}
}

export default Notifications;