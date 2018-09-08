import React from 'react';

import LinkRouter from './LinkRouter';

const ContentLinks = ({ location }) => {
    return (
        <div className="collapse navbar-collapse menu" id="navbarSupportedContent">
            <ul className="navbar-nav mr-auto">
                <LinkRouter
                    to="/"
                    active={location.pathname === "/"}>Kartoni</LinkRouter>
                <LinkRouter
                    to="/reports"
                    active={location.pathname === "/reports"}>Izveštaji</LinkRouter>
                <LinkRouter
                    to="/evaluation"
                    active={location.pathname === "/evaluation"}>Procena</LinkRouter>
            </ul>
            <button type="button" className="btn btn-light my-2 my-lg-0 btn-inverse logout">Login out</button>
        </div>
    );
}

export default ContentLinks;