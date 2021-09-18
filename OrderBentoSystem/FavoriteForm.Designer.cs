
namespace OrderBentoSystem
{
    partial class FavoriteForm
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
            this.BtnDelSelect = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnInsertShopCar = new System.Windows.Forms.Button();
            this.LstFavorite = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnDelSelect
            // 
            this.BtnDelSelect.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDelSelect.Location = new System.Drawing.Point(241, 136);
            this.BtnDelSelect.Name = "BtnDelSelect";
            this.BtnDelSelect.Size = new System.Drawing.Size(172, 56);
            this.BtnDelSelect.TabIndex = 2;
            this.BtnDelSelect.Text = "刪除項目";
            this.BtnDelSelect.UseVisualStyleBackColor = true;
            this.BtnDelSelect.Click += new System.EventHandler(this.BtnDelSelect_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnInfo.Location = new System.Drawing.Point(241, 12);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(172, 56);
            this.BtnInfo.TabIndex = 3;
            this.BtnInfo.Text = "查看內容";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnInsertShopCar
            // 
            this.BtnInsertShopCar.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnInsertShopCar.Location = new System.Drawing.Point(241, 74);
            this.BtnInsertShopCar.Name = "BtnInsertShopCar";
            this.BtnInsertShopCar.Size = new System.Drawing.Size(172, 56);
            this.BtnInsertShopCar.TabIndex = 2;
            this.BtnInsertShopCar.Text = "加入至購物車";
            this.BtnInsertShopCar.UseVisualStyleBackColor = true;
            this.BtnInsertShopCar.Click += new System.EventHandler(this.BtnInsertShopCar_Click);
            // 
            // LstFavorite
            // 
            this.LstFavorite.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LstFavorite.FormattingEnabled = true;
            this.LstFavorite.ItemHeight = 24;
            this.LstFavorite.Location = new System.Drawing.Point(12, 12);
            this.LstFavorite.Name = "LstFavorite";
            this.LstFavorite.Size = new System.Drawing.Size(223, 364);
            this.LstFavorite.TabIndex = 4;
            // 
            // FavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(422, 386);
            this.Controls.Add(this.LstFavorite);
            this.Controls.Add(this.BtnInsertShopCar);
            this.Controls.Add(this.BtnDelSelect);
            this.Controls.Add(this.BtnInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FavoriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的最愛管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FavoriteForm_FormClosing);
            this.Load += new System.EventHandler(this.FavoriteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDelSelect;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnInsertShopCar;
        private System.Windows.Forms.ListBox LstFavorite;
    }
}