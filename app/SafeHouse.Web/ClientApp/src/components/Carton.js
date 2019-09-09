import React, { Component } from 'react';
import styled from 'styled-components';
import { withRouter } from 'react-router-dom';

import Colours from '../components/common/colours';
import { FontWeight, Body, Headings } from '../components/common/typography';
import Modal from '../components/common/Modal/Modal';
import FirstEvaluation from '../components/evaluation/FirstEvaluation';
import Evaluation from '../components/evaluation/Evaluation';
import IndividualPlan from '../components/evaluation/IndividualPlan';
import {input as CustomInput, label as CustomLabel, select as CustomSelect} from './common/Inputs/Inputs';
import Constants from '../components/common/constants';

import * as CardboardActions from '../actions/CardboardActions';
import * as FirstEvaluationActions from '../actions/FirstEvaluationActions';
import * as EvaluationActions from '../actions/EvaluationActions';
import * as IndividualPlanActions from '../actions/IndividualPlanActions';

import CardboardStore from '../stores/CardboardStore';
import FirstEvaluationStore from '../stores/FirstEvaluationStore';
import EvaluationStore from '../stores/EvaluationStore';
import IndividualPlanStore from '../stores/IndividualPlanStore';

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
const H2 = styled.h2`
	font-size: 15px;
	color: ${Colours.martinique};
	text-align: center;
`;
const Hr = styled.hr`
	border: 0;
	border-top: 1px solid rgba(0,0,0,.1);
	margin: 10px 0 20px;
`;
const ButtonContainer = styled.div`
	display: flex;
	flex-wrap: wrap;
	margin-left: auto;
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
const Table = styled.table`
	border-spacing: 0;
	font-size: 14px;
	font-family: ${Body.font};
	line-height: 1.5;
	color: ${Colours.baliHai};
	background-color: ${Colours.white};
	background-clip: padding-box;
	border-radius: .370rem;
	box-shadow: 0 1px 3px rgba(49, 49, 92, 0.15), 0 1px 0 rgba(0,0,0, 0.03);
	border: 0;
	transition: box-shadow .15s ease;
	box-sizing: border-box;
	outline: none;
	border-bottom: 2px solid ${Colours.lochmara};
`;
const TH = styled.th`
	font-size: 14px;
	font-weight: ${FontWeight.normal};
	font-family: ${Headings.font};
	color: #333;
	padding: 12px 0;
	vertical-align: middle;
`;
const TD = styled.td`
	font-size: 14px;
	font-weight: ${FontWeight.light};
	font-family: ${Headings.font};
	color: #333;
	padding: 14px 0;
	border-top: 1px solid #ddd;
	vertical-align: middle;
	text-align: center;
	cursor: pointer;
	&:hover {
		color: #0580c6;
	}
`;
const TR = styled.tr`
	border-bottom: 1px solid #ddd;
`;
const ButtonWrapper = styled.div`
	display: inline-flex;
	margin-left: auto;
`;
const DarkButton = styled(Button)`
	background: ${Colours.stTropaz};
