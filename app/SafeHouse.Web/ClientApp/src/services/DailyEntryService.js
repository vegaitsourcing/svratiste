

export function correctWorkshop(workshops, workshopType, name, value) {
    return workshops.map((workshop) => {
        if (workshop.WorkshopType !== workshopType) {
            return workshop;
        }

        return {...workshop, [name]: value};
    });
}