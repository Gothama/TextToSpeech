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

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        private int j =0;
        SpeechSynthesizer voice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            voice = new SpeechSynthesizer();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                switch (j)
                {
                    case 0:
                        voice.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case 1:
                        voice.SelectVoiceByHints(VoiceGender.Male);
                        break;

                    default:
                        voice.SelectVoiceByHints(VoiceGender.Neutral);
                        break;
                }
                voice.SpeakAsync(textBox1.Text);
            }
            catch(Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                voice.Pause();
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            try
            {
                voice.Resume();
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            j = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            j = 1;
        }
    }
}
