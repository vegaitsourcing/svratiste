import React, { Component } from 'react';
import styled from 'styled-components';

import Colours from '../common/colours';
import {input as CustomInput, label as CustomLabel, textarea as CustomTextarea} from '../common/Inputs/Inputs';

import EvaluationStore from '../../stores/EvaluationStore';
import * as EvaluationActions from '../../actions/EvaluationActions';

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
const InputWrapperWide = styled.div`
	width: 100%;
	padding-right: 15px;
	padding-left: 15px;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
	label {
		width: 30%;
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
const Hr = styled.hr`
	border: 0;
	border-top: 1px solid ${Colours.lochmara};
	margin: 0 auto;
	width: 80%;
`;
class Evaluation extends Component {
	constructor(props) {
		super(props);
	}
	state = {
		evaluation: {
			id: '',
			cartonId: '',
			age: '',
			familyMembers : '',
			schoolStatus: '',
			caseLeader: '',
			dedicatedWorker: '',
			otherMembers: '',
			basicPhysicalNeeds: '',
			psyhoSocialNeeds: '',
			educationalNeeds: '',
			otherNeeds: '',
			dominantEmotions: '',
			dominantBehaviors: '',
			surroundStrenghts: '',
			familyStrenghts: '',
			personalStrenghts: '',
			otherStrenghts: '',
			surroundRisks : '',
			familyRisks: '',
			behaviorRisks: '',
			otherRisks: '',
			capabilities: '',
			culturalSpecifics: '',
			advicedLevelOfSupport: '',
			evaluationDoneBy: '',
			date: ''
		}
	}
    initState() {
        this.setState({
			evaluation: {
				id: '',
				cartonId: '',
				age: '',
				familyMembers : '',
				schoolStatus: '',
				caseLeader: '',
				dedicatedWorker: '',
				otherMembers: '',
				basicPhysicalNeeds: '',
				psyhoSocialNeeds: '',
				educationalNeeds: '',
				otherNeeds: '',
				dominantEmotions: '',
				dominantBehaviors: '',
				surroundStrenghts: '',
				familyStrenghts: '',
				personalStrenghts: '',
				otherStrenghts: '',
				surroundRisks : '',
				familyRisks: '',
				behaviorRisks: '',
				otherRisks: '',
				capabilities: '',
				culturalSpecifics: '',
				advicedLevelOfSupport: '',
				evaluationDoneBy: '',
				date: ''
			}
		});
    }
	onInputChange = (event) => {
		const evaluation = this.state.evaluation;
		evaluation[event.target.name] = event.target.value;
		this.setState({evaluation});
	}
	handleCheckboxChange = (event) => {
		const evaluation = this.state.evaluation;
		evaluation[event.target.name] = event.target.value;
		this.setState({evaluation});
	}
	onSave = () => {
		const data = this.state.evaluation;

        EvaluationActions.addEvaluation(data);
        this.initState();
	}
	onDelete = () => {
		//ToDO
	}
	getEvaluation() {
		const evaluation = EvaluationStore.getEvaluation();
		this.setState({evaluation});
	}
	render() {
		return (
			<Container>
				<InputWrapper>
					<CustomLabel title="Zadužen stručni radnik/saradnik u usluzi:"/>
					<CustomInput value={this.state.dedicatedWorker} inputName="dedicatedWorker" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Imena, funkcija i kontakt drugih osoba uključenih u procenu:"/>
					<CustomInput value={this.state.otherMembers} inputName="otherMembers" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapperWide>
				<Hr />
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Osnovne fizičke potrebe:"/>
					<CustomTextarea value={this.state.basicPhysicalNeeds} inputName=".basicPhysicalNeeds" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Psihološke i socijalne potrebe:"/>
					<CustomTextarea value={this.state.psyhoSocialNeeds} inputName="psyhoSocialNeeds" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Edukativne potrebe:"/>
					<CustomTextarea value={this.state.educationalNeeds} inputName="educationalNeeds" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Druge potrebe:"/>
					<CustomTextarea value={this.state.otherNeeds} inputName="otherNeeds" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Dominantne emocije:"/>
					<CustomTextarea value={this.state.dominantEmotions} inputName="dominantEmotions" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Dominantna ponašanja:"/>
					<CustomTextarea value={this.state.dominantBehaviors} inputName="dominantBehaviors" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
				<Hr />
				</InputWrapperWide>
				<InputWrapper>
					<CustomLabel title="Snage iz neposrednog okruženja:"/>
					<CustomInput value={this.state.surroundStrenghts} inputName="surroundStrenghts" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Snage iz porodičnih odnosa:"/>
					<CustomInput value={this.state.familyStrenghts} inputName="familyStrenghts" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Snage iz ličnosti korisnika:"/>
					<CustomInput value={this.state.personalStrenghts} inputName="personalStrenghts" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Druge snage:"/>
					<CustomInput value={this.state.otherStrenghts} inputName="otherStrenghts" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Rizici vezani za sredinske faktore:"/>
					<CustomInput value={this.state.surroundRisks} inputName="surroundRisks" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Rizici vezani za porodične odnose:"/>
					<CustomInput value={this.state.familyRisks} inputName="familyRisks" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Rizici vezani za ponašanja korisnika:"/>
					<CustomInput value={this.state.behaviorRisks} inputName="behaviorRisks" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Drugi rizici:"/>
					<CustomInput value={this.state.otherRisks} inputName="otherRisks" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapperWide>
				<Hr />
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Procena sposobnosti korisnika:"/>
					<CustomTextarea value={this.state.capabilities} inputName="capabilities" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
					<CustomLabel title="Kulturološke i druge posebnosti korisnika:"/>
					<CustomTextarea value={this.state.culturalSpecifics} inputName="culturalSpecifics" change={this.onInputChange}/>
				</InputWrapperWide>
				<InputWrapperWide>
				<Hr />
				</InputWrapperWide>
				<InputWrapper>
					<CustomLabel title="Preporučeni stepen podrške:"/>
					<CustomInput value={this.state.advicedLevelOfSupport} inputName="advicedLevelOfSupport" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Procenu uradio:"/>
					<CustomInput value={this.state.evaluationDoneBy} inputName="evaluationDoneBy" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Datum:"/>
					<CustomInput inputType="date" value={this.state.date} inputName="date" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapperWide>
					<Button onClick={this.onSave}>Sačuvaj</Button>
					<Button onClick={this.onDelete}>Obriši</Button>
					<Button>Odštampaj</Button>
				</InputWrapperWide>
			</Container>
		 );
	}
}
export default Evaluation;