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
    public partial class frmPharmacist : frmMain
    {
        public frmPharmacist()
        {
            InitializeComponent();
        }

        private void frmPharmacist_Resize(object sender, EventArgs e)
        {
            dgvOrders.Height = this.Height - 318;
        }
    }
}
