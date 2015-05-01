import React from 'react';
import RenderView from './renderview2';
import Menu from './menu';
import Store from '../data/datastore1';

//This is the controllerview for RenderView view, only data retrieval etc.
export default class Ctrl extends React.Component{
	constructor(){
		super();
        this.state = this.getState();
	}
	getState(){
        return{
            items: Store.getItems()
        };
    }
    onStoreChange(){
        this.setState(this.getState());
    }
    componentDidMount(){
        Store.addChangeListener(this.onStoreChange.bind(this));
    }
    componentWillUnmount(){
        Store.removeChangeListener(this.onStoreChange.bind(this));
    }

	render(){
		console.log('controllerview2 render');
		return(
			<div>
				<Menu />
               	<div className="BS.container">
					<RenderView data={this.state.items}/>
                </div>
			</div>
			);
	}
}
