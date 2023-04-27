import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
        <div>
            <h3 className="gotoText">Welcome to my ranking items application!</h3>
            <h3 className="gotoText">Please go to the Rank items tab.</h3>
      </div>
    );
  }
}
