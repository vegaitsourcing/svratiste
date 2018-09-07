import React, { Component } from 'react';


class LoginForm extends Component {
    constructor(props) {
        super(props);

        this.state = {
            username: '',
            password: ''
        };
    }

    render () {
        return (
            <main className="main main-page">
                <div className="login-panel">
                    <div className="panel">
                        <h3>username:</h3>
                        <input type="text" />
                        <h3>password:</h3>
                        <input type="text" />
                        <button type="button" className="btn btn-light my-2 my-lg-0 btn-inverse login">Login</button>
                    </div>
                </div>
            </main>
        );
    };
}

export default LoginForm;