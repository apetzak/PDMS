namespace PDMS
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWarehouse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToOrderColumns = true;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicine,
            this.quantity,
            this.shipmentNumber,
            this.expireDate});
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(12, 52);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(666, 490);
            this.dgvInventory.TabIndex = 0;
            // 
            // medicine
            // 
            this.medicine.HeaderText = "Medicine";
            this.medicine.Name = "medicine";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // shipmentNumber
            // 
            this.shipmentNumber.HeaderText = "Shipment Number";
            this.shipmentNumber.Name = "shipmentNumber";
            // 
            // expireDate
            // 
            this.expireDate.HeaderText = "Expire Date";
            this.expireDate.Name = "expireDate";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.Location = new System.Drawing.Point(12, 9);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(70, 25);
            this.lblWarehouse.TabIndex = 1;
            this.lblWarehouse.Text = "label1";
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 556);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.dgvInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.Label lblWarehouse;
    }
}