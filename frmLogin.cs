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
        public frmLogin()
        {
            InitializeComponent();
            
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
            }                                  
            else if (txtUsername.Text == "2")
            {
                form2.Show();
                form2.User = User;
            }                     
            else if (txtUsername.Text == "3")
            {
                form3.Show();
                form3.User = User;
            }                                
            else  
            {
                form4.Show();
            }                
            this.Hide();
        }
    }
}
