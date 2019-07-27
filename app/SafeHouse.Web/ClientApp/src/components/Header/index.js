import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';
import styled from 'styled-components';
import Colours from '../common/colours';
import ContentLinks from './ContentLinks';

const PageHeader = styled.header`
	position: relative;
	background-color: ${Colours.brightGray};
`;
const BorderBottom = styled.span`
	position: absolute;
	bottom: 0;
	left: 0;
	right: 0;
	height: 3px;
	background: linear-gradient(to right, #8577e3, #f318d9);
`;
const Wrap = styled.div`
	margin: 0 auto;
	max-width: 1280px;
	padding: 0 20px;
	width: 100%;
	display: flex;
`;
const Logo = styled.div`
	position: relative;
	color: ${Colours.white};
	font-size: 16px;
	text-transform: uppercase;
	background-color: rgba(133, 119, 227, 0.6);
	padding: 12px;
	padding-left: 42px;
	&::after {
        font-family: 'svgicons';
        font-style: normal;
        font-variant: normal;
        font-weight: normal;
        text-decoration: none;
        text-transform: none;
        content: '\\E002';
        font-size: 21px;
        position: absolute;
        display: inline-block;
        top: 50%;
        transform: translateY(-50%);
		left: 12px;
    }
`;
class Header extends Component {
	render () {
		const { location } = this.props;

		return (
			<PageHeader>
				<Wrap>
					<Logo>Svratište</Logo>
					{location.pathname !== "/login" && <ContentLinks location={location} />}
				</Wrap>
				<BorderBottom />
			</PageHeader>
		);
	};
}

export default withRouter(Header);