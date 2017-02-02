/*
 *==================
 *创建人：琚建飞
 *创建时间：2017/2/2 9:36:04
 *说明：
 *==================
 */
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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }
        
        //点击收入按钮，从数据库中读取注册时收的钱和充值时收的钱
        private void button1_Click(object sender, EventArgs e) 
        {

        }

        //点击退款按钮，从数据库中读取退款时收的钱
        private void button2_Click(object sender, EventArgs e)
        {
            Facade.Consumers cs=new Facade.Consumers();
            DataTable dt=cs.ReturnBackInfo();
            dataGridView2.DataSource = dt;
        }

        //点击注册按钮，返回一张注册记录表
        private void btnRegist_Click(object sender, EventArgs e)
        {
            Facade.Consumers cs = new Facade.Consumers();
            DataTable dt = cs.ReturnRegister();
            dataGridView1.DataSource = dt;
        }

        //点击充值按钮，返回一张充值记录表
        private void button4_Click(object sender, EventArgs e)
        {
            Facade.Consumers cs = new Facade.Consumers();
            DataTable dt = cs.ReturnRecharge();
            dataGridView3.DataSource = dt;
        }

        //单击总利润按钮，计算收入和支出，并得出利润值
        private void button3_Click(object sender, EventArgs e)
        {
            int result;
            int RechargeSR = Convert.ToInt32(txtRechargeSum.Text.Trim());
            int RegisterSR = Convert.ToInt32(txtRegistSum.Text.Trim());
            int Back = Convert.ToInt32(txtBackSum.Text.Trim());
            result = RechargeSR + RegisterSR - Back;
            txtGain.Text = Convert.ToString(result);
        }

        //点击注册金额总数按钮
        private void button6_Click(object sender, EventArgs e)
        {
            Facade.Consumers cs = new Facade.Consumers();
            txtRegistSum.Text = Convert.ToString(cs.ReturnRegisterSum());
        }

        //点击退款金额总数按钮
        private void button7_Click(object sender, EventArgs e)
        {
            Facade.Consumers cs = new Facade.Consumers();
            txtBackSum.Text = Convert.ToString(cs.ReturnBackSum());
        }

        //点击充值金额总数按钮
        private void button8_Click(object sender, EventArgs e)
        {
            Facade.Consumers cs = new Facade.Consumers();
            txtRechargeSum.Text = Convert.ToString(cs.ReturnRechargeSum());
        }
    }
}
