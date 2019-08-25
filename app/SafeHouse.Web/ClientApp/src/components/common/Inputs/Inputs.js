import React from 'react';
import styled from 'styled-components';

import Colours from '../colours';
import {Body, FontWeight} from '../typography';
const Input = styled.input`
	display: block;
	width: 100%;
	height: calc(2.75rem + 2px);
	padding: .625rem .75rem;
	font-size: 14px;
	/* font-family: ${Body.font}; */
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
`;
const Label = styled.label`
	display: block;
	padding: 5px 0;
	color: ${Colours.bunting};
	font-size: 14px;
	font-weight: ${FontWeight.medium};
`;
const Span = styled.span`
	color: ${Colours.apricot};
	font-size: 11px;
	padding-left: 6px;
`;
const Select = styled.select`
	display: block;
	width: 100%;
	height: calc(2.75rem + 2px);
	padding: .625rem .75rem;
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
`;
const Textarea = styled.textarea`
	display: block;
	width: 100%;
	height: calc(2.75rem + 2px);
	padding: .625rem .75rem;
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
	resize: vertical; 
`;
export const input = (props) => {
	return(
		<Input
		value={props.value}
		onChange={props.change}
		type={props.inputType}
		name={props.inputName}
		/>
	);
}
export const select = (props) => {
	return(
		<Select onChange={props.change} value={props.value} name={props.inputName}>
			<option disabled value="">{props.title}</option>
			{props.options.map(option => (
				<option key={option.value} value={option.value}>
					{option.name}
				</option>
			))}
		</Select>
	);
}
export const textarea = (props) => {
	return(
		<Textarea
		value={props.value}
		onChange={props.change}
		name={props.inputName}
		></Textarea>
	);
}
export const label = (props) => {
	return(
		<Label>{props.title}{props.required ? <Span>*obavezno</Span> : null }</Label>
	);
}