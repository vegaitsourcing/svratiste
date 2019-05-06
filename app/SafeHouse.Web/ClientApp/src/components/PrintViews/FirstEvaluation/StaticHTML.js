import React from 'react';


const StaticHTML = ({ evaluation }) => {

    const formatDate = (date) => {
        var d = new Date(date),
            month = '' + (d.getMonth() + 1),
            day = '' + d.getDate(),
            year = d.getFullYear();
    
        if (month.length < 2) month = '0' + month;
        if (day.length < 2) day = '0' + day;
    
        return [day, month, year].join('.');
    }

    return (
        <div className="container wrap">
			<div className="table-print">
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">1. Информације о кориснику, његовом индетитету и породици</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<th className="row-width" scope="row">Име, презиме и надимак корисника:</th>
							<td colSpan="5"><span>{evaluation.carton.firstName}, {evaluation.carton.lastName} {evaluation.carton.nickname}</span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Имена родитеља / старатеља:</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.guardiansName} cols="30" rows="10"></textarea></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Имена друге деце из породице:</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.otherChildernName} cols="30" rows="10"></textarea></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Имена и сродство других чланова домаћинства</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.otherMembersName} cols="30" rows="10"></textarea></td>
						</tr>
						<tr className="table-details">
							<th scope="row">Адреса становања:</th>
							<td colSpan="5"><span>{evaluation.carton.addressStreetName} {evaluation.carton.addressStreetNumber}</span></td>
						</tr>
						<tr>
							<th scope="row">Живи у:</th>
							<td colSpan="1"><span>Породици</span><input type="checkbox" /></td>
							<td colSpan="1"><span>Установи</span><input type="checkbox" /></td>
							<td colSpan="1"><span>Вршњачкој групи</span><input type="checkbox" /></td>
							<td colSpan="2"><span>Друго</span><input type="checkbox" /></td>
						</tr>
						<tr>
							<th scope="row">Школа и разред</th>
							<td colSpan="5"><span>{evaluation.schoolAndGrade}</span></td>
						</tr>
						<tr>
							<th scope="row">Матерњи и други језици</th>
							<td colSpan="5"><span>{evaluation.languages}</span></td>
						</tr>
						<tr>
							<th scope="row" colSpan="1">Здравствена књижица</th>
							<td colSpan="1"><span>Да</span><input type="checkbox" disabled checked={evaluation.healthCard} /></td>
							<td colSpan="1"><span>Не</span><input type="checkbox" disabled checked={!evaluation.healthCard} /></td>
							<th scope="row" colSpan="1">Датум рођења</th>
							<td colSpan="1"><span>{formatDate(evaluation.carton.dateOfBirth)}</span></td>
							<td className="is-hidden"></td>
						</tr>
						<tr>
							<th scope="row" colSpan="1">Водитељ случаја</th>
							<td colSpan="5"><span>{evaluation.caseLeaderName}</span></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">2. Процена подобности корисника</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<td colSpan="2"><span>Спава на улици</span><input type="checkbox" /></td>
							<td colSpan="2"><span>Храну проналази у контејнерима</span><input type="checkbox" /></td>
							<td colSpan="2"><span>Сакупља секундарне сировине</span><input type="checkbox" /></td>
						</tr>
						<tr>
							<td colSpan="1"><span>Проси:</span><input type="checkbox" /></td>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<td colSpan="2"><span>Продаје сексуалне услуге</span><input type="checkbox" /></td>
							<td colSpan="4"><span>Prodaje na pijaci/ulici</span><input type="checkbox" /></td>
						</tr>
						<tr>
							<td colSpan="1"><span>Помаже породици у раду на улицу:</span><input type="checkbox" /></td>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<td colSpan="1"><span>Екстремно сиромашна породица, постоји ризик за дете:</span><input type="checkbox" /></td>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<td colSpan="1"><span>Друго:</span><input type="checkbox" /></td>
							<td colSpan="5"><span></span></td>
						</tr>
						<tr>
							<th scope="row">Имена и сродство других чланова домаћинства</th>
							<td colSpan="5"><textarea className="small" disabled cols="30" rows="10"></textarea></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">3. Процена капацитета пружаоца услуге, приоритета за пријем и упућивања на друге услуге или службе у заједници</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<th scope="row">Постоје капацитети услуге да задовољи потребе корисника</th>
							<td colSpan="2"><span>Да</span><input type="checkbox" disabled checked={evaluation.capability} /></td>
							<td colSpan="2"><span>Не</span><input type="checkbox" disabled checked={!evaluation.capability} /></td>
							<th className="is-hidden"></th>
						</tr>
						<tr>
							<th className="row-width" scope="row">На листи чекања:</th>
							<td colSpan="1"><span>Да</span><input type="checkbox" disabled checked={evaluation.onTheWaitingList} /></td>
							<td colSpan="1"><span>Не</span><input type="checkbox" disabled checked={!evaluation.onTheWaitingList} /></td>
							<th className="row-width" scope="row">Датум почетка коришћења услуге</th>
							<td colSpan="2"><span>{formatDate(evaluation.serviceStart)}</span></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Упућен на:</th>
							<td colSpan="5"><span>{evaluation.directedToName}</span></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">4. Процена капацитета пружаоца услуге, приоритета за пријем и упућивања на друге услуге или службе у заједници</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<th scope="row" className="row-width">Способност самосталног кретања:</th>
							<td colSpan="2"><span>Да</span><input type="checkbox" disabled checked={evaluation.individualMovementAbility} /></td>
							<td colSpan="2"><span>Не</span><input type="checkbox" disabled checked={!evaluation.individualMovementAbility} /></td>
							<th className="is-hidden"></th>
						</tr>
						<tr>
							<th className="row-width" scope="row">Способност вербалне комуникације (тешкоће у изговору, тешкоће у разумевању језика, тешкоће у вербалном изражавању, итд.):</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.verbalComunicationAbility} cols="30" rows="10"></textarea></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Кратак опис физичког изгледа (укључујићи белеге, ожиљке):</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.physicalDescription} cols="30" rows="10"></textarea></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Дијагностификована болест, алергија:</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.diagnosedDisease} cols="30" rows="10"></textarea></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Приоритетне потребе корисника:</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.priorityNeeds} cols="30" rows="10"></textarea></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">5. Процена става корисника и других значајних особа и нјихових оцекивања од услуге (на крају овог дела дати информације о реалним очекивањима)</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr className="table-details">
							<th className="row-width" scope="row">Став:</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.attitude} cols="30" rows="10"></textarea></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Очекивања:</th>
							<td colSpan="5"><textarea className="small" disabled value={evaluation.expectations} cols="30" rows="10"></textarea></td>
						</tr>
						<tr>
							<th className="row-width" scope="row">Урађен од стране:</th>
							<td colSpan="5"><span>{evaluation.directedFromName}</span></td>
						</tr>
					</tbody>
				</table>
				<table className="table table-position table-bordered">
					<thead className="thead-light">
						<tr>
							<th className="table-head" scope="col">6. Остало (број телефона родитеља, наставника, друге битне информације о породици, итд.</th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
							<th className="is-hidden"></th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td colSpan="6"><textarea cols="30" disabled value={evaluation.other} rows="10"></textarea></td>
						</tr>
						<tr className="table-details">
							<th scope="row" colSpan="1">Пријем започет:</th>
							<td colSpan="2"><span>{formatDate(evaluation.startedEvaluation)}</span></td>
							<th scope="row" colSpan="1">Пријем завршен:</th>
							<td colSpan="2"><span>{formatDate(evaluation.finishedEvaluation)}</span></td>
						</tr>
						<tr>
							<th scope="row" colSpan="1">Пријем урадио:</th>
							<td colSpan="2"><span>{evaluation.evaluationDoneBy}</span></td>
							<th scope="row" colSpan="1">Прегледао:</th>
							<td colSpan="2"><span>{evaluation.evaluationRevisedBy}</span></td>
						</tr>
					</tbody>
				</table>
			</div>
		</div>
    );
}

export default StaticHTML;