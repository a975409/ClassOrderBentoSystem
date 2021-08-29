
namespace OrderBentoSystem
{
    partial class OrderDetailForm
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
            this.LsvOrderDetial = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOrderNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOrderDate = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInsertOrderDateTime = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOrderState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LsvOrderDetial
            // 
            this.LsvOrderDetial.CheckBoxes = true;
            this.LsvOrderDetial.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LsvOrderDetial.FullRowSelect = true;
            this.LsvOrderDetial.HideSelection = false;
            this.LsvOrderDetial.Location = new System.Drawing.Point(12, 44);
            this.LsvOrderDetial.Name = "LsvOrderDetial";
            this.LsvOrderDetial.Size = new System.Drawing.Size(644, 333);
            this.LsvOrderDetial.TabIndex = 1;
            this.LsvOrderDetial.UseCompatibleStateImageBehavior = false;
            this.LsvOrderDetial.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "訂單編號：";
            // 
            // TxtOrderNo
            // 
            this.TxtOrderNo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtOrderNo.Location = new System.Drawing.Point(116, 9);
            this.TxtOrderNo.Name = "TxtOrderNo";
            this.TxtOrderNo.ReadOnly = true;
            this.TxtOrderNo.Size = new System.Drawing.Size(95, 29);
            this.TxtOrderNo.TabIndex = 7;
            this.TxtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "便當送達日期：";
            // 
            // TxtOrderDate
            // 
            this.TxtOrderDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtOrderDate.Location = new System.Drawing.Point(496, 9);
            this.TxtOrderDate.Name = "TxtOrderDate";
            this.TxtOrderDate.ReadOnly = true;
            this.TxtOrderDate.Size = new System.Drawing.Size(160, 29);
            this.TxtOrderDate.TabIndex = 7;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClose.Location = new System.Drawing.Point(346, 417);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(144, 41);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "關閉";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "訂單加入時間：";
            // 
            // TxtInsertOrderDateTime
            // 
            this.TxtInsertOrderDateTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtInsertOrderDateTime.Location = new System.Drawing.Point(160, 383);
            this.TxtInsertOrderDateTime.Name = "TxtInsertOrderDateTime";
            this.TxtInsertOrderDateTime.ReadOnly = true;
            this.TxtInsertOrderDateTime.Size = new System.Drawing.Size(207, 29);
            this.TxtInsertOrderDateTime.TabIndex = 7;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCancel.Location = new System.Drawing.Point(196, 417);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(144, 41);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "取消訂單";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(373, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "訂單狀態：";
            // 
            // TxtOrderState
            // 
            this.TxtOrderState.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtOrderState.Location = new System.Drawing.Point(496, 383);
            this.TxtOrderState.Name = "TxtOrderState";
            this.TxtOrderState.ReadOnly = true;
            this.TxtOrderState.Size = new System.Drawing.Size(160, 29);
            this.TxtOrderState.TabIndex = 7;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(668, 467);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtOrderState);
            this.Controls.Add(this.TxtInsertOrderDateTime);
            this.Controls.Add(this.TxtOrderDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOrderNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LsvOrderDetial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂單詳細資訊";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LsvOrderDetial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOrderNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOrderDate;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInsertOrderDateTime;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOrderState;
    }
}