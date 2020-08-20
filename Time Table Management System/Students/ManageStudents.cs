﻿using System;
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

namespace Time_Table_Management_System.Students
{
    public partial class ManageStudents : Form
    {
        private bool executedFirstTime;
        private Student selectedStu;
        private IStudentService studentService;
        public ManageStudents()
        {
            InitializeComponent();
            executedFirstTime = true;
            studentService = new StudentService();
            populateData();
        }

        private void populateData()
        {
            IStudentService studentService = new StudentService();
            List<Student> studentsArray = studentService.getAllStudents();

            foreach (Student student in studentsArray)
            {
                dataGridView1.Rows.Add(student.Id,student.AcademicYear, student.Programme, student.GroupNumber, student.GroupId, student.SubGroupNumber, student.SubGroupId);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        selectedStu = studentService.GetStudent(id);

                        #region Set data to Fields
                        textBoxAcYear.Text = selectedStu.AcademicYear;

                        switch (selectedStu.Programme)
                        {
                            case "IT":
                                comboBoxProgramme.SelectedIndex = 0;
                                break;
                            case "CSSE":
                                comboBoxProgramme.SelectedIndex = 1;
                                break;
                            case "CSE":
                                comboBoxProgramme.SelectedIndex = 2;
                                break;
                            case "DS":
                                comboBoxProgramme.SelectedIndex = 3;
                                break;
                            case "CN":
                                comboBoxProgramme.SelectedIndex = 4;
                                break;

                        }
                        numericGroupno.Value = selectedStu.GroupNumber;
                        numericSubGroup.Value = selectedStu.SubGroupNumber;
                        textBoxgroupId.Text = selectedStu.GroupId;
                        textBoxSubGroup.Text = selectedStu.SubGroupId;

                        #endregion

                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }


            }
            catch (ArgumentOutOfRangeException es)
            {
                Console.WriteLine(es.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            textBoxAcYear.Text = String.Empty;
            comboBoxProgramme.SelectedIndex = -1;
            numericGroupno.Value = 0;
            numericSubGroup.Value = 0;
            textBoxgroupId.Text = String.Empty;
            textBoxSubGroup.Text = String.Empty;


            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void textBoxAcYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericGroupno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericSubGroup_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxgroupId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSubGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
