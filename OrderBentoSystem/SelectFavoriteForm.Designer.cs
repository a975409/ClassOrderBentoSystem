
namespace OrderBentoSystem
{
    partial class SelectFavoriteForm
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
            this.LstFavorite = new System.Windows.Forms.ListBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtFavoriteName = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblShop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstFavorite
            // 
            this.LstFavorite.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LstFavorite.FormattingEnabled = true;
            this.LstFavorite.ItemHeight = 24;
            this.LstFavorite.Location = new System.Drawing.Point(12, 12);
            this.LstFavorite.Name = "LstFavorite";
            this.LstFavorite.Size = new System.Drawing.Size(223, 364);
            this.LstFavorite.TabIndex = 5;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOK.Location = new System.Drawing.Point(246, 340);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(105, 36);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCancel.Location = new System.Drawing.Point(357, 340);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 36);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnInsert.Location = new System.Drawing.Point(302, 43);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(160, 36);
            this.BtnInsert.TabIndex = 6;
            this.BtnInsert.Text = "新增我的最愛";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtFavoriteName
            // 
            this.TxtFavoriteName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtFavoriteName.Location = new System.Drawing.Point(246, 12);
            this.TxtFavoriteName.Name = "TxtFavoriteName";
            this.TxtFavoriteName.Size = new System.Drawing.Size(216, 29);
            this.TxtFavoriteName.TabIndex = 7;
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.Color.Cyan;
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.ForeColor = System.Drawing.Color.Red;
            this.LblMsg.Location = new System.Drawing.Point(245, 221);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(216, 116);
            this.LblMsg.TabIndex = 8;
            this.LblMsg.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(241, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "店家：";
            // 
            // LblShop
            // 
            this.LblShop.BackColor = System.Drawing.Color.Yellow;
            this.LblShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblShop.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblShop.ForeColor = System.Drawing.Color.Red;
            this.LblShop.Location = new System.Drawing.Point(246, 105);
            this.LblShop.Name = "LblShop";
            this.LblShop.Size = new System.Drawing.Size(216, 27);
            this.LblShop.TabIndex = 8;
            this.LblShop.Text = "店家：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(241, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "菜色：";
            // 
            // LblMenu
            // 
            this.LblMenu.BackColor = System.Drawing.Color.Yellow;
            this.LblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMenu.ForeColor = System.Drawing.Color.Red;
            this.LblMenu.Location = new System.Drawing.Point(246, 165);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(216, 27);
            this.LblMenu.TabIndex = 8;
            this.LblMenu.Text = "店家：";
            // 
            // SelectFavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(476, 387);
            this.Controls.Add(this.LblMenu);
            this.Controls.Add(this.LblShop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtFavoriteName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LstFavorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectFavoriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectFavoriteForm";
            this.Load += new System.EventHandler(this.SelectFavoriteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstFavorite;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtFavoriteName;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMenu;
    }
}