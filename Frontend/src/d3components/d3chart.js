import d3 from 'd3';

export default class d3Chart{
    scales(el, domain) {
        if (!domain) {
            return null;
        }

        let width = el.offsetWidth;
        let height = el.offsetHeight;
        return {
            x: d3.scale.linear()
                .range([0, width])
                .domain(domain.x),

            y: d3.scale.linear()
                .range([height, 0])
                .domain(domain.y),

            z: d3.scale.linear()
                .range([5, 20])
                .domain([1, 10])
        };
    }
    drawPoints(el, scales, data) {
        let g = d3.select(el).selectAll('.d3-points');

        let point = g.selectAll('.d3-point')
            .data(data, function(d) {
                return d.id;
            });

        // ENTER
        point.enter().append('circle')
            .attr('class', 'd3-point');

        // ENTER & UPDATE
        point.attr('cx', function(d) {
                return scales.x(d.x);
            })
            .attr('cy', function(d) {
                return scales.y(d.y);
            })
            .attr('r', function(d) {
                return scales.z(d.z);
            });
        point.exit()
            .remove();
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