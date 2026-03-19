using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeskTimer
{
    public partial class frmDeskTimer : Form
    {
        public frmDeskTimer()
        {
            InitializeComponent();
        }

        //----------buttons------------//
        private void btnhr_plus_Click(object sender, EventArgs e)
        {

            if (txthour.Text == "hour")
            {
                txthour.Text = Convert.ToString("0");
            }
            else
            {
                decimal hour = Convert.ToDecimal(txthour.Text);

                hour += 1;

                txthour.Text = Convert.ToString(hour);
            }
        }

        private void btnhr_minus_Click(object sender, EventArgs e)
        {

            if (txthour.Text == "hour" || txthour.Text == "0")
            {
                MessageBox.Show("Hour cannot be below zero", "Error");
            }
            else
            {
                decimal hour = Convert.ToDecimal(txthour.Text);

                hour -= 1;

                txthour.Text = Convert.ToString(hour);
            }
        }

        private void btnmin_plus_Click(object sender, EventArgs e)
        {

            if (txtminute.Text == "min")
            {
                txtminute.Text = Convert.ToString("0");
            }
            else
            {
                decimal minute = Convert.ToDecimal(txtminute.Text);

                minute += 1;

                txtminute.Text = Convert.ToString(minute);
            }
        }

        private void btnmin_minus_Click(object sender, EventArgs e)
        {

            if (txtminute.Text == "min" || txtminute.Text == "0")
            {
                MessageBox.Show("Minutes cannot be below zero", "Error");
            }
            else
            {
                decimal minute = Convert.ToDecimal(txtminute.Text);

                minute -= 1;

                txtminute.Text = Convert.ToString(minute);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    this.Tag = Convert_Time();
                    frmTimer TimerForm = new frmTimer();
                    TimerForm.Owner = this;
                    TimerForm.ShowDialog();
                    Buttons_Disabled();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("A format exception has occurred. Please check for valid numerical entry.", "Entry Error");
                Buttons_Enabled();
            }
            //catches input errors that are too large/don't fit in text box
            catch (OverflowException oe)
            {
                MessageBox.Show("An overflow exception has occurred. Please limit your entries or make them " +
                    "smaller with stacktrace:\n" + oe.StackTrace, "Overflow Error");
                Buttons_Enabled();
            }
            catch (Exception ex) //catch using the exception properties
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType() + "\n" + ex.StackTrace, "Exception");
                Buttons_Enabled();
                throw ex;           //re-throw the exception
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txthour.ReadOnly = false;
            txtminute.ReadOnly = false;

            Buttons_Enabled();

            txthour.Text = Convert.ToString("hour");
            txtminute.Text = Convert.ToString("min");
        }


        //----------helper methods------------//
        private bool IsValidData()
        {
            bool success = true;

            if (txthour.Text == "hour")
            {
                txthour.Text = "0";
            }

            if (txtminute.Text == "min")
            {
                txtminute.Text = "0";
            }

            if (ValidTime() == false)
            {
                //MessageBox.Show("Entries must be valid numbers, and minutes cannot go over 60.", "Error");
                success = false;
            }

            return success;
        }

        public bool ValidTime()
        {
            bool success = true;

            decimal ValidHour = 0m;
            decimal ValidMinute = 0m;

            if (!decimal.TryParse(txthour.Text, out ValidHour) & !decimal.TryParse(txtminute.Text, out ValidMinute))
            {
                success = false;
            }

            if (ValidMinute < 0m | ValidMinute > 60m &
                ValidHour < 0m | ValidHour > 60m)
            {
                success = false;
            }

            return success;
        }

        private void Buttons_Enabled()
        {
            btnhr_minus.Enabled = true;
            btnhr_plus.Enabled = true;
            btnmin_minus.Enabled = true;
            btnmin_plus.Enabled = true;
        }

        private void Buttons_Disabled()
        {
            btnhr_minus.Enabled = false;
            btnhr_plus.Enabled = false;
            btnmin_minus.Enabled = false;
            btnmin_plus.Enabled = false;
        }

        public string Convert_Time()
        {
            decimal Timer_hour = Convert.ToDecimal(txthour.Text);
            decimal Timer_min = Convert.ToDecimal(txtminute.Text);

            Timer_min = Timer_min + (Timer_hour * 60m);

            return Convert.ToString(Timer_min);
        }
    }
}
