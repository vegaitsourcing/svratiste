import React from 'react';


const TableHeader = () => {
    return (
        <thead className="thead-light">
            <tr>
                <th scope="col">Broj posetilaca</th>
                <th scope="col">Broj muskih posetilaca</th>
                <th scope="col">Broj zenskih posetilaca</th>
                <th scope="col">Broj poseta</th>
                <th scope="col">Broj obroka</th>
                <th scope="col">Broj kupanja</th>
                <th scope="col">Broj devansiranja</th>
                <th scope="col">Odeca i obuca</th>
            </tr>
        </thead>
    );
}

export default TableHeader;