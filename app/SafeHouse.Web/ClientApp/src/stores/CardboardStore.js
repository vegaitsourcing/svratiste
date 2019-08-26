import {EventEmitter} from 'events';

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
	getCartons() {
		return this.cartons;
	}
	getNumOfPages() {
		return this.totalPages;
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
};

const cardboardStore = new CardboardStore();
dispatcher.register(cardboardStore.handleActions.bind(cardboardStore));

export default cardboardStore;