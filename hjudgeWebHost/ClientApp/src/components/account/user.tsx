import * as React from 'react';
import { Item, Popup, Input, Divider, Header, Icon, Table, Label, Form, Placeholder, InputOnChangeData, SemanticCOLORS, Grid } from 'semantic-ui-react';
import { UserInfo } from '../../interfaces/userInfo';
import { setTitle } from '../../utils/titleHelper';

interface UserProps {
  userInfo: UserInfo,
  refreshUserInfo: (() => void),
  openPortal: ((header: string, message: string, color: SemanticCOLORS) => void)
}

export default class User extends React.Component<UserProps> {
  constructor(props: UserProps) {
    super(props);
    this.confirmEmail = this.confirmEmail.bind(this);
    this.confirmPhoneNumber = this.confirmPhoneNumber.bind(this);
  }

  componentDidMount() {
    setTitle('门户');
  }

  confirmEmail() {

  }

  confirmPhoneNumber() {
    alert('gggg');
  }

  handleChange(event: React.ChangeEvent<HTMLInputElement>, data: InputOnChangeData) {
    console.log(event);
    console.log(data);
  }

  showUserInfo() {
    return <>
      <Item.Group>
        <Item>
          <div>
            <Popup
              position='bottom center'
              trigger={<Item.Image size='small' src={`/Account/UserAvatar?userId=${this.props.userInfo.userId}`} circular style={{ cursor: 'pointer' }} onClick={() => alert('hh')} />}
              content='点击更换头像'
            />
          </div>
          <Item.Content>
            <Item.Header>{this.props.userInfo.userName}</Item.Header>
            <Item.Meta><Label>{this.props.userInfo.privilege === 1 ? '管理员' :
              this.props.userInfo.privilege === 2 ? '教师' :
                this.props.userInfo.privilege === 3 ? '助教' :
                  this.props.userInfo.privilege === 4 ? '学生' :
                    this.props.userInfo.privilege === 5 ? '黑名单' : '未知'}</Label> 经验：{this.props.userInfo.experience}，金币：{this.props.userInfo.coins}</Item.Meta>
            <Item.Description>

              <Grid columns={2} relaxed='very' stackable>
                <Grid.Column>
                  <Form id='infoForm'>
                    <Divider horizontal>
                      <Header as='h4'>
                        <Icon name='tag'></Icon>
                        基本信息
                      </Header>
                    </Divider>
                    <Table definition>
                      <Table.Body>
                        <Table.Row>
                          <Table.Cell textAlign='center' width={4}>姓名</Table.Cell>
                          <Table.Cell><Input name='name' onChange={this.handleChange} fluid defaultValue={this.props.userInfo.name} /></Table.Cell>
                        </Table.Row>
                        <Table.Row>
                          <Table.Cell textAlign='center' width={4}>邮箱</Table.Cell>
                          <Table.Cell><Input name='email' onChange={this.handleChange} fluid defaultValue={this.props.userInfo.email} type='email' action={this.props.userInfo.emailConfirmed ? null : { color: 'blue', content: '验证', onClick: this.confirmEmail }} /></Table.Cell>
                        </Table.Row>
                        <Table.Row>
                          <Table.Cell textAlign='center' width={4}>手机</Table.Cell>
                          <Table.Cell><Input name='phoneNumber' onChange={this.handleChange} fluid defaultValue={this.props.userInfo.phoneNumber} action={this.props.userInfo.phoneNumberConfirmed ? null : { color: 'blue', content: '验证', onClick: this.confirmPhoneNumber }} /></Table.Cell>
                        </Table.Row>
                      </Table.Body>
                    </Table>
                    <Divider horizontal>
                      <Header as='h4'>
                        <Icon name='hashtag'></Icon> 其他信息
                      </Header>
                    </Divider>
                    <Table definition>
                      <Table.Body>
                        {
                          this.props.userInfo.otherInfo.map((v, i) =>
                            <Table.Row key={i}>
                              <Table.Cell textAlign='center' width={4}>{v.name}</Table.Cell>
                              <Table.Cell><Input onChange={this.handleChange} name={v.key} fluid defaultValue={v.value} /></Table.Cell>
                            </Table.Row>
                          )
                        }
                      </Table.Body>
                    </Table>
                  </Form>
                </Grid.Column>

                <Grid.Column>
                  <Divider horizontal>
                    <Header as='h4'>
                      <Icon name='pencil'></Icon>
                      做题记录
                    </Header>
                  </Divider>
                  <Header as='h5'>已通过的题目</Header>
                  <Placeholder>
                    <Placeholder.Paragraph>
                      <Placeholder.Line />
                      <Placeholder.Line />
                      <Placeholder.Line />
                      <Placeholder.Line />
                    </Placeholder.Paragraph>
                  </Placeholder>
                  <Header as='h5'>已尝试的题目</Header>
                  <Placeholder>
                    <Placeholder.Paragraph>
                      <Placeholder.Line />
                      <Placeholder.Line />
                      <Placeholder.Line />
                      <Placeholder.Line />
                    </Placeholder.Paragraph>
                  </Placeholder>
                </Grid.Column>
              </Grid>
            </Item.Description>
          </Item.Content>
        </Item>
      </Item.Group>
    </>;
  }

  render() {
    let notSignedIn =
      <>
        <Header as='h1'>出现错误</Header>
        <Header as='h4' color='red'>请先登录账户</Header>
      </>;
    let loading = <>
      <Placeholder>
        <Placeholder.Header image>
          <Placeholder.Line />
          <Placeholder.Line />
        </Placeholder.Header>
        <Placeholder.Paragraph>
          <Placeholder.Line />
          <Placeholder.Line />
          <Placeholder.Line />
        </Placeholder.Paragraph>
      </Placeholder>
    </>
    return this.props.userInfo.succeeded ? ((!this.props.userInfo.signedIn) ? notSignedIn : this.showUserInfo()) : loading;
  }
}