import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class FirstEvaluationStore extends EventEmitter {
    constructor(props) {
        super(props);
        this.dailyEntry = {};
    }

    getDailyEntry() {
        return this.dailyEntry;
    }

    handleActions(action) {
        switch (action.type) {
            case "FETCHED_DAILY_ENTRY":
            this.dailyEntry = action.payload;
            this.emit("fetched_daily_entry");
            break;
        case "UNAUTHORIZED":
            this.emit("unauthorized");
            break;
        default:
        }
    }
}

const firstEvaluationStore = new FirstEvaluationStore();
dispatcher.register(firstEvaluationStore.handleActions.bind(firstEvaluationStore));

export default firstEvaluationStore;