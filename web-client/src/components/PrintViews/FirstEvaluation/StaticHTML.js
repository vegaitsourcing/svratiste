import React from 'react';


const StaticHTML = ({ evaluation }) => {
    return (
        <div className="container wrap">
			<div className="table-print">
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">1. Основни подаци</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<th className="row-width" scope="row">Име, Презиме и надимак корисника</th>
							<td colSpan="5"><span>{evaluation.carton.firstName}, {evaluation.carton.lastName} {evaluation.carton.nickname}</span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Узраст</th>
							<td colSpan="3"><span></span></td>
							<th scope="row">Пол</th>
							<td><span></span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Чланови домаћинства</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Адреса становања</th>
							<td colSpan="5"><span>{evaluation.carton.addressStreetName} {evaluation.carton.addressStreetNumber}</span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Школски статус</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Водитељ случаја</th>
							<td colSpan="5"><span>{evaluation.caseLeaderName}</span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row"> Задужени стручни радник / сарадник у услузи</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">имена, функција и контакти других особа укључених у процени</th>
							<td colSpan="5"><textarea cols="130" rows="20"></textarea></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">2. Процена потреба корисника</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<th className="row-width">Основне физичке потребе</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Психолошке и социјалне потребе</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Едукативне потребе</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Друге потребе</th>
							<td colSpan="5"><span></span></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">3. Доминанте емоције</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<th scope="row"><span></span></th>
							<td className="is-hidden"></td>
							<td className="is-hidden"></td>
							<td className="is-hidden"></td>
							<td className="is-hidden"></td>
							<td className="is-hidden"></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">4. Доминанта понашанња</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<th scope="row" colSpan="6"><span></span></th>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">5. Процена снага корисника</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<th className="row-width">Снаге из непосредног окружења:</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">снаге из породичних односа</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Снаге и личности корисника</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Друге снаге:</th>
							<td colSpan="5"><span></span></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">6. Процена ризика којима је изложен корисник</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<th className="row-width">Ризици везани за срединске факторе</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Ризици везани за породичне односе</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Ризици везани за понашање корисника</th>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th className="row-width">Други ризици:</th>
							<td colSpan="5"><span></span></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">7. Процена способности корисника</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<th scope="row" colSpan="6"><span></span></th>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">8. Културолошке и друге посебности корисника</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<th scope="row" colSpan="6"><span></span></th>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">/</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<th scope="row" colSpan="6">Препоручени степен подршке:</th>
						</tr>
						<tr>
							<td colSpan="6"><span></span></td>
						</tr>
						<tr className="table-details">
							<th scope="row" colSpan="3">Процену урадио:</th>
							<th scope="row" colSpan="3">Датум:</th>
						</tr>
						<tr>
							<td colSpan="3"><span></span></td>
							<td colSpan="3"><span></span></td>
						</tr>
					</tbody>
				</table>
			</div>
		</div>
    );
}

export default StaticHTML;