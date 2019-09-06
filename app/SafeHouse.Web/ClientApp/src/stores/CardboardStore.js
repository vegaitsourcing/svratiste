import {EventEmitter} from 'events';

import dispatcher from '../dispatcher';

class CardboardStore extends EventEmitter {
	constructor(props) {
		super(props);
		this.carton = {};
		this.cartons = [];
		this.cartonsOverEighteen = [];
		this.totalPages = 1;
	}
	getCarton() {
		return this.carton;
	}
	getCartons() {
		return this.cartons;
	}
	getCartonsOverEighteen() {
		return this.cartonsOverEighteen;
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
			case "FETCHED_CARTONS_OVER_EIGHTEEN":
				this.cartonsOverEighteen = action.payload;
				this.emit("fetched_cartons_over_eighteen");
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