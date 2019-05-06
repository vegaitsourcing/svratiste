import React, { Component } from 'react';

import StaticHTML from './StaticHTML';

import * as EvaluationActions from '../../../actions/EvaluationActions';

import EvaluationStore from '../../../stores/EvaluationStore';


class FirstEvaluationPrint extends Component {
    constructor(props) {
        super(props);

        this.state = {
            evaluation: {
                carton: {}
            }
        };

        this.redirectToLogin = this.redirectToLogin.bind(this);
        this.getEvaluation = this.getEvaluation.bind(this);
    }

    componentWillMount() {
        EvaluationStore.on("fetched_first_evaluation", this.getEvaluation);
        EvaluationStore.on("unauthorized", this.redirectToLogin);
    }

    componentDidMount() {
        const { id } = this.props.match.params;
        EvaluationActions.getFirstEvaluation(id);
    }

    componentWillUnmount() {
        EvaluationStore.removeListener("fetched_first_evaluation", this.getEvaluation);
        EvaluationStore.removeListener("unauthorized", this.redirectToLogin);
    }

    redirectToLogin() {
        localStorage.clear();
        this.props.history.push('/login');
    }

    getEvaluation() {
        let evaluation = EvaluationStore.getFirstEvaluation();
        console.log(evaluation);
        this.setState({ evaluation });
    }

    render() {
        return (
            <main className="main">
                <StaticHTML 
                    evaluation={this.state.evaluation} />
            </main>
        );
    };
}

export default FirstEvaluationPrint;