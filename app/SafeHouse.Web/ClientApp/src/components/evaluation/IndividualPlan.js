import React, { Component } from 'react';
import styled from 'styled-components';

import Colours from '../common/colours';
import {input as CustomInput, label as CustomLabel} from '../common/Inputs/Inputs';

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
		id: '',
		cartonId: '',
		date: '',
		due: '',
		goalsAndResults: [
			{
				goals: '',
				results: ''
			}
		],
		activitiesAndDue: [
			{
				activities: '',
				leadPerson: '',
				due: ''
			}
		],
		involvedPersons: [
			{
				name: '',
				jobTitle: ''
			}
		]
	}
	onInputChange = (event) => {
		const newState = {
			...this.state,
			[event.target.name] : event.target.value
		}
		this.setState(newState);
	}
	onArrayChange = (e, index) => {
		const goalsAndResults = [...this.state.goalsAndResults];
		const name = e.target.name;
		goalsAndResults[index][name] = e.target.value;
		this.setState({goalsAndResults});
	}
	onPersonsChange = (e, index) => {
		const involvedPersons = [...this.state.involvedPersons];
		const name = e.target.name;
		involvedPersons[index][name] = e.target.value;
		this.setState({involvedPersons});
	}
	onActivityChange = (e, index) => {
		const activitiesAndDue = [...this.state.activitiesAndDue];
		const name = e.target.name;
		activitiesAndDue[index][name] = e.target.value;
		this.setState({activitiesAndDue});
	}
	addNewGoalsAndResultsField = () => {
		const goalsAndResults = this.state.goalsAndResults.concat([{goals: '', results: ''}])
		this.setState({goalsAndResults})
	}
	addNewActivityField = () => {
		const activitiesAndDue = this.state.activitiesAndDue.concat([{activities: '', leadPerson: '', due: ''}])
		this.setState({activitiesAndDue})
	}
	addNewPersonField = () => {
		const involvedPersons = this.state.involvedPersons.concat([{name: '', jobTitle: ''}])
		this.setState({involvedPersons})
	}
	render() {
		return (
			<Container>
				<InputWrapperWide><CustomLabel title="Ciljevi i ishodi pružanja usluge:"/></InputWrapperWide>
				<InputWrapper><CustomLabel title="Ciljevi:"/></InputWrapper>
				<InputWrapper><CustomLabel title="Rezultati:"/></InputWrapper>
				{this.state.goalsAndResults.map((item, index) => (
					<Div key={index}>
						<InputWrapper>
							<CustomInput value={item.goals} inputName="goals" change={(e) => this.onArrayChange(e, index)}/>
						</InputWrapper>
						<InputWrapper>
							<CustomInput value={item.results} inputName="results" change={(e) => this.onArrayChange(e, index)}/>
						</InputWrapper>
					</Div>
				))}
				<ButtonContainer>
					<Button onClick={this.addNewGoalsAndResultsField}>Dodaj novo polje</Button>
				</ButtonContainer>
				<Hr />
				<InputWrapperWide><CustomLabel title="Aktivnosti, odgovorna osoba i vremenski okvir"/></InputWrapperWide>
				<InputWrapperSlim><CustomLabel title="Aktivnosti:"/></InputWrapperSlim>
				<InputWrapperSlim><CustomLabel title="Odgovorna osoba"/></InputWrapperSlim>
				<InputWrapperSlim><CustomLabel title="Rok:"/></InputWrapperSlim>
				{this.state.activitiesAndDue.map((item, index) => (
					<Div key={index}>
						<InputWrapperSlim>
							<CustomInput value={item.activities} inputName="activities" change={(e) => this.onActivityChange(e, index)}/>
						</InputWrapperSlim>
						<InputWrapperSlim>
							<CustomInput value={item.leadPerson} inputName="leadPerson" change={(e) => this.onActivityChange(e, index)}/>
						</InputWrapperSlim>
						<InputWrapperSlim>
							<CustomInput value={item.due} inputName="due" change={(e) => this.onActivityChange(e, index)}/>
						</InputWrapperSlim>
					</Div>
				))}
				<ButtonContainer>
					<Button onClick={this.addNewActivityField}>Dodaj novo polje</Button>
				</ButtonContainer>
				<Hr />
				<InputWrapperWide><CustomLabel title="Osobe koje su učestvovale u izradi individualnog plana usluge:"/></InputWrapperWide>
				<InputWrapper><CustomLabel title="Ime i prezime:"/></InputWrapper>
				<InputWrapper><CustomLabel title="Funkcija:"/></InputWrapper>
				{this.state.involvedPersons.map((item, index) => (
					<Div key={index}>
						<InputWrapper>
							<CustomInput value={item.name} inputName="name" change={(e) => this.onPersonsChange(e, index)}/>
						</InputWrapper>
						<InputWrapper>
							<CustomInput value={item.jobTitle} inputName="jobTitle" change={(e) => this.onPersonsChange(e, index)}/>
						</InputWrapper>
					</Div>
				))}
				<ButtonContainer>
					<Button onClick={this.addNewPersonField}>Dodaj novo polje</Button>
				</ButtonContainer>
				<Hr />
				<InputWrapper>
					<CustomLabel title="Datum:"/>
					<CustomInput inputType="date" value={this.state.date} inputName="date" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Rok za ponovni pregled:"/>
					<CustomInput value={this.state.due} inputName="due" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapperWide>
					<Button>Sačuvaj</Button>
					<Button>Odštampaj</Button>
				</InputWrapperWide>
			</Container>
		 );
	}
}
export default IndividualPlan;