using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers;
using TimeTableManagementSystemApp.CommonFiles;
using BusinessLayers.Location;
using DataLayer;
using System.Data.Entity;
using System.Data.Entity.Core.Common.EntitySql;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    public partial class AddLocationUC : UserControl
    {
        private LocationBO locationBO; 
        private LocationController locationContol;

        private int buildingID = 0;
        private int RoomID = 0;

        public AddLocationUC()
        {
            InitializeComponent();

            

            locationBO = new LocationBO();

            txtNewBuilding.Visible = false;
            btnBuildingSave.Visible = false;
            btnBuildingUpdate.Visible = false;
            btnDeleteBuilding.Visible = false;

            txtNewRoom.Visible = false;
            btnRoomSave.Visible = false;
            btnRoomUpdate.Visible = false;
            btnDeleteRoom.Visible = false;

            //Room Details
            labelRoom.Visible = false;
            comboBoxRoom.Visible = false;
            btnAddNewRoom.Visible = false;
            btnChangeRoomName.Visible = false;

            setBuildingDropdown();


            

        }

        private void txtNewBuilding_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnChangeBuildingName_Click(object sender, EventArgs e)
        {
            txtNewBuilding.Text = comboBoxBuilding.Text;
            locationBO.BuildingID = comboBoxBuilding.SelectedIndex;
            txtNewBuilding.Visible = true;
            btnBuildingUpdate.Visible = true;
            btnDeleteBuilding.Visible = true;
            btnBuildingSave.Visible = false;
        }

        private void btnAddNewBuilding_Click(object sender, EventArgs e)
        {
            txtNewBuilding.Text = "";
            txtNewBuilding.Visible = true;
            btnBuildingSave.Visible = true;
            btnBuildingUpdate.Visible = false;
            btnDeleteBuilding.Visible = false;

        }

        private void lblRoomDetails_Click(object sender, EventArgs e)
        {
            //MoreRoomDetailsUC moreRoomDetailsUC = new MoreRoomDetailsUC();
            //CommonClass.showControl(moreRoomDetailsUC, panelRoomDetails);
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            txtNewRoom.Text = "";
            txtNewRoom.Visible = true;
            btnRoomSave.Visible = true;
            btnRoomUpdate.Visible = false;
            btnDeleteRoom.Visible = false;
        }

        private void btnChangeRoomName_Click(object sender, EventArgs e)
        {
            txtNewRoom.Text = comboBoxRoom.Text;
            txtNewRoom.Visible = true;
            btnRoomUpdate.Visible = true;
            btnDeleteRoom.Visible = true;
            btnRoomSave.Visible = false;
        }

        private void btnRoomSave_Click(object sender, EventArgs e)
        {
            

            locationContol = new LocationController();
            string RoomName = string.Empty;

            RoomName = txtNewRoom.Text;
            locationBO.RoomName = RoomName.ToString();
            RoomID = locationContol.saveRoom(RoomName,locationBO.BuildingID);
            txtNewRoom.Text = "";

            if (RoomID > 0)
            {
                locationBO.RoomID = RoomID;
            }
            else
            {
                locationBO.RoomID = 0;
            }

            //MoreRoomDetailsUC moreRoomDetailsUC = new MoreRoomDetailsUC(locationBO);
            //CommonClass.showControl(moreRoomDetailsUC, panelRoomDetails);
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            locationContol = new LocationController();
            string RoomName = string.Empty;
            int roomselectedIndex = 0;
            roomselectedIndex = comboBoxRoom.SelectedIndex;
            if(roomselectedIndex != -1)
            {
                
                KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)comboBoxRoom.SelectedItem;
                locationBO.RoomID = int.Parse(selectedEntry.Key);


                RoomName = selectedEntry.Value.ToString();
                locationBO.RoomName = RoomName;
                
                

            }
            

            
        }

        private void btnBuildingSave_Click(object sender, EventArgs e)
        {
            locationContol = new LocationController();
            string buildingName = string.Empty;
            
            buildingName = txtNewBuilding.Text;
            locationBO.BuildingName = buildingName.ToString();
            buildingID = locationContol.saveBuilding(buildingName);
            txtNewBuilding.Text = "";

            if (buildingID > 0)
            {
                locationBO.BuildingID = buildingID;
            }
            else
            {
                locationBO.BuildingID = 0;
            }

        }

        
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.buildingsTableAdapter.FillBy(this.timetableManagementSystemDataSet.Buildings);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.buildingsTableAdapter.Fill(this.timetableManagementSystemDataSet.Buildings);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

            labelRoom.Visible = true;
            comboBoxRoom.Visible = true;
            btnAddNewRoom.Visible = true;
            btnChangeRoomName.Visible = true;

            if(comboBoxBuilding.SelectedIndex != -1)
            {
                KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)comboBoxBuilding.SelectedItem;
                locationBO.BuildingID = int.Parse(selectedEntry.Key);
            }
            

            //locationBO.BuildingID = int.Parse(((System.Collections.Generic.KeyValuePair<string, string>)comboBoxBuilding.SelectedValue).Key);


            //locationBO.BuildingID = int.Parse(comboBoxBuilding.SelectedValue.ToString());



            SetRoomDropDown();

        }


        private void btnViewRoomDetails_Click(object sender, EventArgs e)
        {

            if (locationBO.RoomID > 0)
            {
                MoreRoomDetailsUC moreRoomDetailsUC = new MoreRoomDetailsUC(locationBO);
                CommonClass.showControl(moreRoomDetailsUC, panelRoomDetails);
            }

        }


        //Public Methods

        public void setBuildingDropdown()
        {
            locationContol = new LocationController();
            List<Building> buildingList = locationContol.getAllBuilding();
            //comboBoxBuilding.DataSource = buildingList;

            var BuildingStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Building building in buildingList)
            {

                BuildingStatus.Add(new KeyValuePair<string, string>(building.id.ToString(), building.BuidingName.ToString()));

            }

            comboBoxBuilding.DataSource = BuildingStatus;
            comboBoxBuilding.ValueMember = "Key";
            comboBoxBuilding.DisplayMember = "Value";
            //if(buildingList.Count > 0)
            //{
            //    comboBoxBuilding.SelectedIndex = 0;
            //}
            comboBoxBuilding.SelectedIndex = -1;
            //locationBO.BuildingID = int.Parse(((System.Collections.Generic.KeyValuePair<string, string>)comboBoxBuilding.SelectedValue).Key);

        }


        public void SetRoomDropDown()
        {
            locationContol = new LocationController();
            List<Room> roomList = locationContol.getAllRooms(locationBO.BuildingID);

            var roomStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Room room in roomList)
            {

                roomStatus.Add(new KeyValuePair<string, string>(room.id.ToString(), room.RoomName.ToString()));

            }

            comboBoxRoom.DataSource = roomStatus;
            comboBoxRoom.ValueMember = "Key";
            comboBoxRoom.DisplayMember = "Value";
            comboBoxRoom.SelectedIndex = -1;
            
            

        }

        
    }
}
