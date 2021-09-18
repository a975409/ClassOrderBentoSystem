
namespace OrderBentoSystem
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtstuName = new System.Windows.Forms.TextBox();
            this.TxtClass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnAccount = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnBookmarks = new System.Windows.Forms.Button();
            this.BtnShopCar = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BtnShopInfo = new System.Windows.Forms.Button();
            this.BtnShopList = new System.Windows.Forms.Button();
            this.BtnClassOrder = new System.Windows.Forms.Button();
            this.CboShopItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.splitContainer1.Panel1.Controls.Add(this.TxtstuName);
            this.splitContainer1.Panel1.Controls.Add(this.TxtClass);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.BtnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAccount);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.BtnOrder);
            this.splitContainer1.Panel1.Controls.Add(this.BtnBookmarks);
            this.splitContainer1.Panel1.Controls.Add(this.BtnShopCar);
            this.splitContainer1.Panel1.Controls.Add(this.BtnUpdate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(975, 651);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            // 
            // TxtstuName
            // 
            this.TxtstuName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtstuName.Location = new System.Drawing.Point(12, 605);
            this.TxtstuName.Name = "TxtstuName";
            this.TxtstuName.ReadOnly = true;
            this.TxtstuName.Size = new System.Drawing.Size(135, 29);
            this.TxtstuName.TabIndex = 8;
            // 
            // TxtClass
            // 
            this.TxtClass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtClass.Location = new System.Drawing.Point(12, 542);
            this.TxtClass.Name = "TxtClass";
            this.TxtClass.ReadOnly = true;
            this.TxtClass.Size = new System.Drawing.Size(135, 29);
            this.TxtClass.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "姓名";
            // 
            // BtnLogout
            // 
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(0, 425);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(168, 85);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "登出";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnAccount
            // 
            this.BtnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAccount.FlatAppearance.BorderSize = 0;
            this.BtnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnAccount.ForeColor = System.Drawing.Color.White;
            this.BtnAccount.Location = new System.Drawing.Point(0, 340);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Size = new System.Drawing.Size(168, 85);
            this.BtnAccount.TabIndex = 4;
            this.BtnAccount.Text = "個人帳戶管理";
            this.BtnAccount.UseVisualStyleBackColor = true;
            this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "所屬單位";
            // 
            // BtnOrder
            // 
            this.BtnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrder.FlatAppearance.BorderSize = 0;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOrder.ForeColor = System.Drawing.Color.White;
            this.BtnOrder.Location = new System.Drawing.Point(0, 255);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(168, 85);
            this.BtnOrder.TabIndex = 3;
            this.BtnOrder.Text = "個人訂單管理";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnBookmarks
            // 
            this.BtnBookmarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBookmarks.FlatAppearance.BorderSize = 0;
            this.BtnBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBookmarks.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnBookmarks.ForeColor = System.Drawing.Color.White;
            this.BtnBookmarks.Location = new System.Drawing.Point(0, 170);
            this.BtnBookmarks.Name = "BtnBookmarks";
            this.BtnBookmarks.Size = new System.Drawing.Size(168, 85);
            this.BtnBookmarks.TabIndex = 2;
            this.BtnBookmarks.Text = "我的最愛管理";
            this.BtnBookmarks.UseVisualStyleBackColor = true;
            this.BtnBookmarks.Click += new System.EventHandler(this.BtnBookmarks_Click);
            // 
            // BtnShopCar
            // 
            this.BtnShopCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnShopCar.FlatAppearance.BorderSize = 0;
            this.BtnShopCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShopCar.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnShopCar.ForeColor = System.Drawing.Color.White;
            this.BtnShopCar.Location = new System.Drawing.Point(0, 85);
            this.BtnShopCar.Name = "BtnShopCar";
            this.BtnShopCar.Size = new System.Drawing.Size(168, 85);
            this.BtnShopCar.TabIndex = 1;
            this.BtnShopCar.Text = "購物車";
            this.BtnShopCar.UseVisualStyleBackColor = true;
            this.BtnShopCar.Click += new System.EventHandler(this.BtnShopCar_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(0, 0);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(168, 85);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "重新整理";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BtnShopInfo);
            this.splitContainer2.Panel1.Controls.Add(this.BtnShopList);
            this.splitContainer2.Panel1.Controls.Add(this.BtnClassOrder);
            this.splitContainer2.Panel1.Controls.Add(this.CboShopItem);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(795, 644);
            this.splitContainer2.SplitterDistance = 73;
            this.splitContainer2.TabIndex = 7;
            // 
            // BtnShopInfo
            // 
            this.BtnShopInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnShopInfo.Location = new System.Drawing.Point(285, 9);
            this.BtnShopInfo.Name = "BtnShopInfo";
            this.BtnShopInfo.Size = new System.Drawing.Size(114, 30);
            this.BtnShopInfo.TabIndex = 7;
            this.BtnShopInfo.Text = "查看店家資訊";
            this.BtnShopInfo.UseVisualStyleBackColor = true;
            this.BtnShopInfo.Click += new System.EventHandler(this.BtnShopInfo_Click);
            // 
            // BtnShopList
            // 
            this.BtnShopList.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnShopList.Location = new System.Drawing.Point(640, 6);
            this.BtnShopList.Name = "BtnShopList";
            this.BtnShopList.Size = new System.Drawing.Size(147, 58);
            this.BtnShopList.TabIndex = 7;
            this.BtnShopList.Text = "店家管理";
            this.BtnShopList.UseVisualStyleBackColor = true;
            this.BtnShopList.Click += new System.EventHandler(this.BtnShopList_Click);
            // 
            // BtnClassOrder
            // 
            this.BtnClassOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClassOrder.Location = new System.Drawing.Point(487, 6);
            this.BtnClassOrder.Name = "BtnClassOrder";
            this.BtnClassOrder.Size = new System.Drawing.Size(147, 58);
            this.BtnClassOrder.TabIndex = 7;
            this.BtnClassOrder.Text = "班級訂單管理";
            this.BtnClassOrder.UseVisualStyleBackColor = true;
            this.BtnClassOrder.Click += new System.EventHandler(this.BtnClassOrder_Click);
            // 
            // CboShopItem
            // 
            this.CboShopItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CboShopItem.FormattingEnabled = true;
            this.CboShopItem.Location = new System.Drawing.Point(80, 10);
            this.CboShopItem.Name = "CboShopItem";
            this.CboShopItem.Size = new System.Drawing.Size(201, 28);
            this.CboShopItem.TabIndex = 6;
            this.CboShopItem.SelectedIndexChanged += new System.EventHandler(this.CboShopItem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "店家：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 651);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnBookmarks;
        private System.Windows.Forms.Button BtnShopCar;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboShopItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtstuName;
        private System.Windows.Forms.TextBox TxtClass;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BtnShopList;
        private System.Windows.Forms.Button BtnClassOrder;
        private System.Windows.Forms.Button BtnShopInfo;
    }
}