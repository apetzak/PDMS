using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDMS
{
    public partial class frmAdmin : frmMain
    {
        public DataController controller = new DataController();

        public DataGridView dgvUsers = new DataGridView();

        public List<Control> orderControls = new List<Control>();

        public frmAdmin()
        {
            InitializeComponent();
            foreach (Control c in groupBox.Controls)
                orderControls.Add(c);

            groupBox.Controls.Clear();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            ButtonClick("Order Entry", (sender as Button));
            foreach (Control c in orderControls)
                groupBox.Controls.Add(c);

            dgvLineItems.Rows.Clear();
            comboPatient.Items.Clear();
            comboPatient.Text = "";
            comboPrescriptions.Text = "";

            List<string> patients = controller.LoadName("patients");
            foreach (string s in patients)
                comboPatient.Items.Add(s);

            dtDate.Value = DateTime.Today;
            string branch = this.Text.Remove(0, 7);
            int i = controller.LoadExpectedDelivery(branch);
            DateTime date = DateTime.Today;
            date = date.AddDays(i);
            dtExpectedDelivery.Value = date;

            lblOrderNumber.Text = controller.LoadOrderCount().ToString();
        }

        private void comboPatient_TextChanged(object sender, EventArgs e)
        {
            comboPrescriptions.Items.Clear();

            List<string> prescriptions = controller.LoadPrescriptions(comboPatient.Text);
            foreach (string s in prescriptions)
                comboPrescriptions.Items.Add(s);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboPrescriptions.Text == "")
                return;

            string item = comboPrescriptions.Text;
            string uofm = "Each";
            string s = "";

            if (item.EndsWith("Case"))
            {
                uofm = "Case";
                s = item.Remove(item.Length - 7);
            }
            else
                s = item;

            dgvLineItems.Rows.Add(new object[] {
                    s,
                    controller.LoadPrice(item, uofm),
                    uofm,
                    });

            comboPrescriptions.Text = "";
            
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            double total = 0;
            double tax = 0;
            double subtotal = 0;

            foreach (DataGridViewRow row in dgvLineItems.Rows)
                subtotal += Convert.ToDouble(row.Cells[1].Value);
            
            tax = subtotal * .06;

            total = tax + subtotal;

            lblSub.Text = "$" + subtotal;
            lblTax.Text = "$" + tax;
            lblTotal.Text = "$" + total;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string medicines = "";

            foreach (DataGridViewRow row in dgvLineItems.Rows)
                medicines = medicines + row.Cells[0].Value.ToString() + ", ";

            medicines = medicines.Remove(medicines.Length - 2);

            controller.CreateOrder(Convert.ToInt32(lblOrderNumber.Text), medicines, comboPatient.Text, "", dtDate.Value, dtExpectedDelivery.Value, 0);

            lblOrderNumber.Text = controller.LoadOrderCount().ToString();
            comboPatient.Text = "";
            comboPrescriptions.Text = "";
            dgvLineItems.Rows.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            comboPatient.Text = "";
            comboPrescriptions.Text = "";
            dgvLineItems.Rows.Clear();
        }

        private void dgvLineItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblSub.Text = "$0.00";
            lblTax.Text = "$0.00";
            lblTotal.Text = "$0.00";
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ButtonClick("Users", (sender as Button));
            CreateUsersGrid();
        }

        private void CreateUsersGrid()
        {
            DataGridView dgv = new DataGridView();
            dgv.Width = 490;
            dgv.Height = 650;
            dgv.Location = new Point(20, 90);
            dgv.ColumnCount = 3;
            dgv.Columns[0].Name = "username";
            dgv.Columns[0].Width = 140;
            dgv.Columns[1].Name = "role";
            dgv.Columns[1].Width = 130;
            dgv.Columns[2].Name = "branch";
            dgv.Columns[2].Width = 160;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AllowUserToAddRows = false;

            dgvUsers = dgv;

            AddButton("Create User", 20, 30);
            AddButton("Delete User", 165, 30);

            groupBox.Controls.Add(dgvUsers);
            controller.LoadUsers(dgvUsers);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser(dgvUsers);
            form.BackColor = this.BackColor;
            form.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count != 0)
                controller.DeleteUser(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
            controller.LoadUsers(dgvUsers);
        }

        public Label number = new Label();
        public Label medicine = new Label();
        public ComboBox comboMedicine = new ComboBox();
        public Label branch = new Label();
        public ComboBox comboBranch = new ComboBox();
        public Label quantity = new Label();
        public TextBox txtQty = new TextBox();
        public Button btnEnter = new Button();

        private void btnEnterShipments_Click(object sender, EventArgs e)
        {
            ButtonClick("Enter Shipments", (sender as Button));

            comboMedicine.Items.Clear();
            comboBranch.Items.Clear();
            txtQty.Text = "";

            number.Location = new Point(30, 40);
            number.Text = "Shipment Number: " + controller.LoadShipmentCount();
            number.Width = 200;
            groupBox.Controls.Add(number);
            
            medicine.Location = new Point(30, 80);
            medicine.Text = "Medicine: ";
            groupBox.Controls.Add(medicine);
            
            comboMedicine.Location = new Point(140, 80);
            controller.LoadMedicines(comboMedicine);
            groupBox.Controls.Add(comboMedicine);
            
            branch.Location = new Point(30, 120);
            branch.Text = "Branch: ";
            groupBox.Controls.Add(branch);
            
            comboBranch.Location = new Point(140, 120);
            List<string> branches = controller.LoadName("warehouses");
            foreach (string s in branches)
                comboBranch.Items.Add(s);
            groupBox.Controls.Add(comboBranch);
            
            quantity.Location = new Point(30, 160);
            quantity.Text = "Quantity: ";
            groupBox.Controls.Add(quantity);
         
            txtQty.Location = new Point(140, 160);
            groupBox.Controls.Add(txtQty);
         
            btnEnter.Text = "Enter";
            btnEnter.Location = new Point(30, 200);
            btnEnter.Click += BtnEnter_Click;
            btnEnter.Width = 100;
            btnEnter.Height = 30;
            btnEnter.BackColor = SystemColors.Control;
            groupBox.Controls.Add(btnEnter);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (comboMedicine.Text == "" || comboBranch.Text == "" || txtQty.Text == "")
                return;

            try
            {
                controller.InsertShipment(comboMedicine.Text, comboBranch.Text, Convert.ToInt32(txtQty.Text), controller.LoadShipmentCount(), controller.LoadExpireDate(comboMedicine.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            comboMedicine.Text = "";
            comboBranch.Text = "";
            txtQty.Text = "";
            number.Text = "Shipment Number: " + controller.LoadShipmentCount();
        }

        public OpenFileDialog dialog = new OpenFileDialog();
        public string filePath = "";
        public string importType = "medicines";

        private void btnImport_Click(object sender, EventArgs e)
        {
            ButtonClick("Import CSV File", (sender as Button));

            AddButton("Patients", 50, 50);
            AddButton("Medicines", 50, 100);
            AddButton("Warehouses", 50, 150);
            AddButton("Inventory", 50, 200);
        }

        public void ButtonClick(string text, Button btn)
        {
            foreach (Control c in this.Controls)
                if (c.GetType() == typeof (Button))
                    c.Enabled = true;
            btn.Enabled = false;
            groupBox.Text = text;
            groupBox.Controls.Clear();
            groupBox.Focus();
        }

        public void AddButton(string text, int x, int y)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Width = 120;
            btn.Height = 30;
            btn.Location = new Point(x, y);
            btn.BackColor = SystemColors.Control;

            if (groupBox.Text == "Import CSV File")
                btn.Click += btnImportSelection_Click;
            else if (text == "Create User")
                btn.Click += btnAddUser_Click;
            else if (text == "Delete User")
                btn.Click += btnDeleteUser_Click;

            groupBox.Controls.Add(btn);
        }

        private void btnImportSelection_Click(object sender, EventArgs e)
        {
            importType = (sender as Button).Text;
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(dialog.FileName);
                    filePath = dialog.FileName;
                    sr.Close();

                    controller.ImportData(filePath, importType);
                }
                else
                {
                    filePath = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAdmin_Resize(object sender, EventArgs e)
        {
            groupBox.Width = this.Width - 250;
            groupBox.Height = this.Height - 260;
        }

        private void groupBox_Resize(object sender, EventArgs e)
        {
            dgvUsers.Height = (sender as GroupBox).Height - 110;
        }
    }
}
