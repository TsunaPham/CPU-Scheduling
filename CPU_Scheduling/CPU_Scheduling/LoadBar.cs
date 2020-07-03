using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    class LoadBar
    {
        public ProgressBar b1 = new ProgressBar();
        public int Max { set; get; }
        public void load()
        {
            Timer T = new Timer();
            
            b1.Maximum = Max;
            b1.Width = 25*Max;
            T.Tick += new EventHandler(Loadpro);
            T.Interval = 1000;
            T.Start();
        }
        private void Loadpro(object sender, EventArgs e)
        {
            if (b1.Value !=Max)
            {
                b1.Value++;
            }
            
        }
    }
}
