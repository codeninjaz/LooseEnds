import React from 'react';
import {Nav} from 'react-bootstrap';
import {ButtonLink} from 'react-router-bootstrap';

export default class Menu extends React.Component{
    constructor(){
        super();
    }
    render(){
        return (
            <div>
                <Nav navbar bsStyle="pills" className="navbar-inverse navbar-fixed-top">
                    <ButtonLink to="/"><i className="fa fa-home" /> Hem</ButtonLink>
                    <ButtonLink to="/other"><i className="fa fa-subway" /> Annan sida</ButtonLink>
                </Nav>
               	<div className="BS.container" style={{paddingTop:'65px'}}>
                </div>
            </div>
        );
    }
}