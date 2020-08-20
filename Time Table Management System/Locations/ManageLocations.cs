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


namespace Time_Table_Management_System.Locations
{
    public partial class ManageLocations : Form
    {
        private bool executedFirstTime;
        private Location selectedLoc;
        private ILocationService locationService;
        public ManageLocations()
        {
            InitializeComponent();
            executedFirstTime = true;
            locationService = new LocationService();
            populateData();
        }
        private void populateData()
        {
            ILocationService locationService = new LocationService();
            List<Location> locationsArray = locationService.getAllLocations();

            foreach (Location location in locationsArray)
            {
                dataGridLocations.Rows.Add(location.Id, location.BuildingName, location.RoomName, location.RoomType, location.Capacity);
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            
            textBoxBuildName.Text = "";
            radioButtonLectureHall.Checked = false;
            radioButtonLaboratory.Checked = false;
            textBoxCapacity.Text = "";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                int selectedIndex = dataGridLocations.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridLocations.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridLocations.SelectedRows[0].Cells[0].Value.ToString());
                        selectedLoc = locationService.GetLocation(id);

                        #region Set data to Fields
                        textBoxBuildName.Text = selectedLoc.BuildingName;
                        textBoxRoomName.Text = selectedLoc.RoomName;

                        if (radioButtonLectureHall.Checked == true)
                            selectedLoc.RoomType = "Lecture Hall";
                        else
                            selectedLoc.RoomType = "Laboratory";

                        textBoxCapacity.Text = selectedLoc.Capacity;
                       
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
