import React from 'react';
import { Switch, Route } from 'react-router-dom';

import Cardboard from "../../views/Cardboard";

const AppRouter = () => {
    return (
        <Switch>
            {/* Sections */}
            <Route exact path="/" component={Cardboard} />
        </Switch>
    );
};

export default AppRouter;