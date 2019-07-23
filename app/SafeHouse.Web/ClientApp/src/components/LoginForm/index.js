import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';
import styled from 'styled-components';

import Colors from '../common/colours';
import '../common/icons.css';
import * as LoginActions from '../../actions/LoginActions';
import LoginStore from '../../stores/LoginStore';
import clouds from '../../assets/images/cloud.png'
import * as authToken from '../../authToken';

const PanelIcon = styled.div`
    position: absolute;
    width: 100px;
    height: 100px;
    background-color: ${Colors.primary};
    left: 50%;
    transform: translateX(-50%);
    top: -50px;
    color: #fff;
    border-radius: 50%;
    &::after {
        font-family: 'svgicons';
        font-style: normal;
        font-variant: normal;
        font-weight: normal;
        text-decoration: none;
        text-transform: none;
        content: '\\E002';
        font-size: 48px;
        position: absolute;
        display: inline-block;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }
`;
const PanelImage = styled.div`
    height: 210px;
    background-color: #762aec;
    background-image: url('${clouds}');
    background-position: bottom;
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 5px;
`;
const LoginPanel = styled.div`
	background: ${Colors.white};
	position: absolute;
	top: 50%;
	left: 50%;
	transform: translate(-50%, -50%);
	width: 100%;
	max-width: 500px;
	z-index: 2;
	display: block;
	border-radius: 5px;
	box-shadow: 0 4px 10px -7px rgba(0, 0, 0, 0.3);
`;
const Panel = styled.div`
	padding: 60px 40px 40px;
`;
const P = styled.p`
    color: ${Colors.white};
    font-size: 17px;
    text-align: center;
    padding: 0 20px;
`;
const H3 = styled.h3`
	color: ${Colors.doveGray};
	font-size: 16px;
`;
const FormContent = styled.div`
	position: relative;
`;
const Input = styled.input`
	display: block;
	width: 100%;
	height: 30px;
	border: 0;
	border-bottom: 2px solid ${Colors.havelockBlue};
	margin-bottom: 20px;
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
	background: ${Colors.primary};
    width: 100%;
	margin-left: 0;
	border: 0;
	cursor: pointer;
	display: block;
	color: ${Colors.white};
	font-weight: 400;
    text-align: center;
    white-space: nowrap;
	user-select: none;
	padding: .375rem .75rem;
    font-size: 1rem;
    line-height: 1.5;
    border-radius: .25rem;
    transition: color .15s ease-in-out, background-color .15s ease-in-out, border-color .15s ease-in-out, box-shadow .15s ease-in-out;
`;
const Span = styled.span`
	position: absolute;
	bottom: 0;
	left: 0;
	right: 0;
	height: 1px;
	background-color: ${Colors.shockingPink};
	transform-origin: bottom left;
	transform: scaleX(0);
	transition: transform 0.5s ease;
`;
class LoginForm extends Component {
    constructor(props) {
        super(props);

        this.state = {
            Username: '',
            Password: ''
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.loginClick = this.loginClick.bind(this);

        this.fetchEdToken = this.fetchEdToken.bind(this);
    }

    componentWillMount() {
        if (authToken.getToken()) {
            this.props.history.push('/');
        }
        LoginStore.on("fetched_token", this.fetchEdToken);
    }

    componentWillUnmount() {
        LoginStore.removeListener("fetched_token", this.fetchEdToken);
    }

    fetchEdToken() {
        this.props.history.push('/');
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
	}
    loginClick() {
        LoginActions.login(this.state);
    }

    render () {
        return (
            <main className="main main-page">
                <LoginPanel>
                    <PanelImage>
                        <P>
                            Welcome back! Please enter your username and password below!
                        </P>
                    </PanelImage>
                    <Panel>
						<FormContent>
							<H3>username:</H3>
							<Input name="Username" type="text" onChange={this.handleInputChange}/>
							<Span />
						</FormContent>
						<FormContent>
							<H3>password:</H3>
							<Input name="Password" type="password" onChange={this.handleInputChange} />
							<Span />
						</FormContent>
                        <Button type="button" onClick={this.loginClick}>Login</Button>
					</Panel>
				</LoginPanel>
            </main>
        );
    };
}

export default withRouter(LoginForm);