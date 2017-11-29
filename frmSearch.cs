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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        public Label HeaderLabel = new Label();
        public int User;

        private void frmSearch_Resize(object sender, EventArgs e)
        {
            dgvResults.Height = this.Height - 179;
        }

        private void frmSearch_VisibleChanged(object sender, EventArgs e)
        {
            lblHeader.Text = HeaderLabel.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (User == 1)
            {
                frmAdmin f = new frmAdmin();
                f.User = User;
                f.Show();
            }
            if (User == 2)
            {
                frmPharmacist f = new frmPharmacist();
                f.User = User;
                f.Show();
            }
            if (User == 3)
            {
                frmManager f = new frmManager();
                f.User = User;
                f.Show();
            }
            if (User == 4)
            {
                frmMain f = new frmMain();
                f.User = User;
                f.Show();
            }

            this.Close();

        }
    }
}
