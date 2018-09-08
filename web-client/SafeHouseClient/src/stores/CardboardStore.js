import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class CardboardStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.cartons = [];
    }

    getAll() {
        return this.cartons;
    }

    handleActions(action) {
        switch(action.type) {
            case "FETCHED_ALL_CARTONS":
                this.cartons = action.payload;
                this.emit("fetched_cartons");
                break;
            case "HIDE_ADD_BAR":
                this.emit("hide_add_bar");
                break;
            default:
        }
    }
}

const cardboardStore = new CardboardStore();
dispatcher.register(cardboardStore.handleActions.bind(cardboardStore));

export default cardboardStore;