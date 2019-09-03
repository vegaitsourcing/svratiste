import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class FirstEvaluationStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.firstEvaluation = {};
    }

    getFirstEvaluation() {
        return this.firstEvaluation;
    }

    handleActions(action) {
        switch (action.type) {
            case "FETCHED_FIRST_EVALUATION":
            this.firstEvaluation = action.payload;
            this.emit("fetched_first_evaluation");
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