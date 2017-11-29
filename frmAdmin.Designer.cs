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
            this.btnManageBranches = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnEnterShipments = new System.Windows.Forms.Button();
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageBranches
            // 
            this.btnManageBranches.AutoSize = true;
            this.btnManageBranches.Location = new System.Drawing.Point(301, 199);
            this.btnManageBranches.Name = "btnManageBranches";
            this.btnManageBranches.Size = new System.Drawing.Size(173, 66);
            this.btnManageBranches.TabIndex = 17;
            this.btnManageBranches.Text = "Manage Branches";
            this.btnManageBranches.UseVisualStyleBackColor = true;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.AutoSize = true;
            this.btnManageUsers.Location = new System.Drawing.Point(591, 199);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(173, 66);
            this.btnManageUsers.TabIndex = 16;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnEnterShipments
            // 
            this.btnEnterShipments.AutoSize = true;
            this.btnEnterShipments.Location = new System.Drawing.Point(591, 363);
            this.btnEnterShipments.Name = "btnEnterShipments";
            this.btnEnterShipments.Size = new System.Drawing.Size(173, 66);
            this.btnEnterShipments.TabIndex = 15;
            this.btnEnterShipments.Text = "Enter Shipments";
            this.btnEnterShipments.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.AutoSize = true;
            this.btnRegisterPatient.Location = new System.Drawing.Point(301, 363);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(173, 66);
            this.btnRegisterPatient.TabIndex = 14;
            this.btnRegisterPatient.Text = "Register Patient";
            this.btnRegisterPatient.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoSize = true;
            this.btnCreateOrder.Location = new System.Drawing.Point(19, 363);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(173, 66);
            this.btnCreateOrder.TabIndex = 13;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.Location = new System.Drawing.Point(19, 199);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(173, 66);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import Data";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 605);
            this.Controls.Add(this.btnManageBranches);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnEnterShipments);
            this.Controls.Add(this.btnRegisterPatient);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnImport);
            this.MaximumSize = new System.Drawing.Size(800, 650);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Controls.SetChildIndex(this.btnImport, 0);
            this.Controls.SetChildIndex(this.btnCreateOrder, 0);
            this.Controls.SetChildIndex(this.btnRegisterPatient, 0);
            this.Controls.SetChildIndex(this.btnEnterShipments, 0);
            this.Controls.SetChildIndex(this.btnManageUsers, 0);
            this.Controls.SetChildIndex(this.btnManageBranches, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageBranches;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnEnterShipments;
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnImport;
    }
}