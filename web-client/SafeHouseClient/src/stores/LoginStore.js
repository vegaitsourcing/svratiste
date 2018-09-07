import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class LoginStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.token = null;
    }

    getToken() {
        return this.token;
    }

    handleActions(action) {
        switch(action.type) {
            case "FETCHED_TOKEN":
                this.token = action.payload;
                break;
        }
    }
}

const loginStore = new LoginStore();
dispatcher.register(loginStore.handleActions.bind(this));

export default loginStore;