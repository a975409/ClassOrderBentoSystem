
namespace OrderBentoSystem
{
    partial class FavoriteDetailForm
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
            this.BtnRemoveItem = new System.Windows.Forms.Button();
            this.LsvFavoriteDetial = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRemoveItem
            // 
            this.BtnRemoveItem.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRemoveItem.Location = new System.Drawing.Point(372, 9);
            this.BtnRemoveItem.Name = "BtnRemoveItem";
            this.BtnRemoveItem.Size = new System.Drawing.Size(163, 41);
            this.BtnRemoveItem.TabIndex = 19;
            this.BtnRemoveItem.Text = "移除所選項目";
            this.BtnRemoveItem.UseVisualStyleBackColor = true;
            this.BtnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // LsvFavoriteDetial
            // 
            this.LsvFavoriteDetial.CheckBoxes = true;
            this.LsvFavoriteDetial.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LsvFavoriteDetial.FullRowSelect = true;
            this.LsvFavoriteDetial.HideSelection = false;
            this.LsvFavoriteDetial.Location = new System.Drawing.Point(10, 56);
            this.LsvFavoriteDetial.Name = "LsvFavoriteDetial";
            this.LsvFavoriteDetial.Size = new System.Drawing.Size(525, 333);
            this.LsvFavoriteDetial.TabIndex = 9;
            this.LsvFavoriteDetial.UseCompatibleStateImageBehavior = false;
            this.LsvFavoriteDetial.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "總金額：";
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.Color.Yellow;
            this.LblTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTotal.ForeColor = System.Drawing.Color.Red;
            this.LblTotal.Location = new System.Drawing.Point(95, 11);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(233, 27);
            this.LblTotal.TabIndex = 20;
            // 
            // FavoriteDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(544, 401);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemoveItem);
            this.Controls.Add(this.LsvFavoriteDetial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FavoriteDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的最愛詳細內容";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FavoriteDetailForm_FormClosing);
            this.Load += new System.EventHandler(this.FavoriteDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRemoveItem;
        private System.Windows.Forms.ListView LsvFavoriteDetial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
    }
}