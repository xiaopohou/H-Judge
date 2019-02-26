﻿import * as React from "react";
import { Route, Switch } from 'react-router-dom';
import Layout from './components/layout/layout';
import 'semantic-ui-css/semantic.min.css';
import NotFound from './components/notfound/notfound';
import About from './components/about/about';
import Home, { PropsInterface } from './components/home/home';
import { UserInfo } from './interfaces/userInfo'
import { Get } from "./utils/requestHelper";
import User from "./components/account/user";
import { TransitionablePortal, Header, Segment, Divider, SemanticCOLORS, Icon } from "semantic-ui-react";

interface PortalState {
  open: boolean,
  header: string,
  message: string,
  color: SemanticCOLORS
}

interface AppState {
  userInfo: UserInfo,
  portal: PortalState
}

export default class App extends React.Component<{}, AppState> {
  constructor(props: {}) {
    super(props);
    
    this.state = {
      portal: {
        open: false,
        header: '',
        message: '',
        color: 'black'
      },
      userInfo: {
        email: '',
        emailConfirmed: false,
        phoneNumberConfirmed: false,
        name: '',
        otherInfo: [],
        phoneNumber: '',
        privilege: 0,
        userId: '',
        userName: '',
        signedIn: false,
        experience: 0,
        coins: 0
      }
    }

    this.refreshUserInfo = this.refreshUserInfo.bind(this);
    this.openPortal = this.openPortal.bind(this);
    this.closePortal = this.closePortal.bind(this);

    this.refreshUserInfo();
  }

  openPortal(header: string, message: string, color: SemanticCOLORS) {
    if (this.state.portal.open) {
      this.setState({
        portal: {
          open: false
        }
      } as AppState);
    }
    process.nextTick(() => {
      this.setState({
        portal: {
          open: true,
          header: header,
          message: message,
          color: color
        }
      } as AppState);
    })
  }

  closePortal() {
    this.setState({
      portal: {
        open: false
      }
    } as AppState);
  }

  refreshUserInfo() {
    Get('/Account/UserInfo')
      .then(response => response.json())
      .then(data => {
        this.setState({
          userInfo: data
        } as AppState);
      })
      .catch(err => {
        this.openPortal('错误', '用户信息加载失败', 'red');
        console.error(err);
      });
  }

  render() {
    return (
      <>
        <Layout openPortal={this.openPortal} userInfo={this.state.userInfo} refreshUserInfo={this.refreshUserInfo}>
          <Switch>
            <Route
              exact
              path='/'
              render={(props) => <Home {...props} userInfo={this.state.userInfo} />}>
            </Route>
            <Route
              path='/problem'
              render={() => { return <p>problem</p>; }}>
            </Route>
            <Route
              path='/contest'
              render={() => { return <p>contest</p>; }}>
            </Route>
            <Route
              path='/group'
              render={() => { return <p>group</p>; }}>
            </Route>
            <Route
              path='/message'
              render={() => { return <p>message</p>; }}>
            </Route>
            <Route
              path='/status'
              render={() => { return <p>status</p>; }}>
            </Route>
            <Route
              path='/rank'
              render={() => { return <p>rank</p>; }}>
            </Route>
            <Route
              path='/discussion'
              render={() => { return <p>discussion</p>; }}>
            </Route>
            <Route
              path='/article'
              render={() => { return <p>article</p>; }}>
            </Route>
            <Route
              exact
              path='/about'
              component={About}>
            </Route>
            <Route
              path='/user'
              render={() => <User userInfo={this.state.userInfo} openPortal={this.openPortal} refreshUserInfo={this.refreshUserInfo} />}>
            </Route>
            <Route
              component={NotFound}>
            </Route>
          </Switch>
        </Layout>
        <TransitionablePortal open={this.state.portal.open} onClose={this.closePortal} transition={{ animation: 'drop', duration: 500 }}>
          <Segment style={{ bottom: '5em', position: 'fixed', right: '2em', zIndex: 1048576 }} color={this.state.portal.color} inverted>
            <Header>
              {this.state.portal.header}
              <div style={{ display: 'inline', cursor: 'pointer', float: 'right' }} onClick={this.closePortal}>
                <Icon name='close' size='small'></Icon>
              </div>
            </Header>
            <Divider />
            <p style={{ wordBreak: 'break-all', wordWrap: 'break-word', 'overflow': 'hidden', width: '20em' }}>{this.state.portal.message}</p>
          </Segment>
        </TransitionablePortal>
      </>
    );
  }
}
