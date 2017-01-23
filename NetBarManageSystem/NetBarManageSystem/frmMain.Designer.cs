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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginManage = new System.Windows.Forms.Button();
            this.btnExitSystem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCheck = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExitSystem);
            this.panel1.Location = new System.Drawing.Point(24, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 281);
            this.panel1.TabIndex = 1;
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
            // btnExitSystem
            // 
            this.btnExitSystem.Location = new System.Drawing.Point(39, 197);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(75, 23);
            this.btnExitSystem.TabIndex = 0;
            this.btnExitSystem.Text = "退出系统";
            this.btnExitSystem.UseVisualStyleBackColor = true;
            this.btnExitSystem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRecharge);
            this.panel2.Controls.Add(this.txtCheck);
            this.panel2.Controls.Add(this.btnAddUsers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(524, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 281);
            this.panel2.TabIndex = 2;
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
            this.panel3.Location = new System.Drawing.Point(288, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 281);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 588);
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

    }
}