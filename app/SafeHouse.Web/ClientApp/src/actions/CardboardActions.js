import axios from 'axios';

import dispatcher from '../dispatcher';
import { web_api_url } from '../components/common/constants';
import * as authToken from '../authToken';

export function getCartons(page) {
	axios.get(web_api_url + '/Carton/GetByPageNumber/' + page,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then((response) => {
			dispatcher.dispatch({
				type: "FETCHED_ALL_CARTONS",
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

export function getCartonsOverEighteen() {
	axios.get(web_api_url + '/Carton/GetOverEighteen',
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then((response) => {
			dispatcher.dispatch({
				type: "FETCHED_CARTONS_OVER_EIGHTEEN",
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

export function getCartonsReadyForInitialEvaluation() {
	axios.get(web_api_url + '/Carton/GetReadyForInitialEvaluation',
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then((response) => {
			dispatcher.dispatch({
				type: "FETCHED_CARTONS_READY_FOR_INITIAL_EVALUATION",
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
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}

export function getCartonById(id) {
	axios.get(web_api_url + '/Carton/' + id,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then((response) => {
			dispatcher.dispatch({
				type: "FETCHED_CARTON",
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

export function addCarton(carton) {
	axios.post(web_api_url + '/Carton', carton,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then(() => {
			getCartons(carton.pageNumber);
		}).catch(error => {
			if (error.response && error.response.status === 401) {
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
				type: "RELOAD_PAGE"
			});
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}

export function deleteCarton(id) {
	axios.delete(web_api_url + '/Carton/' + id,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then((response) => {
			dispatcher.dispatch({
				type: "RELOAD_PAGE"
			});
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}