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

        public int UserRole;
        public string UserName;
        public string UserPassword;

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            frmAdmin form1 = new frmAdmin();
            frmPharmacist form2 = new frmPharmacist();
            frmManager form3 = new frmManager();
            
            UserName = controller.LoadUserName(txtUsername.Text);
            UserRole = controller.LoadUserRole(UserName);
            UserPassword = controller.LoadUserPassword(UserName);

            if (UserName == "")
            {
                label1.Text = "User Does Not Exist!";
                return;
            }

            if (txtPassword.Text != UserPassword && UserPassword != " ")
            {
                label1.Text = "Incorrect Password!";
                return;
            }

            if (UserPassword == " " && txtConfirmPassword.Visible == false)
            {
                label1.Text = "Welcome, " + UserName + "! Please set your password";
                txtConfirmPassword.Show();
                btnLogin.Location = new Point(135, 113);
                this.Height += 25;
                label2.Show();
                
                btnLogin.Text = "Confirm";

                return;
            }

            if (txtConfirmPassword.Visible == true)
            {
                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    label1.Text = "Passwords do not match!";
                    return;
                }
                else if (txtConfirmPassword.Text.Length < 8)
                {
                    label1.Text = "Password must be at least 8 characters";
                    return;
                }
                else
                {
                    controller.SetPassword(UserName, txtPassword.Text);
                }
            }
               
            if (UserRole == 0)
            {
                form1.Show();
                form1.UserRole = UserRole;
                form1.BackColor = this.BackColor;
                form1.Text = "PDMS - " + controller.LoadUserBranch(UserName);
            }                                  
            else if (UserRole == 1)
            {
                form2.Show();
                form2.UserRole = UserRole;
                form2.BackColor = this.BackColor;
                form2.Text = "PDMS - " + controller.LoadUserBranch(UserName);
                form2.UserName = this.UserName;
            }                     
            else if (UserRole == 2)
            {
                form3.Show();
                form3.UserRole = UserRole;
                form3.BackColor = this.BackColor;
            }                                      
            this.Hide();
        }
    }
}
