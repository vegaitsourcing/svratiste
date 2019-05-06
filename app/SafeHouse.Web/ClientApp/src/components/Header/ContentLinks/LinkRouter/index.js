import React from 'react';
import { Link } from 'react-router-dom';


const LinkRouter = ({ to, active, children }) => {
    return (
        <li className={active ? "nav-item active" : "nav-item"}>
            <Link
                to={to}
                className="nav-link" >
                { children }
            </Link>
        </li>
    );
};

export default LinkRouter;