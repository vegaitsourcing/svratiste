import React from 'react';

const PaginationItem = ({ active, clickItem, text }) => {
    let classNmaes = "page-link color-secondary";
    if (active) {
        classNmaes += " active-page";
    }

    return (
        <li 
            className="page-item"
            onClick={clickItem}>
            <span className={classNmaes}>
                {text}
            </span>
        </li>
    );
}

export default PaginationItem;