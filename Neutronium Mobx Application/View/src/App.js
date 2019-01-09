import React, { Component } from 'react';
import { observer } from 'mobx-react';
import logo from './logo.svg';
import './App.css';

@observer
export default class App extends Component {
  constructor(props) {
    super(props);
  }

  render() {
    const vm = this.props.viewModel;
    return (
      <div id="app" className="fluid container">
        <div className="jumbotron logo">
          <img src={logo} className="App-logo" alt="logo" />
          <p>{vm.Message}</p>
        </div>
      </div>
    );
  }
}
