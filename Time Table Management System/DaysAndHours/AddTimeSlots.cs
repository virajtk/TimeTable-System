﻿using System;
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
    public partial class AddTimeSlots : Form
    {
        private TimeSlot timeSlot = new TimeSlot();

        public AddTimeSlots()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            numericSThours.Value = 0;
            numericSTMinutes.Value = 0;
            numericETHours.Value = 0;
            numericETMinutes.Value = 0;

        }

        private void btnAddTimeSlot_Click(object sender, EventArgs e)
        {
            if (numericSThours.Value <= 0 ^ numericSThours.Value >= 12)
            {
                numericSThours.Focus();
                errorProviderTimeSlot.SetError(numericSThours, "Please Enter Valid Hours");
                clear();
            }
            else if (numericSTMinutes.Value <= 0 ^ numericSTMinutes.Value >= 60)
            {
                numericSTMinutes.Focus();
                errorProviderTimeSlot.SetError(numericSTMinutes, "Please Enter Valid Minutes");
                clear();
            }
            else if (numericETHours.Value <= 0 ^ numericETHours.Value >= 12)
            {
                numericETHours.Focus();
                errorProviderTimeSlot.SetError(numericETHours, "Please Enter Valid Hours");
                clear();
            }
            else if (numericETMinutes.Value <= 0 ^ numericETMinutes.Value >= 60)
            {
                numericETMinutes.Focus();
                errorProviderTimeSlot.SetError(numericETMinutes, "Please Enter Valid Minutes");
                clear();
            }

            else
            {
                ITimeSlotService timeSlotService = new TimeSlotService();

                #region Set Data to Object
                // Set Data to model
                timeSlot.StHours = int.Parse(numericSThours.Value.ToString());
                timeSlot.StMinutes = int.Parse(numericSTMinutes.Value.ToString());
                timeSlot.EtHours = int.Parse(numericETHours.Value.ToString());
                timeSlot.EtMinutes = int.Parse(numericETMinutes.Value.ToString());
                #endregion

                //Insert Data
                if (timeSlotService.addTimeSlots(timeSlot))
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
    }
}
