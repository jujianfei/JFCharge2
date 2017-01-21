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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //退出系统按钮
        {
            ExitSystem();
        }

        private void ExitSystem() //退出系统给出询问提示
        {
            if (DialogResult.Yes == MessageBox.Show("是否退出系统？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e) //添加用户按钮
        {
            frmAddUsers f = new frmAddUsers();
            f.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) //点击窗体右上角红叉
        {
            ExitSystem();
        }
    }
}
