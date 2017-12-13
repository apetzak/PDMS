using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using DataGridViewAutoFilter;

namespace PDMS
{
    public partial class frmSearch : Form
    {
        public DataController controller = new DataController();

        public string HeaderLabel = "";
        public int User;
        public List<string> ColumnList = new List<string>();

        public frmSearch(string header, int user)
        {
            InitializeComponent();
            this.HeaderLabel = header;
            this.User = user;
            this.Text = "PDMS - " + header;           

            if (HeaderLabel == "Warehouses")
            {
                Button btn = new Button();
                btn.Text = "View Inventory";
                btn.Location = new Point(20, 20);
                btn.Width = 160;
                btn.Height = 35;
                btn.Click += btnInventory_Click;
                btn.BackColor = SystemColors.Control;
                btn.Anchor = AnchorStyles.Top;
                this.Controls.Add(btn);
            }

            CreateColumns();

            foreach (string s in ColumnList)
                comboFilter.Items.Add(s);
            comboFilter.SelectedItem = comboFilter.Items[0];

            try
            {
                controller.LoadData(header, dgvResults, "", comboFilter.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        
            if (User == 0)
            {
                dgvResults.AllowUserToAddRows = true;
                dgvResults.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                lblCount.Text = Convert.ToString(dgvResults.RowCount - 1);
            }
            else
                lblCount.Text = Convert.ToString(dgvResults.RowCount);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {                  
            if (dgvResults.SelectedRows.Count > 0)
            {
                frmWarehouse form = new frmWarehouse(dgvResults.SelectedRows[0].Cells[0].Value.ToString());
                form.BackColor = this.BackColor;
                form.Show();
            }
        }

        public void CreateColumns()
        {
            if (HeaderLabel == "Medicines")
            {
                dgvResults.ColumnCount = 4;
                dgvResults.Columns[0].Name = "Name";
                dgvResults.Columns[0].Width = 120;
                dgvResults.Columns[1].Name = "Price";
                dgvResults.Columns[2].Name = "Case Price";
                dgvResults.Columns[3].Name = "Expiration Days";
            }
            else if (HeaderLabel == "Patients")
            {
                dgvResults.ColumnCount = 7;
                dgvResults.Columns[0].Name = "Name";
                dgvResults.Columns[0].Width = 120;
                dgvResults.Columns[1].Name = "Date of Birth";
                dgvResults.Columns[1].Width = 80;
                dgvResults.Columns[2].Name = "Prescription";
                dgvResults.Columns[3].Name = "Insurance";
                dgvResults.Columns[3].Width = 150;
                dgvResults.Columns[4].Name = "Last Visit Date";
                dgvResults.Columns[5].Name = "Email";
                dgvResults.Columns[5].Width = 150;
                dgvResults.Columns[6].Name = "Address";
                dgvResults.Columns[6].Width = 420;

            }
            else if (HeaderLabel == "Warehouses")
            {
                dgvResults.ColumnCount = 3;
                dgvResults.Columns[0].Name = "Name";
                dgvResults.Columns[0].Width = 150;
                dgvResults.Columns[1].Name = "Address";
                dgvResults.Columns[1].Width = 420;
                dgvResults.Columns[2].Name = "Default Expected Delivery";
            }

            foreach (DataGridViewColumn c in dgvResults.Columns)
                ColumnList.Add(c.Name);          
        }      

        //public void AddRows()
        //{
        //    dgvResults.Rows.Add(new object[] {
        //            reader.GetValue(reader.GetOrdinal("name")),
        //            reader.GetValue(reader.GetOrdinal("score")),
        //            reader.GetValue(reader.GetOrdinal("name")),
        //            reader.GetValue(reader.GetOrdinal("score")),
        //            reader.GetValue(reader.GetOrdinal("name")),
        //            reader.GetValue(reader.GetOrdinal("score")),
        //            });
        //}

        private void frmSearch_Resize(object sender, EventArgs e)
        {
            dgvResults.Height = this.Height - 179;
            dgvResults.Width = this.Width - 42;
        }

        private void frmSearch_VisibleChanged(object sender, EventArgs e)
        {
            lblHeader.Text = HeaderLabel;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (User == 0)
            {
                frmAdmin f = new frmAdmin();
                ShowForm(f);
            }
            if (User == 1)
            {
                frmPharmacist f = new frmPharmacist();
                ShowForm(f);
            }
            if (User == 2)
            {
                frmManager f = new frmManager();
                ShowForm(f);
            }
            this.Close();
        }

        public void ShowForm(frmMain f)
        {
            f.BackColor = this.BackColor;
            f.UserRole = User;
            f.Show();
        }

        private void dgvResults_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            controller.UpdateData(dgvResults, lblCount, HeaderLabel, e);
        }

        private void dgvResults_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            controller.SelectedRowName = Convert.ToString(dgvResults.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dgvResults_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            controller.LoadData(HeaderLabel, dgvResults, txtSearch.Text, comboFilter.SelectedItem.ToString());
            lblCount.Text = dgvResults.Rows.Count.ToString();
            if (User == 0)
                lblCount.Text = Convert.ToString(dgvResults.Rows.Count - 1);
        }

        private void comboFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.LoadData(HeaderLabel, dgvResults, txtSearch.Text, comboFilter.SelectedItem.ToString());
        }
    }
}
