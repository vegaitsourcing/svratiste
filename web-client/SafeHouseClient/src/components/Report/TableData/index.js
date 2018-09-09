import React from 'react';


const TableData = ({ data }) => {
    return (
        <tbody>
            <tr className="table-details table-report">
                <td>{data.guestsCount}</td>
                <td>{data.maleGuestsCount}</td>
                <td>{data.femaleGuestsCount}</td>
                <td>{data.visitsCount}</td>
                <td>{data.mealCount}</td>
                <td>{data.bathsCount}</td>
                <td>{data.liecesRemovedCount}</td>
                <td>{data.clothingSumCount}</td>
            </tr>
        </tbody>
    );
}

export default TableData;