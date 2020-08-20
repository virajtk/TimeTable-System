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

namespace Time_Table_Management_System.Lecturers
{
    public partial class AddLecturer : Form
    {
        private Lecturer lecturer = new Lecturer();

        public AddLecturer()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            textBoxLecturerName.Text = String.Empty;
            textBoxEmployeeID.Text = String.Empty;
            comboBoxFaculty.SelectedIndex = -1;
            textBoxDepartment.Text = String.Empty;
            comboBoxCenter.SelectedIndex = -1;
            comboBoxBuilding.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;
            textBoxRank.Text = String.Empty;
            textBoxEmployeeID.ReadOnly = false;
            comboBoxLevel.Enabled = true;
            btnGenerateRank.Enabled = true;
        }

        private void btnGenerateRank_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeID.Text == String.Empty)
            {
                textBoxEmployeeID.Focus();
                errorAddLecturer.SetError(textBoxEmployeeID, "Please Enter Employee ID");
            }
            else if(comboBoxLevel.SelectedIndex == -1)
            {
                comboBoxLevel.Focus();
                errorAddLecturer.SetError(comboBoxLevel, "Please Select Level");
            }
            else
            {
                lecturer.Rank = comboBoxLevel.SelectedItem + "." + textBoxEmployeeID.Text.Trim();
                textBoxRank.Text = lecturer.Rank;
                textBoxEmployeeID.ReadOnly = true;
                comboBoxLevel.Enabled = false;
                btnGenerateRank.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxLecturerName.Text == String.Empty)
            {
                textBoxLecturerName.Focus();
                errorAddLecturer.SetError(textBoxLecturerName, "Please Enter Lecturer Name");
            }
            else if (comboBoxFaculty.SelectedIndex == -1)
            {
                comboBoxFaculty.Focus();
                errorAddLecturer.SetError(comboBoxFaculty, "Please Select Faculty");
            }
            else if (textBoxDepartment.Text == String.Empty)
            {
                textBoxDepartment.Focus();
                errorAddLecturer.SetError(textBoxDepartment, "Please Enter Department");
            }
            else if (comboBoxCenter.SelectedIndex == -1)
            {
                comboBoxCenter.Focus();
                errorAddLecturer.SetError(comboBoxCenter, "Please Select Center");
            }
            else if (textBoxRank.Text == String.Empty)
            {
                btnGenerateRank.Focus();
                ErrorMessage em = new ErrorMessage("Please Generate Rank before Save");
                em.Show();
            }
            else
            {
                ILecturerService lecturerService = new LecturerService();

                #region Set Data to Object
                // Set Data to model
                lecturer.Name = textBoxLecturerName.Text.Trim();
                lecturer.EmployeeID = textBoxEmployeeID.Text.Trim();
                lecturer.Faculty = comboBoxFaculty.SelectedItem.ToString();
                lecturer.Department = textBoxDepartment.Text.Trim();
                lecturer.Center = comboBoxCenter.SelectedItem.ToString();
                lecturer.Building = comboBoxBuilding.SelectedItem.ToString();
                lecturer.Level = int.Parse(comboBoxLevel.SelectedIndex.ToString());
                lecturer.Rank = textBoxRank.Text.Trim();
                #endregion

                //Insert Data
                if (lecturerService.addLecturer(lecturer))
                {
                    SuccessMessage sc = new SuccessMessage("Lecturer Added Successfully !");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
