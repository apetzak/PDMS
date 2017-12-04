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
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnEnterShipments = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.AutoSize = true;
            this.btnManageUsers.Enabled = false;
            this.btnManageUsers.Location = new System.Drawing.Point(19, 250);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(173, 66);
            this.btnManageUsers.TabIndex = 16;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnEnterShipments
            // 
            this.btnEnterShipments.AutoSize = true;
            this.btnEnterShipments.Enabled = false;
            this.btnEnterShipments.Location = new System.Drawing.Point(19, 350);
            this.btnEnterShipments.Name = "btnEnterShipments";
            this.btnEnterShipments.Size = new System.Drawing.Size(173, 66);
            this.btnEnterShipments.TabIndex = 15;
            this.btnEnterShipments.Text = "Enter Shipments";
            this.btnEnterShipments.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoSize = true;
            this.btnCreateOrder.Enabled = false;
            this.btnCreateOrder.Location = new System.Drawing.Point(19, 150);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(173, 66);
            this.btnCreateOrder.TabIndex = 13;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.Location = new System.Drawing.Point(19, 450);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(173, 66);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(227, 150);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(542, 365);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 605);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnEnterShipments);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnImport);
            this.MaximumSize = new System.Drawing.Size(800, 650);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Controls.SetChildIndex(this.btnImport, 0);
            this.Controls.SetChildIndex(this.btnCreateOrder, 0);
            this.Controls.SetChildIndex(this.btnEnterShipments, 0);
            this.Controls.SetChildIndex(this.btnManageUsers, 0);
            this.Controls.SetChildIndex(this.groupBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnEnterShipments;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBox;
    }
}