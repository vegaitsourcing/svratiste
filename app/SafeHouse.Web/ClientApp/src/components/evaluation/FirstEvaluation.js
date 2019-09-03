import React, { Component } from 'react';
import styled from 'styled-components';

import Colours from '../common/colours';
import { FontWeight} from '../common/typography';
import {input as CustomInput, label as CustomLabel, select as CustomSelect} from '../common/Inputs/Inputs';
import Constants from '../common/constants';

const Container = styled.div`
	display: flex;
	flex-wrap: wrap;
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
const InputWrapperWide = styled.div`
	width: 100%;
	padding-right: 15px;
	padding-left: 15px;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
`;

const InputHidden = styled.input`
	opacity: 0;
	font-size: 0;
	visibility: hidden;
	margin: 0;
	height: 0;
	width: 0;
	&:checked+label::after {
		content: '';
		position: absolute;
		width: 10px;
		height: 10px;
		background: ${Colours.lochmara};
		top: 8px;
		left: 8px;
	}
`;
const LabelCheckbox = styled.label`
	display: inline-block;
	cursor: pointer;
	padding: 3px 0 3px 36px;
	position: relative;
	margin: 0;
	color: ${Colours.bunting};
	font-size: 14px;
	font-weight: ${FontWeight.medium};
	&::before {
		content: "";
		background-color: transparent;
		border: 1px solid #c6c6c6;
		border-radius: 2px;
		display: inline-block;
		height: 24px;
		width: 24px;
		position: absolute;
		left: 0;
		top: 0;
	}
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
class FirstEvaluation extends Component {
	state = {
		id: '',
		cartonId: '',
		otherChildrenName: '',
		otherMembersName: '',
		guardiansName: '',
		livingSpace: '',
		schoolAndGrade: '',
		languages: '',
		healthCard: false,
		caseLeaderName: '',
		capability: false,
		onTheWaitingList: false,
		serviceStart: '',
		directedToName: '',
		individualMovementAbility: '',
		verbalComunicationAbility: '',
		physicalDescription: '',
		diagnosedDisease: '',
		priorityNeeds: '',
		attitude: '',
		expectations: '',
		directedFromName: '',
		other: '',
		startedEvaluation: '',
		finishedEvaluation: '',
		evaluationDoneBy: '',
		evaluationRevisedBy: '',
		suitabilityId: ''
	}
	onInputChange = (event) => {
		const newState = {
			...this.state,
			[event.target.name] : event.target.value
		}
		this.setState(newState);
		console.log(this.state);
	}
	handleCheckboxChange = (event) => {
		const { target } = event;
		const { name, checked } = target;

		this.setState({ [name]: checked });
	}
	render() {
		return (
			<Container>
				<InputWrapper>
					<CustomLabel title="Imena roditelja/staratelja:"/>
					<CustomInput value={this.state.guardiansName} inputName="guardiansName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Imena druge dece iz porodice:"/>
					<CustomInput value={this.state.otherChildrenName} inputName="otherChildrenName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Imena i srodstvo drugih članova domaćinstva:"/>
					<CustomInput value={this.state.otherMembersName} inputName="otherMembersName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Živi u:"/>
					<CustomSelect options={Constants.livingSpace} title="Izaberi..." value={this.state.livingSpace} inputName="livingSpace" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Škola i razred:"/>
					<CustomInput value={this.state.schoolAndGrade} inputName="schoolAndGrade" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Maternji i drugi jezici:"/>
					<CustomInput value={this.state.languages} inputName="languages" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="healthCard" name="healthCard" checked={this.state.healthCard} onChange={this.handleCheckboxChange}/>
					<LabelCheckbox htmlFor="healthCard">Zdravstvena knjižica</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Voditelj slučaja:"/>
					<CustomInput value={this.state.caseLeaderName} inputName="caseLeaderName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="capability" name="capability" checked={this.state.capability} onChange={this.handleCheckboxChange}/>
					<LabelCheckbox htmlFor="capability">Postoje kapaciteti usluge da zadovolji potrebe korisnika</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="onTheWaitingList" name="onTheWaitingList" checked={this.state.onTheWaitingList} onChange={this.handleCheckboxChange}/>
					<LabelCheckbox htmlFor="onTheWaitingList">Na listi čekanja</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Datum početka korišćenja usluge:"/>
					<CustomInput inputType="date" value={this.state.serviceStart} inputName="serviceStart" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Kome je upućen:"/>
					<CustomInput value={this.state.directedToName} inputName="directedToName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Sposobnost samostalnog kretanja:"/>
					<CustomInput value={this.state.individualMovementAbility} inputName="individualMovementAbility" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Sposobnost verbalne komunikacije:"/>
					<CustomInput value={this.state.verbalComunicationAbility} inputName="verbalComunicationAbility" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Kratak opis fizičkog izgleda:"/>
					<CustomInput value={this.state.physicalDescription} inputName="physicalDescription" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Dijagnostikofana bolest, alergija:"/>
					<CustomInput value={this.state.diagnosedDisease} inputName="diagnosedDisease" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prioritetne potrebe korisnika:"/>
					<CustomInput value={this.state.priorityNeeds} inputName="priorityNeeds" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Stav:"/>
					<CustomInput value={this.state.attitude} inputName="attitude" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Očekivanja:"/>
					<CustomInput value={this.state.expectations} inputName="expectations" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Upućen od strane:"/>
					<CustomInput value={this.state.directedFromName} inputName="directedFromName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Ostalo:"/>
					<CustomInput value={this.state.other} inputName="other" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prijem Započet:"/>
					<CustomInput inputType="date" value={this.state.startedEvaluation} inputName="startedEvaluation" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prijem Završen:"/>
					<CustomInput inputType="date" value={this.state.finishedEvaluation} inputName="finishedEvaluation" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prijem uradio:"/>
					<CustomInput value={this.state.evaluationDoneBy} inputName="evaluationDoneBy" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Pregledao:"/>
					<CustomInput value={this.state.evaluationRevisedBy} inputName="evaluationRevisedBy" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapperWide>
					<Button>Sačuvaj</Button>
					<Button>Odštampaj</Button>
				</InputWrapperWide>
			</Container>
		 );
	}
}
export default FirstEvaluation;