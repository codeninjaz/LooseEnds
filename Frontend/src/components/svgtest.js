import React from 'react';
import Classnames from 'classnames';
import d3Circle from '../d3components/d3circle';
import uuid from 'uuid';

export default class SvgTest extends React.Component{
    constructor() {
      super();
      this.state = {
        radius: 20,
        on: false,
        circles: []
      }
    }
    handleSubCircleClick(key, e) {
      console.log('key', key);
      console.log('e', e);
    }
    handleClick(e) {
      e.preventDefault();
      e.stopPropagation();
      this.setState({
        on: !this.state.on
      })
    }
    getRandom(min, max) {
      return Math.round(Math.random() * (max - min) + min);
    }
    makeCircle(x, y, r, k) {
      let color = 'rgba(' + this.getRandom(0,255) + ',' + this.getRandom(0,255) + ',' + this.getRandom(0,255) + ',' + this.getRandom(0,255) + ')';
      let key = uuid.v4();
      return (
        <circle key={key} cx={x} cy={y} r={r} fill={color} onClick={this.handleSubCircleClick.bind(this, key)}/>
      );
    }
    makeRandomCircles() {
      let cs = [];
      for (let i = 0; i < this.getRandom(5, 30); i++) {
        let x = this.getRandom(0, 100);
        let y = this.getRandom(0, 100);
        let r = this.getRandom(0, 10);
         cs.push(this.makeCircle(x, y, r, i));
      }
      return cs;
    }
    render() {
      let cl = Classnames({
        circle: true,
        green: this.state.on,
        blue: !this.state.on
      });
      return (
        <svg xmlns   ="http://www.w3.org/2000/svg"
             width   ="500"
             height  ="500"
             viewBox ="0 0 100 100"
             fill="#EFEFEF">
          <circle className={cl} cx="50" cy="50" r={this.state.radius} fill="#3BAAFF" onClick={this.handleClick.bind(this)}/>
          {this.state.on ? this.makeRandomCircles():null}
        </svg>
      )
    }
}
