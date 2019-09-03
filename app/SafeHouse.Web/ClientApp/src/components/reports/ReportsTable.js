import React from 'react';
import styled from 'styled-components';
import {withRouter} from 'react-router-dom';

import Colours from '../common/colours';
import { FontWeight, Headings, Body } from '../common/typography';

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
	&:hover {
		color: #0580c6;
	}
`;
const TR = styled.tr`
	border-bottom: 1px solid #ddd;
`;
const reportsTable = ( props ) => (
	<div>
		<Table width="100%" border="0">
			<thead>
				<TR>
					<TH>Broj korisnika</TH>
					<TH>Broj poseta</TH>
					<TH>Broj obroka</TH>
					<TH>Održavanje lične higijene</TH>
					<TH>Odeća i obuća</TH>
					<TH>Posredovanje</TH>
					<TH>Edukacija</TH>
					<TH>Podrška oko škole</TH>
					<TH>Kontakt sa roditeljima</TH>
					<TH>Medicinske intervencije</TH>
				</TR>
			</thead>
			<tbody>
				<TR>
					<TD>{props.reports.users}</TD>
					<TD>{props.reports.visits}</TD>
					<TD>{props.reports.meals}</TD>
					<TD>{props.reports.hygiene}</TD>
					<TD>{props.reports.clothes}</TD>
					<TD>{props.reports.intervention}</TD>
					<TD>{props.reports.education}</TD>
					<TD>{props.reports.school}</TD>
					<TD>{props.reports.parents}</TD>
					<TD>{props.reports.medicalhelp}</TD>
				</TR>
			</tbody>
		</Table>
	</div>
);

export default withRouter(reportsTable);