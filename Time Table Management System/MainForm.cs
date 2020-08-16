using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            loadTimeDate();
        }
        #region Functions for NavBar
        private void customizeDesign()
        {
            panelWorkingHoursSubMenu.Visible = false;
            panelLecturersSubMenu.Visible = false;
            panelSubjectsSubMenu.Visible = false;
            panelStudentsSubMenu.Visible = false;
            panelTagsSubMenu.Visible = false;
            panelLocationsSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelWorkingHoursSubMenu.Visible == true)
                panelWorkingHoursSubMenu.Visible = false;
            if (panelLecturersSubMenu.Visible == true)
                panelLecturersSubMenu.Visible = false;
            if (panelSubjectsSubMenu.Visible == true)
                panelSubjectsSubMenu.Visible = false;
            if (panelStudentsSubMenu.Visible == true)
                panelStudentsSubMenu.Visible = false;
            if (panelTagsSubMenu.Visible == true)
                panelTagsSubMenu.Visible = false;
            if (panelLocationsSubMenu.Visible == true)
                panelLocationsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region WorkingHours

        private void btnWorkingHours_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorkingHoursSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        #endregion

        #region DashBoard
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        #endregion

        #region Lecturers
        private void btnLecturers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLecturersSubMenu);
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageLecturers_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Subjects
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubjectsSubMenu);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        #endregion

        #region Students
        private void btnStudents_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentsSubMenu);
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Tags
        private void btnTags_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTagsSubMenu);
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageTags_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Locations
        private void btnLocations_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLocationsSubMenu);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Time and Date
        private void loadTimeDate()
        {
            timer1.Start();
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
            textBoxDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        #endregion

    }
}
