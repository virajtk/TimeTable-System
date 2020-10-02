using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Allocations;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;
using System.Data.SQLite;

namespace Time_Table_Management_System.Allocations
{
    public partial class AllocateSession : Form
    {

        private SessionDTO selectedSession = null;
        private ISessionService sessionService = new SessionService();
        private IConsecutiveService consecutiveService = new ConsecutiveService();
        private bool executedFirstTime;

        public AllocateSession()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();

            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn chkbox2 = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn chkbox3 = new DataGridViewCheckBoxColumn();
            
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            chkbox2.HeaderText = "";
            chkbox2.Width = 30;
            chkbox2.Name = "checkBoxColumn";
            chkbox3.HeaderText = "";
            chkbox3.Width = 30;
            chkbox3.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);
            dataGridView2.Columns.Insert(0, chkbox2);
            dataGridView3.Columns.Insert(0, chkbox3);
        }

        public void populateData()
        {
            List<SessionDTO> sessionsArray = sessionService.getAllSessions();
            dataGridView1.Rows.Clear();

            foreach (SessionDTO session in sessionsArray)
            {
                dataGridView1.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);

                dataGridView2.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);

                dataGridView3.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);
            }

        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            int conSessionID1=0;
            int conSessionID2=0;
            int selectedSessionsCount = 0;

            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    if(selectedSessionsCount == 0)
                    {
                        conSessionID1 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount++;
                        
                    }
                    else if (selectedSessionsCount == 1)
                    {
                        conSessionID2 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount++;
                    }
                }
                
            }
            if (consecutiveService.addConsecutive(conSessionID1, conSessionID2))
            {
                label1.Text = "Consecutive Sessions Added Successfully";
            }
            else
            {
                label1.Text = "Oops...Something went wrong";
            }
            
        }
        
        private void btnView_Click(object sender, EventArgs e)
        {
            ManageConsecutives consecutiveSession = new ManageConsecutives();
            consecutiveSession.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewN_Click(object sender, EventArgs e)
        {
            ManageNonoverlaps nonoverlapSession = new ManageNonoverlaps();
            nonoverlapSession.Show();
        }

        private void btnViewP_Click(object sender, EventArgs e)
        {
            ManageParallels parallelSession = new ManageParallels();
            parallelSession.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
