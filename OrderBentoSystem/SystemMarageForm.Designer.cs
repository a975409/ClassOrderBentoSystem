
namespace OrderBentoSystem
{
    partial class SystemMarageForm
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
            this.BtnShopList = new System.Windows.Forms.Button();
            this.BtnClassOrder = new System.Windows.Forms.Button();
            this.ClassGroup = new System.Windows.Forms.GroupBox();
            this.BtnClassOK = new System.Windows.Forms.Button();
            this.BtnClassCancel = new System.Windows.Forms.Button();
            this.TxtClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClassDelete = new System.Windows.Forms.Button();
            this.BtnClassEdit = new System.Windows.Forms.Button();
            this.BtnClassInsert = new System.Windows.Forms.Button();
            this.CboClassRooms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnAccount = new System.Windows.Forms.Button();
            this.LstStudent = new System.Windows.Forms.ListBox();
            this.BtnStuDelete = new System.Windows.Forms.Button();
            this.BtnStuEdit = new System.Windows.Forms.Button();
            this.BtnStuInsert = new System.Windows.Forms.Button();
            this.StudentGroup = new System.Windows.Forms.GroupBox();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnStuOK = new System.Windows.Forms.Button();
            this.BtnStuClose = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOnDuty = new System.Windows.Forms.Button();
            this.BtnCancelDuty = new System.Windows.Forms.Button();
            this.ClassGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.StudentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShopList
            // 
            this.BtnShopList.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnShopList.Location = new System.Drawing.Point(513, 8);
            this.BtnShopList.Name = "BtnShopList";
            this.BtnShopList.Size = new System.Drawing.Size(147, 51);
            this.BtnShopList.TabIndex = 8;
            this.BtnShopList.Text = "店家管理";
            this.BtnShopList.UseVisualStyleBackColor = true;
            this.BtnShopList.Click += new System.EventHandler(this.BtnShopList_Click);
            // 
            // BtnClassOrder
            // 
            this.BtnClassOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClassOrder.Location = new System.Drawing.Point(283, 8);
            this.BtnClassOrder.Name = "BtnClassOrder";
            this.BtnClassOrder.Size = new System.Drawing.Size(147, 51);
            this.BtnClassOrder.TabIndex = 9;
            this.BtnClassOrder.Text = "班級訂單管理";
            this.BtnClassOrder.UseVisualStyleBackColor = true;
            this.BtnClassOrder.Click += new System.EventHandler(this.BtnClassOrder_Click);
            // 
            // ClassGroup
            // 
            this.ClassGroup.Controls.Add(this.BtnClassOK);
            this.ClassGroup.Controls.Add(this.BtnClassCancel);
            this.ClassGroup.Controls.Add(this.TxtClassName);
            this.ClassGroup.Controls.Add(this.label4);
            this.ClassGroup.Location = new System.Drawing.Point(12, 60);
            this.ClassGroup.Name = "ClassGroup";
            this.ClassGroup.Size = new System.Drawing.Size(332, 100);
            this.ClassGroup.TabIndex = 18;
            this.ClassGroup.TabStop = false;
            this.ClassGroup.Text = "新增/編輯班級";
            // 
            // BtnClassOK
            // 
            this.BtnClassOK.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClassOK.Location = new System.Drawing.Point(182, 57);
            this.BtnClassOK.Name = "BtnClassOK";
            this.BtnClassOK.Size = new System.Drawing.Size(69, 37);
            this.BtnClassOK.TabIndex = 2;
            this.BtnClassOK.Text = "確定";
            this.BtnClassOK.UseVisualStyleBackColor = true;
            this.BtnClassOK.Click += new System.EventHandler(this.BtnClassOK_Click);
            // 
            // BtnClassCancel
            // 
            this.BtnClassCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClassCancel.Location = new System.Drawing.Point(257, 57);
            this.BtnClassCancel.Name = "BtnClassCancel";
            this.BtnClassCancel.Size = new System.Drawing.Size(69, 37);
            this.BtnClassCancel.TabIndex = 2;
            this.BtnClassCancel.Text = "取消";
            this.BtnClassCancel.UseVisualStyleBackColor = true;
            this.BtnClassCancel.Click += new System.EventHandler(this.BtnClassCancel_Click);
            // 
            // TxtClassName
            // 
            this.TxtClassName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtClassName.Location = new System.Drawing.Point(119, 18);
            this.TxtClassName.Name = "TxtClassName";
            this.TxtClassName.Size = new System.Drawing.Size(207, 25);
            this.TxtClassName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "班級名稱：";
            // 
            // BtnClassDelete
            // 
            this.BtnClassDelete.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClassDelete.Location = new System.Drawing.Point(238, 166);
            this.BtnClassDelete.Name = "BtnClassDelete";
            this.BtnClassDelete.Size = new System.Drawing.Size(106, 37);
            this.BtnClassDelete.TabIndex = 15;
            this.BtnClassDelete.Text = "移除班級";
            this.BtnClassDelete.UseVisualStyleBackColor = true;
            this.BtnClassDelete.Click += new System.EventHandler(this.BtnClassDelete_Click);
            // 
            // BtnClassEdit
            // 
            this.BtnClassEdit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClassEdit.Location = new System.Drawing.Point(124, 166);
            this.BtnClassEdit.Name = "BtnClassEdit";
            this.BtnClassEdit.Size = new System.Drawing.Size(106, 37);
            this.BtnClassEdit.TabIndex = 16;
            this.BtnClassEdit.Text = "編輯班級";
            this.BtnClassEdit.UseVisualStyleBackColor = true;
            this.BtnClassEdit.Click += new System.EventHandler(this.BtnClassEdit_Click);
            // 
            // BtnClassInsert
            // 
            this.BtnClassInsert.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClassInsert.Location = new System.Drawing.Point(12, 166);
            this.BtnClassInsert.Name = "BtnClassInsert";
            this.BtnClassInsert.Size = new System.Drawing.Size(106, 37);
            this.BtnClassInsert.TabIndex = 17;
            this.BtnClassInsert.Text = "新增班級";
            this.BtnClassInsert.UseVisualStyleBackColor = true;
            this.BtnClassInsert.Click += new System.EventHandler(this.BtnClassInsert_Click);
            // 
            // CboClassRooms
            // 
            this.CboClassRooms.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CboClassRooms.FormattingEnabled = true;
            this.CboClassRooms.Location = new System.Drawing.Point(90, 20);
            this.CboClassRooms.Name = "CboClassRooms";
            this.CboClassRooms.Size = new System.Drawing.Size(173, 28);
            this.CboClassRooms.TabIndex = 20;
            this.CboClassRooms.SelectedIndexChanged += new System.EventHandler(this.CboClassRooms_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "班級：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.CboClassRooms);
            this.splitContainer1.Panel1.Controls.Add(this.BtnClassOrder);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAccount);
            this.splitContainer1.Panel1.Controls.Add(this.BtnShopList);
            this.splitContainer1.Panel1.Controls.Add(this.ClassGroup);
            this.splitContainer1.Panel1.Controls.Add(this.BtnClassDelete);
            this.splitContainer1.Panel1.Controls.Add(this.BtnClassInsert);
            this.splitContainer1.Panel1.Controls.Add(this.BtnClassEdit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LstStudent);
            this.splitContainer1.Panel2.Controls.Add(this.BtnStuDelete);
            this.splitContainer1.Panel2.Controls.Add(this.BtnStuEdit);
            this.splitContainer1.Panel2.Controls.Add(this.BtnStuInsert);
            this.splitContainer1.Panel2.Controls.Add(this.StudentGroup);
            this.splitContainer1.Size = new System.Drawing.Size(670, 645);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 21;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnLogout.ForeColor = System.Drawing.Color.Black;
            this.BtnLogout.Location = new System.Drawing.Point(513, 122);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(147, 49);
            this.BtnLogout.TabIndex = 21;
            this.BtnLogout.Text = "登出";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnAccount
            // 
            this.BtnAccount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnAccount.Location = new System.Drawing.Point(513, 65);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Size = new System.Drawing.Size(147, 51);
            this.BtnAccount.TabIndex = 8;
            this.BtnAccount.Text = "個人帳戶管理";
            this.BtnAccount.UseVisualStyleBackColor = true;
            this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // LstStudent
            // 
            this.LstStudent.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LstStudent.FormattingEnabled = true;
            this.LstStudent.ItemHeight = 24;
            this.LstStudent.Location = new System.Drawing.Point(12, 15);
            this.LstStudent.Name = "LstStudent";
            this.LstStudent.Size = new System.Drawing.Size(218, 364);
            this.LstStudent.TabIndex = 9;
            this.LstStudent.SelectedIndexChanged += new System.EventHandler(this.LstStudent_SelectedIndexChanged);
            // 
            // BtnStuDelete
            // 
            this.BtnStuDelete.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnStuDelete.Location = new System.Drawing.Point(473, 347);
            this.BtnStuDelete.Name = "BtnStuDelete";
            this.BtnStuDelete.Size = new System.Drawing.Size(106, 37);
            this.BtnStuDelete.TabIndex = 15;
            this.BtnStuDelete.Text = "移除學生";
            this.BtnStuDelete.UseVisualStyleBackColor = true;
            this.BtnStuDelete.Click += new System.EventHandler(this.BtnStuDelete_Click);
            // 
            // BtnStuEdit
            // 
            this.BtnStuEdit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnStuEdit.Location = new System.Drawing.Point(357, 347);
            this.BtnStuEdit.Name = "BtnStuEdit";
            this.BtnStuEdit.Size = new System.Drawing.Size(106, 37);
            this.BtnStuEdit.TabIndex = 16;
            this.BtnStuEdit.Text = "編輯學生";
            this.BtnStuEdit.UseVisualStyleBackColor = true;
            this.BtnStuEdit.Click += new System.EventHandler(this.BtnStuEdit_Click);
            // 
            // BtnStuInsert
            // 
            this.BtnStuInsert.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnStuInsert.Location = new System.Drawing.Point(238, 347);
            this.BtnStuInsert.Name = "BtnStuInsert";
            this.BtnStuInsert.Size = new System.Drawing.Size(106, 37);
            this.BtnStuInsert.TabIndex = 17;
            this.BtnStuInsert.Text = "新增學生";
            this.BtnStuInsert.UseVisualStyleBackColor = true;
            this.BtnStuInsert.Click += new System.EventHandler(this.BtnStuInsert_Click);
            // 
            // StudentGroup
            // 
            this.StudentGroup.Controls.Add(this.BtnCancelDuty);
            this.StudentGroup.Controls.Add(this.BtnOnDuty);
            this.StudentGroup.Controls.Add(this.BtnRandom);
            this.StudentGroup.Controls.Add(this.TxtPwd);
            this.StudentGroup.Controls.Add(this.label3);
            this.StudentGroup.Controls.Add(this.label5);
            this.StudentGroup.Controls.Add(this.TxtId);
            this.StudentGroup.Controls.Add(this.BtnStuOK);
            this.StudentGroup.Controls.Add(this.BtnStuClose);
            this.StudentGroup.Controls.Add(this.TxtName);
            this.StudentGroup.Controls.Add(this.label1);
            this.StudentGroup.Location = new System.Drawing.Point(238, 15);
            this.StudentGroup.Name = "StudentGroup";
            this.StudentGroup.Size = new System.Drawing.Size(422, 326);
            this.StudentGroup.TabIndex = 18;
            this.StudentGroup.TabStop = false;
            this.StudentGroup.Text = "新增/編輯學生";
            // 
            // BtnRandom
            // 
            this.BtnRandom.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRandom.ForeColor = System.Drawing.Color.Black;
            this.BtnRandom.Location = new System.Drawing.Point(45, 239);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(232, 35);
            this.BtnRandom.TabIndex = 16;
            this.BtnRandom.Text = "隨機產生一組帳號密碼";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // TxtPwd
            // 
            this.TxtPwd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtPwd.Location = new System.Drawing.Point(11, 200);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.ReadOnly = true;
            this.TxtPwd.Size = new System.Drawing.Size(324, 33);
            this.TxtPwd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "帳號：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "密碼：";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtId.Location = new System.Drawing.Point(11, 124);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(324, 33);
            this.TxtId.TabIndex = 11;
            // 
            // BtnStuOK
            // 
            this.BtnStuOK.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnStuOK.Location = new System.Drawing.Point(341, 48);
            this.BtnStuOK.Name = "BtnStuOK";
            this.BtnStuOK.Size = new System.Drawing.Size(69, 37);
            this.BtnStuOK.TabIndex = 2;
            this.BtnStuOK.Text = "確定";
            this.BtnStuOK.UseVisualStyleBackColor = true;
            this.BtnStuOK.Click += new System.EventHandler(this.BtnStuOK_Click);
            // 
            // BtnStuClose
            // 
            this.BtnStuClose.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnStuClose.Location = new System.Drawing.Point(341, 91);
            this.BtnStuClose.Name = "BtnStuClose";
            this.BtnStuClose.Size = new System.Drawing.Size(69, 37);
            this.BtnStuClose.TabIndex = 2;
            this.BtnStuClose.Text = "取消";
            this.BtnStuClose.UseVisualStyleBackColor = true;
            this.BtnStuClose.Click += new System.EventHandler(this.BtnStuClose_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtName.Location = new System.Drawing.Point(11, 48);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(324, 33);
            this.TxtName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "學生姓名：";
            // 
            // BtnOnDuty
            // 
            this.BtnOnDuty.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOnDuty.ForeColor = System.Drawing.Color.Black;
            this.BtnOnDuty.Location = new System.Drawing.Point(283, 239);
            this.BtnOnDuty.Name = "BtnOnDuty";
            this.BtnOnDuty.Size = new System.Drawing.Size(127, 35);
            this.BtnOnDuty.TabIndex = 16;
            this.BtnOnDuty.Text = "指派值日生";
            this.BtnOnDuty.UseVisualStyleBackColor = true;
            this.BtnOnDuty.Click += new System.EventHandler(this.BtnOnDuty_Click);
            // 
            // BtnCancelDuty
            // 
            this.BtnCancelDuty.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCancelDuty.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelDuty.Location = new System.Drawing.Point(283, 280);
            this.BtnCancelDuty.Name = "BtnCancelDuty";
            this.BtnCancelDuty.Size = new System.Drawing.Size(127, 35);
            this.BtnCancelDuty.TabIndex = 16;
            this.BtnCancelDuty.Text = "取消值日生";
            this.BtnCancelDuty.UseVisualStyleBackColor = true;
            this.BtnCancelDuty.Click += new System.EventHandler(this.BtnCancelDuty_Click);
            // 
            // SystemMarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(670, 645);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemMarageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系統管理介面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemMarageForm_FormClosing);
            this.Load += new System.EventHandler(this.SystemMarageForm_Load);
            this.ClassGroup.ResumeLayout(false);
            this.ClassGroup.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.StudentGroup.ResumeLayout(false);
            this.StudentGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShopList;
        private System.Windows.Forms.Button BtnClassOrder;
        private System.Windows.Forms.GroupBox ClassGroup;
        private System.Windows.Forms.Button BtnClassOK;
        private System.Windows.Forms.Button BtnClassCancel;
        private System.Windows.Forms.TextBox TxtClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClassDelete;
        private System.Windows.Forms.Button BtnClassEdit;
        private System.Windows.Forms.Button BtnClassInsert;
        private System.Windows.Forms.ComboBox CboClassRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox LstStudent;
        private System.Windows.Forms.Button BtnStuDelete;
        private System.Windows.Forms.Button BtnStuEdit;
        private System.Windows.Forms.Button BtnStuInsert;
        private System.Windows.Forms.GroupBox StudentGroup;
        private System.Windows.Forms.Button BtnStuOK;
        private System.Windows.Forms.Button BtnStuClose;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnOnDuty;
        private System.Windows.Forms.Button BtnCancelDuty;
    }
}