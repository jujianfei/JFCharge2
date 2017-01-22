using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetBarManageSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Facade.Users user = new Facade.Users();
            string username = txtUserName.Text.Trim(); //获取界面输入的用户名
            string password = txtPassword.Text.Trim(); //获取界面输入的密码
            Entity.GoAnyWhere.id = username;   // 将登陆id赋值给全局变量
            Entity.Login users = new Entity.Login();
            users.username = username;
            users.password = password;

            if (username == "") //判断用户名是否为空
            {
                MessageBox.Show("请输入用户名！", "温馨提示");
            }
            else if (password == "") //判断密码是否为空
            {
                MessageBox.Show("请输入密码！", "温馨提示");
            }
            else
            {
                bool result = user.username(username);
                if (result == false) //判断用户是否存在
                {
                    MessageBox.Show("您输入的用户名不存在！", "温馨提示");
                }
                else
                {
                    //判断密码是否正确
                    Facade.Users pwd = new Facade.Users();
                    bool result2 = pwd.password(users);
                    if (result2 == true)
                    {
                        //判断用户的类型
                        string result3 = user.userlevel(username);
                        Entity.GoAnyWhere.level = result3;
                        this.DialogResult = DialogResult.OK;  //上面的执行成功则显示主窗体
                    }
                    else
                    {
                        MessageBox.Show("密码错误，请重新输入！", "温馨提示");
                    }
                }
            }
        }
    }
}
