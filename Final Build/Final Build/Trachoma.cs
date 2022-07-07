using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Final_Build
{
    public partial class Trachoma : Form
    {
        private SpeechSynthesizer Synth;
        public Trachoma()
        {
            InitializeComponent();
        }

        private void btn_gobak_Click(object sender, EventArgs e)
        {
            Selection_From Gform = new Selection_From();
            Gform.Show();
            this.Close();        }

        private void Trachoma_Load(object sender, EventArgs e)
        {

        }

        private void BTN_PlaySound_Click(object sender, EventArgs e)
        {
            bool play = false;

            if (play != true)
            {
                Synth = new SpeechSynthesizer();
                Synth.Speak(this.textBoxT.Text);
                play = true;
            }
        }
    }
}
