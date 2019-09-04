import React, { Component } from 'react';
import styled from 'styled-components';
import Select from 'react-select';

import Colours from '../components/common/colours';
import { FontWeight } from '../components/common/typography';
import {input as CustomInput, label as CustomLabel} from './common/Inputs/Inputs';

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
const LabelLarge = styled(CustomLabel)`
	font-weight: ${FontWeight.medium};
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
const Div = styled.div`
	width: 100%;
	box-sizing: border-box;
	margin-bottom: 15px;
	display: flex;
	flex-wrap: wrap;
`;
class DailyRecord extends Component {
	state = {
		firstName: '',
		lastName: '',
		gender: '',
		stay: false,
		breakfast: false,
		lunch: false,
		bath: false,
		liecesRemoval: false,
		cartonId: '',
		clothes: 0,
		mediationWriting: 0,
		mediationWritingDescription: '',
		mediationSpeaking: 0,
		mediationSpeakingDescription: '',
		lifeSkills: 0,
		schoolAcivities: 0,
		workshops: [],
		psihosocialSupport: false,
		parentsContact: false,
		medicalInterventions: 0,
		arrival: '',
		// pageNumber: props.pageNumber,

		// enumerations
		mediationWritingsEnum: [{ value: 'chocolate', label: 'Chocolate' },
		{ value: 'strawberry', label: 'Strawberry' },
		{ value: 'vanilla', label: 'Vanilla' }],
		mediationSpeakingsEnum: [{ value: 'chocolate', label: 'Chocolate' },
		{ value: 'strawberry', label: 'Strawberry' },
		{ value: 'vanilla', label: 'Vanilla' }],
		lifeSkillsEnum: [],
		workshopTypesEnum: [],
		schoolActivitiesEnum: [],
		medicalInterventionsEnum: []
	};
	handleCheckboxChange = (event) => {
		const { target } = event;
		const { name, checked } = target;

		this.setState({ [name]: checked });
	}
	multiSelectChange(value, state) {
		console.log(value);
		console.log(state);
		let values = value.reduce(function (prev, cur) {
			return prev + cur.value;
		}, 0);
		this.setState({[state]: values})
	}
	onDelete = () => {
		//ToDo
	}
	render() {
		return (
			<Container>
				<InputWrapperWide>
					<LabelLarge title="Obezbeđenje boravka:"/>
					<InputHidden type="checkbox" id="stay" name="stay" checked={this.state.stay} onChange={this.handleCheckboxChange}/>
					<LabelCheckbox htmlFor="stay">Boravak</LabelCheckbox>
					<Hr />
				</InputWrapperWide>
				<InputWrapperWide>
					<LabelLarge title="Obezbeđenje obroka za korisnike:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="breakfast" name="breakfast" checked={this.state.breakfast} onChange={this.handleCheckboxChange}/>
						<LabelCheckbox htmlFor="breakfast">Doručak</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="lunch" name="lunch" checked={this.state.lunch} onChange={this.handleCheckboxChange}/>
						<LabelCheckbox htmlFor="lunch">Ručak</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="diner" name="diner" checked={this.state.diner} onChange={this.handleCheckboxChange}/>
						<LabelCheckbox htmlFor="diner">Večera</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Obezbeđenje uslova za održavanje lične higijene:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="bath" name="bath" checked={this.state.bath} onChange={this.handleCheckboxChange}/>
						<LabelCheckbox htmlFor="bath">Kupanje</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="liecesRemoval" name="liecesRemoval" checked={this.state.liecesRemoval} onChange={this.handleCheckboxChange}/>
						<LabelCheckbox htmlFor="liecesRemoval">Devaširanje</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Nabavka obuće i odeće i obezbeđivanje uslova za njihovo održavanje:"/>
					<InputHidden type="checkbox" id="clothes" name="clothes" checked={this.state.clothes} onChange={this.handleCheckboxChange}/>
					<LabelCheckbox htmlFor="clothes">Odeća i obuća</LabelCheckbox>
				</InputWrapperWide>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Posredovanje u obezbeđivanju dostupnosti usluga u zajednici"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Usmeno" />
						<Select
							options={this.state.mediationSpeakingsEnum}
							onChange={(value) => this.multiSelectChange(value, "mediationSpeaking")}
							isMulti />
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Pismeno" />
						<Select
							options={this.state.mediationWritingsEnum}
							onChange={(value) => this.multiSelectChange(value, "mediationWriting")}
							isMulti />
					</InputWrapper>
				</Div>
				<Button>Sačuvaj</Button>
				<Button onClick={this.onDelete}>Obriši</Button>
				<ButtonWrapper>
					<DarkButton onClick={() => this.showModal(1)}>Otkazi   </DarkButton>
				</ButtonWrapper>
			</Container>
		);
	}
}
export default DailyRecord;