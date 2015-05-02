import React from 'react';
import d3Circle from '../d3components/d3circle';

export default class Chart extends React.Component{
    constructor() {
      super();
      this.myCircle = new d3Circle();
    }
    componentDidMount(){
      var el=React.findDOMNode(this);
      this.myCircle.create(el)
    }
    render(){
      return(
        <div className="circle" width="300" height="300" backgroundColor="#E43232"></div>
      )
    }
}
