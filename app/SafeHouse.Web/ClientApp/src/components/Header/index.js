import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

import ContentLinks from './ContentLinks';


class Header extends Component {
    render () {
		const { location } = this.props;

		return (
			<header className="header" role="banner">
				<nav className="navbar navbar-expand-lg navbar-dark bg-info">
					<div className="container wrap">
                        <span className="navbar-brand">Svratište</span>
						<button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
							<span className="navbar-toggler-icon"></span>
						</button>
						{location.pathname !== "/login" && <ContentLinks location={location} />}
					</div>
				</nav>
			</header>
		);
	};
}

export default withRouter(Header);