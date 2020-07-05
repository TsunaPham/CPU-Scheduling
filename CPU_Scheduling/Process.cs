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
    public partial class Process : UserControl
    {
        public Process()
        {
            InitializeComponent();

            proStatus.Maximum = Burst;
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
        public int Num
        {
            get { return _num; }
            set { _num = value; txtNum.Text += value.ToString();  }
        }
        public int Maxtime
        {
            get { return _maximum; }
            set { _maximum = value; proStatus.Maximum = value; }
        }
        
        public int End=0;
        public int Start=0;
        private int _wait=0;
        public int WaitT
        {
            get { return _wait; }
            set { _wait = value; }

        }
        public void setWait(int wait)
        {
            txtWait.Text = wait.ToString();
        }
        public int Turnaround=0;
        Timer T = new Timer();
        public void loadprogress()
        {
            T.Tick -= Loadpro;
            proStatus.Maximum = Burst;

            T.Tick += (Loadpro);
            T.Interval = 1000;
            T.Start();
        }
        public void stop()
        {
            T.Stop();
            proStatus.Value = 0;
            setWait(0);
        }
        private void Loadpro(object sender, EventArgs e)
        {

            if (proStatus.Value != proStatus.Maximum)
            {
                proStatus.Value++;
            }
            
        }

        private void txtBurst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
