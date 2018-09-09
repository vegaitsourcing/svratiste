import React from 'react';


const TableData = ({ data, selectItem }) => {
    return (
        <tbody>
            {data.map((row, index) => (
                <tr key={ index } onClick={() => selectItem(row)}>
                    <th scope="row">{ ++index }</th>
                    <td>{ row.firstName }</td>
                    <td>{ row.lastName }</td>
                    <td className="notify notify-warning">{ row.notifications }</td>
                </tr>
            ))}
        </tbody>
    );
}

export default TableData;