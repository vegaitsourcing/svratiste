import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../constants';

import * as authToken from '../authToken';


export function getCartonById(id) {
    console.log(id);
    /*
    axios.get(web_api_url + '/Carton/' + id,
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_CARTON",
                payload: response.data
            });
        }).catch(error => {
            if (error.response.status === 401) {
                dispatcher.dispatch({
                    type: "UNAUTHORIZED"
                });
            }
        });
        */
}

export function getCartons(page) {
    axios.get(web_api_url + '/Carton/' + page,
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_ALL_CARTONS",
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

export function getCartonsPageCount() {
    axios.get(web_api_url + '/Carton/pageCount',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
        dispatcher.dispatch({
            type: "FETCHED_PAGES_COUNT",
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

export function addCarton(carton) {
    axios.post(web_api_url + '/Carton', carton,
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then(() => {
        getCartons(carton.pageNumber);
        dispatcher.dispatch({
            type: "HIDE_ADD_BAR"
        });
        }).catch(error => {
            if (error.response.status === 401) {
                dispatcher.dispatch({
                    type: "UNAUTHORIZED"
                });
            }
        });
}

export function editCarton(carton) {
    axios.put(web_api_url + '/Carton', carton,
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then(() => {
        getCartons(carton.pageNumber);
        dispatcher.dispatch({
            type: "HIDE_EDIT_BAR"
        });
        }).catch(error => {
            if (error.response.status === 401) {
                dispatcher.dispatch({
                    type: "UNAUTHORIZED"
                });
            }
        });
}

export function hideAddBar() {
    dispatcher.dispatch({
        type: "HIDE_ADD_BAR"
    });
}

export function hideAddDailyEntryBar() {
    dispatcher.dispatch({
        type: "HIDE_ADD_DAILY_ENTRY_BAR"
    });
}

export function hideEditBar() {
    dispatcher.dispatch({
        type: "HIDE_EDIT_BAR"
    });
}