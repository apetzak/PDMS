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
    public partial class frmLogin : Form
    {
        DataController controller = new DataController();

        public frmLogin()
        {
            InitializeComponent();
            //controller.CreateTables();
            //controller.InsertData();
        }

        public int User;

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            frmAdmin form1 = new frmAdmin();
            frmPharmacist form2 = new frmPharmacist();
            frmManager form3 = new frmManager();
            frmMain form4 = new frmMain();

            if (txtUsername.Text != "")
                User = Convert.ToInt32(txtUsername.Text);

            if (txtUsername.Text == "1")
            {
                form1.Show();
                form1.User = User;
                form1.BackColor = this.BackColor;
            }                                  
            else if (txtUsername.Text == "2")
            {
                form2.Show();
                form2.User = User;
                form2.BackColor = this.BackColor;
            }                     
            else if (txtUsername.Text == "3")
            {
                form3.Show();
                form3.User = User;
                form3.BackColor = this.BackColor;
            }                                
            else  
            {
                form4.Show();
                form4.BackColor = this.BackColor;
            }                
            this.Hide();
        }
    }
}
