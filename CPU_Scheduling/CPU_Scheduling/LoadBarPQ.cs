using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    class LoadBarPQ
    {
        public ProgressBar b1 = new ProgressBar();
        public int Max { set; get; }
        Timer timer1 = new Timer();
        int progress = 0;
        //public void load()
        //{

        //    T.Tick -= Loadpro;
        //    b1.Maximum = Max;
        //    b1.Width = 25 * Max;
        //    T.Tick += Loadpro;
        //    T.Interval = 1000;
        //    T.Start();
        //}
        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;
            if (progress > b1.Maximum)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }

            else b1.Value = progress;

        }
        public void setMax()
        {
            b1.Maximum = Max;
            b1.Width = 25 * Max;
        }
        public void proStart()
        {
            timer1.Tick -= timer1_Tick;
            
            
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
