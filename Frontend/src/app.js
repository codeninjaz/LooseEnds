import React from 'react';
import Circular from './components/circular';
import SvgTest from './components/svgtest';
import Router from 'react-router';

require('./styles/font-awesome.min.css');
require('./styles/style.scss');

//Application root, handles routing
let DefaultRoute = Router.DefaultRoute;
// let NotFoundRoute = Router.NotFoundRoute;
// let Link = Router.Link;
let Route = Router.Route;
let RouteHandler = Router.RouteHandler;
let Redirect = Router.Redirect;

let routes = (
  <Route handler={App} path="/">
    <Route name="circular" handler={Circular} />
    <Route name="svg" handler={SvgTest} />
    <DefaultRoute handler={Circular} />
    <Redirect from="home" to="/" />
  </Route>
);
    // <NotFoundRoute handler={App}/>

class App extends React.Component {
}

Router.run(routes, Router.HistoryLocation, function(Handler){
    React.render(<Handler />, document.getElementById('app'));
});

