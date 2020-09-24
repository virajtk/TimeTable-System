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
    public partial class ManageSessionsMain : Form
    {
        public ManageSessionsMain()
        {
            InitializeComponent();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            ManageSessions manageSessions = new ManageSessions();
            manageSessions.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
