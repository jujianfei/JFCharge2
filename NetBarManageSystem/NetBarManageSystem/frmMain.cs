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
            frmAddManager f = new frmAddManager();
            f.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) //点击窗体右上角红叉
        {
            ExitSystem();
        }

        private void frmMain_Load(object sender, EventArgs e) //窗体加载事件
        {
            if (Entity.GoAnyWhere.level.Trim() == "用户")
            {
                panel2.Hide();
                panel3.Hide();
            }
            else if (Entity.GoAnyWhere.level.Trim() == "收银员")
            {
                panel1.Hide();
                panel3.Hide();
            }
            else
            {
                panel1.Hide();
                panel2.Hide();
            }
        }

        private void btnAddUsers_Click(object sender, EventArgs e) //收银员添加消费用户
        {
            frmAddUsers f = new frmAddUsers();
            f.ShowDialog();
        }

        private void txtCheck_Click(object sender, EventArgs e)  //查看所有消费者数据
        {
            frmConsumersInfo f = new frmConsumersInfo();
            f.ShowDialog();
        }

        private void btnRecharge_Click(object sender, EventArgs e) //单击用户充值按钮
        {
            frmConsumerRecharge f = new frmConsumerRecharge();
            f.ShowDialog();
        }
    }
}
