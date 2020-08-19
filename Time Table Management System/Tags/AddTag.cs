using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Messages;

namespace Time_Table_Management_System.Tags
{
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
        }

        private void AddTag_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                textBox1.Focus();
                errorAddTag.SetError(textBox1, "Please Enter Subject Name");
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Focus();
                errorAddTag.SetError(textBox2, "Please Enter Subject Code");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                errorAddTag.SetError(comboBox1, "Please Select Related Tag");
            }
            else
            {
                Tag tag = new Tag();

                // Set Data
                tag.SubjectName = textBox1.Text.Trim();
                tag.SubjectCode = textBox2.Text.Trim();
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        tag.RelatedTag = "Lecture";
                        break;
                    case 1:
                        tag.RelatedTag = "Lab";
                        break;
                    case 2:
                        tag.RelatedTag = "Practicle";
                        break;
                }


                SuccessMessage sc = new SuccessMessage("Tag Added Successfully !");
                sc.Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
