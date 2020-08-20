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

namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    public partial class AddLocationUC : UserControl
    {
        private LocationBO locationBO;
        private LocationController locationContol;

        private int buildingID = 0;

        public AddLocationUC()
        {
            InitializeComponent();
            txtNewBuilding.Visible = false;
            btnBuildingSave.Visible = false;
            btnBuildingUpdate.Visible = false;
            btnDeleteBuilding.Visible = false;

            txtNewRoom.Visible = false;
            btnRoomSave.Visible = false;
            btnRoomUpdate.Visible = false;
            btnDeleteRoom.Visible = false;

        }

        private void txtNewBuilding_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnChangeBuildingName_Click(object sender, EventArgs e)
        {
            txtNewBuilding.Text = comboBoxBuilding.Text;
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
            MoreRoomDetailsUC moreRoomDetailsUC = new MoreRoomDetailsUC();
            CommonClass.showControl(moreRoomDetailsUC, panelRoomDetails);
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoreRoomDetailsUC moreRoomDetailsUC = new MoreRoomDetailsUC();
            CommonClass.showControl(moreRoomDetailsUC, panelRoomDetails);
        }

        private void btnBuildingSave_Click(object sender, EventArgs e)
        {
            locationContol = new LocationController();
            string buildingName = string.Empty;
            locationBO = new LocationBO();
            buildingName = txtNewBuilding.Text;
            locationBO.RoomName = buildingName.ToString();
            buildingID = locationContol.saveBuilding(buildingName);
        }
    }
}
