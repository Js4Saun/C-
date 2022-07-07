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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            //Open Selection Form
            Selection_From selection_From = new Selection_From();
            selection_From.Show();
            this.Hide();
        }
    }
}
