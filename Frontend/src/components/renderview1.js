import React from 'react';
import _  from 'lodash';
import {ListGroup, ListGroupItem} from 'react-bootstrap';
import ListItem from './listitem';

//This is a render-view only rendering allowed
export default class RenderView1 extends React.Component {
    constructor(props) {
        super(props);
    }

    itemList(){
        var listItems = [];
        _.forEach(this.props.data, function(item){
            listItems.push(
                <ListGroupItem key={item.id}>
                    <ListItem item={item} />
                </ListGroupItem>
                );
        });
        return listItems;
    }

    render(){
        return(
        <div>
            <ListGroup>
                {this.itemList()}
            </ListGroup>
        </div>
        );
    }
}