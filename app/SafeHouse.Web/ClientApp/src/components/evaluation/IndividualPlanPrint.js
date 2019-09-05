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
const Centered = styled(TD)`
	text-align: center;
`;
class IndividualPlanPrint extends Component {
	state = {
		carton: {
			firstName: '',
			lastName: '',
			nickname: '',
			dateOfBirth: undefined,
			gender: 0
		},
		evaluation: {
			dedicatedWorker: ''
		},
		individualPlan: {
			id: '',
			cartonId: '',
			date: '',
			due: '',
			goalsAndResults: [
				{
					goals: '',
					results: ''
				}
			],
			activitiesAndDue: [
				{
					activities: '',
					leadPerson: '',
					due: ''
				}
			],
			involvedPersons: [
				{
					name: '',
					jobTitle: ''
				}
			]
		}
	}
	render() {
		return (
			<Container>
				<H1>Individualni plan usluga</H1>
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
							<TD>Zaduženi stručni radnik/saradnik u usluzi:</TD>
							<TD>{this.state.evaluation.dedicatedWorker}</TD>
						</tr>
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={2}>2. Ciljevi i ishodi pružanja usluge</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<Centered width="50%"><b>Ciljevi</b></Centered>
							<Centered width="50%"><b>Ishodi</b></Centered>
						</tr>
						{this.state.individualPlan.goalsAndResults.map((item, index) => (
							<tr key={index}>
								<Centered>{item.goals}</Centered>
								<Centered>{item.results}</Centered>
							</tr>
						)) }
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={3}>3. Aktivnosti, odgovorna osoba i vremenski okvir</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<Centered width="33%"><b>Aktivnosti</b></Centered>
							<Centered width="34%"><b>Odgovorna osoba</b></Centered>
							<Centered width="33%"><b>Rok</b></Centered>
						</tr>
						{this.state.individualPlan.involvedPersons.map((item, index) => (
							<tr key={index}>
								<Centered>{item.name}</Centered>
								<Centered>{item.jobTitle}</Centered>
								<Centered></Centered>
							</tr>
						)) }
					</tbody>
				</Table>
				<Table>
					<thead>
						<tr>
							<TH colSpan={3}>4. Osobe koje su učestvovale u izradi individualnog plana usluge</TH>
						</tr>
					</thead>
					<tbody>
						<tr>
							<Centered width="33%"><b>Ime i prezime</b></Centered>
							<Centered width="34%"><b>Funkcija</b></Centered>
							<Centered width="33%"><b>Potpis</b></Centered>
						</tr>
						{this.state.individualPlan.activitiesAndDue.map((item, index) => (
							<tr key={index}>
								<Centered>{item.activities}</Centered>
								<Centered>{item.leadPerson}</Centered>
								<Centered>{item.due}</Centered>
							</tr>
						)) }
					</tbody>
				</Table>
				
				<Table>
					<tbody>
						<tr>
							<TD width="50%">Datum: {this.state.individualPlan.date}</TD>
							<TD width="50%">Rok za ponovni pregled: {this.state.individualPlan.due}</TD>
						</tr>
					</tbody>
				</Table>
			</Container>
		);
	}
}
export default IndividualPlanPrint;