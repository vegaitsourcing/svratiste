import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';

class ReportStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.report = {}
    }

    handleActions(action) {
        switch (action.type) {
            
            case "FETCHED_REPORTS":
                this.report = action.payload;
                this.emit("fetched_reports");
                break;
            case "UNAUTHORIZED":
                this.emit("unauthorized");
                break;
            default:
        }
    }

    getAll() {
        return this.report;
    }
}

const reportStore = new ReportStore();
dispatcher.register(reportStore.handleActions.bind(reportStore));

export default reportStore;