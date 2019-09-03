import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../components/common/constants';

import * as authToken from '../authToken';


export function getFirstEvaluationByCartonId(cartonId) {
    axios.get(web_api_url + '/FirstEvaluation/' + cartonId,
    {
        headers: { Authorization: "Bearer " + authToken.getToken() }
    }).then((response) => {
    dispatcher.dispatch({
        type: "FETCHED_FIRST_EVALUATION",
        payload: response.data
    });
    }).catch(error => {
        if (error.response.status === 401) {
            dispatcher.dispatch({
                type: "UNAUTHORIZED"
            });
        }
    });
}

export function addFirstEvaluation(evaluation) {
    axios.post(web_api_url + '/FirstEvaluation', evaluation,
    {
        headers: { Authorization: "Bearer " + authToken.getToken() }
    }).then(() => {
        console.log("DOBAR");
    }).catch(error => {
        if (error.response.status === 401) {
            dispatcher.dispatch({
                type: "UNAUTHORIZED"
            });
        }
    });
}

export function editFirstEvaluation(evaluation) {
	axios.put(web_api_url + '/FirstEvaluation', evaluation,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then(() => {
            getFirstEvaluationByCartonId(evaluation.cartonId);
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}