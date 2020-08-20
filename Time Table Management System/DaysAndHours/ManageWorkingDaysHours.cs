﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.DaysAndHours
{
    public partial class ManageWorkingDaysHours : Form
    {
        private WorkingDaysHours workingDaysHours = new WorkingDaysHours();
        private bool executedFirstTime;
        private TimeSlot selectedTimeSlot;
        private IWorkingDaysHoursService workingDaysHoursService;

        public ManageWorkingDaysHours()
        {
            InitializeComponent();
            executedFirstTime = true;
            workingDaysHoursService = new WorkingDaysHoursService();
            populateData();
        }

        private void populateData()
        {
            List<WorkingDaysHours> workingDaysHoursArray = new List<WorkingDaysHours>();
            workingDaysHoursArray = workingDaysHoursService.getWorkingDaysHours();

            foreach (WorkingDaysHours workingDaysHours in workingDaysHoursArray)
            {
                btnDaysCount.Text = workingDaysHours.NoOfWorkingDays.ToString();
                List<String> workingArr = new List<String>();
                if(workingDaysHours.Monday == 1)
                    workingArr.Add("Monday");
                if (workingDaysHours.Tuesday == 1)
                    workingArr.Add("Tuesday");
                if (workingDaysHours.Wednesday == 1)
                    workingArr.Add("Wednesday");
                if (workingDaysHours.Thursday == 1)
                    workingArr.Add("Thursday");
                if (workingDaysHours.Friday == 1)
                    workingArr.Add("Friday");
                if (workingDaysHours.Saturday == 1)
                    workingArr.Add("Saturday");
                if (workingDaysHours.Sunday == 1)
                    workingArr.Add("Sunday");

                btnWorkingDays.Text = String.Empty;
                foreach(String day in workingArr)
                {
                    btnWorkingDays.Text = btnWorkingDays.Text + " | "+ day;
                }

                btnTime.Text = workingDaysHours.NoOfHours + ":" + workingDaysHours.NoOfMinutes;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxWorkingDays.Text != String.Empty)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNoOfDays.Text = btnDaysCount.Text;
            btnWorkingDays.Enabled = false;
            btnTime.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxNoOfDays.Text = String.Empty;
            textBoxWorkingDays.Text = String.Empty;
            textBoxTime.Text = String.Empty;
            btnWorkingDays.Enabled = true;
            btnDaysCount.Enabled = true;
            btnTime.Enabled = true;
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            textBoxTime.Text = btnTime.Text;
            btnWorkingDays.Enabled = false;
            btnDaysCount.Enabled = false;
        }

        private void btnWorkingDays_Click(object sender, EventArgs e)
        {
            textBoxWorkingDays.Text = btnWorkingDays.Text;
            btnTime.Enabled = false;
            btnDaysCount.Enabled = false;
        }
    }
}