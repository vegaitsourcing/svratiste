import React from 'react';
import {BrowserRouter as Router, Route} from 'react-router-dom';

import Auxiliary from './hoc/Auxiliary';
import Login from './screens/Login';
import NewCarton from './screens/NewCarton';
import RecordById from './screens/RecordById';
import RecordByCartonId from './screens/RecordByCartonId';
import Records from './screens/Records';
import Dashboard from './screens/Dashboard';
import Notifications from './screens/Notifications';
import Reports from './screens/Reports';
import FirstEvaluationPrint from './components/evaluation/FirstEvaluationPrint';
import EvaluationPrint from './components/evaluation/EvaluationPrint';
import IndividualPlanPrint from './components/evaluation/IndividualPlanPrint';

const App = () => {
	return (
		<Auxiliary>
			<Router>
				<Route exact path="/login" component={Login} />
				<Route exact path="/add" component={NewCarton} />
				<Route exact path="/users" component={Dashboard} />
				<Route exact path='/users/:id' component={NewCarton} />
				<Route exact path='/records' component={Records} />
				<Route exact path='/records/id/:id/:cartonId' component={RecordById} />
				<Route exact path='/records/carton-id/:id' component={RecordByCartonId} />
				{/* <Route exact path='/reports' component={Reports} /> */}
				<Route exact path='/first-evaluation/print/:id' component={FirstEvaluationPrint} />
				<Route exact path='/evaluation/print/:id' component={EvaluationPrint} />
				<Route exact path='/individual-plan/print/:id' component={IndividualPlanPrint} />
				<Route exact path="/" component={Notifications} />
			</Router>
		</Auxiliary>
	);
}

export default App;
