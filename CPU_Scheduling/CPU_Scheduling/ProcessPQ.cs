using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    public partial class ProcessPQ : UserControl
    {
        public ProcessPQ()
        {
            InitializeComponent();

        }
        private int _maximum;
        private int _num;
        public int Arrival
        {
            get { return Convert.ToInt32(txtArrival.Text.Trim()); }
            set { txtArrival.Text = value.ToString(); }

        }
        public int Burst
        {
            get { return Convert.ToInt32(txtBurst.Text.Trim()); }
            set { txtBurst.Text = value.ToString(); }
        }
        public int Prior
        {
            get { return Convert.ToInt32(txtPrior.Text.Trim()); }
            set { txtPrior.Text = value.ToString(); }
        }
        public int Num
        {
            get { return _num; }
            set { _num = value; txtNum.Text += value.ToString(); }
        }
        public int Maxtime
        {
            get { return _maximum; }
            set { _maximum = value; proStatus.Maximum = value; }
        }

        public int End = 0;
        public int Start = 0;
        private int _wait = 0;
        public int WaitT
        {
            get { return _wait; }
            set { _wait = value; }

        }
        public void setWait(int wait)
        {
            txtWait.Text = wait.ToString();
        }
        public int Turnaround = 0;
        public int Response = 0;
        
        Timer timer1 = new Timer();
        
        //public void timer1_Tick(int load)
        //{
          

        //    T.Tick -= Loadpro;
        //    proStatus.Maximum = Burst;

        //    T.Tick += (Loadpro);
        //    T.Interval = 1000;
        //    T.Start();
        //}
        public void stop()
        {
            timer1.Stop();
            proStatus.Value = 0;
            setWait(0);
        }
        int progress = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            progress++;
            if (progress > proStatus.Maximum)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            else  proStatus.Value = progress;

        }

        private void txtBurst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void proStart()
        {
            
            timer1.Tick -= timer1_Tick;
            progress = 0;
            proStatus.Maximum = Burst;
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();


        }
        public void proStop()
        {
            timer1.Stop();
            

        }

       
    }
}
