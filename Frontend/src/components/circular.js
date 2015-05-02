import React from 'react';
import d3Circle from '../d3components/d3circle';

export default class Chart extends React.Component{
    constructor() {
      super();
      this.myCircle = new d3Circle();
    }
    getChartState() {
      return {
        data: this.props.data,
        domain: this.props.domain,
        bgcolor: this.props.bgcolor
      };
    }
    componentDidMount(){
      var el=React.findDOMNode(this);
      this.myCircle.create(el, this.props, this.getChartState())
    }
    render(){
      return(
        <div className="circle"></div>
      )
    }
}
