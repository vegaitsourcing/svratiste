import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class CardboardStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.carton = {};
        this.cartons = [];
        this.totalPages = 1;
    }

    getCarton() {
        return this.carton;
    }

    getNumOfPages() {
        return this.totalPages;
    }

    getAll() {
        return this.cartons;
    }

    handleActions(action) {
        switch(action.type) {
            case "FETCHED_CARTON":
                this.carton = action.payload;
                this.emit("fetched_carton");
                break;
            case "FETCHED_ALL_CARTONS":
                this.cartons = action.payload;
                this.emit("fetched_cartons");
                break;
            case "HIDE_ADD_BAR":
                this.emit("hide_add_bar");
                break;
            case "HIDE_ADD_DAILY_ENTRY_BAR":
                this.emit("hide_add_daily_entry_bar");
                break;
            case "HIDE_EDIT_BAR":
                this.emit("hide_edit_bar");
                break;
            case "FETCHED_PAGES_COUNT":
                this.totalPages = action.payload;
                this.emit("fetched_pages_count");
                break;
            case "UNAUTHORIZED":
                this.emit("unauthorized");
                break;
            default:
        }
    }
}

const cardboardStore = new CardboardStore();
dispatcher.register(cardboardStore.handleActions.bind(cardboardStore));

export default cardboardStore;