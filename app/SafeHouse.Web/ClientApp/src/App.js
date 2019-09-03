import React from 'react';
import {BrowserRouter as Router, Route} from 'react-router-dom';

import Aux from './hoc/Hoc';
import Login from './screens/Login';
import NewCarton from './screens/NewCarton';
import Record from './screens/Record';
import Records from './screens/Records';
import Dashboard from './screens/Dashboard';
import Notifications from './screens/Notifications';
import Reports from './screens/Reports';

const App = () => {
	return (
		<Aux>
			<Router>
				<Route exact path="/login" component={Login} />
				<Route exact path="/add" component={NewCarton} />
				<Route exact path="/users" component={Dashboard} />
				<Route exact path='/users/:id' component={NewCarton} />
				<Route exact path='/records' component={Records} />
				<Route exact path='/records/:id' component={Record} />
				<Route exact path='/reports' component={Reports} />
				<Route exact path="/" component={Notifications} />
			</Router>
		</Aux>
	);
}

export default App;
