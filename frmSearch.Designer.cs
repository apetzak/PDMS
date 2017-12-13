namespace PDMS
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResults.Location = new System.Drawing.Point(12, 122);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(758, 471);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellEnter);
            this.dgvResults.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellValueChanged);
            this.dgvResults.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvResults_ColumnDisplayIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(321, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(109, 38);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "label1";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(22, 133);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(20, 22);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comboFilter
            // 
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(12, 82);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(145, 24);
            this.comboFilter.TabIndex = 5;
            this.comboFilter.SelectedValueChanged += new System.EventHandler(this.comboFilter_SelectedValueChanged);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 605);
            this.Controls.Add(this.comboFilter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.VisibleChanged += new System.EventHandler(this.frmSearch_VisibleChanged);
            this.Resize += new System.EventHandler(this.frmSearch_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboFilter;
    }
}