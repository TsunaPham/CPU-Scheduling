using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    public partial class FCFS : Form
    {
       
        public FCFS()
        {
            InitializeComponent();
            populate();
            picBusy.Hide();
            picWaiting.Show();
        }
        private int _num;
        private int _max;
        private int _min;
        public int Numpro
        {
            get { return _num; }
            set { _num = value; }
        }
        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        Random rand = new Random();
        private int Normal(double mean, double stdDev, int max, int min)
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
        Process[] prolist;
        public void populate()
        {prolist = new Process[_num];
           
            double mean = (double)(_max + _min)/(double) 2;
            double stdDev = (double)(_max - _min) / (double)6;
            MessageBox.Show(mean.ToString());
            for (int i = 0; i < _num; i++)

            {   
                prolist[i] = new Process();
                prolist[i].Arrival = Normal(mean, stdDev, _max, _min);
                prolist[i].Burst = Normal(mean, stdDev, _max, _min);
                flowLayoutPanel1.Controls.Add(prolist[i]);
            }
            
        }
        public void addrow()
        {
            tableLayoutPanel1.ColumnCount=3;
        }
        private void LoadBar(Process p1)
        {
           
            LoadBar newload = new LoadBar();
            newload.Max = p1.Burst;
            int i = tableLayoutPanel1.ColumnCount++;
            
            tableLayoutPanel1.Controls.Add(newload.b1, i - 1, 0);
            newload.load();
            p1.loadprogress();

        }
        int counttick;
        int orderpro=0;
        int counttime;
        private void btnStart_Click(object sender, EventArgs e)
        {   
            timer1.Interval = 2000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {   if (orderpro < Numpro)
            {

                if (counttick == 0) { LoadBar(prolist[orderpro]); picBusy.Show();picWaiting.Hide(); }
                counttick++;
                if (counttick == prolist[orderpro].Burst) { counttick = 0; orderpro++; }
            }
            else timer1.Stop();
        }

    }
}
