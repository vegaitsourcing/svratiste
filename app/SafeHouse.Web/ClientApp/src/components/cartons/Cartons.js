import React from 'react';
import styled from 'styled-components';
import {withRouter} from 'react-router-dom';
import Icon from '@material-ui/core/Icon';

import Pagination from '../common/Pagination/Pagination';
import { FontWeight, Headings } from '../common/typography';

const Table = styled.table`
	border-spacing: 0;
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
const TableTitle = styled.p`
	color: #0580c6;
	font-size: 14px;
	font-weight: ${FontWeight.light};
	font-family: ${Headings.font};
	text-transform: uppercase;
	display: flex;
	align-items: center;
	padding-bottom: 10px;
	span {
		margin-right: 10px;
		margin-left: 22px;
	}
`;
const PaginationWrapper = styled.div`
	display: flex;
	justify-content: center;
`;
const cartons = ( props ) => (
	<div>
		{props.title && <TableTitle>
			<Icon>{props.icon}</Icon>
			{props.title}
		</TableTitle>}
		<Table width="100%" border="0">
			<thead>
				<TR>
					<TH>Ime</TH>
					<TH>Prezime</TH>
				</TR>
			</thead>
			<tbody>
				{ 
					props.cartons.map((item, index) => (
						<TR key={index} onClick={() => props.history.push(props.path + item.id)}>
							<TD>{item.firstName}</TD>
							<TD>{item.lastName}</TD>
						</TR>
					))
				}
			</tbody>
		</Table>
		{props.showPagination && <PaginationWrapper>
			<Pagination pageNumbers={props.pageNumbers} pageClicked={props.pageClicked} previous={props.previous} next={props.next} current={props.current}/>
		</PaginationWrapper>}
	</div>
);

export default withRouter(cartons);