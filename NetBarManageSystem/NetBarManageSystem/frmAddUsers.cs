/*
 *==================
 *创建人：琚建飞
 *创建时间：2017/1/22 10:36:52
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
    public partial class frmAddUsers : Form
    {
        public frmAddUsers()
        {
            InitializeComponent();
        }

        private void frmAddUsers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //点击确定添加按钮
        {
            Entity.Consumers cs = new Entity.Consumers();
            cs.cardno = txtCardno.Text.Trim();
            cs.name = txtName.Text.Trim();
            cs.age = txtAge.Text.Trim();
            cs.gender = cboGender.Text.Trim();
            cs.money = txtAddMoney.Text.Trim();
            cs.status = cboStatus.Text.Trim();
            cs.sno = Entity.GoAnyWhere.id;
            cs.addtime = DateTime.Now;
            //将界面获取的数据插入到数据库中
            Facade.Consumers consumer = new Facade.Consumers();
            int result = consumer.addconsumers(cs);   //插入到消费者信息表
            if (result > 0)
            {
                MessageBox.Show("添加成功！", "温馨提示");
                //将消费者信息插入到登录表中
                Entity.Login user = new Entity.Login();
                user.username = txtCardno.Text.Trim();
                user.password = "123456";
                user.level = "用户";
                user.status = cboStatus.Text.Trim();
                Facade.LoginUsers fuser = new Facade.LoginUsers();
                int result2 = fuser.addusers(user);
            }
            else
            {
                MessageBox.Show("添加失败，请联系管理员","温馨提示");
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
