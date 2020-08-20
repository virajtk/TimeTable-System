using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Lecturers;
using Time_Table_Management_System.Students;
using Time_Table_Management_System.Tags;

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

        private void defaultBtn()
        {
            btnDashBoard.BackColor = Color.FromArgb(11, 7, 17);
            btnWorkingHours.BackColor = Color.FromArgb(11, 7, 17);
            btnLecturers.BackColor = Color.FromArgb(11, 7, 17);
            btnSubjects.BackColor = Color.FromArgb(11, 7, 17);
            btnStudents.BackColor = Color.FromArgb(11, 7, 17);
            btnTags.BackColor = Color.FromArgb(11, 7, 17);
            btnLocations.BackColor = Color.FromArgb(11, 7, 17);
        }
        #endregion

        #region WorkingHours

        private void btnWorkingHours_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnWorkingHours.BackColor = Color.FromArgb(0, 25, 51);
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
            defaultBtn();
            btnDashBoard.BackColor = Color.FromArgb(0, 25, 51);

            openChildForm(new DashBoard());
            //..
            // your code
            //..

            hideSubMenu();
        }

        #endregion

        #region Lecturers
        private void btnLecturers_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnLecturers.BackColor = Color.FromArgb(0, 25, 51);
            showSubMenu(panelLecturersSubMenu);
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            openChildForm(new AddLecturer());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageLecturers_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageLecturers());
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Subjects
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnSubjects.BackColor = Color.FromArgb(0, 25, 51);
            showSubMenu(panelSubjectsSubMenu);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            openChildForm(new AddSubject());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageSubjects());
            //..
            // your code
            //..

            hideSubMenu();
        }

        #endregion

        #region Students
        private void btnStudents_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnStudents.BackColor = Color.FromArgb(0, 25, 51);
            showSubMenu(panelStudentsSubMenu);
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStudent());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudents());
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Tags
        private void btnTags_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnTags.BackColor = Color.FromArgb(0, 25, 51);
            showSubMenu(panelTagsSubMenu);
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            openChildForm(new AddTag());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageTags_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageTags());
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Locations
        private void btnLocations_Click(object sender, EventArgs e)
        {
            
            defaultBtn();
            btnLocations.BackColor = Color.FromArgb(0, 25, 51);
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
            timerDateNTime.Start();
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
            textBoxDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
            timerDateNTime.Start();
        }



        #endregion

        #region child form function
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

    }
}
