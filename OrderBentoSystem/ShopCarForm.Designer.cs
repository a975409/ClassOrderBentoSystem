
namespace OrderBentoSystem
{
    partial class ShopCarForm
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
            this.LsvShopCar = new System.Windows.Forms.ListView();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.BtnDelSelect = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LsvShopCar
            // 
            this.LsvShopCar.CheckBoxes = true;
            this.LsvShopCar.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LsvShopCar.FullRowSelect = true;
            this.LsvShopCar.HideSelection = false;
            this.LsvShopCar.Location = new System.Drawing.Point(12, 81);
            this.LsvShopCar.Name = "LsvShopCar";
            this.LsvShopCar.Size = new System.Drawing.Size(644, 333);
            this.LsvShopCar.TabIndex = 0;
            this.LsvShopCar.UseCompatibleStateImageBehavior = false;
            this.LsvShopCar.View = System.Windows.Forms.View.Details;
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClearAll.Location = new System.Drawing.Point(141, 420);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(189, 56);
            this.BtnClearAll.TabIndex = 1;
            this.BtnClearAll.Text = "清空購物車";
            this.BtnClearAll.UseVisualStyleBackColor = true;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // BtnDelSelect
            // 
            this.BtnDelSelect.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDelSelect.Location = new System.Drawing.Point(336, 420);
            this.BtnDelSelect.Name = "BtnDelSelect";
            this.BtnDelSelect.Size = new System.Drawing.Size(186, 56);
            this.BtnDelSelect.TabIndex = 1;
            this.BtnDelSelect.Text = "刪除勾選的項目";
            this.BtnDelSelect.UseVisualStyleBackColor = true;
            this.BtnDelSelect.Click += new System.EventHandler(this.BtnDelSelect_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSend.Location = new System.Drawing.Point(466, 18);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(189, 56);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "訂單送出";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "選擇要訂購哪一天的便當：";
            // 
            // DtpOrderDate
            // 
            this.DtpOrderDate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DtpOrderDate.Location = new System.Drawing.Point(12, 39);
            this.DtpOrderDate.Name = "DtpOrderDate";
            this.DtpOrderDate.Size = new System.Drawing.Size(243, 35);
            this.DtpOrderDate.TabIndex = 7;
            // 
            // ShopCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(667, 486);
            this.Controls.Add(this.DtpOrderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelSelect);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.LsvShopCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "購物車";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopCarForm_FormClosing);
            this.Load += new System.EventHandler(this.ShopCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LsvShopCar;
        private System.Windows.Forms.Button BtnClearAll;
        private System.Windows.Forms.Button BtnDelSelect;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpOrderDate;
    }
}