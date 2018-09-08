import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../constants';

export function login(credentials) {
    axios.post(web_api_url + '/login', credentials).then((response) => {
        dispatcher.dispatch({
            type: "FETCHED_TOKEN",
            payload: response.data
        })
    }); 
} 