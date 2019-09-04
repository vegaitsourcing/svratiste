import React, { Component } from 'react';
import { NavLink} from 'react-router-dom';
import styled from 'styled-components';
import Icon from '@material-ui/core/Icon';

import LoginStore from '../stores/LoginStore';

import Colours from '../components/common/colours';
import Constants from '../components/common/constants';
import { FontWeight, Headings } from '../components/common/typography';
import smalldeco from '../assets/images/decorationsmall.png';
import whiteLogo from '../assets/images/logowhite.png';
import shape from '../assets/images/house.png';
import triangle from '../assets/images/triangles.png';

const Wrapper = styled.div`
	background: ${Colours.porcelain};
	min-height: 100vh;
	position: relative;
`;
const Sidebar = styled.div`
	position: fixed;
	top: 0;
	bottom: 0;
	left: 0;
	z-index: 2;
	width: 300px;
	box-shadow: 0 16px 38px -12px rgba(0,0,0,.56), 0 4px 25px 0 rgba(0,0,0,.12), 0 8px 10px -5px rgba(0,0,0,.2);
	background: #191919;
	background: url('${smalldeco}') bottom left no-repeat,linear-gradient(to bottom,#143d4e 0%,#17264e 100%);
	box-sizing: border-box;
	padding: 10px;
`;
const LogoWrapper = styled.div`
	display: flex;
	justify-content: center;
	padding-bottom: 25px;
	border-bottom: 1px solid #7cc0d8;
	img {
		opacity: 0.9;
	}
`;
const NavigationWrapper = styled.div`

`;
const List = styled.ul`
	margin: 0;
	padding: 0;
`;
const ListItem = styled.li`
	display: block;
	padding: 16px 0;
	border-bottom: 1px solid #7cc0d8;
	position: relative;
	a {
		color: ${Colours.white};
		font-size: 13px;
		font-weight: ${FontWeight.light};
		font-family: ${Headings.font};
		text-decoration: none;
		display: flex;
		align-items: center;
	}
	button {
		color: ${Colours.white};
		font-size: 13px;
		font-weight: ${FontWeight.light};
		font-family: ${Headings.font};
		text-decoration: none;
		display: flex;
		align-items: center;
		padding-left: 0;
		background: transparent;
		border: 0;
		cursor: pointer;
		outline: none;
	}
	span {
		margin: 0 60px 0 20px;
	}
	&::after {
		content: '';
		position: absolute;
		bottom: -1px;
		left: 0;
		width: 100%;
		height: 1px;
		background: ${Colours.ripeLemon};
		transform: scaleX(0);
		transition: transform .25s ease-in-out;
	}
	&:hover {
		&::after {
			transform: scaleX(1)
		}
	}
`;
const Header = styled.div`
	background-color: ${Colours.pampas};
	height: 270px;
	border-bottom: 1px solid ${Colours.white};
	position: relative;
	background-image: url(${triangle});
	&::after {
		content: '';
		position: absolute;
		height: 1px;
		width: 100%;
		bottom: -2px;
		left: 0;
		background: ${Colours.alto};
	}
`;
const Shape = styled.img`
	position: absolute;
	left: 50%;
	transform: translateX(-39%) scale(0.76);;
	bottom: 23px;
`;
const Content = styled.div`
	margin-top: -60px;
	padding: 0 40px 30px 340px;
	position: relative;
`;
const TableContainer = styled.div`
	box-shadow: 0 0 2rem 0 rgba(136,152,170,.15);
`;
const TableHeader = styled.div`
	background: ${Colours.white};
	border-radius: 10px 10px 0 0;
	padding: 5px 20px;
	display: flex;
	justify-content: space-between;
`;
const H3 = styled.h3`
	font-size: 15px;
	color: #32325d;
`;
const TableBody = styled.div`
	background: ${Colours.blackSqueeze};
	padding: 10px 30px 30px;
	border-radius: 0 0 10px 10px;
`;
const SearchWrapper = styled.div`
	display: flex;
	margin-top: 5px;
`;
const SearchInput = styled.input`
	display: inline-block;
	min-width: 270px;
	height: 30px;
	border: 0;
	border-bottom: 2px solid #0775c3;
	outline: none;
	padding-left: 10px;
	&::placeholder {
		color: #adadad;
	}
`;
const Search = styled.button`
	color: #0775c3;
	background: transparent;
	border: 0;
	padding-top: 10px;
	cursor: pointer;
	height: 30px;
`;
class Dashboard extends Component {
	state = {
		searchParams: ''
	}
	onInputChange = (event) => {
		const params =  event.target.value;
		this.setState({searchParams: params});
	}
	handleClick = () => {
		console.log('izlogovan');
	}
	render() {
		return (
			<Wrapper>
				<Header>
					<Shape src={shape} alt="shape" />
				</Header>
				<Content>
					<TableContainer>
						<TableHeader>
							<H3>{this.props.name}</H3>
							{this.props.showSearch && <SearchWrapper>
								<SearchInput placeholder="Search user" value={this.state.searchParams} onChange={this.onInputChange}/>
								<Search>
									<Icon>search</Icon>
								</Search>
							</SearchWrapper>}
						</TableHeader>
						<TableBody>
							{this.props.children}
						</TableBody>
					</TableContainer>
				</Content>
				<Sidebar>
					<LogoWrapper>
						<img src={whiteLogo} alt="logowhite"/>
					</LogoWrapper>
					<NavigationWrapper>
						<List>
							{Constants.links && Constants.links.map((item, index) => (
								<ListItem key={index}>
									<NavLink to={`/${item.path}`}>
										<Icon>{item.icon}</Icon>{item.name}
									</NavLink>
								</ListItem>
							))}
							<ListItem>
								<button onClick={this.handleClick}>
									<Icon>power_settings_new</Icon>Izloguj se
								</button>
							</ListItem>
						</List>
					</NavigationWrapper>
				</Sidebar>
			</Wrapper>
		);
	}
}

export default Dashboard;
