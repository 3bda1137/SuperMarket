using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class SpalshForm : Form
    {
        public SpalshForm()
        {
            InitializeComponent();
        }
        private void SpalshForm_Load(object sender, EventArgs e)
        {
            timer_Start.Start();
        }

        int startpoint = 0;
        private void timer_Start_Tick(object sender, EventArgs e)
        {
            startpoint += 4;
            AM_ProgressBar.Value = startpoint;
            if(AM_ProgressBar.Value==100)
            {
                AM_ProgressBar.Value = 0;
                timer_Start.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

       
    }
}
