import React, { Component } from 'react';
import styled from 'styled-components';

import Layout from '../hoc/Layout';
import Report from '../components/reports/ReportsTable';
import Constants from '../components/common/constants';
import Colours from '../components/common/colours';
import {FontWeight, Body, Headings} from '../components/common/typography';
import {input as CustomInput, label as CustomLabel} from '../components/common/Inputs/Inputs';

const FilterWrapper = styled.div`
	display: flex;
	flex-wrap: nowrap;
	margin-bottom: 20px;
	& > div {
		width: calc(100%/3);
		padding: 0 10px;
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
	width: calc(100% - 20px);
	margin-left: 10px;
	margin-bottom: 20px;
`;
const TH = styled.th`
	font-size: 16px;
	font-weight: ${FontWeight.light};
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
class Reports extends Component {
	constructor(props) {
		super(props);
		this.state = {
			startDate: '',
			endDate: '',
			name: '',
			users: [{id: 1, name: 'Ana', lastname: 'Ivanpovic'}, {id: 2, name: 'Ana', lastname: 'Ivanpovic'}]
		};
	}
	onInputChange = (event) => {
		const newState = {
			...this.state,
			[event.target.name] : event.target.value
		}
		console.log(newState);
		this.setState(newState);
	}
	showReports = () => {
		//get reports for selected person
	}
	render() {
		return (
			<Layout name="Izveštaji">
				<FilterWrapper>
					<div>
						<CustomLabel title="Početni datum"/>
						<CustomInput inputType="date" change={this.onInputChange} inputName="startDate" value={this.state.startDate}/>
					</div>
					<div>
						<CustomLabel title="Krajnji datum"/>
						<CustomInput inputType="date" change={this.onInputChange} inputName="endDate" value={this.state.endDate}/>
					</div>
					<div>
						<CustomLabel title="Ime"/>
						<CustomInput value={this.state.name} inputName="name" change={this.onInputChange}/>
					</div>
				</FilterWrapper>
				{this.state.users.length > 0 && <Table width="100%" border="0">
					<thead>
						<TR>
							<TH>ID</TH>
							<TH>Ime</TH>
							<TH>Prezime</TH>
						</TR>
					</thead>
					<tbody>
						{this.state.users.map((item, index) => (
							<TR key={index} onClick={this.showReports}>
								<TD>{item.id}</TD>
								<TD>{item.name}</TD>
								<TD>{item.lastname}</TD>
							</TR>
						))}
					</tbody>
				</Table>}
				<Report reports={Constants.reports} />
			</Layout>
		);
	}
}

export default Reports;