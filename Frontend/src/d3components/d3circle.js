import d3 from 'd3';

export default class d3Chart{
    scales(el, domain) {
      if (!domain) {
        var svg = d3.select(el).append('svg')
          .attr('class', 'd3')
          .attr('width', 300)
          .attr('height', 300)
          .style('background-color', '#D44B4B');

        svg.append('g')
            .attr('class', 'd3-points');

        this.update(el, state);
      }
    }
    create(el, props, state) {
      var svg = d3.select(el).append('svg')
        .attr('class', 'd3')
        .attr('width', props.width)
        .attr('height', props.height)
        .style('background-color', props.backgroundColor);

      svg.append('g')
          .attr('class', 'd3-points');

      this.update(el, state);
    }
    update(el, state) {
      // Re-compute the scales, and render the data points
      var scales = this.scales(el, state.domain);
      this.drawPoints(el, scales, state.data);
      d3.select(el).select('svg')
        .transition()
        .duration(500)
        .style('background-color', state.bgcolor);
    }
    destroy(el) {
      // Any clean-up would go here
      // in this example there is nothing to do
    }
}
