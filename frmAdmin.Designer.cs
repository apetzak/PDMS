namespace PDMS
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnEnterShipments = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dtExpectedDelivery = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvLineItems = new System.Windows.Forms.DataGridView();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UofM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSub = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPrescriptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPatient = new System.Windows.Forms.ComboBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblasdf = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.AutoSize = true;
            this.btnManageUsers.Location = new System.Drawing.Point(13, 250);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(173, 66);
            this.btnManageUsers.TabIndex = 16;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnEnterShipments
            // 
            this.btnEnterShipments.AutoSize = true;
            this.btnEnterShipments.Location = new System.Drawing.Point(13, 350);
            this.btnEnterShipments.Name = "btnEnterShipments";
            this.btnEnterShipments.Size = new System.Drawing.Size(173, 66);
            this.btnEnterShipments.TabIndex = 15;
            this.btnEnterShipments.Text = "Enter Shipments";
            this.btnEnterShipments.UseVisualStyleBackColor = true;
            this.btnEnterShipments.Click += new System.EventHandler(this.btnEnterShipments_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoSize = true;
            this.btnCreateOrder.Location = new System.Drawing.Point(13, 150);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(173, 66);
            this.btnCreateOrder.TabIndex = 13;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.Location = new System.Drawing.Point(13, 450);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(173, 66);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dtDate);
            this.groupBox.Controls.Add(this.dtExpectedDelivery);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.btnCancel);
            this.groupBox.Controls.Add(this.lblTotal);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.lblTax);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.btnSave);
            this.groupBox.Controls.Add(this.dgvLineItems);
            this.groupBox.Controls.Add(this.lblSub);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.btnAdd);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.comboPrescriptions);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.comboPatient);
            this.groupBox.Controls.Add(this.lblOrderNumber);
            this.groupBox.Controls.Add(this.lblasdf);
            this.groupBox.Location = new System.Drawing.Point(218, 150);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(600, 500);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            this.groupBox.Resize += new System.EventHandler(this.groupBox_Resize);
            // 
            // dtDate
            // 
            this.dtDate.Enabled = false;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(459, 87);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(100, 22);
            this.dtDate.TabIndex = 19;
            this.dtDate.Value = new System.DateTime(2017, 12, 11, 23, 38, 9, 0);
            // 
            // dtExpectedDelivery
            // 
            this.dtExpectedDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpectedDelivery.Location = new System.Drawing.Point(460, 123);
            this.dtExpectedDelivery.Name = "dtExpectedDelivery";
            this.dtExpectedDelivery.Size = new System.Drawing.Size(100, 22);
            this.dtExpectedDelivery.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Expected Delivery";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Date";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 43);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(507, 422);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "$0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(294, 422);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(44, 17);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tax:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(353, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvLineItems
            // 
            this.dgvLineItems.AllowUserToAddRows = false;
            this.dgvLineItems.AllowUserToDeleteRows = false;
            this.dgvLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine,
            this.Price,
            this.UofM});
            this.dgvLineItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLineItems.Location = new System.Drawing.Point(32, 163);
            this.dgvLineItems.Name = "dgvLineItems";
            this.dgvLineItems.RowTemplate.Height = 24;
            this.dgvLineItems.Size = new System.Drawing.Size(525, 240);
            this.dgvLineItems.TabIndex = 9;
            this.dgvLineItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvLineItems_RowsRemoved);
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            this.Medicine.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // UofM
            // 
            this.UofM.HeaderText = "UofM";
            this.UofM.Name = "UofM";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(101, 422);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(44, 17);
            this.lblSub.TabIndex = 8;
            this.lblSub.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 26);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prescriptions";
            // 
            // comboPrescriptions
            // 
            this.comboPrescriptions.FormattingEnabled = true;
            this.comboPrescriptions.Location = new System.Drawing.Point(126, 120);
            this.comboPrescriptions.Name = "comboPrescriptions";
            this.comboPrescriptions.Size = new System.Drawing.Size(121, 24);
            this.comboPrescriptions.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient";
            // 
            // comboPatient
            // 
            this.comboPatient.FormattingEnabled = true;
            this.comboPatient.Location = new System.Drawing.Point(126, 87);
            this.comboPatient.Name = "comboPatient";
            this.comboPatient.Size = new System.Drawing.Size(121, 24);
            this.comboPatient.TabIndex = 2;
            this.comboPatient.TextChanged += new System.EventHandler(this.comboPatient_TextChanged);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(182, 41);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(24, 25);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "1";
            // 
            // lblasdf
            // 
            this.lblasdf.AutoSize = true;
            this.lblasdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasdf.Location = new System.Drawing.Point(31, 41);
            this.lblasdf.Name = "lblasdf";
            this.lblasdf.Size = new System.Drawing.Size(155, 25);
            this.lblasdf.TabIndex = 0;
            this.lblasdf.Text = "Order Number:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 659);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnEnterShipments);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnImport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Resize += new System.EventHandler(this.frmAdmin_Resize);
            this.Controls.SetChildIndex(this.btnImport, 0);
            this.Controls.SetChildIndex(this.btnCreateOrder, 0);
            this.Controls.SetChildIndex(this.btnEnterShipments, 0);
            this.Controls.SetChildIndex(this.btnManageUsers, 0);
            this.Controls.SetChildIndex(this.groupBox, 0);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnEnterShipments;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblasdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPatient;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPrescriptions;
        private System.Windows.Forms.DataGridView dgvLineItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn UofM;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DateTimePicker dtExpectedDelivery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}