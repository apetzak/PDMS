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
    public partial class frmManager : frmMain
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void frmManager_Resize(object sender, EventArgs e)
        {
            lbReports.Height = this.Height - 358;
        }
    }
}
