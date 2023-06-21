using System;
using System.Windows.Forms;

namespace CP_Session
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            timerAbout.Enabled = true;
            timerAbout.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timerAbout.Enabled)
            {
                timerAbout.Stop();
                timerAbout.Enabled = false;
            }
            Close();
        }

        private void timerAbout_Tick(object sender, EventArgs e)
        {
            timerAbout.Stop();
            timerAbout.Enabled = false;
            Close();
        }
    }
}
