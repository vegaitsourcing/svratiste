import React from 'react';
import { Switch, Route } from 'react-router-dom';

import Login from "../../views/Login";

import Cardboard from "../../views/Cardboard";
import Reports from "../../views/Reports";
import Evaluation from "../../views/Evaluation";

const AppRouter = () => {
    return (
        <Switch>
            {/* Cardboard */}
            <Route exact path="/" component={Cardboard} />

            {/* Reports */}
            <Route exact path="/reports" component={Reports} />

            {/* Evaluation */}
            <Route exact path="/evaluation" component={Evaluation} />

            {/* Login */}
            <Route exact path="/login" component={Login} />
        </Switch>
    );
};

export default AppRouter;