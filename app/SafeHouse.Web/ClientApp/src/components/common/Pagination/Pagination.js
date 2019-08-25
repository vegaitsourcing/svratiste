import React from 'react'
import styled from 'styled-components';

import Colours from '../colours';
import {Headings} from '../typography';

const Ul = styled.ul`
	display: flex;
	list-style: none;
`;
const Button= styled.button`
	display: flex;
	align-items: center;
	justify-content: center;
	padding: 0;
	margin: 0 3px;
	border-radius: 50%;
	width: 34px;
	height: 34px;
	font-size: 14px;
	font-family: ${Headings.font};
	color: ${Colours.doveGray};
	background: ${Colours.white};
	border: 1px solid ${Colours.doveGray};
	cursor: pointer;
	&:hover {
		color: ${Colours.lochmara};
		border: 1px solid ${Colours.lochmara};
	}
	&.active {
		background: ${Colours.lochmara};
		color: ${Colours.white};
	}
	&.previous {
		position: relative;
		&::after {
			content: '';
			position: absolute;
			width: 12px;
			height: 12px;
			top: 11px;
			left: 13px;
			box-sizing: border-box;
			border-right: 2px solid ${Colours.doveGray};;
			border-bottom: 2px solid ${Colours.doveGray};
			transform: rotate(135deg);
		}
	}
	&.next {
		position: relative;
		&::after {
			content: '';
			position: absolute;
			width: 12px;
			height: 12px;
			top: 11px;
			left: 9px;
			box-sizing: border-box;
			border-right: 2px solid ${Colours.doveGray};;
			border-bottom: 2px solid ${Colours.doveGray};
			transform: rotate(315deg);
		}
	}
`;
const pagination = (props) => {
	const pageNumbers = [];
	for(let i = 1; i <= props.pageNumbers; i++) {
		pageNumbers.push(i);
	}
	return(
		<Ul>
			<li><Button className="previous" onClick={props.previous}/></li>
			{pageNumbers.map(item => (
				<li key={item}>
					<Button onClick={() => props.pageClicked(item)} className={props.current === item ? 'active' : ''}>{item}</Button>
				</li>
			))}
			<li><Button className="next" onClick={props.next}/></li>
		</Ul>
	);
}
export default pagination;