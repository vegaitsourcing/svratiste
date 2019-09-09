import React, { Component } from 'react';
import styled from 'styled-components';
import Select from 'react-select';

import Colours from '../components/common/colours';
import { FontWeight } from '../components/common/typography';
import {input as CustomInput, label as CustomLabel} from './common/Inputs/Inputs';

import * as DailyEntryActions from '../actions/DailyEntryActions';

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
		id: '',
		cartonId: '',
		firstName: '',
		lastName: '',
		gender: '',
		stay: false,
		breakfast: false,
		lunch: false,
		bath: false,
		liecesRemoval: false,
		clothes: 0,
		mediationWriting: 0,
		mediationWritingDescription: '',
		mediationSpeaking: 0,
		mediationSpeakingDescription: '',
		lifeSkills: 0,
		schoolAcivities: 0,
		psihosocialSupport: false,
		parentsContact: 0,
		medicalInterventions: 0,
		arrival: '',
		educationWorkshop: 0,
		creativeWorkshop: 0,
		startTime: '',
		endTIme: '',
		// enumerations
		mediationWritingsEnum: [
			{ value: 1, label: 'Centar za socijalni rad' },
			{ value: 2, label: 'Obrazovanje' },
			{ value: 3, label: 'Udruženja građana'},
			{ value: 4, label: 'Zdravstvene ustanove'},
			{ value: 5, label: 'Policija'},
			{ value: 6, label: 'Ostalo'},
		],
		mediationSpeakingsEnum: [
			{ value: 1, label: 'Centar za socijalni rad' },
			{ value: 2, label: 'Obrazovanje' },
			{ value: 3, label: 'Udruženja građana' },
			{ value: 4, label: 'Zdravstvene ustanove' },
			{ value: 5, label: 'Policija' },
			{ value: 6, label: 'Ostalo' }
		],
		lifeSkillsEnum: [
			{ value: 1, label: 'Veština donošenj odluka'},
			{ value: 2, label: 'Vetina rešavanja problema'},
			{ value: 3, label: 'Asertivna komunikacija'},
			{ value: 4, label: 'Kako reći "Ne"'},
			{ value: 5, label: 'Svest o sebi'},
			{ value: 6, label: 'Prepoznavanje i upravljanje emocijama'},
			{ value: 7, label: 'Empatija'},
			{ value: 8, label: 'Suopčavanje sa stresom'},
			{ value: 9, label: 'Održavanje lične higijene'},
			{ value: 10, label: 'Održavanje higijene odeće i obuće'},
			{ value: 11, label: 'Zdravlje (prevencija i lečenje)'},
			{ value: 12, label: 'Lična bezbednost i snalaženje u kriznim situacijama'},
			{ value: 13, label: 'Vođenje brige o ličnim finansijama'},
			{ value: 14, label: 'Održavanje higijene mesta boravka'},
			{ value: 15, label: 'Upotreba kućnih aparata'},
			{ value: 16, label: 'Priprema i serviranje obroka'},
			{ value: 17, label: 'Ponašanje za stolom'},
			{ value: 18, label: 'Nabavljanje namirnica'},
			{ value: 19, label: 'Briga o zdravlju tokom trudnoće'},
			{ value: 20, label: 'Fizička nega novorođenčeta i deteta'},
			{ value: 21, label: 'Iskazivanje ljubavi prema detetu'},
			{ value: 22, label: 'Zaštita deteta'},
			{ value: 23, label: 'Stimulisanje deteta'},
			{ value: 24, label: 'Ishodovanje ličnih dokumenata'},
			{ value: 25, label: 'Upotreba sata, orjentacija u vremenu i planiranje vremena'},
			{ value: 26, label: 'Saobraćajni propisi i znaci'},
			{ value: 27, label: 'Korišćenje resursa zajednice'},
			{ value: 28, label: 'Snalaženje u prostoru'},
			{ value: 29, label: 'Upotreba sredstava informisanja'},
			{ value: 30, label: 'Aktivno traženje posla'},
			{ value: 31, label: 'Ostalo'},
		],
		schoolActivitiesEnum: [
			{ value: 1, label: 'Domaći zadaci'},
			{ value: 2, label: 'Vežbanje'},
			{ value: 3, label: 'Učenje školskog gradiva'},
			{ value: 4, label: 'Specifične intervencije za razvoj kognitivnih funkcija'},
		],
		parentsContactEnum: [
			{ value: 1, label: 'Telefonski kontakt'},
			{ value: 2, label: 'Lični kontakt'},
		],
		medicalInterventionsEnum: [
			{ value: 1, label: 'Intervencija u svratištu'},
			{ value: 2, label: 'Savetovanje'},
			{ value: 3, label: 'Lekovi'}
		]
	};

    initState() {
        this.setState({
			id: '',
			cartonId: '',
			firstName: '',
			lastName: '',
			gender: '',
			stay: false,
			breakfast: false,
			lunch: false,
			bath: false,
			liecesRemoval: false,
			clothes: 0,
			mediationWriting: 0,
			mediationWritingDescription: '',
			mediationSpeaking: 0,
			mediationSpeakingDescription: '',
			lifeSkills: 0,
			schoolAcivities: 0,
			psihosocialSupport: false,
			parentsContact: 0,
			medicalInterventions: 0,
			arrival: '',
			educationWorkshop: 0,
			creativeWorkshop: 0,
			startTime: '',
			endTIme: '',
		});
	}

	componentDidMount() {
		if(this.props.dailyEntry === undefined) {
			this.setState({newDailyEntry: true});
		} else {
			this.setState({dailyEntry: this.props.dailyEntry});
		}
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
			data.cartonId = this.props.cartonId;
			DailyEntryActions.addDailyEntry(data);
		} else {
			DailyEntryActions.editDailyEntry(data);
		}
		
        this.initState();
	}
	
	onDelete = () => {
		DailyEntryActions.deleteDailyEntry(this.state.dailyEntry.cartonId);
		this.initState();
	}
	
	multiSelectChange(value, state) {
		let values = value.reduce(function (prev, cur) {
			return prev + cur.value;
		}, 0);
		this.setState({[state]: values})
	}
	
	render() {
		return (
			<Container>
				<InputWrapperWide>
					<LabelLarge title="Obezbeđenje boravka:"/>
					<InputHidden type="checkbox" id="stay" name="stay" checked={this.state.stay} onChange={this.onCheckboxChange}/>
					<LabelCheckbox htmlFor="stay">Boravak</LabelCheckbox>
					<Hr />
				</InputWrapperWide>
				<InputWrapperWide>
					<LabelLarge title="Obezbeđenje obroka za korisnike:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="breakfast" name="breakfast" checked={this.state.breakfast} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="breakfast">Doručak</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="lunch" name="lunch" checked={this.state.lunch} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="lunch">Ručak</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="diner" name="diner" checked={this.state.diner} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="diner">Večera</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Obezbeđenje uslova za održavanje lične higijene:"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="bath" name="bath" checked={this.state.bath} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="bath">Kupanje</LabelCheckbox>
					</InputWrapper>
					<InputWrapper>
						<InputHidden type="checkbox" id="liecesRemoval" name="liecesRemoval" checked={this.state.liecesRemoval} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="liecesRemoval">Devaširanje</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Nabavka obuće i odeće i obezbeđivanje uslova za njihovo održavanje:"/>
					<InputHidden type="checkbox" id="clothes" name="clothes" checked={this.state.clothes} onChange={this.onCheckboxChange}/>
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
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Edukacija i podrška korisnicima u sticanju osnovnih životnih veština"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<CustomLabel title="Grupno učenje životnih veština" />
						<Select
							options={this.state.lifeSkillsEnum}
							onChange={(value) => this.multiSelectChange(value, "lifeSkills")}
							isMulti />
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Individualno učenje životnih veština" />
						<Select
							options={this.state.lifeSkillsEnum}
							onChange={(value) => this.multiSelectChange(value, "lifeSkills")}
							isMulti />
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Radionice" />
						<CustomLabel title="Edukativna radionica" />
						<CustomInput value={this.state.educationWorkshop} inputName="educationWorkshop" change={this.onInputChange} inputType={"number"}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="&nbsp;" />
						<CustomLabel title="Kreativna radionica" />
						<CustomInput value={this.state.creativeWorkshop} inputName="creativeWorkshop" change={this.onInputChange} inputType={"number"}/>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Pružanje psihosocijalne podrške"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<InputHidden type="checkbox" id="psihosocialSupport" name="psihosocialSupport" checked={this.state.psihosocialSupport} onChange={this.onCheckboxChange}/>
						<LabelCheckbox htmlFor="psihosocialSupport">Pružanje psihosocijalne podrške</LabelCheckbox>
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Pružanje podrške u obavljanju školski obaveza"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<Select
							options={this.state.schoolActivitiesEnum}
							onChange={(value) => this.multiSelectChange(value, "schoolActivities")}
							isMulti />
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Kontakti sa roditeljima"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<Select
							options={this.state.parentsContactEnum}
							onChange={(value) => this.multiSelectChange(value, "parentsContact")}
							isMulti />
					</InputWrapper>
				</Div>
				<InputWrapperWide>
					<Hr />
					<LabelLarge title="Pružanje medicinskih intervencija i savetovanja"/>
				</InputWrapperWide>
				<Div>
					<InputWrapper>
						<Select
							options={this.state.medicalInterventionsEnum}
							onChange={(value) => this.multiSelectChange(value, "medicalInterventions")}
							isMulti />
					</InputWrapper>
				</Div>
				<Div>
					<InputWrapper>
						<CustomLabel title="Vreme dolaska" />
						<CustomInput value={this.state.startTime} inputName="startTime" change={this.onInputChange} inputType={"time"}/>
					</InputWrapper>
					<InputWrapper>
						<CustomLabel title="Vreme odlaska" />
						<CustomInput value={this.state.endTIme} inputName="endTIme" change={this.onInputChange} inputType={"time"}/>
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