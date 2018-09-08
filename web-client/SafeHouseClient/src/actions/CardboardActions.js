import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../constants';


export function getCartons(page) {
    axios.get(web_api_url + '/Carton/' + page).then((response) => {
        dispatcher.dispatch({
            type: "FETCHED_ALL_CARTONS",
            payload: response.data
        });
    });
}

export function getCartonsPageCount() {
    axios.get(web_api_url + '/Carton').then((response) => {
        dispatcher.dispatch({
            type: "FETCHED_PAGES_COUNT",
            payload: response.data
        });
    });
}

export function addCarton(carton) {
    axios.post(web_api_url + '/Carton', carton).then(() => {
        getCartons();
        dispatcher.dispatch({
            type: "HIDE_ADD_BAR"
        });
    });
}

export function editCarton(carton) {
    axios.put(web_api_url + '/Carton', carton).then(() => {
        getCartons();
        dispatcher.dispatch({
            type: "HIDE_EDIT_BAR"
        });
    });
}

export function hideAddBar() {
    dispatcher.dispatch({
        type: "HIDE_ADD_BAR"
    });
}

export function hideEditBar() {
    dispatcher.dispatch({
        type: "HIDE_EDIT_BAR"
    });
}