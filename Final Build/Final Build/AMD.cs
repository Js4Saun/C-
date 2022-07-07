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
    public partial class AMD : Form
    {
        private SpeechSynthesizer Synth;
        public AMD()
        {
            InitializeComponent();
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            Selection_From Gform = new Selection_From();
            Gform.Show();
            this.Close();
        }

        private void BTN_SoundAMD_Click(object sender, EventArgs e)
        {
            bool play = false;

            if (play != true)
            {
                Synth = new SpeechSynthesizer();
                Synth.Speak(this.textBoxAMD.Text);
                play = true;
            }
        }
    }
}
