import React from 'react';
import d3Chart from '../d3components/d3chart';

export default class Chart extends React.Component{
    constructor(){
        super();
        this.myChart = new d3Chart();
    }
    getChartState() {
	    return {
	      data: this.props.data,
	      domain: this.props.domain,
	      bgcolor: this.props.bgcolor
	    };
	 }
    componentDidMount(){
    	var el = React.findDOMNode(this);
    	console.log('this.myChart', this.myChart.create );
	    this.myChart.create(el, {
	      width: '600px',
	      height: '300px',
	      backgroundColor: this.props.bgcolor
	    }, this.getChartState());
    }
   	componentDidUpdate() {
	    var el = React.findDOMNode(this);
	    this.myChart.update(el, this.getChartState());
	}
	componentWillUnmount() {
	    var el = React.findDOMNode(this);
	    this.myChart.destroy(el);
  	}
    render(){
        return (
			<div className="Chart"></div>
        );
    }
}

  Chart.propTypes = {
    data: React.PropTypes.array,
    domain: React.PropTypes.object,
    bgcolor: React.PropTypes.string
  }