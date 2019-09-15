import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class IndividualPlanStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.individualPlan = {};
    }

    getIndividualPlan() {
        return this.individualPlan;
    }

    handleActions(action) {
        switch (action.type) {
            case "FETCHED_INDIVIDUAL_PLAN":
            this.individualPlan = action.payload;
            this.emit("fetched_individual_plan");
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

const individualPlanStore = new IndividualPlanStore();
dispatcher.register(individualPlanStore.handleActions.bind(individualPlanStore));

export default individualPlanStore;