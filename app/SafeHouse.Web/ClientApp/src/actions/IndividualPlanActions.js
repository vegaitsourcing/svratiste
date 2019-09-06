import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../components/common/constants';

import * as authToken from '../authToken';


export function getIndividualPlanByCartonId(cartonId) {
    axios.get(web_api_url + '/IndividualPlan/' + cartonId,
    {
        headers: { Authorization: "Bearer " + authToken.getToken() }
    }).then((response) => {
    dispatcher.dispatch({
        type: "FETCHED_INDIVIDUAL_PLAN",
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

export function addIndividualPlan(individualPlan) {
    axios.post(web_api_url + '/IndividualPlan', individualPlan,
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

export function editIndividualPlan(individualPlan) {
	axios.put(web_api_url + '/IndividualPlan', individualPlan,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then(() => {
            getIndividualPlanByCartonId(individualPlan.cartonId);
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}