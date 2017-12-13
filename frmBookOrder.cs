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
    public partial class frmBookOrder : Form
    {
        public DataController controller = new DataController();

        public frmBookOrder(int orderNumber, string pharmacist)
        {
            InitializeComponent();
            lblOrderNumber.Text = "Order Number: " + orderNumber;
            controller.LoadLineItems(dgvItems, orderNumber);
            OrderNumber = orderNumber;
            Pharmacist = pharmacist;
        }

        public int OrderNumber = 0;
        public string Pharmacist = "";

        private void btnFulfill_Click(object sender, EventArgs e)
        {
            if (comboAvailable.Text == "")
                return;
           
            dgvItems.SelectedRows[0].Cells[2].Value = 1;

            string[] s = comboAvailable.Text.Split('/');
            string shipmentNumber = s[2];
            shipmentNumber = shipmentNumber.Remove(0, 1);
            shipmentNumber = shipmentNumber.Remove(shipmentNumber.Length - 1);

            dgvItems.SelectedRows[0].Cells[3].Value = shipmentNumber;

            comboAvailable.Text = "";
            comboAvailable.Items.Clear();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            comboAvailable.Items.Clear();

            if (dgvItems.SelectedRows.Count == 0)
                return;

            controller.LoadAvailableQty(comboAvailable, dgvItems.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells[1].Value.ToString() == "Each")
                    controller.UpdateInventory(row.Cells[3].Value.ToString(), 0);
                else
                    controller.UpdateInventory(row.Cells[3].Value.ToString(), 1);
            }

            controller.UpdateOrder(OrderNumber, Pharmacist);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
