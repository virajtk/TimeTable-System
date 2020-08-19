using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Messages;

namespace Time_Table_Management_System.Students
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                textBox1.Focus();
                errorAddStudent.SetError(textBox1, "Please Enter Subject Name");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorAddStudent.SetError(comboBox1, "Please Select Programme");
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Focus();
                errorAddStudent.SetError(textBox2, "Please Enter Group Number");
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Focus();
                errorAddStudent.SetError(textBox3, "Please Enter Group Id");
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Focus();
                errorAddStudent.SetError(textBox4, "Please Enter Sub Group Number");
            }
            else if (textBox5.Text == String.Empty)
            {
                textBox5.Focus();
                errorAddStudent.SetError(textBox5, "Please Enter Sub Group Id");
            }
            else
            {
                Student student = new Student();

                // Set Data
                student.AcademicYear = textBox1.Text.Trim();
                student.GroupNumber = textBox2.Text.Trim();
                student.GroupId = textBox3.Text.Trim();
                student.SubGroupNumber = textBox4.Text.Trim();
                student.SubGroupId = textBox5.Text.Trim();

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        student.Programme = "IT";
                        break;
                    case 1:
                        student.Programme = "CSSE";
                        break;
                    case 2:
                        student.Programme = "CSE";
                        break;
                    case 3:
                        student.Programme = "DS";
                        break;
                    case 4:
                        student.Programme = "CN";
                        break;
                }
                SuccessMessage sc = new SuccessMessage("Student Group Added Successfully !");
                sc.Show();
            }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
