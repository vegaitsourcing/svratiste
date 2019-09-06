import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../components/common/constants';

import * as authToken from '../authToken';


export function getEvaluationByCartonId(cartonId) {
    axios.get(web_api_url + '/Evaluation/' + cartonId,
    {
        headers: { Authorization: "Bearer " + authToken.getToken() }
    }).then((response) => {
    dispatcher.dispatch({
        type: "FETCHED_EVALUATION",
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

export function addEvaluation(evaluation) {
    axios.post(web_api_url + '/Evaluation', evaluation,
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

export function editEvaluation(evaluation) {
	axios.put(web_api_url + '/Evaluation', evaluation,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then(() => {
            getEvaluationByCartonId(evaluation.cartonId);
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}

export function deleteEvaluation(id) {
	axios.delete(web_api_url + '/Evaluation/' + id,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then((response) => {
			// Done
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}