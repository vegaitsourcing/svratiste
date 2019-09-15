import React, { Component } from 'react';
import styled from 'styled-components';

import Colours from '../common/colours';
import {input as CustomInput, label as CustomLabel, textarea as CustomTextarea} from '../common/Inputs/Inputs';

import * as IndividualPlanActions from '../../actions/IndividualPlanActions';

const Container = styled.div`
	display: flex;
	flex-wrap: wrap;
	width: 100%;
`;
const InputWrapper = styled.div`
	flex: 0 0 50%;
	max-width: 50%;
	position: relative;
	width: 100%;
	min-height: 1px;
	padding-right: 15px;
	padding-left: 15px;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
	flex-direction: column;
	justify-content: center;
`;
const InputWrapperSlim = styled.div`
	flex: 0 0 33.3%;
	max-width: 33.3%;
	position: relative;
	width: 100%;
	min-height: 1px;
	padding-right: 15px;
	padding-left: 15px;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
	flex-direction: column;
	justify-content: center;
`;
const InputWrapperWide = styled.div`
	width: 100%;
	padding-right: 15px;
	padding-left: 15px;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
	> label {
		font-weight: bold;
	}
`;
const ButtonContainer = styled.div`
	width: 100%;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
	justify-content: flex-end;
	padding-right: 15px;
`;
const ButtonWrapper = styled.div`
	display: inline-flex;
	margin-left: auto;
`;
const Div = styled.div`
	width: 100%;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
`;
const Button = styled.button`
	background: ${Colours.lochmara};
	margin-left: 0;
	border: 0;
	cursor: pointer;
	display: block;
	color: ${Colours.white};
	font-weight: 400;
	text-align: center;
	white-space: nowrap;
	user-select: none;
	padding: 5px 15px;
	font-size: 1rem;
	line-height: 1.5;
	position: relative;
	z-index: 1;
	min-width: 100px;
	margin-left: 15px;
	margin-top: 10px;
	&::after {
		content: '';
		z-index: -1;
		position: absolute;
		top: 0;
		bottom: 0;
		left: 0;
		right: 0;
		background-color: ${Colours.curiousBlue};
		transform-origin: center top;
		transform: scaleY(0);
		transition: transform .25s ease-in-out;
	}
	&:hover {
		&::after {
			transform-origin: center bottom;
			transform: scaleY(1);
		}
	}
`;
const Hr = styled.hr`
	border: 0;
	border-top: 1px solid ${Colours.lochmara};
	margin: 10px auto;
	width: 80%;
`;
class IndividualPlan extends Component {
	state = {
		individualPlan: {
			cartonId: '',
			goalsAndResults: "",
			activitiesAndDue: "",
			involvedPersons: "",
			date: undefined,
			due: undefined
		},
		newIndividualPlan: false
	}

    initState() {
        this.setState({
			individualPlan: {
				cartonId: '',
				goalsAndResults: "",
				activitiesAndDue: "",
				involvedPersons: "",
				date: undefined,
				due: undefined
			}
		});
	}

	componentDidMount() {
		if(this.props.individualPlan === undefined || this.props.individualPlan === "") {
			this.setState({newIndividualPlan: true});
		} else {
			this.setState({individualPlan: this.props.individualPlan});
		}
	}

	onInputChange = (event) => {
		const individualPlan = this.state.individualPlan;
		individualPlan[event.target.name] = event.target.value;
		this.setState({individualPlan});
	}

	onCheckboxChange = (event) => {
		const individualPlan = this.state.individualPlan;
		individualPlan[event.currentTarget.name] = !individualPlan[event.currentTarget.name];
		this.setState({individualPlan});
	}

	onArrayChange = (e, index) => {
		const individualPlan = this.state.individualPlan;
		const goalsAndResults = [...this.state.individualPlan.goalsAndResults];
		const name = e.target.name;
		goalsAndResults[index][name] = e.target.value;
		individualPlan.goalsAndResults = goalsAndResults;
		this.setState({individualPlan});
	}

	onPersonsChange = (e, index) => {
		const individualPlan = this.state.individualPlan;
		const involvedPersons = [...this.state.individualPlan.involvedPersons];
		const name = e.target.name;
		involvedPersons[index][name] = e.target.value;
		individualPlan.involvedPersons = involvedPersons;
		this.setState({individualPlan});
	}

