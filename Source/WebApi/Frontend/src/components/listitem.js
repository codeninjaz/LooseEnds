import React from 'react';
import {Grid, Row, Col} from 'react-bootstrap';
import ImageList from './imagelist';

export default class DummyItem extends React.Component {
    constructor(props) {
        super(props);
    }

    render(){
        let item = this.props.item;
        return(
        <Grid>
            <Row>
                <Col md={12}>
                    <h2 tooltip={item.id}>{item.name}</h2>
                </Col>
            </Row>
            <Row>
                <Col xs={12} md={4}>
                    {item.price}kr / {item.unit}
                </Col>
                <Col xs={12} md={8}>
                    {item.description}
                </Col>
            </Row>
            <Row>
                <Col xs={12} md={12}>
                    <ImageList images={item.images} />
                </Col>
            </Row>
        </Grid>
        );
    }
}
