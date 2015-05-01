import React from 'react';
import Ctrl from './components/controllerview1';
import OtherPage from './components/controllerview2';
import Router from 'react-router';
import BS from 'react-bootstrap';
import RBS from 'react-router-bootstrap';

require('./styles/bootstrap.min.css');
require('./styles/font-awesome.min.css');
require('./styles/style.scss');

//Application root, handles routing
var DefaultRoute = Router.DefaultRoute;
// var NotFoundRoute = Router.NotFoundRoute;
// var Link = Router.Link;
var Route = Router.Route;
var RouteHandler = Router.RouteHandler;
var Redirect = Router.Redirect;
    // <Route name="about" handler={About} />
    // <Route name="users" handler={Users}>
    //   <Route name="recent-users" path="recent" handler={RecentUsers} />
    //   <Route name="user" path="/user/:userId" handler={User} />
    //   <NotFoundRoute handler={UserRouteNotFound}/>
    // </Route>

var routes = (
  <Route handler={App} path="/">
    <Route name="ctrl" handler={Ctrl} />
    <Route name="other" handler={OtherPage} />
    <DefaultRoute handler={Ctrl} />
    <Redirect from="home" to="/" />
  </Route>
);
    // <NotFoundRoute handler={App}/>

class App extends React.Component {
}

Router.run(routes, Router.HistoryLocation, function(Handler){
    React.render(<Handler />, document.getElementById('app'));
});

