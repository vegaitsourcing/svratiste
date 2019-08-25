import React, {Component } from 'react';
import { withRouter } from 'react-router-dom';
import styled from 'styled-components';

import * as LoginActions from '../actions/LoginActions';
// eslint-disable-next-line
import LoginStore from '../stores/LoginStore';
// eslint-disable-next-line
import * as authToken from '../authToken';

import Colours from '../components/common/colours';
import Constants from '../components/common/constants';
import { FontWeight, Headings, Body } from '../components/common/typography';
import ScreenSizes from '../components/common/mediaqueries';
import decoration from '../assets/images/decoration.png';
import Logo from '../assets/images/logo.png';
import LogoWhite from '../assets/images/logowhite.png';
import { keyframes } from 'emotion';

const Content = styled.div`
	display: flex;
	min-height: 100vh;
	justify-content: center;
	background: ${Colours.white};
	flex-wrap: wrap;
`;
const LeftSide = styled.div`
	width: 50%;
	display: flex;
	flex-direction: column;
	justify-content: center;
	align-items: center;
	${ScreenSizes.largeDown} {
		width: 100%;
	}
`;
const RightSide = styled.div`
	width: 50%;
	background: ${Colours.bunting};
	background: url('${decoration}') top right no-repeat, linear-gradient(135deg, ${Colours.elephant} 0%, ${Colours.bunting} 100%);
	position: relative;
	display: flex;
	flex-direction: column;
	justify-content: center;
	align-items: center;
	${ScreenSizes.largeDown} {
		width: 100%;
	}
`;
const increaseWidth = keyframes`
	from {
		width: 0;
	}
	to {
		width: 100%;
	}
`;
const RightSideWrapper = styled.div`
	width: 400px;
	padding-bottom: 12px;
	position: relative;
	&::after {
		content: '';
		display: block;
		position: absolute;
		bottom: -10px;
		left: 0;
		height: 2px;
		z-index: 3;
		background: ${Colours.curiousBlue};
		animation: ${increaseWidth} 1s linear forwards;
	}
`;
const Title = styled.h2`
	font-family: ${Headings.font};
	font-size: 24px;
	color: ${Colours.white};
	padding-left: 15px;
`;
const Description = styled.p`
	font-size: 16px;
	font-family: ${Body.font};
	color: ${Colours.white};
	opacity: 0.8;
	padding-left: 15px;
`;
const LoginMessage = styled.p`
	text-transform: uppercase;
	font-size: 14px;
	font-family: ${Body.font};
	letter-spacing: -0.2px;
	color: ${Colours.bunting};
`;
const LoginContent = styled.div`
	min-width: 440px;
	margin: 70px auto 0;
`;
const H3 = styled.h3`
	color: ${Colours.doveGray};
	font-size: 16px;
	font-weight: ${FontWeight.normal};
	font-family: ${Body.font};
`;
const FormContent = styled.div`
	position: relative;
`;
const Input = styled.input`
	display: block;
	width: 100%;
	height: 30px;
	border: 0;
	border-bottom: 2px solid ${Colours.lochmara};
	margin-bottom: 20px;
	outline: none;
	&:last-of-type {
		margin-bottom: 30px;
	}
	&::placeholder {
		opacity: 0.4;
	}
	&:focus {
		& + span {
			transform-origin: bottom left;
			transform: scaleX(1);
		}
	}
`;
const Button = styled.button`
	background: ${Colours.lochmara};
	width: 100%;
	margin-left: 0;
	border: 0;
	cursor: pointer;
	display: block;
	color: ${Colours.white};
	font-weight: 400;
	text-align: center;
	white-space: nowrap;
	user-select: none;
	padding: .575rem .75rem;
	font-size: 1rem;
	line-height: 1.5;
	position: relative;
	z-index: 1;
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
const Span = styled.span`
	position: absolute;
	bottom: 0;
	left: 0;
	right: 0;
	height: 2px;
	background-color: ${Colours.curiousBlue};
	transform-origin: bottom left;
	transform: scaleX(0);
	transition: transform 0.5s ease;
`;
class Login extends Component {
	constructor(props) {
		super(props);

		this.state = {
			Username: '',
			Password: ''
		};
		this.fetchEdToken = this.fetchEdToken.bind(this);
	}

	// componentWillMount() {
	// 	if (authToken.getToken()) {
	// 		this.props.history.push('/');
	// 	}
	// 	LoginStore.on("fetched_token", this.fetchEdToken);
	// }
	// componentWillUnmount() {
	// 	LoginStore.removeListener("fetched_token", this.fetchEdToken);
	// }
	fetchEdToken() {
		this.props.history.push('/');
	}

	handleInputChange = (e) => {
		const {target} = e;
		const {name, value} = target;
		this.setState({[name]: value});
	}

	loginClick= () => {
		LoginActions.login(this.state);
	}
	render() {
		return (
			<Content>
				<LeftSide>
					<img src={Logo} alt="logo"/>
					<LoginMessage>{Constants.loginMessage}</LoginMessage>
					<LoginContent>
						<FormContent>
							<H3>{Constants.loginUsername}</H3>
							<Input name="Username" type="text" onChange={this.handleInputChange}/>
							<Span />
						</FormContent>
						<FormContent>
							<H3>{Constants.loginPassword}</H3>
							<Input name="Password" type="password" onChange={this.handleInputChange} />
							<Span />
						</FormContent>
						<Button type="button" onClick={this.loginClick}>{Constants.loginButton}</Button>
					</LoginContent>
				</LeftSide>
				<RightSide>
					<RightSideWrapper>
					<img src={LogoWhite} alt="logowhite" />
						<Title>{Constants.loginTitle}</Title>
						<Description>{Constants.loginDescription}</Description>
					</RightSideWrapper>
				</RightSide>
			</Content>
		);
	};
}
export default withRouter(Login);