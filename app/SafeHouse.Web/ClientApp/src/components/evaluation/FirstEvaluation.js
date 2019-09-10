import React, { Component } from 'react';
import styled from 'styled-components';

import Colours from '../common/colours';
import { FontWeight} from '../common/typography';
import {input as CustomInput, label as CustomLabel, select as CustomSelect} from '../common/Inputs/Inputs';
import Constants from '../common/constants';

import * as FirstEvaluationActions from '../../actions/FirstEvaluationActions';

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
const ButtonWrapper = styled.div`
	display: inline-flex;
	margin-left: auto;
`;
const ButtonContainer = styled.div`
	display: flex;
	flex-wrap: wrap;
	margin-left: auto;
`;
class FirstEvaluation extends Component {
	state = {
		firstEvaluation: {
			id: "",
			cartonId: "",
			guardiansName: "",
			otherChildrenName: "",
			otherMembersName: "",
			livingSpace: undefined,
			schoolAndGrade: "",
			languages: "",
			healthCard: "",
			caseLeaderName: "",
			sleepOnStreet: undefined,
			dumpsterDiving: undefined,
			begging: undefined,
			prostituting: undefined,
			sellsOnStreet: undefined,
			helpingFamilyOnStreet: undefined,
			extremelyPoor: undefined,
			otherSuitability: "",
			explanation: "",
			capability: undefined,
			onTheWaitingList: false,
			serviceStart: "",
			directedToName: "",
			individualMovementAbility: "",
			verbalComunicationAbility: "",
			physicalDescription: "",
			diagnosedDisease: "",
			priorityNeeds: "",
			attitude: "",
			expectations: "",
			directedFromName: "",
			other: "",
			startedEvaluation: "",
			finishedEvaluation: "",
			evaluationDoneBy: "",
			evaluationRevisedBy: ""
		},
		newFirstEvaluation: false
	}

    initState() {
        this.setState({
			firstEvaluation: {
				id: "",
				cartonId: "",
				guardiansName: "",
				otherChildrenName: "",
				otherMembersName: "",
				livingSpace: undefined,
				schoolAndGrade: "",
				languages: "",
				healthCard: "",
				caseLeaderName: "",
				sleepOnStreet: undefined,
				dumpsterDiving: undefined,
				begging: undefined,
				prostituting: undefined,
				sellsOnStreet: undefined,
				helpingFamilyOnStreet: undefined,
				extremelyPoor: undefined,
				otherSuitability: "",
				explanation: "",
				capability: undefined,
				onTheWaitingList: false,
				serviceStart: "",
				directedToName: "",
				individualMovementAbility: "",
				verbalComunicationAbility: "",
				physicalDescription: "",
				diagnosedDisease: "",
				priorityNeeds: "",
				attitude: "",
				expectations: "",
				directedFromName: "",
				other: "",
				startedEvaluation: "",
				finishedEvaluation: "",
				evaluationDoneBy: "",
				evaluationRevisedBy: ""
			}
		});
	}

	componentDidMount() {
		if(this.props.firstEvaluation === undefined || this.props.firstEvaluation === "") {
			this.setState({newFirstEvaluation: true});
		} else {
			this.setState({firstEvaluation: this.props.firstEvaluation});
		}
	}

	onInputChange = (event) => {
		const firstEvaluation = this.state.firstEvaluation;
		firstEvaluation[event.target.name] = event.target.value;
		this.setState({firstEvaluation});
	}

	onCheckboxChange = (event) => {
		const firstEvaluation = this.state.firstEvaluation;
		firstEvaluation[event.currentTarget.name] = !firstEvaluation[event.currentTarget.name];
		this.setState({firstEvaluation});
	}

	onSave = () => {
		const data = this.state.firstEvaluation;

		if (this.state.newFirstEvaluation) {
			delete data.id;
			data.cartonId = this.props.cartonId;
			FirstEvaluationActions.addFirstEvaluation(data);
		} else {
			FirstEvaluationActions.editFirstEvaluation(data);
		}

		this.props.modalClosed();
	}
	
	onDelete = () => {
		FirstEvaluationActions.deleteFirstEvaluation(this.state.firstEvaluation.cartonId);
		this.initState();
		this.props.modalClosed();
	}

