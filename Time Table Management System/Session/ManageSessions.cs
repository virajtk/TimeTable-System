using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System.Session
{
    public partial class ManageSessions : Form
    {
        public ManageSessions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            comboBoxGroup.SelectedIndex = -1;
            comboBoxSubject.SelectedIndex = -1;
            txtDuration.Text = String.Empty;
            txtNoOfStudents.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxLec.SelectedIndex = -1;
            comboBoxTag.SelectedIndex = -1;
            txtSelectedLec.Text = String.Empty;
        }
    }
}
