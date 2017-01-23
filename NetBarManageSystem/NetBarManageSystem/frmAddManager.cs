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
    public partial class frmAddManager : Form
    {
        public frmAddManager()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)  //单击确定按钮
        {
            Entity.Login user = new Entity.Login();
            user.username = txtUserName.Text.Trim();
            user.password = txtPassword.Text.Trim();
            user.level = "收银员";
            user.status = "允许登录";
            //判断用户是否已经存在
            Facade.LoginUsers fuser = new Facade.LoginUsers();
            bool result = fuser.username(user.username);
            if (result == true) //判断用户是否存在
            {
                MessageBox.Show("您输入的用户名已存在！", "温馨提示");
            }
            else
            {
                int result2 = fuser.addusers(user);
                if (result2 > 0)
                {
                    MessageBox.Show("添加用户成功！", "温馨提示");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //删除用户按钮
        {
            Entity.Login user = new Entity.Login();
            user.username = txtUserName.Text.Trim();
            user.password = txtPassword.Text.Trim();
            Facade.LoginUsers fuser = new Facade.LoginUsers();
            int result = fuser.deleteusers(user);
            if (result>0)
            {
                MessageBox.Show("删除成功！","温馨提示");
            }
        }
    }
}
