import { EventEmitter } from 'events';

import dispatcher from '../dispatcher';


class EnumerationStore extends EventEmitter {
    constructor(props) {
        super(props);

        this.mediationWritings = [];
        this.mediationSpeakings = [];
        this.lifeSkills = [];
        this.workshopTypes = [];

        this.changeStructure = this.changeStructure.bind(this);
    }

    getMediationWritings() {
        return this.mediationWritings;
    }

    getMediationSpeakings() {
        return this.mediationSpeakings;
    }

    getLifeSkills() {
        return this.lifeSkills;
    }

    getWorkshopTypes() {
        return this.workshopTypes;
    }

    changeStructure(data) {
        return data.map((item) => {
            return {
                value: item.value, 
                label: item.name,
                name: item.name
            };
        });
    }

    handleActions(action) {
        switch(action.type) {
            case "FETCHED_MEDIATION_WRITINGS":
                this.mediationWritings = action.payload;
                this.emit("fetched_mediation_writings");
                break;
            case "FETCHED_MEDIATION_SPEAKINGS":
                this.mediationSpeakings = action.payload;
                this.emit("fetched_mediation_speakings");
                break;
            case "FETCHED_LIFE_SKILLS":
                this.lifeSkills = this.changeStructure(action.payload);
                this.emit("fetched_life_skills");
                break;
            case "FETCHED_WORKSHOP_TYPES":
                this.workshopTypes = this.changeStructure(action.payload);
                this.emit("fetched_workshop_types");
                break;
            default:
        }
    }
}

const enumerationStore = new EnumerationStore();
dispatcher.register(enumerationStore.handleActions.bind(enumerationStore));

export default enumerationStore;