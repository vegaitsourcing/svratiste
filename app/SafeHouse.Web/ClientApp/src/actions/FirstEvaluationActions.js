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
        if (error.response && error.response.status === 401) {
            dispatcher.dispatch({
                type: "UNAUTHORIZED"
            });
        }
    });
}

export function addFirstEvaluation(firstEvaluation) {
    axios.post(web_api_url + '/FirstEvaluation', firstEvaluation,
    {
        headers: { Authorization: "Bearer " + authToken.getToken() }
    }).then(() => {
        this.getFirstEvaluationByCartonId(firstEvaluation.cartonId);
    }).catch(error => {
        if (error.response.status === 401) {
            dispatcher.dispatch({
                type: "UNAUTHORIZED"
            });
        }
    });
}

export function editFirstEvaluation(firstEvaluation) {
	axios.put(web_api_url + '/FirstEvaluation', firstEvaluation,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then(() => {
            getFirstEvaluationByCartonId(firstEvaluation.cartonId);
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}

export function deleteFirstEvaluation(id) {
	axios.delete(web_api_url + '/FirstEvaluation/' + id,
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