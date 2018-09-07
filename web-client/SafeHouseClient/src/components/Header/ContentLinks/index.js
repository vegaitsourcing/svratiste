import React from 'react';


const ContentLinks = () => {
    return (
        <div className="collapse navbar-collapse menu" id="navbarSupportedContent">
            <ul className="navbar-nav mr-auto">
                <li className="nav-item active">
                    <a className="nav-link" href="home.html">home</a>
                </li>
                <li className="nav-item">
                    <a className="nav-link" href="evaluation.html">evaluation</a>
                </li>
                <li className="nav-item">
                    <a className="nav-link" href="reports.html">reports</a>
                </li>
            </ul>
            <button type="button" className="btn btn-light my-2 my-lg-0 btn-inverse logout">Login out</button>
        </div>
    );
}

export default ContentLinks;