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

namespace Time_Table_Management_System
{
    public partial class ManageSubjects : Form
    {
        private bool executedFirstTime;
        private Subject selectedSub;
        private ISubjectService subjectService;
        private List<Subject> subjectsArray;

        public ManageSubjects()
        {
            InitializeComponent();
            executedFirstTime = true;
            subjectService = new SubjectService();
            populateData();
        }

        private void populateData()
        {
            subjectsArray = new List<Subject>();
            subjectsArray = subjectService.getAllSubjects();

            foreach (Subject subject in subjectsArray)
            {
                dataGridSubjects.Rows.Add(subject.Id, subject.SubjectName, subject.SubjectCode, subject.OfferedYear, subject.OfferedSem, subject.LecHours, subject.TuteHours, subject.LabHours, subject.EvaluationHours);
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            textBoxSubName.Text = String.Empty;
            textBoxSubCode.Text = String.Empty;
            comboBoxOfferdYear.SelectedIndex = -1;
            radioButtonSem1.Checked = false;
            radioButtonSem2.Checked = false;
            numericLecHours.Value = 2;
            numericTuteHours.Value = 1;
            numericLabHours.Value = 2;
            numericEvaluationHours.Value = 1;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (subjectService.deleteSubject(selectedSub.Id))
            {
                SuccessMessage sm = new SuccessMessage("Subject Deleted Successfully");
                sm.Show();
                clear();
                dataGridSubjects.Rows.Clear();
                populateData();
            }
            else
            {
                ErrorMessage em = new ErrorMessage("Oops, Somthing went wrong..");
                em.Show();
            }
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
                int selectedIndex = dataGridSubjects.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridSubjects.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridSubjects.SelectedRows[0].Cells[0].Value.ToString());
                        selectedSub = subjectService.getSubject(id);

                        #region Set data to Fields
                        textBoxSubName.Text = selectedSub.SubjectName;
                        textBoxSubCode.Text = selectedSub.SubjectCode;
                        switch (selectedSub.OfferedYear)
                        {
                            case 1:
                                comboBoxOfferdYear.SelectedIndex = 0;
                                break;
                            case 2:
                                comboBoxOfferdYear.SelectedIndex = 1;
                                break;
                            case 3:
                                comboBoxOfferdYear.SelectedIndex = 2;
                                break;
                            case 4:
                                comboBoxOfferdYear.SelectedIndex = 3;
                                break;
                        }

                        if(selectedSub.OfferedSem == 1)
                        {
                            radioButtonSem1.Checked = true;
                        }
                        else
                        {
                            radioButtonSem2.Checked = true;
                        }

                        numericLecHours.Value = selectedSub.LecHours;
                        numericTuteHours.Value = selectedSub.TuteHours;
                        numericLabHours.Value = selectedSub.LabHours;
                        numericEvaluationHours.Value = selectedSub.EvaluationHours;
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
    }
}
