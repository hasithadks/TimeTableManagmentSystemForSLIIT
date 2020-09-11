using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayers.Lecturer;
using BusinessLayers.Location;

namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    public partial class AddLecturerUC : UserControl
    {
        private LecturerController lecturerController;
        private LocationBO locationBO;

        public AddLecturerUC()
        {
            InitializeComponent();
            locationBO = new LocationBO();
            setBuildingDropdown();
        }

        private void labeldepartment_Click(object sender, EventArgs e)
        {

        }

        private void textBoxdepartment_TextChanged(object sender, EventArgs e)
        {

        }

        public void setBuildingDropdown()
        {
            lecturerController = new LecturerController();
            List<Building> buildingList = lecturerController.getAllBuilding();

            var BuildingStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Building building in buildingList)
            {

                BuildingStatus.Add(new KeyValuePair<string, string>(building.id.ToString(), building.BuidingName.ToString()));

            }

            comboBoxBuilding.DataSource = BuildingStatus;
            comboBoxBuilding.ValueMember = "Key";
            comboBoxBuilding.DisplayMember = "Value";
            comboBoxBuilding.SelectedIndex = -1;
        }

        private void buttonaddlecturer_Click(object sender, EventArgs e)
        {
            lecturerController = new LecturerController();

            string lid = textBoxid.Text;
            string lname = textBoxname.Text;
            string lfaculty = checkedListBoxfaculty.Text;
            string ldepartment = textBoxdepartment.Text;
            string lcenter = checkedListBoxCenter.Text;
            string lbuilding = comboBoxBuilding.Text;
            int llevel = Convert.ToInt32(textBoxlevel.Text);
            string lrank = textBoxrank.Text;

            lecturerController.saveLecturer(lid, lname, lfaculty, ldepartment,lcenter,lbuilding,llevel,lrank);

            MessageBox.Show("New Lecturer Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxid.Clear();
            textBoxname.Clear();
            textBoxdepartment.Clear();
            textBoxlevel.Clear();
            textBoxrank.Clear();
        }

        private void AddLecturerUC_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuilding.SelectedIndex != -1)
            {
                KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)comboBoxBuilding.SelectedItem;
                locationBO.BuildingID = int.Parse(selectedEntry.Key);
            }
        }
    }
}
