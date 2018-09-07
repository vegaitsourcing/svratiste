import React, { Component } from 'react';


class Login extends Component {
    constructor(props) {
        super(props);

        this.state = {
            username: '',
            password: ''
        };
    }

    render() {
        return (
            <h2>Login</h2>
        );
    };
}

export default Login;