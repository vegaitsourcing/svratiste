import dispatcher from '../dispatcher';

import axios from 'axios';
import { web_api_url } from '../constants';

import * as authToken from '../authToken';

export function getMediationWritings() {
    axios.get(web_api_url + '/Enumerations/MediationWritings',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_MEDIATION_WRITINGS",
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

export function getMediationSpeakings() {
    axios.get(web_api_url + '/Enumerations/MediationSpeakings',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_MEDIATION_SPEAKINGS",
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

export function getLifeSkills() {
    axios.get(web_api_url + '/Enumerations/LifeSkills',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_LIFE_SKILLS",
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

export function getWorkshopTypes() {
    axios.get(web_api_url + '/Enumerations/WorkshopTypes',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_WORKSHOP_TYPES",
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

export function getSchoolActivities() {
    axios.get(web_api_url + '/Enumerations/SchoolActivities',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_SCHOOL_ACTIVITIES",
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

export function getMedicalInterventions() {
    axios.get(web_api_url + '/Enumerations/MedicalInterventions',
        {
            headers: { Authorization: "Bearer " + authToken.getToken() }
        }).then((response) => {
            dispatcher.dispatch({
                type: "FETCHED_MEDICAL_INTERVETIONS",
                payload: response.data
            });
        }).catch(error => {
            console.log(error);
            if (error.response.status === 401) {
                dispatcher.dispatch({
                    type: "UNAUTHORIZED"
                });
            }
        });
}