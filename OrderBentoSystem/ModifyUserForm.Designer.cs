
namespace OrderBentoSystem
{
    partial class ModifyUserForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.TxtNewPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNewId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtOldPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOldId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPwdMsg = new System.Windows.Forms.Label();
            this.LblUserMsg = new System.Windows.Forms.Label();
            this.TxtstuName = new System.Windows.Forms.TextBox();
            this.TxtClass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClose.Location = new System.Drawing.Point(120, 406);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(130, 35);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "關閉";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOK.Location = new System.Drawing.Point(256, 406);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(130, 35);
            this.BtnOK.TabIndex = 18;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblPwdMsg);
            this.groupBox2.Controls.Add(this.LblUserMsg);
            this.groupBox2.Controls.Add(this.BtnRandom);
            this.groupBox2.Controls.Add(this.TxtNewPwd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtNewId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 220);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "請設定新的帳號/密碼";
            // 
            // BtnRandom
            // 
            this.BtnRandom.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRandom.ForeColor = System.Drawing.Color.Black;
            this.BtnRandom.Location = new System.Drawing.Point(234, 173);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(232, 35);
            this.BtnRandom.TabIndex = 15;
            this.BtnRandom.Text = "隨機產生一組帳號密碼";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // TxtNewPwd
            // 
            this.TxtNewPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtNewPwd.Location = new System.Drawing.Point(87, 106);
            this.TxtNewPwd.Name = "TxtNewPwd";
            this.TxtNewPwd.Size = new System.Drawing.Size(379, 33);
            this.TxtNewPwd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "帳號：";
            // 
            // TxtNewId
            // 
            this.TxtNewId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtNewId.Location = new System.Drawing.Point(87, 38);
            this.TxtNewId.Name = "TxtNewId";
            this.TxtNewId.Size = new System.Drawing.Size(379, 33);
            this.TxtNewId.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "密碼：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtOldPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtOldId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 134);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請輸入原來的帳號/密碼";
            // 
            // TxtOldPwd
            // 
            this.TxtOldPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtOldPwd.Location = new System.Drawing.Point(87, 84);
            this.TxtOldPwd.Name = "TxtOldPwd";
            this.TxtOldPwd.PasswordChar = '*';
            this.TxtOldPwd.Size = new System.Drawing.Size(379, 33);
            this.TxtOldPwd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "帳號：";
            // 
            // TxtOldId
            // 
            this.TxtOldId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtOldId.Location = new System.Drawing.Point(87, 38);
            this.TxtOldId.Name = "TxtOldId";
            this.TxtOldId.Size = new System.Drawing.Size(379, 33);
            this.TxtOldId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "密碼：";
            // 
            // LblPwdMsg
            // 
            this.LblPwdMsg.BackColor = System.Drawing.Color.Yellow;
            this.LblPwdMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblPwdMsg.ForeColor = System.Drawing.Color.Red;
            this.LblPwdMsg.Location = new System.Drawing.Point(87, 143);
            this.LblPwdMsg.Name = "LblPwdMsg";
            this.LblPwdMsg.Size = new System.Drawing.Size(379, 27);
            this.LblPwdMsg.TabIndex = 16;
            this.LblPwdMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUserMsg
            // 
            this.LblUserMsg.BackColor = System.Drawing.Color.Yellow;
            this.LblUserMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblUserMsg.ForeColor = System.Drawing.Color.Red;
            this.LblUserMsg.Location = new System.Drawing.Point(87, 74);
            this.LblUserMsg.Name = "LblUserMsg";
            this.LblUserMsg.Size = new System.Drawing.Size(379, 26);
            this.LblUserMsg.TabIndex = 17;
            this.LblUserMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtstuName
            // 
            this.TxtstuName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtstuName.Location = new System.Drawing.Point(343, 12);
            this.TxtstuName.Name = "TxtstuName";
            this.TxtstuName.ReadOnly = true;
            this.TxtstuName.Size = new System.Drawing.Size(135, 25);
            this.TxtstuName.TabIndex = 21;
            // 
            // TxtClass
            // 
            this.TxtClass.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtClass.Location = new System.Drawing.Point(68, 10);
            this.TxtClass.Name = "TxtClass";
            this.TxtClass.ReadOnly = true;
            this.TxtClass.Size = new System.Drawing.Size(135, 25);
            this.TxtClass.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(283, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 27);
            this.label11.TabIndex = 19;
            this.label11.Text = "姓名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "班級";
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(507, 449);
            this.Controls.Add(this.TxtstuName);
            this.Controls.Add(this.TxtClass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人帳戶管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyUserForm_FormClosing);
            this.Load += new System.EventHandler(this.ModifyUserForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.TextBox TxtNewPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNewId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtOldPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOldId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPwdMsg;
        private System.Windows.Forms.Label LblUserMsg;
        private System.Windows.Forms.TextBox TxtstuName;
        private System.Windows.Forms.TextBox TxtClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}