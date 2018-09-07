import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../constants';

export function login(credentials) {
    axios.post(web_api_url + '/login', credentials).then((reponse) => {
        console.log(response);
    }); 
} 