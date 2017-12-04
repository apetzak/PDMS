namespace PDMS
{
    partial class frmManager
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
            this.btnReportValue = new System.Windows.Forms.Button();
            this.btnReportsOrders = new System.Windows.Forms.Button();
            this.btnReportBoughtSold = new System.Windows.Forms.Button();
            this.btnReportBalance = new System.Windows.Forms.Button();
            this.lbReports = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Reports";
            // 
            // btnReportValue
            // 
            this.btnReportValue.AutoSize = true;
            this.btnReportValue.Enabled = false;
            this.btnReportValue.Location = new System.Drawing.Point(19, 283);
            this.btnReportValue.Name = "btnReportValue";
            this.btnReportValue.Size = new System.Drawing.Size(173, 66);
            this.btnReportValue.TabIndex = 21;
            this.btnReportValue.Text = "Value of Medicine";
            this.btnReportValue.UseVisualStyleBackColor = true;
            // 
            // btnReportsOrders
            // 
            this.btnReportsOrders.AutoSize = true;
            this.btnReportsOrders.Enabled = false;
            this.btnReportsOrders.Location = new System.Drawing.Point(19, 443);
            this.btnReportsOrders.Name = "btnReportsOrders";
            this.btnReportsOrders.Size = new System.Drawing.Size(173, 66);
            this.btnReportsOrders.TabIndex = 20;
            this.btnReportsOrders.Text = "Total Orders";
            this.btnReportsOrders.UseVisualStyleBackColor = true;
            // 
            // btnReportBoughtSold
            // 
            this.btnReportBoughtSold.AutoSize = true;
            this.btnReportBoughtSold.Enabled = false;
            this.btnReportBoughtSold.Location = new System.Drawing.Point(19, 363);
            this.btnReportBoughtSold.Name = "btnReportBoughtSold";
            this.btnReportBoughtSold.Size = new System.Drawing.Size(173, 66);
            this.btnReportBoughtSold.TabIndex = 19;
            this.btnReportBoughtSold.Text = "Medicine Bought/Sold";
            this.btnReportBoughtSold.UseVisualStyleBackColor = true;
            // 
            // btnReportBalance
            // 
            this.btnReportBalance.AutoSize = true;
            this.btnReportBalance.Enabled = false;
            this.btnReportBalance.Location = new System.Drawing.Point(19, 203);
            this.btnReportBalance.Name = "btnReportBalance";
            this.btnReportBalance.Size = new System.Drawing.Size(173, 66);
            this.btnReportBalance.TabIndex = 18;
            this.btnReportBalance.Text = "Balance";
            this.btnReportBalance.UseVisualStyleBackColor = true;
            // 
            // lbReports
            // 
            this.lbReports.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbReports.FormattingEnabled = true;
            this.lbReports.ItemHeight = 16;
            this.lbReports.Location = new System.Drawing.Point(208, 203);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(562, 308);
            this.lbReports.TabIndex = 22;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 605);
            this.Controls.Add(this.lbReports);
            this.Controls.Add(this.btnReportValue);
            this.Controls.Add(this.btnReportsOrders);
            this.Controls.Add(this.btnReportBoughtSold);
            this.Controls.Add(this.btnReportBalance);
            this.Controls.Add(this.label1);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.Resize += new System.EventHandler(this.frmManager_Resize);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnReportBalance, 0);
            this.Controls.SetChildIndex(this.btnReportBoughtSold, 0);
            this.Controls.SetChildIndex(this.btnReportsOrders, 0);
            this.Controls.SetChildIndex(this.btnReportValue, 0);
            this.Controls.SetChildIndex(this.lbReports, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportValue;
        private System.Windows.Forms.Button btnReportsOrders;
        private System.Windows.Forms.Button btnReportBoughtSold;
        private System.Windows.Forms.Button btnReportBalance;
        private System.Windows.Forms.ListBox lbReports;
    }
}