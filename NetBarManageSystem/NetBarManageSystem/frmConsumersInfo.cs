/*
 *==================
 *创建人：琚建飞
 *创建时间：2017/1/22 20:50:42
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
    public partial class frmConsumersInfo : Form
    {
        public frmConsumersInfo()
        {
            InitializeComponent();
        }

        private void frmConsumersInfo_Load(object sender, EventArgs e)  //窗体加载事件
        {
            UpdaeTable();
        }

        private void UpdaeTable()
        {
            Facade.Consumers csinfo = new Facade.Consumers();
            DataTable dt = csinfo.CheckConsumers();
            dataGridView1.DataSource = dt;
        }

        bool mark3 = false;
        #region 选中dataGridView的某行的某个单元格
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)      //单击某一行
            {
                mark3 = true;
                Entity.GoAnyWhere.cardno = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value); //获取某行的第一个单元格的数据传给全局变量cardno
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e) //点击修改按钮
        {
            if (mark3)
            {
                mark3 = !mark3; //取消选中
                frmModifyCsInfo f = new frmModifyCsInfo();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中一条记录再进行操作");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) //刷新按钮
        {
            UpdaeTable();
        }
    }
}
