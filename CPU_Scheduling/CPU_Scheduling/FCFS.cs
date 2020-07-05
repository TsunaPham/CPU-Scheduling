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
using System.Timers;
using System.Diagnostics;

namespace CPU_Scheduling
{
    public partial class FCFS : Form
    {
       
        public FCFS()
        {
            InitializeComponent();
            
            picBusy.Hide();
            picWaiting.Show();
           
        }
       
       
        public bool ran = false;
        public int Numpro;

        public int Max;

        public int Min;
       
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
        Process[] dosched;
        public void populate()
        {   prolist = new Process[Numpro];           
            double mean = (double)(Max + Min)/(double) 2;
            double stdDev = (double)(Max - Min) / (double)6;
            
            for (int i = 0; i < Numpro; i++)

            {   
                prolist[i] = new Process();
                prolist[i].Num = i;
                if (ran == true)
                {
                    prolist[i].Arrival = Normal(mean, stdDev, Max, Min);
                    prolist[i].Burst = Normal(mean, stdDev, Max, Min);
                }
                else
                {
                    prolist[i].Arrival = 0;
                    prolist[i].Burst = 1;
                }
                flowLayoutPanel1.Controls.Add(prolist[i]);
            }
            
        }
        int totalwait=0;
        int totalturnAround=0;
        public void Sched()
        {
            dosched = new Process[Numpro];
            dosched = prolist;
            dosched.Count();
            for (int k = 0; k < Numpro; k++)
            {
                for (int i = k + 1; i < Numpro; i++)
                {
                    if (dosched[k].Arrival > dosched[i].Arrival ||((dosched[i].Arrival==dosched[k].Arrival) && (dosched[k].Num>dosched[i].Num )))
                    {
                        Process temp = new Process();
                        temp = dosched[i];
                        dosched[i] = dosched[k];
                        dosched[k] = temp;
                    }
                }
            }

            int clock = 0;
            totalwait = 0; totalturnAround = 0;
            for (int i = 0; i < Numpro; i++)
            {
                if (dosched[i].Arrival >= clock)
                {
                    dosched[i].Start = dosched[i].Arrival;
                    clock += dosched[i].Start;
                    clock += dosched[i].Burst;

                }
                else
                {
                    if (i > 0)
                        dosched[i].Start = dosched[i - 1].End;
                    
                    clock += dosched[i].Burst;
                }
                if (dosched[i].Start > dosched[i].Arrival)
                    dosched[i].WaitT = dosched[i].Start - dosched[i].Arrival;
                else dosched[i].WaitT = 0;
                dosched[i].End = dosched[i].Start + dosched[i].Burst;
                dosched[i].Turnaround = dosched[i].WaitT + dosched[i].Burst;
                totalwait += dosched[i].WaitT;
                totalturnAround += dosched[i].Turnaround;
            }
            
            for(int i=0;i<Numpro;i++)
            {   for(int k=0;k<Numpro;k++)
                    if (dosched[i].Num == prolist[k].Num)
                    {
                        prolist[k].WaitT = dosched[i].WaitT;
                    }
            }
            
        }
        
        private void LoadBar(Process p1)
        {   
            Process k = new Process();
            k = p1;
            Label k1 = new Label();
            Label k2 = new Label();
            k1.Text = "P" + p1.Num.ToString();
            k2.Text = "Start time " + p1.Start.ToString();
            LoadBar newload = new LoadBar();
            newload.Max = k.Burst;
            int i = tableLayoutPanel1.ColumnCount++;
            newload.load();
           
            tableLayoutPanel1.Controls.Add(k1, i - 1, 0);
            tableLayoutPanel1.Controls.Add(newload.b1, i - 1, 1);
            tableLayoutPanel1.Controls.Add(k2, i - 1, 2);
            
            picBusy.Show();
            picWaiting.Hide();
            k.loadprogress();
            
        }
       
        int orderpro=0;
        int counttime=0;
        int endtime = 0;
        bool stop;
        private void btnStart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Enabled = false;
            timer1.Tick -= timer1_Tick;
            Simulate();
        }
        private void Simulate()
        {
            Sched();
            
            counttime = 0;
            for (int i = 0; i < Numpro; i++)
            {
                if (endtime < prolist[i].End) endtime = prolist[i].End;
            }
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
           
            timer1.Start();
        }
        

        
        int wait = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            string waitpro = "";

                lbClock.Text = (counttime).ToString();
                for (int i = 0; i < Numpro; i++)
                {
                    if (counttime == prolist[i].Start)
                    {
                        wait = prolist[i].End;
                        prolist[i].setWait(prolist[i].WaitT);
                        LoadBar(prolist[i]);
                        lbCurrent.Text = "P" + prolist[i].Num.ToString();

                    }


                }
                int numqueue = 0;
                for (int k = 0; k < Numpro; k++)
                    if ((counttime > dosched[k].Arrival) && (counttime < dosched[k].Start))
                    { waitpro += "P" + dosched[k].Num.ToString() + "|"; numqueue++; }
                lbWait.Text = waitpro; lbQueue.Text = numqueue.ToString();
                if (counttime < wait ) { lbStatus.Text = "Busy"; picBusy.Show(); picWaiting.Hide(); }
                else if(counttime<endtime) { lbStatus.Text = "Wait"; picBusy.Hide(); picWaiting.Show(); }


                if (counttime == endtime+1) { timer1.Stop(); lbStatus.Text = "Idle"; picBusy.Hide(); picWaiting.Show();lbCurrent.Text = "non";
                    lbWaitT.Text = Math.Round((double)totalwait / (double)Numpro, 2).ToString();
                    lbTurn.Text = Math.Round((double)totalturnAround / (double)Numpro, 2).ToString();
                }
                counttime++;
            
           
        }
        
        private void btnRestart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Enabled = true;
            timer1.Tick -= timer1_Tick;
            picBusy.Hide();picWaiting.Show();
            lbClock.Text = "0";
            lbQueue.Text = "0";
            lbStatus.Text = "Idle";
            lbCurrent.Text = "P";
            lbTurn.Text = "0";
            lbWaitT.Text = "0";

            flowLayoutPanel1.Controls.Clear();
            for (int i = tableLayoutPanel1.Controls.Count - 1; i >= 0; --i)
                tableLayoutPanel1.Controls[i].Dispose();

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnCount = 1;

          
            for (int i = 0; i < Numpro; i++)

            {
                prolist[i].stop();
                
                flowLayoutPanel1.Controls.Add(prolist[i]);
            }
            
            //flowLayoutPanel1.Controls.Clear();



        }

        private void FCFS_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(formclose);

        }
        private void formclose(object sender, EventArgs e)
        {
            Form1 k = new Form1();
            k.Show();
        }
    }
}
