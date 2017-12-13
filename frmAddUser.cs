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
    public partial class frmAddUser : Form
    {
        DataController controller = new DataController();

        DataGridView DgvUsers = new DataGridView();

        public frmAddUser(DataGridView dgvUsers)
        {
            InitializeComponent();
            DgvUsers = dgvUsers;

            List<string> list = controller.LoadName("warehouses");

            foreach (string s in list)
                comboBranches.Items.Add(s);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || comboRoles.SelectedItem == "" || comboBranches.SelectedItem == "")
            {
                return;
            }

            int role = 0;
            if (comboRoles.SelectedItem == "Pharmacist")
                role = 1;
            else if (comboRoles.SelectedItem == "Financial Manager")
                role = 2;

            controller.InsertUser(txtUsername.Text, role, comboBranches.SelectedItem.ToString());

            txtUsername.Text = "";

            controller.LoadUsers(DgvUsers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
