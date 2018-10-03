import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class LoginStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.token = null;
    }

    getToken() {
        return localStorage.get('accessToken');
    }

    handleActions(action) {
        switch(action.type) {
            case "FETCHED_TOKEN":
                localStorage.setItem('accessToken', action.payload);
                this.emit("fetched_token");
                break;
            default:
        }
    }
}

const loginStore = new LoginStore();
dispatcher.register(loginStore.handleActions.bind(loginStore));

export default loginStore;