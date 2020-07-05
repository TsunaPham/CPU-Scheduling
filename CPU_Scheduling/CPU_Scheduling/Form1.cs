using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.VisualStyles;

namespace CPU_Scheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } Random rand = new Random();
        private int Normal(double mean,double stdDev,int max,int min)
        {
            int k = max + 1;
            while (k > max || k < min)
            {
                double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
                double u2 = 1.0 - rand.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                             Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)


                double randNormal = mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
                k = (int)Math.Floor(randNormal);

            }

            return k;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {    double mean = 8;
            double stdDev = 3;
           
               int k = Normal(mean,stdDev,11,0);
           
            MessageBox.Show(k.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdFCFS.Checked == true)
            {
                FCFS fcfs = new FCFS();
                fcfs.Numpro = Convert.ToInt32(txtNum.Text.Trim());
                fcfs.Max = Convert.ToInt32(txtMax.Text.Trim());
                fcfs.Min = Convert.ToInt32(txtMin.Text.Trim());
                fcfs.Show(); this.Hide();
                if (checkRan.Checked == true) fcfs.ran = true;
                fcfs.populate();

            }

            if (rdPQ.Checked == true)
            {
                PQ pq = new PQ();
                pq.Numpro = Convert.ToInt32(txtNum.Text.Trim());
                pq.Max = Convert.ToInt32(txtMax.Text.Trim());
                pq.Min = Convert.ToInt32(txtMin.Text.Trim());
                pq.Show(); this.Hide();
                if (checkRan.Checked == true) pq.ran = true;
                pq.populate();
            }

            if (rdSJF.Checked == true)
            {
                SJF sjf = new SJF();
                sjf.Numpro = Convert.ToInt32(txtNum.Text.Trim());
                sjf.Max = Convert.ToInt32(txtMax.Text.Trim());
                sjf.Min = Convert.ToInt32(txtMin.Text.Trim());
                sjf.Show(); this.Hide();
                if (checkRan.Checked == true) sjf.ran = true;
                sjf.populate();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
