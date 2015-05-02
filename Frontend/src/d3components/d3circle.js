import d3 from 'd3';

export default class d3Chart{
    scales(el, domain) {
        if (!domain) {
          var svg = d3.select(el).append('svg')
            .attr('class', 'd3')
            .attr('width', props.width)
            .attr('height', props.height)
            .style('background-color', props.backgroundColor);

        svg.append('g')
            .attr('class', 'd3-points');

        this.update(el, state);
        }
}
