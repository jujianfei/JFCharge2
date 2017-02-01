/*
 *==================
 *创建人：琚建飞
 *创建时间：2017/2/1 16:00:07
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
    public partial class frmCheckConsumeStation : Form
    {
        public frmCheckConsumeStation()
        {
            InitializeComponent();
        }

        private void frmCheckConsumeStation_Load(object sender, EventArgs e) //窗体加载情况
        {
            //将ConsumeForm中的消费记录绑定到DataGrideView中
            string cardno = Entity.GoAnyWhere.id;
            Facade.Consumers consumeinfo = new Facade.Consumers();
            DataTable dt = consumeinfo.CheckConsumeInfo(cardno);
            dataGridView1.DataSource = dt;
        }
    }
}
