
namespace OrderBentoSystem
{
    partial class ClassOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboDate = new System.Windows.Forms.ComboBox();
            this.FLPShowOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LinkLblNext = new System.Windows.Forms.LinkLabel();
            this.LinkLblBack = new System.Windows.Forms.LinkLabel();
            this.BtnBentoOrder = new System.Windows.Forms.Button();
            this.saveOrderDialog = new System.Windows.Forms.SaveFileDialog();
            this.BtnCheckAll = new System.Windows.Forms.Button();
            this.BtnCancelCheckAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "便當訂購日期：";
            // 
            // CboDate
            // 
            this.CboDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CboDate.FormattingEnabled = true;
            this.CboDate.Location = new System.Drawing.Point(153, 14);
            this.CboDate.Name = "CboDate";
            this.CboDate.Size = new System.Drawing.Size(162, 28);
            this.CboDate.TabIndex = 9;
            this.CboDate.SelectedIndexChanged += new System.EventHandler(this.CboDate_SelectedIndexChanged);
            // 
            // FLPShowOrder
            // 
            this.FLPShowOrder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPShowOrder.Location = new System.Drawing.Point(7, 99);
            this.FLPShowOrder.Name = "FLPShowOrder";
            this.FLPShowOrder.Size = new System.Drawing.Size(718, 413);
            this.FLPShowOrder.TabIndex = 10;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCheck.Location = new System.Drawing.Point(602, 7);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(123, 43);
            this.BtnCheck.TabIndex = 11;
            this.BtnCheck.Text = "確認訂單";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCancel.Location = new System.Drawing.Point(602, 53);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(123, 43);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "取消訂單";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LinkLblNext
            // 
            this.LinkLblNext.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LinkLblNext.Location = new System.Drawing.Point(367, 515);
            this.LinkLblNext.Name = "LinkLblNext";
            this.LinkLblNext.Size = new System.Drawing.Size(126, 37);
            this.LinkLblNext.TabIndex = 12;
            this.LinkLblNext.TabStop = true;
            this.LinkLblNext.Text = "下一頁>";
            this.LinkLblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLblNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblNext_LinkClicked);
            // 
            // LinkLblBack
            // 
            this.LinkLblBack.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LinkLblBack.Location = new System.Drawing.Point(242, 515);
            this.LinkLblBack.Name = "LinkLblBack";
            this.LinkLblBack.Size = new System.Drawing.Size(119, 37);
            this.LinkLblBack.TabIndex = 13;
            this.LinkLblBack.TabStop = true;
            this.LinkLblBack.Text = "<上一頁";
            this.LinkLblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblBack_LinkClicked);
            // 
            // BtnBentoOrder
            // 
            this.BtnBentoOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnBentoOrder.Location = new System.Drawing.Point(321, 7);
            this.BtnBentoOrder.Name = "BtnBentoOrder";
            this.BtnBentoOrder.Size = new System.Drawing.Size(189, 43);
            this.BtnBentoOrder.TabIndex = 11;
            this.BtnBentoOrder.Text = "匯出已確認的訂單";
            this.BtnBentoOrder.UseVisualStyleBackColor = true;
            this.BtnBentoOrder.Click += new System.EventHandler(this.BtnBentoOrder_Click);
            // 
            // BtnCheckAll
            // 
            this.BtnCheckAll.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCheckAll.Location = new System.Drawing.Point(7, 52);
            this.BtnCheckAll.Name = "BtnCheckAll";
            this.BtnCheckAll.Size = new System.Drawing.Size(70, 43);
            this.BtnCheckAll.TabIndex = 11;
            this.BtnCheckAll.Text = "全選";
            this.BtnCheckAll.UseVisualStyleBackColor = true;
            this.BtnCheckAll.Click += new System.EventHandler(this.BtnCheckAll_Click);
            // 
            // BtnCancelCheckAll
            // 
            this.BtnCancelCheckAll.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCancelCheckAll.Location = new System.Drawing.Point(83, 52);
            this.BtnCancelCheckAll.Name = "BtnCancelCheckAll";
            this.BtnCancelCheckAll.Size = new System.Drawing.Size(117, 43);
            this.BtnCancelCheckAll.TabIndex = 11;
            this.BtnCancelCheckAll.Text = "取消全選";
            this.BtnCancelCheckAll.UseVisualStyleBackColor = true;
            this.BtnCancelCheckAll.Click += new System.EventHandler(this.BtnCancelCheckAll_Click);
            // 
            // ClassOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(732, 556);
            this.Controls.Add(this.LinkLblNext);
            this.Controls.Add(this.LinkLblBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnBentoOrder);
            this.Controls.Add(this.BtnCancelCheckAll);
            this.Controls.Add(this.BtnCheckAll);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.FLPShowOrder);
            this.Controls.Add(this.CboDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班級訂單管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.ClassOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboDate;
        private System.Windows.Forms.FlowLayoutPanel FLPShowOrder;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.LinkLabel LinkLblNext;
        private System.Windows.Forms.LinkLabel LinkLblBack;
        private System.Windows.Forms.Button BtnBentoOrder;
        private System.Windows.Forms.SaveFileDialog saveOrderDialog;
        private System.Windows.Forms.Button BtnCheckAll;
        private System.Windows.Forms.Button BtnCancelCheckAll;
    }
}