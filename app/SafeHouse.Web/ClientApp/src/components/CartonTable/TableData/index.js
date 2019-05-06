import React from 'react';


const TableData = ({ data, selectItem }) => {
    return (
        <tbody>
            {data.map((row, index) => {
                let colorClass = "notify notify-normal";
                if (row.numberOfVisits > 2) {
                    colorClass += " notify-warning";
                }
                if (row.numberOfVisits > 5) {
                    colorClass += " notify-danger";
                }

                return (
                    <tr className="table-details" key={index} onClick={() => selectItem(row)}>
                        <th scope="row">{++index}</th>
                        <td>{row.firstName}</td>
                        <td>{row.lastName}</td>
                        <td className={colorClass}>{row.numberOfVisits}</td>
                    </tr>
                );
            })}
        </tbody>
    );
}

export default TableData;