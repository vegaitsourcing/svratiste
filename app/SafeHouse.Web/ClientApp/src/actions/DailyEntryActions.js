import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../components/common/constants';

import * as authToken from '../authToken';

export function getDailyEntryByCartonId(cartonId) {
    axios.get(web_api_url + '/DailyEntry/' + cartonId,
    {
        headers: { Authorization: "Bearer " + authToken.getToken() }
    }).then((response) => {
    dispatcher.dispatch({
        type: "FETCHED_DAILY_ENTRY",
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

export function addDailyEntry(dailyEntry) {
    axios.post(web_api_url + '/DailyEntry', dailyEntry,
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

export function editDailyEntry(dailyEntry) {
	axios.put(web_api_url + '/DailyEntry', dailyEntry,
		{
			headers: { Authorization: "Bearer " + authToken.getToken() }
		}).then(() => {
            getDailyEntryByCartonId(dailyEntry.cartonId);
		}).catch(error => {
			if (error.response && error.response.status === 401) {
				dispatcher.dispatch({
					type: "UNAUTHORIZED"
				});
			}
		});
}

export function deleteDailyEntry(id) {
	axios.delete(web_api_url + '/DailyEntry/' + id,
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