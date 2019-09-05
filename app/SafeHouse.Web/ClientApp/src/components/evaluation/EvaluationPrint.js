import React, { Component } from 'react';
import styled from 'styled-components';

const Container = styled.div`
	margin: 0 auto;
	max-width: 1280px;
	padding: 0 20px;
	width: 100%;
	font-family: Arial, Helvetica, sans-serif;
	box-sizing: border-box;
	padding-bottom: 30px;
`;
const H1 = styled.h1`
	text-align: center;
	font-size: 22px;
	text-transform: uppercase;
`;
const Table = styled.table`
	margin-top: 50px;
	border: 1px solid #dee2e6;
	width: 100%;
	max-width: 100%;
	border-collapse: collapse;
	border-spacing: 0;
`;
const TH = styled.th`
	color: #495057;
    background-color: #e9ecef;
	text-align: center;
    border: 1px solid #dee2e6;
	border-bottom-width: 2px;
	padding: .75rem;
	font-size: 14px;
	span {
		font-weight: 400;
		font-style: italic;
	}
`;
const TD = styled.td`
	border: 1px solid #dee2e6;
	padding: .75rem;
	font-size: 14px;
	color: #495057;
`;
class EvaluationPrint extends Component {
	state = {
		carton: {
			firstName: '',
			lastName: '',
			nickname: '',
			dateOfBirth: undefined,
			addressStreetName: '',
			addressStreetNumber: '',
			gender: 0
		},
		firstEvaluation: {
			id: '',
			cartonId: '',
			otherChildrenName: '',
			otherMembersName: '',
			guardiansName: 'A',
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
			suitabilityId: '',
			sleepOnStreet: false,
			dumpsterDiving: false,
			recycling: false,
			begging: false,
			sellsOnStreet: false,
			prostituting: false,
			extremelyPoor: false,
			helpingFamilyOnStreet: false,
			otherSuitability: '',
			explanation: ''
		},
		evaluation: {
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
	render() {
		return (
			<Container>
				<H1>Procena</H1>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>1. Osnovni podaci</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="30%">Ime, prezime i nadimak korisnika:</TD>
							<TD width="70%">{this.state.carton.firstName} {this.state.carton.lastName} {this.state.carton.nickname}</TD>
						</tr>
						<tr>
							<TD>Pol: <b>{this.state.carton.gender === 0 ? 'Muški' : 'Ženski'}</b></TD>
							<TD>Datum rođenja: {this.state.carton.dateOfBirth}</TD>
						</tr>
						<tr>
							<TD>Članovi domaćinstva:</TD>
							<TD>{this.state.firstEvaluation.otherMembersName}</TD>
						</tr>
						<tr>
							<TD>Adresa stanovanja:</TD>
							<TD>{this.state.carton.addressStreetName} {this.state.carton.addressStreetNumber}</TD>
						</tr>
						<tr>
							<TD>Škola i razred:</TD>
							<TD>{this.state.firstEvaluation.schoolAndGrade}</TD>
						</tr>
						<tr>
							<TD>Voditelj slučaja:</TD>
							<TD>{this.state.firstEvaluation.caseLeaderName}</TD>
						</tr>
						<tr>
							<TD>Zaduženi stručni radnik/saradnik u usluzi:</TD>
							<TD>{this.state.evaluation.dedicatedWorker}</TD>
						</tr>
						<tr>
							<TD>Imena, funkcija i kontakti drugih osoba uključenih u procenu:</TD>
							<TD>{this.state.evaluation.otherMembers}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>2. Procena potreba korisnika</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="30%">Osnovne fizičke potrebe:</TD>
							<TD width="70%">{this.state.evaluation.basicPhysicalNeeds}</TD>
						</tr>
						<tr>
							<TD>Psihološke i socijalne potrebe:</TD>
							<TD>{this.state.evaluation.psyhoSocialNeeds}</TD>
						</tr>
						<tr>
							<TD>Edukativne potrebe:</TD>
							<TD>{this.state.evaluation.educationalNeeds}</TD>
						</tr>
						<tr>
							<TD>Druge potrebe:</TD>
							<TD>{this.state.evaluation.otherNeeds}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH>3. Dominantne emocije</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD>{this.state.evaluation.dominantEmotions}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH>4. Dominantna ponašanja</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD>{this.state.evaluation.dominantBehaviors}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>5. Procena snaga korisnika</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="30%">Snage iz neposrednog okruženja:</TD>
							<TD width="70%">{this.state.evaluation.surroundStrenghts}</TD>
						</tr>
						<tr>
							<TD>Snage iz porodičnih odnosa:</TD>
							<TD>{this.state.evaluation.familyStrenghts}</TD>
						</tr>
						<tr>
							<TD>Snage iz ličnosti korisnika:</TD>
							<TD>{this.state.evaluation.personalStrenghts}</TD>
						</tr>
						<tr>
							<TD>Druge snage:</TD>
							<TD>{this.state.evaluation.otherStrenghts}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>6. Procena rizika kojima je izložen korisnik</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="30%">Rizici vezani za sredinske faktore:</TD>
							<TD width="70%">{this.state.evaluation.surroundRisks}</TD>
						</tr>
						<tr>
							<TD>Rizici vezani za porodične odnose:</TD>
							<TD>{this.state.evaluation.familyRisks}</TD>
						</tr>
						<tr>
							<TD>Rizici vezani za ponašanja korisnika:</TD>
							<TD>{this.state.evaluation.behaviorRisks}</TD>
						</tr>
						<tr>
							<TD>Drugi rizici:</TD>
							<TD>{this.state.evaluation.otherRisks}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH>7. Procena sposobnosti korisnika</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD>{this.state.evaluation.capabilities}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>8. Kulturološke i druge posebnosti korisnika</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD colSpan={2}>{this.state.evaluation.culturalSpecifics}</TD>
						</tr>
						<tr>
							<TD colSpan={2}>Preporučeni stepen podrške: {this.state.evaluation.advicedLevelOfSupport}</TD>
						</tr>
						<tr>
							<TD width="50%">Procenu uradio: {this.state.evaluation.evaluationDoneBy}</TD>
							<TD width="50%">Datum: {this.state.evaluation.date}</TD>
						</tr>
					</tbody>
				</Table>
			</Container>
		);
	}
}
export default EvaluationPrint;