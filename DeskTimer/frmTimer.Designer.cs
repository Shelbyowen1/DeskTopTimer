namespace DeskTimer
{
    partial class frmTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimerPause = new System.Windows.Forms.Button();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(106, 20);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(20, 25);
            this.lblTimeLeft.TabIndex = 0;
            this.lblTimeLeft.Text = ":";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTimeLeft.UseMnemonic = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimerPause
            // 
            this.btnTimerPause.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnTimerPause.Location = new System.Drawing.Point(11, 62);
            this.btnTimerPause.Name = "btnTimerPause";
            this.btnTimerPause.Size = new System.Drawing.Size(104, 40);
            this.btnTimerPause.TabIndex = 1;
            this.btnTimerPause.Text = "Pause";
            this.btnTimerPause.UseVisualStyleBackColor = true;
            this.btnTimerPause.Click += new System.EventHandler(this.btnTimerPause_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnTimerStop.Location = new System.Drawing.Point(78, 108);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(104, 40);
            this.btnTimerStop.TabIndex = 2;
            this.btnTimerStop.Text = "Stop";
            this.btnTimerStop.UseVisualStyleBackColor = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnResume.Location = new System.Drawing.Point(141, 62);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(104, 40);
            this.btnResume.TabIndex = 3;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 172);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnTimerStop);
            this.Controls.Add(this.btnTimerPause);
            this.Controls.Add(this.lblTimeLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTimerPause;
        private System.Windows.Forms.Button btnTimerStop;
        private System.Windows.Forms.Button btnResume;
    }
}