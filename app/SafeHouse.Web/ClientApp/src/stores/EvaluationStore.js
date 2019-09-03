import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class EvaluationStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.evaluation = {};
    }

    getEvaluation() {
        return this.evaluation;
    }

    handleActions(action) {
        switch (action.type) {
            case "FETCHED_EVALUATION":
            this.evaluation = action.payload;
            this.emit("fetched_evaluation");
            break;
        case "UNAUTHORIZED":
            this.emit("unauthorized");
            break;
        default:
        }
    }
}

const evaluationStore = new EvaluationStore();
dispatcher.register(evaluationStore.handleActions.bind(evaluationStore));

export default evaluationStore;