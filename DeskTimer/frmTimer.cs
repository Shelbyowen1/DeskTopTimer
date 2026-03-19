using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTimer
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
            this.TopMost = true;
        }


        int timeLeft;
        private void frmTimer_Load(object sender, EventArgs e)
        {
            frmDeskTimer DeskTimerForm = (frmDeskTimer)this.Owner;
            string FormTime = (string)DeskTimerForm.Tag;
            int TimerTime = Convert.ToInt16(FormTime);

            timeLeft = TimerTime;

            int hours = timeLeft / 60;
            int minutes = timeLeft % 60;
            lblTimeLeft.Text = hours + ":" + minutes.ToString("D2");
               
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;

                int hours = timeLeft / 60;
                int minutes = timeLeft % 60;
                lblTimeLeft.Text = hours + ":" + minutes.ToString("D2");

            }
            else
            {
                timer1.Stop();
                lblTimeLeft.Text = "Time's up!";
            }

        }

        private void btnTimerPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //frmDeskTimer DeskTimerForm = new frmDeskTimer();
            this.Close();
        }
    }
}