	onActivityChange = (e, index) => {
		const individualPlan = this.state.individualPlan;
		const activitiesAndDue = [...this.state.individualPlan.activitiesAndDue];
		const name = e.target.name;
		activitiesAndDue[index][name] = e.target.value;
		individualPlan.activitiesAndDue = activitiesAndDue;
		this.setState({individualPlan});
	}

	addNewGoalsAndResultsField = () => {
		const individualPlan = this.state.individualPlan;
		const goalsAndResults = this.state.individualPlan.goalsAndResults.concat([{goals: '', results: ''}]);
		individualPlan.goalsAndResults = goalsAndResults;
		this.setState({individualPlan})
	}

	addNewActivityField = () => {
		const individualPlan = this.state.individualPlan;
		const activitiesAndDue = this.state.individualPlan.activitiesAndDue.concat([{activities: '', leadPerson: '', due: ''}]);
		individualPlan.activitiesAndDue = activitiesAndDue;
		this.setState({individualPlan})
	}

	addNewPersonField = () => {
		const individualPlan = this.state.individualPlan;
		const involvedPersons = this.state.individualPlan.involvedPersons.concat([{name: '', jobTitle: ''}]);
		individualPlan.involvedPersons = involvedPersons;
		this.setState({individualPlan})
	}

	onSave = () => {
		const data = this.state.individualPlan;

		if (this.state.newIndividualPlan) {
			data.cartonId = this.props.cartonId;
			IndividualPlanActions.addIndividualPlan(data);
		} else {
			IndividualPlanActions.editIndividualPlan(data);
		}

		this.props.modalClosed();
	}
	
	onDelete = () => {
		IndividualPlanActions.deleteIndividualPlan(this.props.cartonId);
		this.initState();
		this.props.modalClosed();
	}

	render() {
		let options;

		if(!this.state.newIndividualPlan) {
			options = <span>
				<ButtonWrapper>
					<Button onClick={this.onDelete}>Obriši</Button>
				</ButtonWrapper>
			</span>
		}
		return (
			<Container>
				<InputWrapperWide><CustomLabel title="Ciljevi i ishodi pružanja usluge:"/></InputWrapperWide>
				<InputWrapper><CustomLabel title="Ciljevi:"/></InputWrapper>
				<InputWrapper><CustomLabel title="Rezultati:"/></InputWrapper>
				<InputWrapperWide><CustomTextarea value={this.state.individualPlan.goalsAndResults} inputName="goalsAndResults" change={this.onInputChange}/></InputWrapperWide>
				<Hr />
				<InputWrapperWide><CustomLabel title="Aktivnosti, odgovorna osoba i vremenski okvir"/></InputWrapperWide>
				<InputWrapperSlim><CustomLabel title="Aktivnosti:"/></InputWrapperSlim>
				<InputWrapperSlim><CustomLabel title="Odgovorna osoba"/></InputWrapperSlim>
				<InputWrapperSlim><CustomLabel title="Rok:"/></InputWrapperSlim>
				<InputWrapperWide><CustomTextarea value={this.state.individualPlan.activitiesAndDue} inputName="activitiesAndDue" change={this.onInputChange}/></InputWrapperWide>
				<Hr />
				<InputWrapperWide><CustomLabel title="Osobe koje su učestvovale u izradi individualnog plana usluge:"/></InputWrapperWide>
				<InputWrapper><CustomLabel title="Ime i prezime:"/></InputWrapper>
				<InputWrapper><CustomLabel title="Funkcija:"/></InputWrapper>
				<InputWrapperWide><CustomTextarea value={this.state.individualPlan.involvedPersons} inputName="involvedPersons" change={this.onInputChange}/></InputWrapperWide>
				<Hr />
				<InputWrapper>
					<CustomLabel title="Datum:"/>
					<CustomInput inputType="date" value={this.state.individualPlan.date} inputName="date" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Rok za ponovni pregled:"/>
					<CustomInput inputType="date" value={this.state.individualPlan.due} inputName="due" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapperWide>
					<Button onClick={this.onSave}>Sačuvaj</Button>
					{options}
				</InputWrapperWide>
			</Container>
		 );
	}
}
export default IndividualPlan;