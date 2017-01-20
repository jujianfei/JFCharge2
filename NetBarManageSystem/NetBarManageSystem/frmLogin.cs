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
            string username = txtUserName.Text.Trim(); //获取界面输入的用户名
            string password = txtPassword.Text.Trim(); //获取界面输入的密码
            Entity.Users users = new Entity.Users();
            users.username = username;
            users.password = password;

            if (username == "") //判断用户名是否为空
            {
                MessageBox.Show("请输入用户名！", "温馨提示");
            }
            else 
            {
                Facade.Users user=new Facade.Users();
                bool result = user.username(username);
                if (result == false) //判断用户是否存在
                {
                    MessageBox.Show("您输入的用户名不存在！", "温馨提示");
                }
            }
        }
    }
}
