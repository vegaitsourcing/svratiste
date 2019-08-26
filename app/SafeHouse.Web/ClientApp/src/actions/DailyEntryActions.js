import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../constants';

import * as authToken from '../authToken';
import { getCartons } from './CardboardActions';

export function addDailyEntry(dailyEntry) {
    axios.post(web_api_url + '/DailyEntry', dailyEntry,
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then(() => {
            getCartons(dailyEntry.pageNumber);
            dispatcher.dispatch({
                type: "HIDE_ADD_DAILY_ENTRY_BAR"
            });
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