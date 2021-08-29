
namespace OrderBentoSystem
{
    partial class OrderForm
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
            this.LinkLblBack = new System.Windows.Forms.LinkLabel();
            this.LinkLblNext = new System.Windows.Forms.LinkLabel();
            this.FLPShowOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LinkLblBack
            // 
            this.LinkLblBack.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LinkLblBack.Location = new System.Drawing.Point(222, 485);
            this.LinkLblBack.Name = "LinkLblBack";
            this.LinkLblBack.Size = new System.Drawing.Size(119, 37);
            this.LinkLblBack.TabIndex = 1;
            this.LinkLblBack.TabStop = true;
            this.LinkLblBack.Text = "<上一頁";
            this.LinkLblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblBack_LinkClicked);
            // 
            // LinkLblNext
            // 
            this.LinkLblNext.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LinkLblNext.Location = new System.Drawing.Point(347, 485);
            this.LinkLblNext.Name = "LinkLblNext";
            this.LinkLblNext.Size = new System.Drawing.Size(126, 37);
            this.LinkLblNext.TabIndex = 1;
            this.LinkLblNext.TabStop = true;
            this.LinkLblNext.Text = "下一頁>";
            this.LinkLblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLblNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblNext_LinkClicked);
            // 
            // FLPShowOrder
            // 
            this.FLPShowOrder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPShowOrder.Location = new System.Drawing.Point(12, 12);
            this.FLPShowOrder.Name = "FLPShowOrder";
            this.FLPShowOrder.Size = new System.Drawing.Size(672, 470);
            this.FLPShowOrder.TabIndex = 4;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(693, 531);
            this.Controls.Add(this.LinkLblNext);
            this.Controls.Add(this.FLPShowOrder);
            this.Controls.Add(this.LinkLblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人訂單管理";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel LinkLblBack;
        private System.Windows.Forms.LinkLabel LinkLblNext;
        private System.Windows.Forms.FlowLayoutPanel FLPShowOrder;
    }
}