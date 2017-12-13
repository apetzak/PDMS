namespace PDMS
{
    partial class frmPharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPharmacist));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pharmacist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBookOrder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select an Order";
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.Medicine,
            this.Patient,
            this.Pharmacist,
            this.Date,
            this.ExpectedDeliveryDate,
            this.Completed});
            this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrders.Location = new System.Drawing.Point(12, 226);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1100, 332);
            this.dgvOrders.TabIndex = 13;
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "Order Number";
            this.OrderNumber.Name = "OrderNumber";
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            this.Medicine.Width = 250;
            // 
            // Patient
            // 
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            this.Patient.Width = 150;
            // 
            // Pharmacist
            // 
            this.Pharmacist.HeaderText = "Pharmacist";
            this.Pharmacist.Name = "Pharmacist";
            this.Pharmacist.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // ExpectedDeliveryDate
            // 
            this.ExpectedDeliveryDate.HeaderText = "Expected Delivery Date";
            this.ExpectedDeliveryDate.Name = "ExpectedDeliveryDate";
            this.ExpectedDeliveryDate.Width = 120;
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Completed";
            this.Completed.Name = "Completed";
            // 
            // btnBookOrder
            // 
            this.btnBookOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBookOrder.Location = new System.Drawing.Point(727, 161);
            this.btnBookOrder.Name = "btnBookOrder";
            this.btnBookOrder.Size = new System.Drawing.Size(218, 48);
            this.btnBookOrder.TabIndex = 14;
            this.btnBookOrder.Text = "Book Order";
            this.btnBookOrder.UseVisualStyleBackColor = true;
            this.btnBookOrder.Click += new System.EventHandler(this.btnBookOrder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Location = new System.Drawing.Point(1012, 161);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 48);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 643);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBookOrder);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmPharmacist";
            this.Text = "frmPharmacist";
            this.Resize += new System.EventHandler(this.frmPharmacist_Resize);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvOrders, 0);
            this.Controls.SetChildIndex(this.btnBookOrder, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnBookOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pharmacist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completed;
        private System.Windows.Forms.Button btnRefresh;
    }
}