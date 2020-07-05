namespace CPU_Scheduling
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPQ = new System.Windows.Forms.RadioButton();
            this.rdSJF = new System.Windows.Forms.RadioButton();
            this.rdRR = new System.Windows.Forms.RadioButton();
            this.rdFCFS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.checkRan = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPQ);
            this.groupBox1.Controls.Add(this.rdSJF);
            this.groupBox1.Controls.Add(this.rdRR);
            this.groupBox1.Controls.Add(this.rdFCFS);
            this.groupBox1.Location = new System.Drawing.Point(16, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Scheduling Type";
            // 
            // rdPQ
            // 
            this.rdPQ.AutoSize = true;
            this.rdPQ.Location = new System.Drawing.Point(20, 151);
            this.rdPQ.Name = "rdPQ";
            this.rdPQ.Size = new System.Drawing.Size(120, 21);
            this.rdPQ.TabIndex = 3;
            this.rdPQ.Text = "Priority Queue";
            this.rdPQ.UseVisualStyleBackColor = true;
            // 
            // rdSJF
            // 
            this.rdSJF.AutoSize = true;
            this.rdSJF.Checked = true;
            this.rdSJF.Location = new System.Drawing.Point(20, 114);
            this.rdSJF.Name = "rdSJF";
            this.rdSJF.Size = new System.Drawing.Size(140, 21);
            this.rdSJF.TabIndex = 2;
            this.rdSJF.TabStop = true;
            this.rdSJF.Text = "Shortest Job First";
            this.rdSJF.UseVisualStyleBackColor = true;
            // 
            // rdRR
            // 
            this.rdRR.AutoSize = true;
            this.rdRR.Location = new System.Drawing.Point(20, 72);
            this.rdRR.Name = "rdRR";
            this.rdRR.Size = new System.Drawing.Size(112, 21);
            this.rdRR.TabIndex = 1;
            this.rdRR.Text = "Round Robin";
            this.rdRR.UseVisualStyleBackColor = true;
            // 
            // rdFCFS
            // 
            this.rdFCFS.AutoSize = true;
            this.rdFCFS.Location = new System.Drawing.Point(20, 34);
            this.rdFCFS.Name = "rdFCFS";
            this.rdFCFS.Size = new System.Drawing.Size(216, 21);
            this.rdFCFS.TabIndex = 0;
            this.rdFCFS.Text = "First Come First Serve (FCFS)";
            this.rdFCFS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the following data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Processes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minimum Random Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maximum Random Value";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(301, 67);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 25);
            this.txtNum.TabIndex = 5;
            this.txtNum.Text = "5";
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(301, 120);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 25);
            this.txtMin.TabIndex = 6;
            this.txtMin.Text = "0";
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(301, 175);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 25);
            this.txtMax.TabIndex = 7;
            this.txtMax.Text = "10";
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMax_KeyPress);
            // 
            // checkRan
            // 
            this.checkRan.AutoSize = true;
            this.checkRan.Checked = true;
            this.checkRan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRan.Location = new System.Drawing.Point(16, 216);
            this.checkRan.Name = "checkRan";
            this.checkRan.Size = new System.Drawing.Size(395, 21);
            this.checkRan.TabIndex = 8;
            this.checkRan.Text = "Generate Arrival Time , Burst Time,  and Priority randomly";
            this.checkRan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(187, 459);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 39);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 526);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkRan);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Input reuired data for scheduling";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPQ;
        private System.Windows.Forms.RadioButton rdSJF;
        private System.Windows.Forms.RadioButton rdRR;
        private System.Windows.Forms.RadioButton rdFCFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.CheckBox checkRan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOK;
    }
}

