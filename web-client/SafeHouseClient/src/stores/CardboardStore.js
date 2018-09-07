import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class CardboardStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.cardboards = [];
    }

    getAll() {
        return this.cardboards;
    }

    handleActions(action) {
        switch(action.type) {
            case "FETCHED_CARTONS":
                
                break;
        }
    }
}

const cardboardStore = new CardboardStore();
dispatcher.register(cardboardStore.handleActions.bind(this));

export default cardboardStore;