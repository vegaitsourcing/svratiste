import React, { Component } from 'react';
import styled from 'styled-components';
import Icon from '@material-ui/core/Icon';

import Aux from '../../../hoc/Aux';
import Colours from '../colours';
import {FontWeight, Headings} from '../typography';
const Backdrop = styled.div`
	width: 100%;
	height: 100%;
	position: fixed;
	z-index: 100;
	left: 0;
	top: 0;
	background-color: rgba(0, 0, 0, 0.5);
	display: ${props => props.show ? 'block' : 'none'};
`;
const ModalWrapper = styled.div`
	position: absolute;
	max-width: 1168px;
	min-width: 60%;
	padding: 60px 30px 30px;
	top: 50%;
	left: 50%;
	transform: translate(-50%, -50%);
	background-color: ${Colours.white};
	margin-top: -100px;
	transition: all 0.8s ease-in-out;
	animation-name: moveDown;
	animation-duration: 0.6s;
	animation-fill-mode: forwards;
	border-radius: 8px;
	border-bottom: 4px solid ${Colours.lochmara};
	@keyframes moveDown {
		from { margin-top: -100px; }
		to { margin-top: 0; }
	}
`;
const CloseButton = styled.div`
	position: absolute;
	width: 40px;
	height: 40px;
	background: ${Colours.white};
	border-radius: 50%;
	top: -22px;
	right: -22px;
	border: 4px solid ${Colours.lochmara};
	cursor: pointer;
	&::after {
		content: '';
		position: absolute;
		top: 20px;
		left: 10px;
		width: 20px;
		height: 4px;
		background: ${Colours.lochmara};
		transform: rotate(45deg);
	}
	&::before {
		content: '';
		position: absolute;
		top: 20px;
		left: 10px;
		width: 20px;
		height: 4px;
		background: ${Colours.lochmara};
		transform: rotate(-45deg);
	}
`;
const ModalContainer = styled.div`
	display: flex;
	max-height: calc(100vh - 280px);
	overflow-y: auto;
	background: ${Colours.blackSqueeze};
	border-radius: 5px;
	box-shadow: inset 0 1px 9px -3px rgba(0,0,0,0.2);
`;
const ModalTitle = styled.div`
	position: absolute;
	top: 20px;
	left: 20px;
	color: #0580c6;
	font-size: 14px;
	font-weight: ${FontWeight.medium};
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
class Modal extends Component {

	render() {
		return (
			<Aux>
				<Backdrop show={this.props.show}>
					<ModalWrapper show={this.props.show}>
						{this.props.title && <ModalTitle>
							<Icon>home</Icon>
							{this.props.title}
						</ModalTitle>}
						<CloseButton onClick={this.props.modalClosed} />
						<ModalContainer>
							{this.props.children}
						</ModalContainer>
					</ModalWrapper>
				</Backdrop>
			</Aux>
			);
	}
}
export default Modal;