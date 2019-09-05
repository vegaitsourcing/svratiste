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
class FirstEvaluationPrint extends Component {
	state = {
		carton: {
			firstName: '',
			lastName: '',
			nickname: '',
			dateOfBirth: undefined,
			addressStreetName: '',
			addressStreetNumber: '',
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
		}
	}
	render() {
		return (
			<Container>
				<H1>Prijemna procena</H1>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>1. Informacije o korisniku, njegovom identitetu i porodici</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="30%">Ime, prezime i nadimak korisnika:</TD>
							<TD width="70%">{this.state.carton.firstName} {this.state.carton.lastName} {this.state.carton.nickname}</TD>
						</tr>
						<tr>
							<TD>Imena roditelja/staratelja:</TD>
							<TD>{this.state.firstEvaluation.guardiansName}</TD>
						</tr>
						<tr>
							<TD>Imena i srodstvo drugih članova domaćinstva:</TD>
							<TD>{this.state.firstEvaluation.otherMembersName}</TD>
						</tr>
						<tr>
							<TD>Adresa stanovanja:</TD>
							<TD>{this.state.carton.addressStreetName} {this.state.carton.addressStreetNumber}</TD>
						</tr>
						<tr>
							<TD>Živi u:</TD>
							<TD>{this.state.firstEvaluation.livingSpace}</TD>
						</tr>
						<tr>
							<TD>Škola i razred:</TD>
							<TD>{this.state.firstEvaluation.schoolAndGrade}</TD>
						</tr>
						<tr>
							<TD>Maternji i drugi jezici:</TD>
							<TD>{this.state.firstEvaluation.languages}</TD>
						</tr>
						<tr>
							<TD>Zdravstvena knjižica: {this.state.firstEvaluation.healthCard ? 'Da' : 'Ne'}</TD>
							<TD>Datum rođenja: {this.state.carton.dateOfBirth}</TD>
						</tr>
						<tr>
							<TD>Voditelj slučaja:</TD>
							<TD>{this.state.firstEvaluation.caseLeaderName}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>2. Procena podobnosti korisnika</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="50%">Spava na ulici: <b>{this.state.firstEvaluation.sleepOnStreet ? 'Da' : 'Ne'}</b></TD>
							<TD width="50%">Hranu pronalazi u kontejnerima: <b>{this.state.firstEvaluation.dumpsterDiving  ? 'Da' : 'Ne'}</b></TD>
						</tr>
						<tr>
							<TD>Sakuplja sekundarne sirovine: <b>{this.state.firstEvaluation.recycling ? 'Da' : 'Ne'}</b></TD>
							<TD>Prosi: <b>{this.state.firstEvaluation.begging ? 'Da' : 'Ne'}</b></TD>
						</tr>
						<tr>
							<TD>Prodaje seksualne usluge: <b>{this.state.firstEvaluation.prostituting ? 'Da' : 'Ne'}</b></TD>
							<TD>Pomaže porodici u radu na ulici: <b>{this.state.firstEvaluation.helpingFamilyOnStreet ? 'Da' : 'Ne'}</b></TD>
						</tr>
						<tr>
							<TD>Prodaje na pijaci/ulici: <b>{this.state.firstEvaluation.sellsOnStreet ? 'Da' : 'Ne'}</b></TD>
							<TD>Ekstremno siromašna porodica, postoji rizik za dete: <b>{this.state.firstEvaluation.extremelyPoor ? 'Da' : 'Ne'}</b></TD>
						</tr>
						<tr>
							<TD colSpan={2}>Drugo: {this.state.firstEvaluation.otherSuitability}</TD>
						</tr>
						<tr>
							<TD colSpan={2}>Obrazloženje nepodobnosti korisnika: {this.state.firstEvaluation.explanation}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>3. Procena kapaciteta pružaoca usluge, prioriteta za prijem i upućivanja na druge usluge ili službe u zajednici</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD colSpan={2}>Postoje kapaciteti usluge da zadovolji potrebe korisnika: <b>{this.state.firstEvaluation.capability ? 'Da' : 'Ne'}</b></TD>
						</tr>
						<tr>
							<TD width="30%">Na listi čekanja: <b>{this.state.firstEvaluation.onTheWaitingList ? 'Da' : 'Ne'}</b></TD>
							<TD width="70%"> Datum početka korišćenja usluge: {this.state.firstEvaluation.serviceStart}</TD>
						</tr>
						<tr>
							<TD>Upućen na:</TD>
							<TD>{this.state.firstEvaluation.directedToName}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>4. Procena sposobnosti i prioritetnih potreba korisnika</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="30%">Sposobnost samostalnog kretanja:</TD>
							<TD width="70%">{this.state.firstEvaluation.individualMovementAbility}</TD>
						</tr>
						<tr>
							<TD>Sposobnost verbalne komunikacije:</TD>
							<TD>{this.state.firstEvaluation.verbalComunicationAbility}</TD>
						</tr>
						<tr>
							<TD>Kratak opis fizičkog izgleda:</TD>
							<TD>{this.state.firstEvaluation.physicalDescription}</TD>
						</tr>
						<tr>
							<TD>Dijagnostifikovana bolest, alergija:</TD>
							<TD>{this.state.firstEvaluation.diagnosedDisease}</TD>
						</tr>
						<tr>
							<TD>Prioritetne potrebe korisnika:</TD>
							<TD>{this.state.firstEvaluation.priorityNeeds}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>5. Procena stava korisnika i drugih znacajnih osoba i njegova očekivanja od usluge <span>(na kraju ovog dela dati informacije o realnim očekivanjima)</span></TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD width="30%">Stav:</TD>
							<TD width="70%">{this.state.firstEvaluation.attitude}</TD>
						</tr>
						<tr>
							<TD>Očekivanja:</TD>
							<TD>{this.state.firstEvaluation.expectations}</TD>
						</tr>
						<tr>
							<TD>Upućen od strane:</TD>
							<TD>{this.state.firstEvaluation.directedFromName}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>6. Ostalo <span>(broj telefona roditelja, druge bitne informacije o porodici, itd.)</span></TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<TD colSpan={2}>{this.state.firstEvaluation.other}</TD>
						</tr>
						<tr>
							<TD width="50%">Prijem započet: {this.state.firstEvaluation.startedEvaluation}</TD>
							<TD width="50%">Prijem Završen: {this.state.firstEvaluation.finishedEvaluation}</TD>
						</tr>
						<tr>
							<TD>Prijem uradio: {this.state.firstEvaluation.evaluationDoneBy}</TD>
							<TD>Pregledao: {this.state.firstEvaluation.evaluationRevisedBy}</TD>
						</tr>
					</tbody>
				</Table>
			</Container>
		);
	}
}
export default FirstEvaluationPrint;