namespace CPU_Scheduling
{
    partial class Process
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNum = new System.Windows.Forms.Label();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtBurst = new System.Windows.Forms.TextBox();
            this.txtWait = new System.Windows.Forms.TextBox();
            this.proStatus = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.AutoSize = true;
            this.txtNum.Location = new System.Drawing.Point(3, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(17, 17);
            this.txtNum.TabIndex = 0;
            this.txtNum.Text = "P";
            // 
            // txtArrival
            // 
            this.txtArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrival.Location = new System.Drawing.Point(80, 10);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(55, 24);
            this.txtArrival.TabIndex = 1;
            this.txtArrival.Text = "0";
            this.txtArrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBurst
            // 
            this.txtBurst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBurst.Location = new System.Drawing.Point(171, 10);
            this.txtBurst.Name = "txtBurst";
            this.txtBurst.Size = new System.Drawing.Size(55, 24);
            this.txtBurst.TabIndex = 2;
            this.txtBurst.Text = "0";
            this.txtBurst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBurst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBurst_KeyPress);
            // 
            // txtWait
            // 
            this.txtWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWait.Location = new System.Drawing.Point(272, 10);
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(55, 24);
            this.txtWait.TabIndex = 3;
            this.txtWait.Text = "0";
            this.txtWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // proStatus
            // 
            this.proStatus.Location = new System.Drawing.Point(394, 12);
            this.proStatus.Name = "proStatus";
            this.proStatus.Size = new System.Drawing.Size(163, 23);
            this.proStatus.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.proStatus);
            this.Controls.Add(this.txtWait);
            this.Controls.Add(this.txtBurst);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtNum);
            this.Name = "Process";
            this.Size = new System.Drawing.Size(576, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNum;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtBurst;
        private System.Windows.Forms.TextBox txtWait;
        public System.Windows.Forms.ProgressBar proStatus;
        private System.Windows.Forms.Timer timer1;
    }
}
