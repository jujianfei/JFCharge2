namespace NetBarManageSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitSystem = new System.Windows.Forms.Button();
            this.btnLoginManage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.txtCheck = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLoginMoney = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.n1 = new System.Windows.Forms.NumericUpDown();
            this.n2 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExitSystem);
            this.panel1.Location = new System.Drawing.Point(24, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 89);
            this.panel1.TabIndex = 1;
            // 
            // btnExitSystem
            // 
            this.btnExitSystem.Location = new System.Drawing.Point(33, 32);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(75, 23);
            this.btnExitSystem.TabIndex = 0;
            this.btnExitSystem.Text = "结账下机";
            this.btnExitSystem.UseVisualStyleBackColor = true;
            this.btnExitSystem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoginManage
            // 
            this.btnLoginManage.Location = new System.Drawing.Point(33, 97);
            this.btnLoginManage.Name = "btnLoginManage";
            this.btnLoginManage.Size = new System.Drawing.Size(75, 23);
            this.btnLoginManage.TabIndex = 1;
            this.btnLoginManage.Text = "用户管理";
            this.btnLoginManage.UseVisualStyleBackColor = true;
            this.btnLoginManage.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRecharge);
            this.panel2.Controls.Add(this.txtCheck);
            this.panel2.Controls.Add(this.btnAddUsers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 249);
            this.panel2.TabIndex = 2;
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(33, 196);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(97, 23);
            this.btnRecharge.TabIndex = 3;
            this.btnRecharge.Text = "用户充值";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(30, 138);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(100, 23);
            this.txtCheck.TabIndex = 2;
            this.txtCheck.Text = "查看用户数据";
            this.txtCheck.UseVisualStyleBackColor = true;
            this.txtCheck.Click += new System.EventHandler(this.txtCheck_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(30, 81);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(100, 23);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "添加用户";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收银员界面";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLoginManage);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(24, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 137);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "管理员界面";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.n2);
            this.panel4.Controls.Add(this.n1);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblLoginMoney);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblLoginId);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblLoginTime);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(249, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(591, 461);
            this.panel4.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(223, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 15;
            this.label15.Text = "元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "元";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "分钟";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "label14";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "剩余金额：";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "消费金额：";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "消费时间：";
            this.label9.Visible = false;
            // 
            // lblLoginMoney
            // 
            this.lblLoginMoney.AutoSize = true;
            this.lblLoginMoney.Location = new System.Drawing.Point(166, 242);
            this.lblLoginMoney.Name = "lblLoginMoney";
            this.lblLoginMoney.Size = new System.Drawing.Size(41, 12);
            this.lblLoginMoney.TabIndex = 5;
            this.lblLoginMoney.Text = "label8";
            this.lblLoginMoney.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "用户余额：";
            this.label7.Visible = false;
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Location = new System.Drawing.Point(166, 202);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(41, 12);
            this.lblLoginId.TabIndex = 3;
            this.lblLoginId.Text = "label6";
            this.lblLoginId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "登录用户：";
            this.label5.Visible = false;
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = true;
            this.lblLoginTime.Location = new System.Drawing.Point(164, 162);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(0, 12);
            this.lblLoginTime.TabIndex = 1;
            this.lblLoginTime.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "上机时间：";
            this.label3.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(373, 335);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(49, 21);
            this.n1.TabIndex = 16;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(449, 335);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(49, 21);
            this.n2.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 12);
            this.label16.TabIndex = 18;
            this.label16.Text = "设定下机时间：";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 588);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统主窗体";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitSystem;
        private System.Windows.Forms.Button btnLoginManage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button txtCheck;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLoginMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown n2;
        private System.Windows.Forms.NumericUpDown n1;

    }
}