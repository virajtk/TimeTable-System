using System;
using System.Collections;
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

namespace Time_Table_Management_System.Lecturers
{
    public partial class ManageLecturers : Form
    {
        private bool executedFirstTime;
        private Lecturer selectedLec;
        private ILecturerService lecturerService;
        public ManageLecturers()
        {
            InitializeComponent();
            executedFirstTime = true;
            lecturerService = new LecturerService();
            populateData();
        }

        private void populateData()
        {
            ILecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturersArray = lecturerService.getAllLecturers();

            foreach(Lecturer lecturer in lecturersArray)
            {
                dataGridLecturers.Rows.Add(lecturer.Id, lecturer.Name, lecturer.EmployeeID, lecturer.Faculty, lecturer.Department, lecturer.Center, lecturer.Building, lecturer.Level, lecturer.Rank);
            }
            
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

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_Selection(object sender, EventArgs e)
        {
            if (executedFirstTime)
            {
                executedFirstTime = false;
                return;
            }
            try
            {
                int selectedIndex = dataGridLecturers.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if(dataGridLecturers.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridLecturers.SelectedRows[0].Cells[0].Value.ToString()); 
                        selectedLec = lecturerService.GetLecturer(id);

                        #region Set data to Fields
                        textBoxLecturerName.Text = selectedLec.Name;
                        textBoxEmployeeID.Text = selectedLec.EmployeeID;
                        switch (selectedLec.Faculty)
                        {
                            case "Computing": 
                                comboBoxFaculty.SelectedIndex = 0;
                                break;
                            case "Engineering":
                                comboBoxFaculty.SelectedIndex = 1;
                                break;
                            case "Business":
                                comboBoxFaculty.SelectedIndex = 2;
                                break;
                            case "Humanities & Sciences":
                                comboBoxFaculty.SelectedIndex = 3;
                                break;
                        }
                        textBoxDepartment.Text = selectedLec.Department;

                        switch (selectedLec.Center)
                        {
                            case "Malabe":
                                comboBoxCenter.SelectedIndex = 0;
                                break;
                            case "Metro":
                                comboBoxCenter.SelectedIndex = 1;
                                break;
                            case "Matara":
                                comboBoxCenter.SelectedIndex = 2;
                                break;
                            case "Kandy":
                                comboBoxCenter.SelectedIndex = 3;
                                break;
                            case "Kurunagala":
                                comboBoxCenter.SelectedIndex = 4;
                                break;
                            case "Jaffna":
                                comboBoxCenter.SelectedIndex = 5;
                                break;
                        }

                        switch (selectedLec.Building)
                        {
                            case "New building":
                                comboBoxBuilding.SelectedIndex = 0;
                                break;
                            case "A-block":
                                comboBoxBuilding.SelectedIndex = 1;
                                break;
                            case "B-block":
                                comboBoxBuilding.SelectedIndex = 2;
                                break;
                            case "C-block":
                                comboBoxBuilding.SelectedIndex = 3;
                                break;
                            case "D-block":
                                comboBoxBuilding.SelectedIndex = 4;
                                break;
                            case "E-block":
                                comboBoxBuilding.SelectedIndex = 5;
                                break;
                        }
                        switch (selectedLec.Level)
                        {
                            case 1: 
                                comboBoxLevel.SelectedIndex = 0;
                                break;
                            case 2:
                                comboBoxLevel.SelectedIndex = 1;
                                break;
                            case 3:
                                comboBoxLevel.SelectedIndex = 2;
                                break;
                            case 4:
                                comboBoxLevel.SelectedIndex = 3;
                                break;
                            case 5:
                                comboBoxLevel.SelectedIndex = 4;
                                break;
                            case 6:
                                comboBoxLevel.SelectedIndex = 5;
                                break;
                            case 7:
                                comboBoxLevel.SelectedIndex = 6;
                                break;
                        }
                        textBoxRank.Text = selectedLec.Rank;
                        #endregion

                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }


            }catch(ArgumentOutOfRangeException es)
            {
                Console.WriteLine(es.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
