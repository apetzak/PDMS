namespace PDMS
{
    partial class frmBookOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookOrder));
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.comboAvailable = new System.Windows.Forms.ComboBox();
            this.btnFulfill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UofM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fulfilled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(12, 19);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(70, 25);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "label1";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine,
            this.UofM,
            this.Fulfilled,
            this.ShipmentNumber});
            this.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItems.Location = new System.Drawing.Point(17, 126);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(499, 251);
            this.dgvItems.TabIndex = 1;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // comboAvailable
            // 
            this.comboAvailable.FormattingEnabled = true;
            this.comboAvailable.Location = new System.Drawing.Point(180, 64);
            this.comboAvailable.Name = "comboAvailable";
            this.comboAvailable.Size = new System.Drawing.Size(336, 24);
            this.comboAvailable.TabIndex = 2;
            // 
            // btnFulfill
            // 
            this.btnFulfill.Location = new System.Drawing.Point(17, 64);
            this.btnFulfill.Name = "btnFulfill";
            this.btnFulfill.Size = new System.Drawing.Size(123, 40);
            this.btnFulfill.TabIndex = 3;
            this.btnFulfill.Text = "Fulfill";
            this.btnFulfill.UseVisualStyleBackColor = true;
            this.btnFulfill.Click += new System.EventHandler(this.btnFulfill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(17, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(375, 392);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 46);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            this.Medicine.Width = 150;
            // 
            // UofM
            // 
            this.UofM.HeaderText = "UofM";
            this.UofM.Name = "UofM";
            // 
            // Fulfilled
            // 
            this.Fulfilled.HeaderText = "Fulfilled";
            this.Fulfilled.Name = "Fulfilled";
            // 
            // ShipmentNumber
            // 
            this.ShipmentNumber.HeaderText = "Shipment Number";
            this.ShipmentNumber.Name = "ShipmentNumber";
            // 
            // frmBookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFulfill);
            this.Controls.Add(this.comboAvailable);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblOrderNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.ComboBox comboAvailable;
        private System.Windows.Forms.Button btnFulfill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn UofM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fulfilled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentNumber;
    }
}