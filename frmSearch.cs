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
            this.Text = "PDMS - " + header;
            
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

            User = user;
            if (User == 1)
            {
                dgvResults.AllowUserToAddRows = true;
                dgvResults.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                lblCount.Text = Convert.ToString(dgvResults.RowCount - 1);
            }
            else
                lblCount.Text = Convert.ToString(dgvResults.RowCount);
        }

        public void CreateColumns()
        {
            dgvResults.ColumnCount = 6;
            if (HeaderLabel == "Medicines")
            {
                dgvResults.Columns[0].Name = "Name";
                dgvResults.Columns[0].Width = 120;
                dgvResults.Columns[1].Name = "Price";
                dgvResults.Columns[2].Name = "Case Price";
                dgvResults.Columns[3].Name = "Expiration Days";
                dgvResults.Columns[4].Name = "Shipment Number";
                dgvResults.Columns[5].Name = "Quantity";
            }
            else if (HeaderLabel == "Patients")
            {
                dgvResults.Columns[0].Name = "First Name";
                dgvResults.Columns[0].Width = 120;
                dgvResults.Columns[1].Name = "Last Name";
                dgvResults.Columns[1].Width = 120;
                dgvResults.Columns[2].Name = "Date of Birth";
                dgvResults.Columns[2].Width = 80;
                dgvResults.Columns[3].Name = "Prescription";
                dgvResults.Columns[4].Name = "Insurance";
                dgvResults.Columns[4].Width = 150;
                dgvResults.Columns[5].Name = "Last Visit Date";
                dgvResults.Columns[5].Width = 80;
            }
            else if (HeaderLabel == "Warehouses")
            {
                dgvResults.Columns[0].Name = "Name";
                dgvResults.Columns[1].Name = "Address";
                dgvResults.Columns[1].Width = 150;
                dgvResults.Columns[2].Name = "Inventory";
                dgvResults.Columns[3].Name = "Stockable Medicines";
                dgvResults.Columns[3].Width = 150;
                dgvResults.Columns[4].Name = "Earliest Expire Date";
                dgvResults.Columns[4].Width = 80;
                dgvResults.Columns[5].Name = "Default Expected Delivery";
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
        }

        private void frmSearch_VisibleChanged(object sender, EventArgs e)
        {
            lblHeader.Text = HeaderLabel;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (User == 1)
            {
                frmAdmin f = new frmAdmin();
                f.BackColor = this.BackColor;
                f.User = User;
                f.Show();
            }
            if (User == 2)
            {
                frmPharmacist f = new frmPharmacist();
                f.BackColor = this.BackColor;
                f.User = User;
                f.Show();
            }
            if (User == 3)
            {
                frmManager f = new frmManager();
                f.BackColor = this.BackColor;
                f.User = User;
                f.Show();
            }
            if (User == 4)
            {
                frmMain f = new frmMain();
                f.BackColor = this.BackColor;
                f.User = User;
                f.Show();
            }
            this.Close();
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
            if (User == 1)
                lblCount.Text = Convert.ToString(dgvResults.Rows.Count - 1);
        }

        private void comboFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.LoadData(HeaderLabel, dgvResults, txtSearch.Text, comboFilter.SelectedItem.ToString());
        }
    }
}
