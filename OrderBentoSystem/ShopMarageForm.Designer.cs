
namespace OrderBentoSystem
{
    partial class ShopMarageForm
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
            this.LstShop = new System.Windows.Forms.ListBox();
            this.BtnInsertShop = new System.Windows.Forms.Button();
            this.BtnDelShop = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstShop
            // 
            this.LstShop.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LstShop.FormattingEnabled = true;
            this.LstShop.ItemHeight = 24;
            this.LstShop.Location = new System.Drawing.Point(6, 6);
            this.LstShop.Name = "LstShop";
            this.LstShop.Size = new System.Drawing.Size(223, 364);
            this.LstShop.TabIndex = 8;
            // 
            // BtnInsertShop
            // 
            this.BtnInsertShop.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnInsertShop.Location = new System.Drawing.Point(235, 68);
            this.BtnInsertShop.Name = "BtnInsertShop";
            this.BtnInsertShop.Size = new System.Drawing.Size(172, 56);
            this.BtnInsertShop.TabIndex = 5;
            this.BtnInsertShop.Text = "新增店家";
            this.BtnInsertShop.UseVisualStyleBackColor = true;
            this.BtnInsertShop.Click += new System.EventHandler(this.BtnInsertShop_Click);
            // 
            // BtnDelShop
            // 
            this.BtnDelShop.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDelShop.Location = new System.Drawing.Point(235, 130);
            this.BtnDelShop.Name = "BtnDelShop";
            this.BtnDelShop.Size = new System.Drawing.Size(172, 56);
            this.BtnDelShop.TabIndex = 6;
            this.BtnDelShop.Text = "刪除店家";
            this.BtnDelShop.UseVisualStyleBackColor = true;
            this.BtnDelShop.Click += new System.EventHandler(this.BtnDelShop_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnInfo.Location = new System.Drawing.Point(235, 6);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(172, 56);
            this.BtnInfo.TabIndex = 7;
            this.BtnInfo.Text = "編輯店家資訊";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // ShopMarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(412, 376);
            this.Controls.Add(this.LstShop);
            this.Controls.Add(this.BtnInsertShop);
            this.Controls.Add(this.BtnDelShop);
            this.Controls.Add(this.BtnInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopMarageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "店家管理";
            this.Load += new System.EventHandler(this.ShopMarageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstShop;
        private System.Windows.Forms.Button BtnInsertShop;
        private System.Windows.Forms.Button BtnDelShop;
        private System.Windows.Forms.Button BtnInfo;
    }
}