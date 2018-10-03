import React from 'react';

import Header from './components/Header';
import AppRouter from './components/Router';

const App = () => {
    return (
        <div className="content">
            <Header />

            <AppRouter />
        </div>
    );
}

export default App;
