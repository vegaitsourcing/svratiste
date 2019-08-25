import React, { Component } from 'react';
import styled from 'styled-components';

import Colours from '../components/common/colours';
import { FontWeight } from '../components/common/typography';
import Modal from '../components/common/Modal/Modal';
import FirstEvaluation from '../components/evaluation/FirstEvaluation';
import Evaluation from '../components/evaluation/Evaluation';
import IndividualPlan from '../components/evaluation/IndividualPlan';
import {input as CustomInput, label as CustomLabel, select as CustomSelect} from './common/Inputs/Inputs';
import Constants from '../components/common/constants';

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
`;
const InputWrapperWide = styled.div`
	width: 100%;
	padding-right: 15px;
	padding-left: 15px;
	box-sizing: border-box;
	margin-bottom: 15px;
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
const Hr = styled.hr`
	border: 0;
	border-top: 1px solid rgba(0,0,0,.1);
	margin: 10px 0 20px;
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
const DarkButton = styled(Button)`
	background: ${Colours.stTropaz};
`;
class Carton extends Component {
	state = {
		FirstName: '',
		LastName: '',
		Nickname: '',
		Gender: '',
		DateOfBirth: '',
		AddressStreetName: '',
		AddressStreetNumber: '',
		FathersName: '',
		MothersName: '',
		show: false,
		componentNumber: ''
	}
	componentDidMount() {

	}
	showModal = (componentNumber) => {
		this.setState({componentNumber: componentNumber, show: true});
	}
	hideModal = () => {
		this.setState({show: false});
	}
	onInputChange = (event) => {
		const newState = {
			...this.state,
			[event.target.name] : event.target.value
		}
		console.log(newState);
		this.setState(newState);
	}
	render() {
		return (
			<Container>
				<InputWrapper>
					<CustomLabel required title="Ime"/>
					<CustomInput value={this.state.FirstName} inputName="FirstName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel required title="Prezime"/>
					<CustomInput value={this.state.LastName} inputName="LastName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Ime oca"/>
					<CustomInput value={this.state.FathersName} inputName="FathersName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Ime majke"/>
					<CustomInput value={this.state.MothersName} inputName="MothersName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Nadimak"/>
					<CustomInput value={this.state.Nickname} inputName="Nickname" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel required title="Pol"/>
					<CustomSelect options={Constants.genderOptions} title="Izaberi pol..." value={this.state.Gender} inputName="Gender" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Adresa stanovanja"/>
					<CustomInput value={this.state.AddressStreetName} inputName="AddressStreetName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Broj ulice"/>
					<CustomInput value={this.state.AddressStreetNumber} inputName="AddressStreetNumber" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel required title="Datum rodjenja"/>
					<CustomInput inputType="date"/>
				</InputWrapper>
				<InputWrapperWide>
					<Hr />
					<InputHidden type="checkbox" id="prijemnaprocena" name="prijemnaprocena"/>
					<LabelCheckbox htmlFor="prijemnaprocena">Prijemna procena</LabelCheckbox>
				</InputWrapperWide>
				<InputWrapperWide>
					<InputHidden type="checkbox" id="procena" name="procena"/>
					<LabelCheckbox htmlFor="procena">Procena</LabelCheckbox>
				</InputWrapperWide>
				<InputWrapperWide>
					<InputHidden type="checkbox" id="individualniPlan" name="individualniPlan"/>
					<LabelCheckbox htmlFor="individualniPlan">Individualni plan</LabelCheckbox>
				</InputWrapperWide>
				<Button>Sačuvaj</Button>
				<ButtonWrapper>
					<DarkButton onClick={() => this.showModal(1)}>Kreiraj Prijemnu Procenu</DarkButton>
					<DarkButton onClick={() => this.showModal(2)}>Kreiraj Procenu</DarkButton>
					<DarkButton onClick={() => this.showModal(3)}>Kreiraj Individualni Plan</DarkButton>
				</ButtonWrapper>
				{(this.state.componentNumber === 1) && <Modal show={this.state.show} modalClosed={() => this.hideModal()} title="Kreiraj Prijemnu Procenu"><FirstEvaluation /></Modal>}
				{(this.state.componentNumber === 2) && <Modal show={this.state.show} modalClosed={() => this.hideModal()} title="Kreiraj Procenu"><Evaluation /></Modal>}
				{(this.state.componentNumber === 3) && <Modal show={this.state.show} modalClosed={() => this.hideModal()} title="Kreiraj Individualni Plan"><IndividualPlan /></Modal>}
			</Container>
		);
	}
}
export default Carton;