import React from 'react';
import { Switch, Route } from 'react-router-dom';

import Cardboard from "../../views/Cardboard";
import Login from "../../views/Login";

const AppRouter = () => {
    return (
        <Switch>
            {/* Cardboard */}
            <Route exact path="/" component={Cardboard} />

            {/* Login */}
            <Route exact path="/login" component={Login} />
        </Switch>
    );
};

export default AppRouter;