namespace CPU_Scheduling
{
    partial class RR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RR));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbTurn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbWaitT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picWaiting = new System.Windows.Forms.PictureBox();
            this.picBusy = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbQueue = new System.Windows.Forms.Label();
            this.lbClock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbWait = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWaiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusy)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(737, 447);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 43);
            this.btnRestart.TabIndex = 82;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // lbTurn
            // 
            this.lbTurn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.Location = new System.Drawing.Point(223, 407);
            this.lbTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(88, 26);
            this.lbTurn.TabIndex = 81;
            this.lbTurn.Text = "0";
            this.lbTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Average Turn Around Time";
            // 
            // lbWaitT
            // 
            this.lbWaitT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbWaitT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWaitT.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitT.Location = new System.Drawing.Point(223, 371);
            this.lbWaitT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWaitT.Name = "lbWaitT";
            this.lbWaitT.Size = new System.Drawing.Size(88, 26);
            this.lbWaitT.TabIndex = 79;
            this.lbWaitT.Text = "0";
            this.lbWaitT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Average Waiting Time";
            // 
            // picWaiting
            // 
            this.picWaiting.Image = ((System.Drawing.Image)(resources.GetObject("picWaiting.Image")));
            this.picWaiting.Location = new System.Drawing.Point(249, 100);
            this.picWaiting.Name = "picWaiting";
            this.picWaiting.Size = new System.Drawing.Size(100, 94);
            this.picWaiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWaiting.TabIndex = 77;
            this.picWaiting.TabStop = false;
            // 
            // picBusy
            // 
            this.picBusy.Image = ((System.Drawing.Image)(resources.GetObject("picBusy.Image")));
            this.picBusy.Location = new System.Drawing.Point(249, 100);
            this.picBusy.Name = "picBusy";
            this.picBusy.Size = new System.Drawing.Size(100, 94);
            this.picBusy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBusy.TabIndex = 76;
            this.picBusy.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Teal;
            this.label19.Location = new System.Drawing.Point(31, 570);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 17);
            this.label19.TabIndex = 75;
            this.label19.Text = "Time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Teal;
            this.label18.Location = new System.Drawing.Point(31, 536);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 17);
            this.label18.TabIndex = 74;
            this.label18.Text = "Load";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(31, 496);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 17);
            this.label17.TabIndex = 73;
            this.label17.Text = "Process";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(833, 447);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 43);
            this.btnStart.TabIndex = 72;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(766, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 71;
            this.label15.Text = "Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(637, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "Waiting Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(540, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 69;
            this.label13.Text = "Burst Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(436, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Arrival Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(371, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "Process";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(374, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(576, 331);
            this.flowLayoutPanel1.TabIndex = 66;
            // 
            // lbCurrent
            // 
            this.lbCurrent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCurrent.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrent.Location = new System.Drawing.Point(135, 226);
            this.lbCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(88, 26);
            this.lbCurrent.TabIndex = 65;
            this.lbCurrent.Text = "P";
            this.lbCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(135, 187);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(88, 26);
            this.lbStatus.TabIndex = 64;
            this.lbStatus.Text = "Idle";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQueue
            // 
            this.lbQueue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQueue.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueue.Location = new System.Drawing.Point(135, 150);
            this.lbQueue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQueue.Name = "lbQueue";
            this.lbQueue.Size = new System.Drawing.Size(88, 26);
            this.lbQueue.TabIndex = 63;
            this.lbQueue.Text = "0";
            this.lbQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbClock.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(134, 78);
            this.lbClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(88, 23);
            this.lbClock.TabIndex = 62;
            this.lbClock.Text = "0";
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Current Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "CPU Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Num in Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Simulation Clock";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(114, 496);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 100);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // lbWait
            // 
            this.lbWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbWait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWait.Location = new System.Drawing.Point(17, 34);
            this.lbWait.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(533, 33);
            this.lbWait.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ready Queue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Quantum";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(134, 114);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(88, 22);
            this.txtQuantum.TabIndex = 84;
            // 
            // RR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 608);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbWaitT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picWaiting);
            this.Controls.Add(this.picBusy);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbQueue);
            this.Controls.Add(this.lbClock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbWait);
            this.Controls.Add(this.label1);
            this.Name = "RR";
            this.Text = "RR";
            ((System.ComponentModel.ISupportInitialize)(this.picWaiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbWaitT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picWaiting;
        private System.Windows.Forms.PictureBox picBusy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbQueue;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbWait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantum;
    }
}