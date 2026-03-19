namespace DeskTimer
{
    partial class frmDeskTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeskTimer));
            this.btnhr_plus = new System.Windows.Forms.Button();
            this.btnhr_minus = new System.Windows.Forms.Button();
            this.btnmin_plus = new System.Windows.Forms.Button();
            this.btnmin_minus = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblcolon = new System.Windows.Forms.Label();
            this.txthour = new System.Windows.Forms.TextBox();
            this.txtminute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnhr_plus
            // 
            this.btnhr_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnhr_plus.Location = new System.Drawing.Point(29, 39);
            this.btnhr_plus.Name = "btnhr_plus";
            this.btnhr_plus.Size = new System.Drawing.Size(56, 29);
            this.btnhr_plus.TabIndex = 0;
            this.btnhr_plus.Text = "+";
            this.btnhr_plus.UseVisualStyleBackColor = true;
            this.btnhr_plus.Click += new System.EventHandler(this.btnhr_plus_Click);
            // 
            // btnhr_minus
            // 
            this.btnhr_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnhr_minus.Location = new System.Drawing.Point(29, 74);
            this.btnhr_minus.Name = "btnhr_minus";
            this.btnhr_minus.Size = new System.Drawing.Size(56, 29);
            this.btnhr_minus.TabIndex = 1;
            this.btnhr_minus.Text = "-";
            this.btnhr_minus.UseVisualStyleBackColor = true;
            this.btnhr_minus.Click += new System.EventHandler(this.btnhr_minus_Click);
            // 
            // btnmin_plus
            // 
            this.btnmin_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnmin_plus.Location = new System.Drawing.Point(266, 39);
            this.btnmin_plus.Name = "btnmin_plus";
            this.btnmin_plus.Size = new System.Drawing.Size(56, 29);
            this.btnmin_plus.TabIndex = 2;
            this.btnmin_plus.Text = "+";
            this.btnmin_plus.UseVisualStyleBackColor = true;
            this.btnmin_plus.Click += new System.EventHandler(this.btnmin_plus_Click);
            // 
            // btnmin_minus
            // 
            this.btnmin_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnmin_minus.Location = new System.Drawing.Point(266, 74);
            this.btnmin_minus.Name = "btnmin_minus";
            this.btnmin_minus.Size = new System.Drawing.Size(56, 29);
            this.btnmin_minus.TabIndex = 3;
            this.btnmin_minus.Text = "-";
            this.btnmin_minus.UseVisualStyleBackColor = true;
            this.btnmin_minus.Click += new System.EventHandler(this.btnmin_minus_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(65, 109);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 32);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(190, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblcolon
            // 
            this.lblcolon.AutoSize = true;
            this.lblcolon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolon.Location = new System.Drawing.Point(167, 56);
            this.lblcolon.Name = "lblcolon";
            this.lblcolon.Size = new System.Drawing.Size(17, 23);
            this.lblcolon.TabIndex = 6;
            this.lblcolon.Text = ":";
            // 
            // txthour
            // 
            this.txthour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthour.Location = new System.Drawing.Point(91, 54);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(70, 30);
            this.txthour.TabIndex = 7;
            this.txthour.Text = "hour";
            this.txthour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtminute
            // 
            this.txtminute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminute.Location = new System.Drawing.Point(190, 54);
            this.txtminute.Name = "txtminute";
            this.txtminute.Size = new System.Drawing.Size(70, 30);
            this.txtminute.TabIndex = 8;
            this.txtminute.Text = "min";
            this.txtminute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmDeskTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 182);
            this.Controls.Add(this.txtminute);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.lblcolon);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnmin_minus);
            this.Controls.Add(this.btnmin_plus);
            this.Controls.Add(this.btnhr_minus);
            this.Controls.Add(this.btnhr_plus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeskTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desk Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhr_plus;
        private System.Windows.Forms.Button btnhr_minus;
        private System.Windows.Forms.Button btnmin_plus;
        private System.Windows.Forms.Button btnmin_minus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblcolon;
        private System.Windows.Forms.TextBox txthour;
        private System.Windows.Forms.TextBox txtminute;
    }
}

