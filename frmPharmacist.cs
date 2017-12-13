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
        public DataController controller = new DataController();

        public frmPharmacist()
        {
            InitializeComponent();
            controller.LoadOrders(dgvOrders);
        }

        private void frmPharmacist_Resize(object sender, EventArgs e)
        {
            dgvOrders.Height = this.Height - 338;
        }

        private void btnBookOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                frmBookOrder form = new frmBookOrder(Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[0].Value), UserName);
                form.BackColor = this.BackColor;
                form.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvOrders.Rows.Clear();

            controller.LoadOrders(dgvOrders);
        }
    }
}
