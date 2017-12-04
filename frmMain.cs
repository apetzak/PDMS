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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            List<Color> colors = GetColors(new List<Color>());
            foreach (Color c in colors)
                comboColor.Items.Add(c.Name);

            comboColor.Sorted = true;

        }

        public int User;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.BackColor = this.BackColor;
            form.Show();
            this.Close();          
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string header = "";

            if (btn.Name == "btnMedicines")
                header = "Medicines";

            if (btn.Name == "btnPatients")
                header = "Patients";

            if (btn.Name == "btnWarehouses")
                header = "Warehouses";

            frmSearch searchForm = new frmSearch(header, User);
            searchForm.BackColor = this.BackColor;

            //searchForm.User = User;
            searchForm.Show();
            this.Close();
        }

        private void comboColor_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Color> colors = GetColors(new List<Color>());
            foreach (Color c in colors)
                if (c.Name == comboColor.Text)
                    this.BackColor = c;
        }

        List<Color> GetColors(List<Color> colors)
        {
            colors.Add(Color.Coral);
            colors.Add(Color.Orange);
            colors.Add(Color.Yellow);
            colors.Add(Color.Green);
            colors.Add(Color.DodgerBlue);
            colors.Add(Color.MediumPurple);
            colors.Add(Color.Violet);
            colors.Add(Color.Crimson);
            colors.Add(Color.PeachPuff);
            colors.Add(Color.LightYellow);
            colors.Add(Color.LawnGreen);
            colors.Add(Color.Aqua);
            colors.Add(Color.DeepPink);
            colors.Add(Color.Purple);
            colors.Add(Color.RosyBrown);
            colors.Add(Color.Salmon);
            colors.Add(Color.WhiteSmoke);
            colors.Add(Color.Turquoise);
            colors.Add(Color.Tomato);
            colors.Add(Color.SteelBlue);
            colors.Add(Color.SlateGray);
            colors.Add(Color.Tan);
            colors.Add(Color.YellowGreen);
            colors.Add(Color.Ivory);
            colors.Add(Color.MistyRose);
            colors.Add(Color.MediumVioletRed);
            colors.Add(Color.Moccasin);
            colors.Add(Color.Plum);
            colors.Add(Color.SpringGreen);
            colors.Add(Color.Wheat);
            colors.Add(Color.PowderBlue);
            colors.Add(Color.NavajoWhite);
            colors.Add(Color.IndianRed);
            colors.Add(Color.Aquamarine);
            colors.Add(Color.Bisque);
            colors.Add(Color.Cyan);
            colors.Add(Color.Gray);
            colors.Add(Color.Gold);
            colors.Add(Color.Orchid);
            colors.Add(Color.Silver);
            colors.Add(Color.Plum);
            colors.Add(Color.DarkKhaki);
            colors.Add(SystemColors.Control);

            return colors;
        }
    }
}
