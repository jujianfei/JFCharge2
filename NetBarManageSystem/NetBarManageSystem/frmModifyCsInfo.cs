/*
 *==================
 *创建人：琚建飞
 *创建时间：2017/1/22 21:20:01
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
    public partial class frmModifyCsInfo : Form
    {
        public frmModifyCsInfo()
        {
            InitializeComponent();
        }

        private void frmModifyCsInfo_Load(object sender, EventArgs e)  //窗体加载事件
        {
            string cardno = Entity.GoAnyWhere.cardno;
            Facade.Consumers cs = new Facade.Consumers();
            DataTable dt = cs.ReturnConsumeinfo(cardno);
            //将查询到的数据显示到界面上
            txtCardno.Text = Convert.ToString(dt.Rows[0][0]);
            txtName.Text = Convert.ToString(dt.Rows[0][1]);
            txtAge.Text = Convert.ToString(dt.Rows[0][2]);
            cboGender.Text = Convert.ToString(dt.Rows[0][3]);
            txtAddMoney.Text = Convert.ToString(dt.Rows[0][4]);
            cboStatus.Text = Convert.ToString(dt.Rows[0][5]);
        }

        private void btnOk_Click(object sender, EventArgs e) //点击确定修改按钮
        {
            string cardno = Entity.GoAnyWhere.cardno; //从全局变量获取cardno值
            string status = cboStatus.Text.Trim(); //获取状态信息

            Facade.Consumers cs = new Facade.Consumers();
            int result = cs.UpdateStatus(cardno,status);
            if (result>0)
            {
                MessageBox.Show("修改用户状态成功！","温馨提示");
            }
        }
    }
}
