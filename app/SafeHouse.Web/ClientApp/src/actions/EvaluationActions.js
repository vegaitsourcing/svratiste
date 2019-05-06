import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../constants';

import * as authToken from '../authToken';


export function getFirstEvaluation(cartonId) {
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

export function createFirstEvaluation(evaluation) {
    axios.post(web_api_url + '/FirstEvaluation', evaluation,
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then(() => {
        console.log("DOBAR");
        /*dispatcher.dispatch({
            type: "HIDE_ADD_BAR"
        });*/
    }).catch(error => {
        if (error.response.status === 401) {
            dispatcher.dispatch({
                type: "UNAUTHORIZED"
            });
        }
    });
}