	render() {
		let options;

		if(!this.state.newCarton) {
			options = <span>
				<ButtonWrapper>
					{/* <Button onClick={this.onDelete}>Obriši</Button> */}
					{/* <Button>Odštampaj</Button> */}
				</ButtonWrapper>
			</span>
		}
		return (
			<Container>
				<InputWrapper>
					<CustomLabel title="Imena roditelja/staratelja:"/>
					<CustomInput value={this.state.firstEvaluation.guardiansName} inputName="guardiansName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Imena druge dece iz porodice:"/>
					<CustomInput value={this.state.firstEvaluation.otherChildrenName} inputName="otherChildrenName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Imena i srodstvo drugih članova domaćinstva:"/>
					<CustomInput value={this.state.firstEvaluation.otherMembersName} inputName="otherMembersName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Živi u:"/>
					<CustomSelect options={Constants.livingSpace} title="Izaberi..." value={this.state.firstEvaluation.livingSpace} inputName="livingSpace" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Škola i razred:"/>
					<CustomInput value={this.state.firstEvaluation.schoolAndGrade} inputName="schoolAndGrade" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Maternji i drugi jezici:"/>
					<CustomInput value={this.state.firstEvaluation.languages} inputName="languages" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="healthCard" name="healthCard" checked={this.state.firstEvaluation.healthCard} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="healthCard">Zdravstvena knjižica</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Voditelj slučaja:"/>
					<CustomInput value={this.state.firstEvaluation.caseLeaderName} inputName="caseLeaderName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="sleepOnStreet" name="sleepOnStreet" checked={this.state.firstEvaluation.sleepOnStreet} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="sleepOnStreet">Spava na ulici</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="dumpsterDiving" name="dumpsterDiving" checked={this.state.firstEvaluation.dumpsterDiving} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="dumpsterDiving">Hranu pronalazi u kontejnerima</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="begging" name="begging" checked={this.state.firstEvaluation.begging} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="begging">Prosi</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="prostituting" name="prostituting" checked={this.state.firstEvaluation.prostituting} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="prostituting">Prodaje seksualne usluge</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="sellsOnStreet" name="sellsOnStreet" checked={this.state.firstEvaluation.sellsOnStreet} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="sellsOnStreet">Prodaje na pijaci/ulici</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="helpingFamilyOnStreet" name="helpingFamilyOnStreet" checked={this.state.firstEvaluation.helpingFamilyOnStreet} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="helpingFamilyOnStreet">Pomaže porodici u radu na ulici</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="extremelyPoor" name="extremelyPoor" checked={this.state.firstEvaluation.extremelyPoor} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="extremelyPoor">Ekstremno siromašna porodica, postoji rizik za dete</LabelCheckbox>
				</InputWrapper>
				<InputWrapper />
				<InputWrapper>
					<CustomLabel title="Drugo:"/>
					<CustomInput value={this.state.firstEvaluation.otherSuitability} inputName="otherSuitability" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Obrazloženje nepodobnosti korisnika:"/>
					<CustomInput value={this.state.firstEvaluation.explanation} inputName="explanation" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="capability" name="capability" checked={this.state.firstEvaluation.capability} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="capability">Postoje kapaciteti usluge da zadovolji potrebe korisnika</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<InputHidden type="checkbox" id="onTheWaitingList" name="onTheWaitingList" checked={this.state.firstEvaluation.onTheWaitingList} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="onTheWaitingList">Na listi čekanja</LabelCheckbox>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Datum početka korišćenja usluge:"/>
					<CustomInput inputType="date" value={this.state.firstEvaluation.serviceStart} inputName="serviceStart" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Kome je upućen:"/>
					<CustomInput value={this.state.firstEvaluation.directedToName} inputName="directedToName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Sposobnost samostalnog kretanja:"/>
					<CustomInput value={this.state.firstEvaluation.individualMovementAbility} inputName="individualMovementAbility" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Sposobnost verbalne komunikacije:"/>
					<CustomInput value={this.state.firstEvaluation.verbalComunicationAbility} inputName="verbalComunicationAbility" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Kratak opis fizičkog izgleda:"/>
					<CustomInput value={this.state.firstEvaluation.physicalDescription} inputName="physicalDescription" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Dijagnostikofana bolest, alergija:"/>
					<CustomInput value={this.state.firstEvaluation.diagnosedDisease} inputName="diagnosedDisease" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prioritetne potrebe korisnika:"/>
					<CustomInput value={this.state.firstEvaluation.priorityNeeds} inputName="priorityNeeds" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Stav:"/>
					<CustomInput value={this.state.firstEvaluation.attitude} inputName="attitude" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Očekivanja:"/>
					<CustomInput value={this.state.firstEvaluation.expectations} inputName="expectations" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Upućen od strane:"/>
					<CustomInput value={this.state.firstEvaluation.directedFromName} inputName="directedFromName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Ostalo:"/>
					<CustomInput value={this.state.firstEvaluation.other} inputName="other" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prijem Započet:"/>
					<CustomInput inputType="date" value={this.state.firstEvaluation.startedEvaluation} inputName="startedEvaluation" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prijem Završen:"/>
					<CustomInput inputType="date" value={this.state.firstEvaluation.finishedEvaluation} inputName="finishedEvaluation" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prijem uradio:"/>
					<CustomInput value={this.state.firstEvaluation.evaluationDoneBy} inputName="evaluationDoneBy" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Pregledao:"/>
					<CustomInput value={this.state.firstEvaluation.evaluationRevisedBy} inputName="evaluationRevisedBy" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapperWide>
					<ButtonContainer>
						<Button onClick={this.onSave}>Sačuvaj</Button>
						{options}
					</ButtonContainer>
				</InputWrapperWide>
			</Container>
		 );
	}
}
export default FirstEvaluation;