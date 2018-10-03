import React from 'react';

import PaginationItem from './PaginationItem';


const Pagination = ({ totalPages, currentPage, previousClick, pageClick, nextClick }) => {
    return (
        <div className="pages">
            <nav aria-label="Page navigation example">
                <ul className="pagination">
                    <PaginationItem text="Prethodna" clickItem={previousClick} />

                    {Array.apply(null, { length: totalPages }).map((number, index) => (
                        <PaginationItem 
                            key={index}
                            text={++index} 
                            clickItem={() => pageClick(index)}
                            active={currentPage === index} />
                    ))}
                    
                    <PaginationItem text="Sledeća" clickItem={nextClick} />
                </ul>
            </nav>
        </div>
    );
}

export default Pagination;