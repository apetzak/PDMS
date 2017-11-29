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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnBookOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select an Order";
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(16, 214);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(747, 332);
            this.dgvOrders.TabIndex = 13;
            // 
            // btnBookOrder
            // 
            this.btnBookOrder.Location = new System.Drawing.Point(544, 147);
            this.btnBookOrder.Name = "btnBookOrder";
            this.btnBookOrder.Size = new System.Drawing.Size(218, 48);
            this.btnBookOrder.TabIndex = 14;
            this.btnBookOrder.Text = "Book Order";
            this.btnBookOrder.UseVisualStyleBackColor = true;
            // 
            // frmPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 605);
            this.Controls.Add(this.btnBookOrder);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label1);
            this.Name = "frmPharmacist";
            this.Text = "frmPharmacist";
            this.Resize += new System.EventHandler(this.frmPharmacist_Resize);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvOrders, 0);
            this.Controls.SetChildIndex(this.btnBookOrder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnBookOrder;
    }
}