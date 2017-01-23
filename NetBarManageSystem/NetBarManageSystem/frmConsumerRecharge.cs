/*
 *==================
 *创建人：琚建飞
 *创建时间：2017/1/23 10:21:01
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
    public partial class frmConsumerRecharge : Form
    {
        public frmConsumerRecharge()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmConsumerRecharge_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e) //确定充值按钮
        {
            string cardno = txtCardno.Text.Trim();
            int money = Convert.ToInt32(txtMoney.Text.Trim());
            Facade.Consumers cs = new Facade.Consumers();
            int result = cs.Recharge(cardno,money);
            if (result>0)
            {
                MessageBox.Show("充值成功！","温馨提示");
            }
        }
    }
}
