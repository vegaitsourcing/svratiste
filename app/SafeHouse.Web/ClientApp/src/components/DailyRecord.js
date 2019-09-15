import React, { Component } from 'react';
import styled from 'styled-components';
import Select from 'react-select';

import Colours from '../components/common/colours';
import { FontWeight } from '../components/common/typography';
import {input as CustomInput, label as CustomLabel} from './common/Inputs/Inputs';

import * as DailyEntryActions from '../actions/DailyEntryActions';

import  DailyEntryStore from '../stores/DailyEntryStore';

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
	constructor(props) {
		super(props);
		this.getDailyEntry = this.getDailyEntry.bind(this);
	}

	state = {
		dailyEntry: {
			id: '',
			cartonId: '',
			breakfast: false,
			lunch: false,
			dinner: false,
			bath: false,
			liecesRemoval: false,
			clothes: false,
			verballySocialCenter: false,
			verballyEducation: false,
			verballyCitizensAssociations: false,
			verballyHealthInstitutions: false,
			verballyPolice: false,
			verballyOther: false,
			writtenSocialCenter: false,
			writtenEducation: false,
			writtenCitizensAssociations: false,
			writtenHealthInstitutions: false,
			writtenPolice: false,
			writtenOther: false,
			cbDecisionMakingSkills: false,
			cbProblemSolvingSkills: false,
			cbAssertiveCommunication: false,
			cbHowToSayNo: false,
			cbAwarenessOfYourself: false,
			cbRecognizingAndManagingEmotions: false,
			cbEmpathy: false,
			cbConfrontationWithStress: false,
			cbMaintainingPersonalHygiene: false,
			cbMaintainingHygieneOfClothingAndFootwear: false,
			cbHealth: false,
			cbPersonalSecurityAndCrisisManagementSituations: false,
			cbTakingCareOfPersonalFinances: false,
			cbMaintainingHygieneOfThePlaceOfResidence: false,
			cbUseOfHomeAppliances: false,
			cbMealPreparationAndServing: false,
			cbBehaviorAtTheTable: false,
			cbProcurementOfGroceries: false,
			cbHealthCareDuringPregnancy: false,
			cbPhysicalCareOfNewbornAndInfant: false,
			cbExpressingLoveForYourChild: false,
			cbChildProtection: false,
			cbStimulatingTheChild: false,
			cbIssuingCersonalDocuments: false,
			cbUseOfTheClock: false,
			cbTrafficRegulationsAndSigns: false,
			cbUtilizingCommunityResources: false,
			cbNavigatingTheSpace: false,
			cbUseOfMedia: false,
			cbActiveJobSearch: false,
			txtDecisionMakingSkills: "",
			txtProblemSolvingSkills: "",
			txtAssertiveCommunication: "",
			txtHowToSayNo: "",
			txtAwarenessOfYourself: "",
			txtRecognizingAndManagingEmotions: "",
			txtEmpathy: "",
			txtConfrontationWithStress: "",
			txtMaintainingPersonalHygiene: "",
			txtMaintainingHygieneOfClothingAndFootwear: "",
			txtHealth: "",
			txtPersonalSecurityAndCrisisManagementSituations: "",
			txtTakingCareOfPersonalFinances: "",
			txtMaintainingHygieneOfThePlaceOfResidence: "",
			txtUseOfHomeAppliances: "",
			txtMealPreparationAndServing: "",
			txtBehaviorAtTheTable: "",
			txtProcurementOfGroceries: "",
			txtHealthCareDuringPregnancy: "",
			txtPhysicalCareOfNewbornAndInfant: "",
			txtExpressingLoveForYourChild: "",
			txtChildProtection: "",
			txtStimulatingTheChild: "",
			txtIssuingCersonalDocuments: "",
			txtUseOfTheClock: "",
			txtTrafficRegulationsAndSigns: "",
			txtUtilizingCommunityResources: "",
			txtNavigatingTheSpace: "",
			txtUseOfMedia: "",
			txtActiveJobSearch: "",
			edictiveWorkshops: "",
			creativeWorkshops: "",
			homework: "",
			training: "",
			learningSchoolMaterials: "",
			interventionsForTheDevelopmentOfCognitiveFunctions: "",
			telephoneContact: "",
			personalContact: "",
			interventionAtTheSafeHouse: "",
			counseling: "",
			medication: "",
			date: undefined
		},
		newDailyEntry: true
	};

    initState() {
        this.setState({
			dailyEntry: {
				id: '',
				cartonId: '',
				breakfast: false,
				lunch: false,
				dinner: false,
				bath: false,
				liecesRemoval: false,
				clothes: false,
				verballySocialCenter: false,
				verballyEducation: false,
				verballyCitizensAssociations: false,
				verballyHealthInstitutions: false,
				verballyPolice: false,
				verballyOther: false,
				writtenSocialCenter: false,
				writtenEducation: false,
				writtenCitizensAssociations: false,
				writtenHealthInstitutions: false,
				writtenPolice: false,
				writtenOther: false,
				cbDecisionMakingSkills: false,
				cbProblemSolvingSkills: false,
				cbAssertiveCommunication: false,
				cbHowToSayNo: false,
				cbAwarenessOfYourself: false,
				cbRecognizingAndManagingEmotions: false,
				cbEmpathy: false,
				cbConfrontationWithStress: false,
				cbMaintainingPersonalHygiene: false,
				cbMaintainingHygieneOfClothingAndFootwear: false,
				cbHealth: false,
				cbPersonalSecurityAndCrisisManagementSituations: false,
				cbTakingCareOfPersonalFinances: false,
				cbMaintainingHygieneOfThePlaceOfResidence: false,
				cbUseOfHomeAppliances: false,
				cbMealPreparationAndServing: false,
				cbBehaviorAtTheTable: false,
				cbProcurementOfGroceries: false,
				cbHealthCareDuringPregnancy: false,
				cbPhysicalCareOfNewbornAndInfant: false,
				cbExpressingLoveForYourChild: false,
				cbChildProtection: false,
				cbStimulatingTheChild: false,
				cbIssuingCersonalDocuments: false,
				cbUseOfTheClock: false,
				cbTrafficRegulationsAndSigns: false,
				cbUtilizingCommunityResources: false,
				cbNavigatingTheSpace: false,
				cbUseOfMedia: false,
				cbActiveJobSearch: false,
				txtDecisionMakingSkills: "",
				txtProblemSolvingSkills: "",
				txtAssertiveCommunication: "",
				txtHowToSayNo: "",
				txtAwarenessOfYourself: "",
				txtRecognizingAndManagingEmotions: "",
				txtEmpathy: "",
				txtConfrontationWithStress: "",
				txtMaintainingPersonalHygiene: "",
				txtMaintainingHygieneOfClothingAndFootwear: "",
				txtHealth: "",
				txtPersonalSecurityAndCrisisManagementSituations: "",
				txtTakingCareOfPersonalFinances: "",
				txtMaintainingHygieneOfThePlaceOfResidence: "",
				txtUseOfHomeAppliances: "",
				txtMealPreparationAndServing: "",
				txtBehaviorAtTheTable: "",
				txtProcurementOfGroceries: "",
				txtHealthCareDuringPregnancy: "",
				txtPhysicalCareOfNewbornAndInfant: "",
				txtExpressingLoveForYourChild: "",
				txtChildProtection: "",
				txtStimulatingTheChild: "",
				txtIssuingCersonalDocuments: "",
				txtUseOfTheClock: "",
				txtTrafficRegulationsAndSigns: "",
				txtUtilizingCommunityResources: "",
				txtNavigatingTheSpace: "",
				txtUseOfMedia: "",
				txtActiveJobSearch: "",
				edictiveWorkshops: "",
				creativeWorkshops: "",
				homework: "",
				training: "",
				learningSchoolMaterials: "",
				interventionsForTheDevelopmentOfCognitiveFunctions: "",
				telephoneContact: "",
				personalContact: "",
				interventionAtTheSafeHouse: "",
				counseling: "",
				medication: "",
				date: undefined
			},
		});
	}
	
	componentWillMount() {
		DailyEntryStore.on("fetched_daily_entry", this.getDailyEntry);
		DailyEntryStore.on("reload_page", this.reloadPage);
	}

	componentDidMount() {
		if(this.props.id === undefined && this.props.cartonId) {
			DailyEntryActions.getDailyEntryForToday(this.props.cartonId);
		} else if (this.props.id && this.props.cartonId) {
			DailyEntryActions.getDailyEntryById(this.props.id, this.props.cartonId);
		}
	}

	componentWillUnmount() {
		DailyEntryStore.removeListener("fetched_daily_record", this.getDailyEntry);
		DailyEntryStore.removeListener("reload_page", this.reloadPage);
	}

	onInputChange = (event) => {
		const dailyEntry = this.state.dailyEntry;
		dailyEntry[event.target.name] = event.target.value;
		this.setState({dailyEntry});
	}

	onCheckboxChange = (event) => {
		const dailyEntry = this.state.dailyEntry;
		dailyEntry[event.currentTarget.name] = !dailyEntry[event.currentTarget.name];
		this.setState({dailyEntry});
	}

	onSave = () => {
		const data = this.state.dailyEntry;

		if (this.state.newDailyEntry) {
			delete data.id;
			if(this.props.cartonId) {
				data.cartonId = this.props.cartonId;
			}
			DailyEntryActions.addDailyEntry(data);
		} else {
			DailyEntryActions.editDailyEntry(data);
		}
		
        this.initState();
	}

	getDailyEntry() {
		const dailyEntry = DailyEntryStore.getDailyEntry();
		if(dailyEntry){
			this.setState({dailyEntry});
			this.setState({newDailyEntry: false});
		}
	}
	
	onDelete = () => {
		const data = this.state.dailyEntry;
		DailyEntryActions.deleteDailyEntry(data.id);
		this.initState();
	}

	reloadPage() {
		window.location.reload();
	}
	
	render() {
		let options;

		if(!this.state.newDailyEntry) {
			options = <span>
				<ButtonWrapper>
					<Button onClick={this.onDelete}>Obriši</Button>
				</ButtonWrapper>
			</span>
		}
		return (
			<Container>
				<InputWrapperWide>
					<LabelLarge title="Obezbeđenje obroka za korisnike:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="breakfast" name="breakfast" checked={this.state.dailyEntry.breakfast} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="breakfast">Doručak</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="lunch" name="lunch" checked={this.state.dailyEntry.lunch} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="lunch">Ručak</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="dinner" name="dinner" checked={this.state.dailyEntry.dinner} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="dinner">Večera</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Obezbeđenje uslova za održavanje lične higijene:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="bath" name="bath" checked={this.state.dailyEntry.bath} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="bath">Kupanje</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="liecesRemoval" name="liecesRemoval" checked={this.state.dailyEntry.liecesRemoval} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="liecesRemoval">Devaširanje</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Nabavka obuće i odeće i obezbeđivanje uslova za njihovo održavanje:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="clothes" name="clothes" checked={this.state.dailyEntry.clothes} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="clothes">Odeća i obuća</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Posredovanje u obezbeđivanju dostupnosti usluga u zajednici - Usmeno:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="verballySocialCenter" name="verballySocialCenter" checked={this.state.dailyEntry.verballySocialCenter} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="verballySocialCenter">Centar za socijalni rad</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="verballyEducation" name="verballyEducation" checked={this.state.dailyEntry.verballyEducation} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="verballyEducation">Obrazovanje</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="verballyCitizensAssociations" name="verballyCitizensAssociations" checked={this.state.dailyEntry.verballyCitizensAssociations} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="verballyCitizensAssociations">Udruženja građana</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="verballyHealthInstitutions" name="verballyHealthInstitutions" checked={this.state.dailyEntry.verballyHealthInstitutions} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="verballyHealthInstitutions">Zdravstvene ustanove</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="verballyPolice" name="verballyPolice" checked={this.state.dailyEntry.verballyPolice} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="verballyPolice">Policija</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="verballyOther" name="verballyOther" checked={this.state.dailyEntry.verballyOther} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="verballyOther">Ostalo</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Posredovanje u obezbeđivanju dostupnosti usluga u zajednici - Pismeno:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="writtenSocialCenter" name="writtenSocialCenter" checked={this.state.dailyEntry.writtenSocialCenter} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="writtenSocialCenter">Centar za socijalni rad</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="writtenEducation" name="writtenEducation" checked={this.state.dailyEntry.writtenEducation} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="writtenEducation">Obrazovanje</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="writtenCitizensAssociations" name="writtenCitizensAssociations" checked={this.state.dailyEntry.writtenCitizensAssociations} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="writtenCitizensAssociations">Udruženja građana</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="writtenHealthInstitutions" name="writtenHealthInstitutions" checked={this.state.dailyEntry.writtenHealthInstitutions} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="writtenHealthInstitutions">Zdravstvene ustanove</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="writtenPolice" name="writtenPolice" checked={this.state.dailyEntry.writtenPolice} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="writtenPolice">Policija</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="writtenOther" name="writtenOther" checked={this.state.dailyEntry.writtenOther} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="writtenOther">Ostalo</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Socijalne veštine:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbDecisionMakingSkills" name="cbDecisionMakingSkills" checked={this.state.dailyEntry.cbDecisionMakingSkills} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbDecisionMakingSkills">Veština donošenj odluka</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbProblemSolvingSkills" name="cbProblemSolvingSkills" checked={this.state.dailyEntry.cbProblemSolvingSkills} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbProblemSolvingSkills">Vetina rešavanja problema</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbAssertiveCommunication" name="cbAssertiveCommunication" checked={this.state.dailyEntry.cbAssertiveCommunication} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbAssertiveCommunication">Asertivna komunikacija</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbHowToSayNo" name="cbHowToSayNo" checked={this.state.dailyEntry.cbHowToSayNo} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbHowToSayNo">Kako reći "Ne"</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbAwarenessOfYourself" name="cbAwarenessOfYourself" checked={this.state.dailyEntry.cbAwarenessOfYourself} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbAwarenessOfYourself">Svest o sebi</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbRecognizingAndManagingEmotions" name="cbRecognizingAndManagingEmotions" checked={this.state.dailyEntry.cbRecognizingAndManagingEmotions} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbRecognizingAndManagingEmotions">Prepoznavanje i upravljanje emocijama</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbEmpathy" name="cbEmpathy" checked={this.state.dailyEntry.cbEmpathy} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbEmpathy">Empatija</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbConfrontationWithStress" name="cbConfrontationWithStress" checked={this.state.dailyEntry.cbConfrontationWithStress} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbConfrontationWithStress">Suopčavanje sa stresom</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Vođenje brige o sebi:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbMaintainingPersonalHygiene" name="cbMaintainingPersonalHygiene" checked={this.state.dailyEntry.cbMaintainingPersonalHygiene} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbMaintainingPersonalHygiene">Održavanje lične higijene</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbMaintainingHygieneOfClothingAndFootwear" name="cbMaintainingHygieneOfClothingAndFootwear" checked={this.state.dailyEntry.cbMaintainingHygieneOfClothingAndFootwear} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbMaintainingHygieneOfClothingAndFootwear">Održavanje higijene odeće i obuće</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbHealth" name="cbHealth" checked={this.state.dailyEntry.cbHealth} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbHealth">Zdravlje (prevencija i lečenje)</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbPersonalSecurityAndCrisisManagementSituations" name="cbPersonalSecurityAndCrisisManagementSituations" checked={this.state.dailyEntry.cbPersonalSecurityAndCrisisManagementSituations} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbPersonalSecurityAndCrisisManagementSituations">Lična bezbednost i snalaženje u kriznim situacijama</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbTakingCareOfPersonalFinances" name="cbTakingCareOfPersonalFinances" checked={this.state.dailyEntry.cbTakingCareOfPersonalFinances} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbTakingCareOfPersonalFinances">Vođenje brige o ličnim finansijama</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Vođenje brige o domaćinstvu:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbMaintainingHygieneOfThePlaceOfResidence" name="cbMaintainingHygieneOfThePlaceOfResidence" checked={this.state.dailyEntry.cbMaintainingHygieneOfThePlaceOfResidence} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbMaintainingHygieneOfThePlaceOfResidence">Održavanje higijene mesta boravka</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbUseOfHomeAppliances" name="cbUseOfHomeAppliances" checked={this.state.dailyEntry.cbUseOfHomeAppliances} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbUseOfHomeAppliances">Upotreba kućnih aparata</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbMealPreparationAndServing" name="cbMealPreparationAndServing" checked={this.state.dailyEntry.cbMealPreparationAndServing} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbMealPreparationAndServing">Priprema i serviranje obroka</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbBehaviorAtTheTable" name="cbBehaviorAtTheTable" checked={this.state.dailyEntry.cbBehaviorAtTheTable} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbBehaviorAtTheTable">Ponašanje za stolom</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbProcurementOfGroceries" name="cbProcurementOfGroceries" checked={this.state.dailyEntry.cbProcurementOfGroceries} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbProcurementOfGroceries">Nabavljanje namirnica</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Roditeljske veštine:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbHealthCareDuringPregnancy" name="cbHealthCareDuringPregnancy" checked={this.state.dailyEntry.cbHealthCareDuringPregnancy} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbHealthCareDuringPregnancy">Briga o zdravlju tokom trudnoće</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbPhysicalCareOfNewbornAndInfant" name="cbPhysicalCareOfNewbornAndInfant" checked={this.state.dailyEntry.cbPhysicalCareOfNewbornAndInfant} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbPhysicalCareOfNewbornAndInfant">Fizička nega novorođenčeta i deteta</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbExpressingLoveForYourChild" name="cbExpressingLoveForYourChild" checked={this.state.dailyEntry.cbExpressingLoveForYourChild} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbExpressingLoveForYourChild">Iskazivanje ljubavi prema detetu</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbChildProtection" name="cbChildProtection" checked={this.state.dailyEntry.cbChildProtection} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbChildProtection">Zaštita deteta</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbStimulatingTheChild" name="cbStimulatingTheChild" checked={this.state.dailyEntry.cbStimulatingTheChild} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbStimulatingTheChild">Stimulisanje deteta</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Veštine neophodne za funkcionisanje u zajednici:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbIssuingCersonalDocuments" name="cbIssuingCersonalDocuments" checked={this.state.dailyEntry.cbIssuingCersonalDocuments} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbIssuingCersonalDocuments">Ishodovanje ličnih dokumenata</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbUseOfTheClock" name="cbUseOfTheClock" checked={this.state.dailyEntry.cbUseOfTheClock} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbUseOfTheClock">Upotreba sata, orjentacija u vremenu i planiranje vremena</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbTrafficRegulationsAndSigns" name="cbTrafficRegulationsAndSigns" checked={this.state.dailyEntry.cbTrafficRegulationsAndSigns} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbTrafficRegulationsAndSigns">Saobraćajni propisi i znaci</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbUtilizingCommunityResources" name="cbUtilizingCommunityResources" checked={this.state.dailyEntry.cbUtilizingCommunityResources} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbUtilizingCommunityResources">Korišćenje resursa zajednice</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbNavigatingTheSpace" name="cbNavigatingTheSpace" checked={this.state.dailyEntry.cbNavigatingTheSpace} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbNavigatingTheSpace">Snalaženje u prostoru</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbUseOfMedia" name="cbUseOfMedia" checked={this.state.dailyEntry.cbUseOfMedia} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbUseOfMedia">Upotreba sredstava informisanja</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="cbActiveJobSearch" name="cbActiveJobSearch" checked={this.state.dailyEntry.cbActiveJobSearch} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="cbActiveJobSearch">Aktivno traženje posla</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Socijalne veštine:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Veština donošenj odluka:"/>
						<CustomInput value={this.state.dailyEntry.txtDecisionMakingSkills} inputName="txtDecisionMakingSkills" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Vetina rešavanja problema:"/>
						<CustomInput value={this.state.dailyEntry.txtProblemSolvingSkills} inputName="txtProblemSolvingSkills" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Asertivna komunikacija:"/>
						<CustomInput value={this.state.dailyEntry.txtAssertiveCommunication} inputName="txtAssertiveCommunication" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title='Kako reći "Ne":'/>
						<CustomInput value={this.state.dailyEntry.txtHowToSayNo} inputName="txtHowToSayNo" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Svest o sebi:"/>
						<CustomInput value={this.state.dailyEntry.txtAwarenessOfYourself} inputName="txtAwarenessOfYourself" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Prepoznavanje i upravljanje emocijama:"/>
						<CustomInput value={this.state.dailyEntry.txtRecognizingAndManagingEmotions} inputName="txtRecognizingAndManagingEmotions" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Empatija:"/>
						<CustomInput value={this.state.dailyEntry.txtEmpathy} inputName="txtEmpathy" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Suopčavanje sa stresom:"/>
						<CustomInput value={this.state.dailyEntry.txtConfrontationWithStress} inputName="txtConfrontationWithStress" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Vođenje brige o sebi:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Održavanje lične higijene:"/>
						<CustomInput value={this.state.dailyEntry.txtMaintainingPersonalHygiene} inputName="txtMaintainingPersonalHygiene" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Održavanje higijene odeće i obuće:"/>
						<CustomInput value={this.state.dailyEntry.txtMaintainingHygieneOfClothingAndFootwear} inputName="txtMaintainingHygieneOfClothingAndFootwear" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Zdravlje (prevencija i lečenje):"/>
						<CustomInput value={this.state.dailyEntry.txtHealth} inputName="txtHealth" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Lična bezbednost i snalaženje u kriznim situacijama:"/>
						<CustomInput value={this.state.dailyEntry.txtPersonalSecurityAndCrisisManagementSituations} inputName="txtPersonalSecurityAndCrisisManagementSituations" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Vođenje brige o ličnim finansijama:"/>
						<CustomInput value={this.state.dailyEntry.txtTakingCareOfPersonalFinances} inputName="txtTakingCareOfPersonalFinances" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Vođenje brige o domaćinstvu:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Održavanje higijene mesta boravka:"/>
						<CustomInput value={this.state.dailyEntry.txtMaintainingHygieneOfThePlaceOfResidence} inputName="txtMaintainingHygieneOfThePlaceOfResidence" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Upotreba kućnih aparata:"/>
						<CustomInput value={this.state.dailyEntry.txtUseOfHomeAppliances} inputName="txtUseOfHomeAppliances" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Priprema i serviranje obroka:"/>
						<CustomInput value={this.state.dailyEntry.txtMealPreparationAndServing} inputName="txtMealPreparationAndServing" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Ponašanje za stolom:"/>
						<CustomInput value={this.state.dailyEntry.txtBehaviorAtTheTable} inputName="txtBehaviorAtTheTable" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Nabavljanje namirnica:"/>
						<CustomInput value={this.state.dailyEntry.txtProcurementOfGroceries} inputName="txtProcurementOfGroceries" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Roditeljske veštine:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Briga o zdravlju tokom trudnoće:"/>
						<CustomInput value={this.state.dailyEntry.txtHealthCareDuringPregnancy} inputName="txtHealthCareDuringPregnancy" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Fizička nega novorođenčeta i deteta:"/>
						<CustomInput value={this.state.dailyEntry.txtPhysicalCareOfNewbornAndInfant} inputName="txtPhysicalCareOfNewbornAndInfant" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Iskazivanje ljubavi prema detetu:"/>
						<CustomInput value={this.state.dailyEntry.txtExpressingLoveForYourChild} inputName="txtExpressingLoveForYourChild" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Zaštita deteta:"/>
						<CustomInput value={this.state.dailyEntry.txtChildProtection} inputName="txtChildProtection" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Stimulisanje deteta:"/>
						<CustomInput value={this.state.dailyEntry.txtStimulatingTheChild} inputName="txtStimulatingTheChild" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Veštine neophodne za funkcionisanje u zajednici:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Ishodovanje ličnih dokumenata:"/>
						<CustomInput value={this.state.dailyEntry.txtIssuingCersonalDocuments} inputName="txtIssuingCersonalDocuments" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Upotreba sata, orjentacija u vremenu i planiranje vremena:"/>
						<CustomInput value={this.state.dailyEntry.txtUseOfTheClock} inputName="txtUseOfTheClock" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Saobraćajni propisi i znaci:"/>
						<CustomInput value={this.state.dailyEntry.txtTrafficRegulationsAndSigns} inputName="txtTrafficRegulationsAndSigns" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Korišćenje resursa zajednice:"/>
						<CustomInput value={this.state.dailyEntry.txtUtilizingCommunityResources} inputName="txtUtilizingCommunityResources" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Snalaženje u prostoru:"/>
						<CustomInput value={this.state.dailyEntry.txtNavigatingTheSpace} inputName="txtNavigatingTheSpace" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Upotreba sredstava informisanja:"/>
						<CustomInput value={this.state.dailyEntry.txtUseOfMedia} inputName="txtUseOfMedia" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Aktivno traženje posla:"/>
						<CustomInput value={this.state.dailyEntry.txtActiveJobSearch} inputName="txtActiveJobSearch" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Radionice:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Edikativne radionice:"/>
						<CustomInput value={this.state.dailyEntry.edictiveWorkshops} inputName="edictiveWorkshops" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Kreativne radionice:"/>
						<CustomInput value={this.state.dailyEntry.creativeWorkshops} inputName="creativeWorkshops" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Pružanje podrške u obavljanju školski obaveza:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Domaći zadaci:"/>
						<CustomInput value={this.state.dailyEntry.homework} inputName="homework" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Vežbanje:"/>
						<CustomInput value={this.state.dailyEntry.training} inputName="training" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Učenje školskog gradiva:"/>
						<CustomInput value={this.state.dailyEntry.learningSchoolMaterials} inputName="learningSchoolMaterials" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Specifične intervencije za razvoj kognitivnih funkcija:"/>
						<CustomInput value={this.state.dailyEntry.interventionsForTheDevelopmentOfCognitiveFunctions} inputName="interventionsForTheDevelopmentOfCognitiveFunctions" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Kontakti sa roditeljima:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Telefonski kontakt:"/>
						<CustomInput value={this.state.dailyEntry.telephoneContact} inputName="telephoneContact" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Lični kontakt:"/>
						<CustomInput value={this.state.dailyEntry.personalContact} inputName="personalContact" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<LabelLarge title="Pružanje medicinskih intervencija i savetovanja:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Intervencija u svratištu:"/>
						<CustomInput value={this.state.dailyEntry.interventionAtTheSafeHouse} inputName="interventionAtTheSafeHouse" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Savetovanje:"/>
						<CustomInput value={this.state.dailyEntry.counseling} inputName="counseling" change={this.onInputChange}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Lekovi:"/>
						<CustomInput value={this.state.dailyEntry.medication} inputName="medication" change={this.onInputChange}/>
					</InputWrapper>
				</Div>
					<Button onClick={this.onSave}>Sačuvaj</Button>
					{options}
			</Container>
		);
	}
}
export default DailyRecord;