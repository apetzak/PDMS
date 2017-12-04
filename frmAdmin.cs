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

        public frmAdmin()
        {
            InitializeComponent();
        }

        public OpenFileDialog dialog = new OpenFileDialog();
        public string filePath = "";
        public string importType = "medicines";

        private void btnImport_Click(object sender, EventArgs e)
        {
            groupBox.Text = "Import csv file";
            AddButton("Patients", 50);
            AddButton("Medicines", 100);
            AddButton("Warehouses", 150);
        }

        public void AddButton(string text, int y)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Width = 120;
            btn.Height = 30;
            btn.Location = new Point(50, y);
            btn.BackColor = SystemColors.Control;
            btn.Click += btn_Click;
            groupBox.Controls.Add(btn);
        }

        private void btn_Click(object sender, EventArgs e)
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
    }
}
