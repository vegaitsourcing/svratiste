import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class FirstEvaluationStore extends EventEmitter {
    constructor(props) {
        super(props);
        this.dailyEntry = {};
        this.dailyEntries = [];
    }

    getDailyEntry() {
        return this.dailyEntry;
    }

    getDailyEntries() {
        return this.dailyEntries;
    }

    handleActions(action) {
        switch (action.type) {
            case "FETCHED_DAILY_ENTRY":
                this.dailyEntry = action.payload;
                this.emit("fetched_daily_entry");
                break;
            case "FETCHED_ALL_DAILY_ENTRIES":
                this.dailyEntries = action.payload;
                this.emit('fetched_daily_entries');
                break;
            case "UNAUTHORIZED":
                this.emit("unauthorized");
                break;
            case "RELOAD_PAGE":
                this.emit("reload_page");
                break;
        default:
        }
    }
}

const firstEvaluationStore = new FirstEvaluationStore();
dispatcher.register(firstEvaluationStore.handleActions.bind(firstEvaluationStore));

export default firstEvaluationStore;