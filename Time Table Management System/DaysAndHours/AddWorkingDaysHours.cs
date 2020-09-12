using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.DaysAndHours
{
    public partial class AddWorkingDaysHours : Form
    {
        private WorkingDaysHours workingDaysHours = new WorkingDaysHours();
        public AddWorkingDaysHours()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericTuteHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            numericNoOfDays.Value = 0;
            checkBoxMonday.Checked = false;
            checkBoxTuesday.Checked = false;
            checkBoxWednesday.Checked = false;
            checkBoxThursday.Checked = false;
            checkBoxFriday.Checked = false;
            checkBoxSaturday.Checked = false;
            checkBoxSunday.Checked = false;
            numericTPerDayHours.Value = 0;
            numericTPerDayMinutes.Value = 0;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numericNoOfDays.Value < 1 ^ numericNoOfDays.Value >= 7)
            {
                numericNoOfDays.Focus();
                errorAddWorkingDays.SetError(numericNoOfDays, "Please Enter Valid No Of Working Days");
            }
            else if (checkBoxMonday.Checked == false & checkBoxTuesday.Checked == false & checkBoxWednesday.Checked == false & checkBoxThursday.Checked == false & checkBoxFriday.Checked == false & checkBoxSaturday.Checked == false & checkBoxSunday.Checked == false)
            {
                ErrorMessage em = new ErrorMessage("Please Select One More Working Days");
                em.Show();
            }
            else if (numericTPerDayHours.Value < 0 ^ numericTPerDayHours.Value >= 24)
            {
                numericTPerDayHours.Focus();
                errorAddWorkingDays.SetError(numericTPerDayHours, "Please Enter Valid No Of Working Hours");
            }
            else if (numericTPerDayMinutes.Value <= 0 ^ numericTPerDayMinutes.Value >= 60)
            {
                numericTPerDayMinutes.Focus();
                errorAddWorkingDays.SetError(numericTPerDayMinutes, "Please Enter Valid No Of Working Minutes");
            }
            else
            {
                IWorkingDaysHoursService workingDaysHoursService = new WorkingDaysHoursService();

                #region Set Data to Object
                // Set Data to model
                workingDaysHours.NoOfWorkingDays = int.Parse(numericNoOfDays.Value.ToString());
                workingDaysHours.NoOfHours = int.Parse(numericTPerDayHours.Value.ToString());
                workingDaysHours.NoOfMinutes = int.Parse(numericTPerDayMinutes.Value.ToString());

                // Check Days Monday
                if (checkBoxMonday.Checked == true)
                    workingDaysHours.Monday = 1;
                else
                    workingDaysHours.Monday = 0;

                // Check Days Tuesday
                if (checkBoxTuesday.Checked == true)
                    workingDaysHours.Tuesday = 1;
                else
                    workingDaysHours.Tuesday = 0;

                // Check Days Wednesday
                if (checkBoxWednesday.Checked == true)
                    workingDaysHours.Wednesday = 1;
                else
                    workingDaysHours.Wednesday = 0;

                // Check Days Thursday
                if (checkBoxThursday.Checked == true)
                    workingDaysHours.Thursday = 1;
                else
                    workingDaysHours.Thursday = 0;

                // Check Days Friday
                if (checkBoxFriday.Checked == true)
                    workingDaysHours.Friday = 1;
                else
                    workingDaysHours.Friday = 0;

                // Check Days Saturday
                if (checkBoxSaturday.Checked == true)
                    workingDaysHours.Saturday = 1;
                else
                    workingDaysHours.Saturday = 0;

                // Check Days Sunday
                if (checkBoxSunday.Checked == true)
                    workingDaysHours.Sunday = 1;
                else
                    workingDaysHours.Sunday = 0;
                #endregion

                //Insert Data
                if (workingDaysHoursService.addWorkingDaysHours(workingDaysHours))
                {
                    SuccessMessage sc = new SuccessMessage("Working Days And Hours Added Successfully !");
                    sc.Show();
                    clear();

                }
                else
                {
                    ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                    ec.Show();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void checkBoxMonday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxMonday.Checked == true)
                    numericNoOfDays.Value++;
                else
                    numericNoOfDays.Value--;
            }
            catch(Exception eMonday)
            {
                
            }
            
        }

        private void checkBoxTuesday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (checkBoxTuesday.Checked == true)
                    numericNoOfDays.Value++;
                else
                    numericNoOfDays.Value--;

            }
            catch (Exception eTuesday) { 
            
            }
            
            

        }

        private void checkBoxWednesday_CheckedChanged(object sender, EventArgs e)
        {
            try {

                if (checkBoxWednesday.Checked == true)
                    numericNoOfDays.Value++;
                else
                    numericNoOfDays.Value--;

            } catch (Exception eWednesday) { 
            
            }
            

        }

        private void checkBoxThursday_CheckedChanged(object sender, EventArgs e)
        {
            try {

                if (checkBoxThursday.Checked == true)
                    numericNoOfDays.Value++;
                else
                    numericNoOfDays.Value--;

            } catch (Exception eThursday) { 
            
            }
            
        }

        private void checkBoxFriday_CheckedChanged(object sender, EventArgs e)
        {
            try {

                if (checkBoxFriday.Checked == true)
                    numericNoOfDays.Value++;
                else
                    numericNoOfDays.Value--;


            } catch (Exception eFriday) {
            
            }
            
        }

        private void checkBoxSaturday_CheckedChanged(object sender, EventArgs e)
        {
            try {

                if (checkBoxSaturday.Checked == true)
                    numericNoOfDays.Value++;
                else
                    numericNoOfDays.Value--;

            } catch (Exception eSaturday) { 
            
            }
            
        }

        private void checkBoxSunday_CheckedChanged(object sender, EventArgs e)
        {
            try {

                if (checkBoxSunday.Checked == true)
                    numericNoOfDays.Value++;
                else
                    numericNoOfDays.Value--;

            } catch (Exception eSunday) { 
            
            }
            
        }
    }
}