`;
class Carton extends Component {
	constructor(props) {
		super(props);
		this.getCarton = this.getCarton.bind(this);
		this.getFirstEvaluation = this.getFirstEvaluation.bind(this);
		this.getEvaluation = this.getEvaluation.bind(this);
		this.getIndividualPlan = this.getIndividualPlan.bind(this);
	}

	state = {
		carton: {
			firstName: '',
			lastName: '',
			nickname: '',
			gender: 0,
			dateOfBirth: undefined,
			addressStreetName: '',
			addressStreetNumber: '',
			fathersName: '',
			fathersLastName: '',
			mothersName: '',
			mothersLastName: '',
			evaluationDone: false,
			individualPlanDone: false,
			individualPlanRevised: false,
			initialEvaluationDone: false,
			notifications: 0,
			notificationsEnabled: true,
			numberOfVisits: 0
		},
		firstEvaluation: undefined,
		evaluation: undefined,
		individualPlan: undefined,
		show: false,
		newCarton: true,
		componentNumber: '',
		dailyRecords: undefined
	}

    initState() {
        this.setState({
			carton: {
				firstName: '',
				lastName: '',
				nickname: '',
				gender: 0,
				dateOfBirth: undefined,
				addressStreetName: '',
				addressStreetNumber: '',
				fathersName: '',
				fathersLastName: '',
				mothersName: '',
				mothersLastName: '',
				evaluationDone: false,
				individualPlanDone: false,
				individualPlanRevised: false,
				initialEvaluationDone: false,
				notifications: 0,
				notificationsEnabled: true,
				numberOfVisits: 0
			}
		});
	}
	
	componentWillMount() {
		CardboardStore.on("fetched_carton", this.getCarton);
		FirstEvaluationStore.on("fetched_first_evaluation", this.getFirstEvaluation);
		EvaluationStore.on("fetched_evaluation", this.getEvaluation);
		IndividualPlanStore.on("fetched_individual_plan", this.getIndividualPlan);
	}

	componentDidMount() {
		if(this.props.id) {
			CardboardActions.getCartonById(this.props.id);
			FirstEvaluationActions.getFirstEvaluationByCartonId(this.props.id);
			EvaluationActions.getEvaluationByCartonId(this.props.id);
			IndividualPlanActions.getIndividualPlanByCartonId(this.props.id);
			this.setState({newCarton: false});
		}
	}

	componentWillUnmount() {
		CardboardStore.removeListener("fetched_carton", this.getCarton);
		FirstEvaluationStore.removeListener("fetched_first_evaluation", this.getFirstEvaluation);
		EvaluationStore.removeListener("fetched_evaluation", this.getEvaluation);
		IndividualPlanStore.removeListener("fetched_individual_plan", this.getIndividualPlan);
	}

	showModal = (componentNumber) => {
		this.setState({componentNumber: componentNumber, show: true});
	}

	hideModal = () => {
		this.setState({show: false});
	}

	onInputChange = (event) => {
		const carton = this.state.carton;
		carton[event.target.name] = event.target.value;
		this.setState({carton});
	}

	onCheckboxChange = (event) => {
		const carton = this.state.carton;
		carton[event.currentTarget.name] = !carton[event.currentTarget.name];
		this.setState({carton});
	}

	onSave = () => {
		const data = this.state.carton;

		delete data.individualPlanRevised;
		delete data.notifications;
		delete data.notificationsEnabled;
		delete data.numberOfVisits;

		if(data.id) {
			CardboardActions.editCarton(data);
		} else {
			delete data.id;
			CardboardActions.addCarton(data);
		}

        this.initState();
	}

	onDelete = () => {
		CardboardActions.deleteCarton(this.props.id);
		this.initState();
	}

	getCarton() {
		const carton = CardboardStore.getCarton();
		carton.dateOfBirth = new Date(carton.dateOfBirth).toISOString().slice(0,10);
		this.setState({carton});
	}

	getFirstEvaluation() {
		const firstEvaluation = FirstEvaluationStore.getFirstEvaluation();
		this.setState({firstEvaluation});
	}

	getEvaluation() {
		const evaluation = EvaluationStore.getEvaluation();
		this.setState({evaluation});
	}

	getIndividualPlan() {
		const individualPlan = IndividualPlanStore.getIndividualPlan();
		this.setState({individualPlan});
	}
	
	showDailyRecord = (id) => {
		this.props.history.push('/records/' + id);
	}

	render() {
		let firstEvaluationTitle = this.state.firstEvaluation === undefined || this.state.firstEvaluation === "" ? "Kreiraj prvu procenu" : "Prva procena";
		let evaluationTitle = this.state.evaluation === undefined || this.state.evaluation === "" ? "Kreiraj Procenu" : "Procena";
		let individualPlanTitle = this.state.individualPlan === undefined || this.state.individualPlan === "" ? "Kreiraj individualni Plan" : "Individualni plan";
		let options;
		let dailyRecords;
		if(!this.state.newCarton) {
			options = <span>
				<ButtonWrapper>
					<Button onClick={this.onDelete}>Obriši</Button>
					<DarkButton onClick={() => this.showModal(1)}>{firstEvaluationTitle}</DarkButton>
					<DarkButton onClick={() => this.showModal(2)}>{evaluationTitle}</DarkButton>
					<DarkButton onClick={() => this.showModal(3)}>{individualPlanTitle}</DarkButton>
				</ButtonWrapper>
				{(this.state.componentNumber === 1) && <Modal show={this.state.show} modalClosed={() => this.hideModal()} title={firstEvaluationTitle}><FirstEvaluation modalClosed={() => this.hideModal()} firstEvaluation={this.state.firstEvaluation} cartonId={this.props.id} /></Modal>}
				{(this.state.componentNumber === 2) && <Modal show={this.state.show} modalClosed={() => this.hideModal()} title={evaluationTitle}><Evaluation modalClosed={() => this.hideModal()} evaluation={this.state.evaluation} cartonId={this.props.id} /></Modal>}
				{(this.state.componentNumber === 3) && <Modal show={this.state.show} modalClosed={() => this.hideModal()} title={individualPlanTitle}><IndividualPlan modalClosed={() => this.hideModal()} individualPlan={this.state.individualPlan} cartonId={this.props.id} /></Modal>}
			</span>;
			if(this.state.dailyRecords !== undefined) {
				dailyRecords = <><InputWrapperWide>
					<Hr />
					<H2>Dnevna evidencija</H2>
					</InputWrapperWide>
					<InputWrapperWide>
						<Table width="100%" border="0">
							<thead>
								<TR>
									<TH>Redni broj</TH>
									<TH>Datum kreiranja</TH>
									<TH>Dolazak</TH>
									<TH>Odlazak</TH>
								</TR>
							</thead>
							<tbody>
								{this.state.dailyRecords.map((item, index) => (
									<TR key={item.id} onClick={() => this.showDailyRecord(item.id)}>
										<TD>{index}</TD>
										<TD>{item.date}</TD>
										<TD>{item.startTime}</TD>
										<TD>{item.endTime}</TD>
									</TR>
								))}
							</tbody>
						</Table>
					</InputWrapperWide></>
			}
		}
		return (
			<Container>
				<InputWrapper>
					<CustomLabel required title="Ime"/>
					<CustomInput value={this.state.carton.firstName} inputName="firstName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel required title="Prezime"/>
					<CustomInput value={this.state.carton.lastName} inputName="lastName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Ime oca"/>
					<CustomInput value={this.state.carton.fathersName} inputName="fathersName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prezime oca"/>
					<CustomInput value={this.state.carton.fathersLastName} inputName="fathersLastName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Ime majke"/>
					<CustomInput value={this.state.carton.mothersName} inputName="mothersName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Prezime majke"/>
					<CustomInput value={this.state.carton.mothersLastName} inputName="mothersLastName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Nadimak"/>
					<CustomInput value={this.state.carton.nickname} inputName="nickname" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel required title="Pol"/>
					<CustomSelect options={Constants.genderOptions} title="Izaberi pol..." value={this.state.carton.gender} inputName="gender" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Adresa stanovanja"/>
					<CustomInput value={this.state.carton.addressStreetName} inputName="addressStreetName" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel title="Broj ulice"/>
					<CustomInput value={this.state.carton.addressStreetNumber} inputName="addressStreetNumber" change={this.onInputChange}/>
				</InputWrapper>
				<InputWrapper>
					<CustomLabel required title="Datum rodjenja"/>
					<CustomInput inputType="date" inputName="dateOfBirth" value={this.state.carton.dateOfBirth} change={this.onInputChange}/>
				</InputWrapper>
				{dailyRecords}
				<InputWrapperWide>
					<Hr />
					<InputHidden type="checkbox" id="prijemnaprocena" name="initialEvaluationDone" checked={this.state.carton.initialEvaluationDone} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="prijemnaprocena">Prijemna procena</LabelCheckbox>
				</InputWrapperWide>
				<InputWrapperWide>
					<InputHidden type="checkbox" id="procena" name="evaluationDone" checked={this.state.carton.evaluationDone} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="procena">Procena</LabelCheckbox>
				</InputWrapperWide>
				<InputWrapper>
					<InputHidden type="checkbox" id="individualniPlan" name="individualPlanDone" checked={this.state.carton.individualPlanDone} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="individualniPlan">Postoje kapaciteti usluge da zadovolji potrebe korisnika</LabelCheckbox>
				</InputWrapper>
				<ButtonContainer>
					<Button onClick={this.onSave}>Sačuvaj</Button>
					{options}
				</ButtonContainer>
			</Container>
		);
	}
}
export default withRouter(Carton);