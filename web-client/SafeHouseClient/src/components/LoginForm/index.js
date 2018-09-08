import React, { Component } from 'react';
import * as LoginActions from '../../actions/LoginActions';

class LoginForm extends Component {
    constructor(props) {
        super(props);

        this.state = {
            Username: '',
            Password: ''
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.loginClick = this.loginClick.bind(this);
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    loginClick()
    {
        LoginActions.login(this.state);
    }

    render () {
        return (
            <main className="main main-page">
                <div className="login-panel">
                    <div className="panel">
                        <h3>username:</h3>
                        <input name="Username" type="text" onChange={this.handleInputChange} />
                        <h3>password:</h3>
                        <input name="Password" type="password" onChange={this.handleInputChange} />
                        <button type="button" className="btn btn-light my-2 my-lg-0 btn-inverse login" onClick={this.loginClick}>Login</button>
                    </div>
                </div>
            </main>
        );
    };
}

export default LoginForm;