import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

import * as LoginActions from '../../actions/LoginActions';
import LoginStore from '../../stores/LoginStore';

import * as authToken from '../../authToken';

class LoginForm extends Component {
    constructor(props) {
        super(props);

        this.state = {
            Username: '',
            Password: ''
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.loginClick = this.loginClick.bind(this);

        this.fetchEdToken = this.fetchEdToken.bind(this);
    }

    componentWillMount() {
        if (authToken.getToken()) {
            this.props.history.push('/');
        }
        LoginStore.on("fetched_token", this.fetchEdToken);
    }

    componentWillUnmount() {
        LoginStore.removeListener("fetched_token", this.fetchEdToken);
    }

    fetchEdToken() {
        this.props.history.push('/');
    }

    handleInputChange(event) {
        const { target } = event;
        const { name, value } = target;

        this.setState({ [name]: value });
    }

    loginClick() {
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

export default withRouter(LoginForm);