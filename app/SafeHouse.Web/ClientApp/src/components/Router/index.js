import React from 'react';
import { Switch, Route } from 'react-router-dom';

import Login from "../../views/Login";

import Cardboard from "../../views/Cardboard";
import Reports from "../../views/Reports";
import Evaluation from "../../views/Evaluation";

import FirstEvaluationPrint from "../PrintViews/FirstEvaluation"

const AppRouter = () => {
    return (
        <Switch>
            {/* Cardboard */}
            <Route exact path="/" component={Cardboard} />

            {/* Reports */}
            <Route exact path="/reports" component={Reports} />

            {/* Evaluation */}
            <Route exact path="/evaluation/:id" component={Evaluation} />

            {/* Print Firts Evaluation */}
            <Route exact path="/first-evaluation/print/:id" component={FirstEvaluationPrint} />

            {/* Login */}
            <Route exact path="/login" component={Login} />
        </Switch>
    );
};

export default AppRouter;