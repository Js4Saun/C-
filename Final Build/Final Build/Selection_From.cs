using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Build
{
    public partial class Selection_From : Form
    {
        public Selection_From()
        {
            InitializeComponent();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Disclaimer Dform = new Disclaimer();
            Dform.Show();
            this.Close();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if (RBTN_Cat.Checked == true)
            {
                Cataracts Cform = new Cataracts();
                Cform.Show();
                this.Hide();
            }
            else if (RDBTN_AMD.Checked == true)
            {
                AMD AMDform = new AMD();
                AMDform.Show();
                this.Hide();
            }
            else if (RDBTN_Galucoma.Checked == true)
            {
                Galcuoma Gform = new Galcuoma();
                Gform.Show();
                this.Hide();
            }
            else if (RDBTN_Trachoma.Checked == true)
            {
                Trachoma Tform = new Trachoma();
                Tform.Show();
                this.Hide();
            }
        }
    }
}
