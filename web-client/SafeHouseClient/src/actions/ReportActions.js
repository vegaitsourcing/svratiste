import axios from 'axios';
import { web_api_url } from '../constants';

import * as authToken from '../authToken';

export function getReport() {
    axios.get(web_api_url + '/Report/',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_REPORTS",
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