/*
 *==================
 *创建人：琚建飞
 *创建时间：2017/2/1 16:38:40
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
    public partial class frmConsumerBackMoney : Form
    {
        public frmConsumerBackMoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //点击查看用户余额按钮
        {
            string cardno = txtCardNo.Text.Trim();
            Facade.Consumers consumer = new Facade.Consumers();
            txtMoney.Text = consumer.LookMoney(cardno);
        }

        private void btnBackMoney_Click(object sender, EventArgs e) //点击退款按钮
        {
            //根据id清空其余额
            string cardno = txtCardNo.Text.Trim();
            Facade.Consumers consumer = new Facade.Consumers();
            consumer.UpdateMoney(cardno,0);
            //将一行退卡信息插入到数据库
            Entity.BackMoney backmoney = new Entity.BackMoney();
            backmoney.cardno = cardno;
            backmoney.money = txtMoney.Text.Trim();
            backmoney.operater = Entity.GoAnyWhere.cardno;
            backmoney.time = DateTime.Now;
            int result = consumer.AddBackInfo(backmoney);
            if (result > 0)
            {
                MessageBox.Show("退卡成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("退卡失败，请联系管理员！", "温馨提示");
            }
        }
    }
}
