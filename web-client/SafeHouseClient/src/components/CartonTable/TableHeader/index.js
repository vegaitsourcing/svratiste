import React from 'react';


const TableHeader = () => {
    return (
        <thead className="thead-light">
            <tr>
                <th scope="col">#</th>
                <th scope="col">Ime</th>
                <th scope="col">Prezime</th>
                <th scope="col">Notifikacije</th>
            </tr>
        </thead>
    );
}

export default TableHeader;