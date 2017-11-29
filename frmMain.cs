using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        public int User;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Close();          
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            Button btn = sender as Button;

            if (btn.Name == "btnMedicines")
            {
                searchForm.HeaderLabel.Text = "Medicines";
                searchForm.Text = "PDMS - Medicines";
            }
            if (btn.Name == "btnPatients")
            {
                searchForm.HeaderLabel.Text = "Patients";
                searchForm.Text = "PDMS - Patients";
            }
            if (btn.Name == "btnWarehouses")
            {
                searchForm.HeaderLabel.Text = "Warehouses";
                searchForm.Text = "PDMS - Warehouses";
            }

            searchForm.User = User;
            searchForm.Show();
            this.Close();
        }
    }
}
