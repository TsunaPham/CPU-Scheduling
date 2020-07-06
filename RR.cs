using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        ProcessRR[] prolist;
        LoadBar2[] listbar;
        public void populate()
        {
            listbar = new LoadBar2[Numpro];
            prolist = new ProcessRR[Numpro];
            double mean = (double)(Max + Min) / (double)2;
            double stdDev = (double)(Max - Min) / (double)6;

            for (int i = 0; i < Numpro; i++)

            {
                prolist[i] = new ProcessRR();
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

        //bool compare1(ProcessRR p1, ProcessRR p2)
        //{
        //    return p1.Arrival < p2.Arrival;
        //}

        //bool compare2(ProcessRR p1, ProcessRR p2)
        //{
        //    return p1.Num < p2.Num;
        //}
        int quantum;
        ProcessRR[] dosched;
        Queue<int> simulate;
        Queue<int> time;
        double avg_WaitT;
        double avg_Turnaround;
        private void Sched()
        {
            simulate = new Queue<int>();
            time = new Queue<int>();
            dosched = new ProcessRR[Numpro];

            for (int i = 0; i < Numpro; i++)
            {
                dosched[i] = new ProcessRR();
                dosched[i].Arrival = prolist[i].Arrival;
                dosched[i].Burst = prolist[i].Burst;
                dosched[i].Num = i;

            }

            quantum = Convert.ToInt32(txtQuantum.Text.Trim());
    
            
            int total_Turnaround = 0;
            int total_WaitT = 0;

            //string la = "";
            //for (int i = 0; i < Numpro; i++)
            //{
            //    la += prolist[i].End.ToString() + "-" + prolist[i].Num + " ";
            //}
            //MessageBox.Show(la);
            for (int k = 0; k < Numpro; k++)
            {
                for (int i = k + 1; i < Numpro; i++)
                {
                    if (dosched[k].Arrival > dosched[i].Arrival || ((dosched[i].Arrival == dosched[k].Arrival) && (dosched[k].Num > dosched[i].Num)))
                    {
                        ProcessRR temp = new ProcessRR();
                        temp = dosched[i];
                        dosched[i] = dosched[k];
                        dosched[k] = temp;
                    }
                }
            }
            int[] burst_remaining = new int[Numpro];
            for (int i = 0; i < Numpro; i++)
            {
                burst_remaining[i] = dosched[i].Burst;
                
            }
            int idx;
            time.Enqueue(dosched[0].Arrival);
            Queue<int> q = new Queue<int>();
            int current_time = 0;
            q.Enqueue(0);
            simulate.Enqueue(dosched[0].Num);
            int completed = 0;
            int[] mark = new int[Numpro];
            
            mark[0] = 1;
            while (completed != Numpro)
            {
                idx = q.Dequeue();
               

                if (burst_remaining[idx] == dosched[idx].Burst)
                {   if (current_time > dosched[idx].Arrival) dosched[idx].Start = current_time;
                    else dosched[idx].Start = dosched[idx].Arrival;
                    //dosched[idx].Start = max(current_time, dosched[idx].Arrival);
                    
                    current_time = dosched[idx].Start;

                }
                

                if (burst_remaining[idx] - quantum > 0)
                {
                    burst_remaining[idx] -= quantum;
                    current_time += quantum;
                }
                
                else
                {
                    current_time += burst_remaining[idx];
                    burst_remaining[idx] = 0;
                    completed++;

                    dosched[idx].End = current_time;

                    dosched[idx].Turnaround = dosched[idx].End - dosched[idx].Arrival;
                    dosched[idx].WaitT = dosched[idx].Turnaround - dosched[idx].Burst;
                    

                    total_Turnaround += dosched[idx].Turnaround;
                    total_WaitT += dosched[idx].WaitT;
                    
                }
                time.Enqueue(current_time);
                for (int i = 1; i < Numpro; i++)
                {
                    if (burst_remaining[i] > 0 && dosched[i].Arrival <= current_time && mark[i] == 0)
                    {
                        q.Enqueue(i);
                        simulate.Enqueue(dosched[i].Num);
                        mark[i] = 1;
                    }
                }

                if (burst_remaining[idx] > 0)
                {
                    q.Enqueue(idx);
                    simulate.Enqueue(dosched[idx].Num);
                }

                if (q.Count()==0)
                {
                    for (int i = 1; i < Numpro; i++)
                    {
                        if (burst_remaining[i] > 0)
                        {
                            q.Enqueue(i);
                            simulate.Enqueue(dosched[i].Num);
                            mark[i] = 1;
                            break;
                        }
                    }
                }


            }
            avg_Turnaround = Math.Round((double)total_Turnaround / (double)Numpro, 2);
            avg_WaitT = Math.Round((double)total_WaitT / (double)Numpro, 2);

            for (int i = 0; i < Numpro; i++)
            {
                for (int k = 0; k < Numpro; k++)
                    if (dosched[i].Num == prolist[k].Num)
                    {
                        prolist[k].End = dosched[i].End;
                        prolist[k].Start = dosched[i].Start;
                        prolist[k].WaitT = dosched[i].WaitT;
                    }
            }
            
            //MessageBox.Show(la);

        }
        int counttime;
        int[] burst_remain;
        int countquantum=0;
        int endtime;
        int currentpro=-1;
        int determine = 0;
        int lastpro = 0;
        int next = -1;
        private void prostart(ProcessRR p1)
        {
            ProcessRR k = new ProcessRR();
            k = p1;

            listbar[p1.Num] = new LoadBar2();
            listbar[p1.Num].Max = k.Burst;
            listbar[p1.Num].setMax();
            Label k1 = new Label();
            Label k2 = new Label();
            k1.Text = "P" + p1.Num.ToString();
            k2.Text = "Start Time " + p1.Start.ToString();
            int i = tableLayoutPanel1.ColumnCount++;
            tableLayoutPanel1.Controls.Add(k1, i - 1, 0);
            tableLayoutPanel1.Controls.Add(listbar[p1.Num].b1, i - 1, 1);
            tableLayoutPanel1.Controls.Add(k2, i - 1, 2);
            k.proStart();
            listbar[p1.Num].proStart();
        }
        private void prostop(ProcessRR p1)
        {

            p1.proStop();
            listbar[p1.Num].proStop();
        }
        private void proresume(ProcessRR p1)
        {
            p1.proStart();
            listbar[p1.Num].proStart();
        }
        int starttime;
        private void Simulate()
        {
            Sched();
            time1 = time.ToArray();
            simulate1 = simulate.ToArray();
            check = new int[Numpro];
            string lo = "";
            for (int i = 0; i < simulate1.Count(); i++)
            {
                lo += time1[i].ToString() + " " + "P" + simulate1[i].ToString() + " ";
            }
            MessageBox.Show(lo);
            counttime = 0;
            burst_remain = new int[Numpro];
            //lastpro = 0;
            for (int i = 0; i < Numpro; i++)
            {
                burst_remain[i] = prolist[i].Burst;
            }
            for (int i = 0; i < Numpro; i++)
            {
                if (endtime < prolist[i].End) endtime = prolist[i].End;
            }
            starttime = prolist[simulate.Peek()].Start;
            //MessageBox.Show("starttime" + starttime.ToString());
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
            MessageBox.Show(quantum.ToString());
        }
        
        int[] check;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = counttime.ToString();
            
            if (determine == 1 &&next>0) 
            {

                if (check[simulate1[next - 1]] == 0) { prostop(prolist[simulate1[next - 1]]);  }
                    determine = 0; 
                
            }
            
            int numqueue = 0;
            string waitqueue = "";
            for (int i = 0; i < Numpro; i++)
            {
                if (prolist[i].End == counttime)
                {
                    prolist[i].setWait(prolist[i].WaitT);
                    check[i] = -1;
                }


            }
            int[] inqueue = Enumerable.Repeat(-1, Numpro).ToArray();
            int t = 0;
            for (int i=0;i<simulate1.Count();i++)
            {
                
                
                if(counttime>time1[i] && check[simulate1[i]]>0 &&i!=currentpro)
                {
                    int xd=0;
                    
                    for(int k=0;k<Numpro;k++)
                    if(inqueue[k]==simulate1[i]) { xd++; }
                    if (xd == 0) { inqueue[t] = simulate1[i]; t++; waitqueue += "P" + simulate1[i].ToString() + "|"; numqueue++; }
                    

                }
                if (counttime == time1[i] &&counttime<endtime) 
                {
                    lbStatus.Text = "Busy";
                    picBusy.Show();picWaiting.Hide();
                    if (currentpro > -1) determine = 1;
                    next = i; currentpro = simulate1[i];lbCurrent.Text = "P" + currentpro.ToString();
                    if (next > 0) if (check[simulate1[next - 1]] == 1) prostop(prolist[simulate1[next - 1]]);
                    if (check[currentpro] == 0) { prostart(prolist[currentpro]); check[currentpro] = 1; }
                    else { proresume(prolist[currentpro]); }
                    
                }


            }
            


            lbQueue.Text = numqueue.ToString();
            lbWait.Text = waitqueue;
            if (counttime == endtime + 1) 
            {  timer1.Stop();
                picWaiting.Show();picBusy.Hide(); 
                lbStatus.Text = "Idle";
               lbCurrent.Text = "non";
                lbWaitT.Text = avg_WaitT.ToString();
                lbTurn.Text = avg_Turnaround.ToString();
            }
            //if (determine == 1)
            //{
            //    prostop(dosched[lastpro]); determine = 0;
            //}
            //if (currentpro > -1) lastpro = currentpro;
            //for (int i = 0; i < Numpro; i++)
            //{
            //    if (counttime == dosched[i].Start) { prostart(dosched[i]); currentpro = i;check = 1;  }
            //}
            //lbQueue.Text = countquantum.ToString();

            //if (currentpro > -1)
            //{

            //    lbCurrent.Text = "P" + dosched[currentpro].Num.ToString();
            //    if ((dosched[lastpro].Start < counttime) && (countquantum == quantum || burst_remain[lastpro] == 0))
            //    {
            //        determine = 1;

            //        countquantum = 0;
            //        if (check)
            //        for (int i = 0; i < Numpro; i++)
            //        {
            //            if (burst_remain[i] > 0 && counttime > dosched[i].Start) { currentpro = i; proresume(dosched[i]); break; }

            //        }
            //    }
            //    burst_remain[currentpro]--;
            //    countquantum++;
            //}
            //if (counttime == 3) prostart(dosched[3]);
            //if (counttime == 5) prostop(dosched[3]);
            //if (counttime == 9) proresume(prolist[3]);
            //if (counttime == prolist[2].Start) prostart(prolist[2]);
            //if (counttime == prolist[4].Start) prostart(prolist[4]);
            //if (counttime == 10) prostop(prolist[3]);
            //if (counttime == 15) proresume(prolist[3]);

            //if (lastpro != -1) { prostop(prolist[lastpro]); lastpro = -1; countquantum = 0; }
            //currentpro = simulate.Peek();
            //if (counttime >= starttime)
            //{
            //    if (determine == 1)
            //    {
            //        MessageBox.Show(counttime.ToString());
            //        if (temp != -1) { prostop(prolist[temp]); temp = -1; }
            //        else prostop(prolist[lastpro]); determine = 0; }
                
            //    if (counttime == prolist[currentpro].Start) { prostart(prolist[currentpro]); check[currentpro] = 1; }
            //    if (countquantum == quantum || burst_remain[lastpro] == 0)
            //    {
            //        countquantum = 0; determine = 1; if (check[currentpro] == 1) proresume(prolist[currentpro]);
                    
            //    }
            //    if (countquantum + 1 == quantum || burst_remain[currentpro] - 1 == 0)
            //    {   if (determine == 1) temp = lastpro;
            //        lastpro=simulate.Dequeue();

            //        currentpro = simulate.Peek();
                    

            //        burst_remain[lastpro]--;burst_remain[currentpro]++;
            //    }
               
            //    lbQueue.Text = "P" + currentpro.ToString(); /*burst_remain[currentpro].ToString();*/
            //    //if (check[currentpro] == 1) proresume(prolist[currentpro]);


            //    burst_remain[currentpro]--;
            //    countquantum++;
            //}
            counttime++;

        }
        int[] time1;
        int[] simulate1;

        private void btnStart_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Enabled = false;
            timer1.Tick -= timer1_Tick;
            Simulate();

                       
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
            txtQuantum.Text = "1";
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

        private void RR_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(formclose);
        }
        private void formclose(object sender, EventArgs e)
        {
            Form1 k = new Form1();
            k.Show();
        }

        private void txtQuantum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
