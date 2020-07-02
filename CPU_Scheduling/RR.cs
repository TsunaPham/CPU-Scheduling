using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    public partial class RR : Form
    {
        public RR()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 5;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 5)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
