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
        }
        private int _arrival;
       
        private int _maximum;
        public int Arrival
        {
            get { return Convert.ToInt32(txtArrival.Text.Trim()); }
            set { txtArrival.Text += value.ToString(); }

        }
        public int Burst
        {
            get { return Convert.ToInt32(txtBurst.Text.Trim()); }
            set { txtBurst.Text += value.ToString(); }
        }
        public int Num
        {
            get { return Convert.ToInt32(txtNum.Text.Trim()); }
            set { txtNum.Text += value.ToString();  }
        }
        public int Maxtime
        {
            get { return _maximum; }
            set { _maximum = value; proStatus.Maximum = value; }
        }
        public void loadprogress()
        {

            Timer T = new Timer();
            T.Interval = 1000;
            proStatus.Maximum = Burst;
           
            T.Tick += new EventHandler(Loadpro);
            T.Start();
        }

        private void Loadpro(object sender, EventArgs e)
        {

            if (proStatus.Value != Burst)
            {
                proStatus.Value++;
            }
            
        }
    }
}
