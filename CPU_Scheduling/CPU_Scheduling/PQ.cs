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
    public partial class PQ : Form
    {
        public PQ()
        {
            InitializeComponent();
            
            picBusy.Hide();
            picWaiting.Show();
        }
        public int Numpro;

        public int Max;

        public int Min;
        public bool ran = false;
        
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
        ProcessPQ[] prolist;
       
        public void populate()
        {
            listbar = new LoadBarPQ[Numpro];
            prolist = new ProcessPQ[Numpro];
            double mean = (double)(Max + Min) / (double)2;
            double stdDev = (double)(Max - Min) / (double)6;

            for (int i = 0; i < Numpro; i++)

            {
                prolist[i] = new ProcessPQ();
                prolist[i].Num = i;
                if (ran == true)
                {
                    prolist[i].Arrival = Normal(mean, stdDev, Max, Min);
                    prolist[i].Burst = Normal(mean, stdDev, Max, Min);
                    prolist[i].Prior = Normal(mean, stdDev, Max, Min);
                }
                else
                {
                    prolist[i].Arrival = 0;
                    prolist[i].Burst = 1;
                    prolist[i].Prior = 1;
                }
                flowLayoutPanel1.Controls.Add(prolist[i]);
            }

        }
        double avg_Turnaround = 0;
        double avg_WaitT = 0;
        
        public void Sched()
        {
          
            int total_Turnaround = 0;
            int total_WaitT = 0;
            int total_Response = 0;
            int total_idle_time = 0;
            
            int[] burst_remaining = new int[Numpro];

            int[] is_completed = new int[Numpro];
            for (int i=0;i<Numpro;i++)
            {
                burst_remaining[i] = prolist[i].Burst;
                is_completed[i] = 0;
            }
            

            int current_time = 0;
            int completed = 0;
            int prev = 0;

            while (completed < Numpro)
            {
                int idx = -1;
                int mx = int.MaxValue;
                for (int i = 0; i < Numpro; i++)
                {
                    if ((prolist[i].Arrival <= current_time) && (is_completed[i] == 0))
                    {
                        if (prolist[i].Prior < mx)
                        {
                            mx = prolist[i].Prior;
                            idx = i;
                        }
                        if (prolist[i].Prior == mx)
                        {
                            if (prolist[i].Arrival < prolist[idx].Arrival)
                            {
                                mx = prolist[i].Prior;
                                idx = i;
                            }
                        }
                    }
                }

                if (idx != -1)
                {
                    if (burst_remaining[idx] == prolist[idx].Burst)
                    {
                        prolist[idx].Start = current_time;
                        total_idle_time += prolist[idx].Start - prev;
                    }
                    burst_remaining[idx] -= 1;
                    current_time++;
                    prev = current_time;

                    if (burst_remaining[idx] == 0)
                    {
                        prolist[idx].End = current_time;
                        prolist[idx].Turnaround = prolist[idx].End - prolist[idx].Arrival;
                        prolist[idx].WaitT = prolist[idx].Turnaround - prolist[idx].Burst;
                        prolist[idx].Response = prolist[idx].Start - prolist[idx].Arrival;

                        total_Turnaround += prolist[idx].Turnaround;
                        total_WaitT += prolist[idx].WaitT;
                        total_Response += prolist[idx].Response;

                        is_completed[idx] = 1;
                        completed++;
                    }
                    
                }
                else
                {
                    current_time++;
                }

            }
            avg_Turnaround = Math.Round((double)total_Turnaround /(double)Numpro,2);
            avg_WaitT = Math.Round((double)total_WaitT / (double)Numpro, 2);
            //string la = "";
            //for (int i=0;i<Numpro;i++)

        }

        private void btnStart_Click(object sender, EventArgs e)
        {  
            
            flowLayoutPanel1.Enabled = false;
            timer1.Tick -= timer1_Tick;
            Simulate();

        }
        LoadBarPQ[] listbar;
        int[] burst_remain;
        private void prostart(ProcessPQ p1)
        {
            ProcessPQ k = new ProcessPQ();
            k = p1;
            listbar[p1.Num] = new LoadBarPQ();
            listbar[p1.Num].Max = k.Burst;
            listbar[p1.Num].setMax();
            Label k1 = new Label();
            Label k2 = new Label();
            k1.Text = "P" + p1.Num.ToString();
            k2.Text = "Start Time " + p1.Start.ToString();
            int i = tableLayoutPanel1.ColumnCount++;
            tableLayoutPanel1.Controls.Add(k1, i - 1, 0);
            tableLayoutPanel1.Controls.Add(listbar[p1.Num].b1, i-1, 1);
            tableLayoutPanel1.Controls.Add(k2, i - 1, 2);
            k.proStart();
            listbar[p1.Num].proStart();
        }
        private void prostop(ProcessPQ p1)
        {  
            p1.proStop();
            listbar[p1.Num].proStop();
        }
        private void proresume(ProcessPQ p1)
        {
            p1.proStart();
            listbar[p1.Num].proStart();
        }
        private void Simulate()
        {
            Sched();
            counttime = 0;
            burst_remain = new int[Numpro];
            for (int i=0;i<Numpro;i++)
            {
                burst_remain[i] = prolist[i].Burst;
            }
            for(int i=0;i<Numpro;i++)
            {
                if (endtime < prolist[i].End) endtime = prolist[i].End;
            }
            //dosched = new ProcessPQ[Numpro];dosched = prolist;

            //for (int k = 0; k < Numpro; k++)
            //{
            //    for (int i = k + 1; i < Numpro; i++)
            //    {
            //        if (dosched[k].Prior > dosched[i].Prior)
            //        {
            //            ProcessPQ temp = new ProcessPQ();
            //            temp = dosched[i];
            //            dosched[i] = dosched[k];
            //            dosched[k] = temp;
            //        }
            //    }
            //}
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();

        }
        int counttime = 0;
        int currentpro = -1;
        
        int determine = 0;
        int endtime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = counttime.ToString();
            if(determine==1)
            {
                for (int k = 0; k < Numpro; k++)
                {
                    if (counttime > prolist[k].Start && burst_remain[k] > 0 && k != currentpro) prostop(prolist[k]);
                    
                }
                determine = 0;
            }
            for (int i = 0; i < Numpro; i++)
            {
                if (prolist[i].Start == counttime)
                {
                    currentpro = i; prostart(prolist[i]); determine = 1; picBusy.Show();picWaiting.Hide(); lbStatus.Text = "Busy";

                }
            }
            if (currentpro > -1)
            {
                if (burst_remain[currentpro]-1 == 0) prolist[currentpro].setWait(prolist[currentpro].WaitT);
                string waitqueue = "";
                int numqueue = 0;
                for (int i=0;i<Numpro;i++)
                {
                    if(burst_remain[i]>0 && i!=currentpro)
                    {
                        waitqueue += "P"+prolist[i].Num.ToString()+"|";numqueue++;
                    }
                }
                lbWait.Text = waitqueue;
                lbCurrent.Text= "P" + currentpro.ToString(); ;
                lbQueue.Text = numqueue.ToString();
                if (burst_remain[currentpro] == 0)
                {
                    
                    //int[] lastprocess = new int[Numpro];
                    int t = 0;

                    for (int i = 0; i < Numpro; i++)
                    {
                        if (burst_remain[i] > 0 /*&& prolist[i].Prior< prolist[currentpro].Prior*/ && counttime>prolist[i].Start)
                        {   if (t == 0) { currentpro = i; t++; }
                            else if (prolist[i].Prior < prolist[currentpro].Prior) currentpro = i;
                           
                        }
                        
                    }
                    if (t == 0 &&counttime<endtime) { picWaiting.Show(); picBusy.Hide(); lbStatus.Text = "Waiting"; }
                    //int min = lastprocess[0];
                    //for(int i=0;i<num;i++)
                    //{
                    //    if(min<)
                    //}
                    proresume(prolist[currentpro]);
                }
                burst_remain[currentpro]--; 
            }
            //if (counttime == 3) prostart(prolist[0]);
            //if (counttime == 4) prostop(prolist[0]);
            //if (counttime == 7) prostop(prolist[0]);
            //if (counttime == 10) proresume(prolist[0]);
            if (counttime == endtime+1) 
                { 
                    timer1.Stop();
                    picWaiting.Show(); 
                    picBusy.Hide();
                    lbWaitT.Text = avg_WaitT.ToString();
                    lbTurn.Text = avg_Turnaround.ToString();
                    lbStatus.Text = "Idle";
                    lbCurrent.Text = "non";
               
                 }
            counttime++;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Enabled = true;
            timer1.Tick -= timer1_Tick;
            picBusy.Hide(); picWaiting.Show();
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
        }

        private void PQ_Load(object sender, EventArgs e)
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
