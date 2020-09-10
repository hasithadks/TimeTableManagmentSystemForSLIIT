using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Location;
using TimeTableManagementSystemApp.CommonFiles;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    public partial class EditLocationDataUC : UserControl
    {

        LocationBO locationBoViewUc = new LocationBO();

        public EditLocationDataUC(LocationBO locationBo)
        {
            InitializeComponent();
            txtCapacity.Enabled = false;
            radioBtnLecture.Enabled = false;
            radioBtnLab.Enabled = false;

            lblBuilding.Text = locationBo.BuildingName;
            lblRoom.Text = locationBo.RoomName;
            txtCapacity.Text =locationBo.RoomCapacity.ToString();
            //roomType : 1 - Lecture Hall 2 - Lab
            if(locationBo.RoomType == 1)
            {
                radioBtnLecture.Checked = true;
            }
            else if (locationBo.RoomType == 2)
            {
                radioBtnLab.Checked = true;
            }

            locationBoViewUc = new LocationBO();

            locationBoViewUc.BuildingID = locationBo.BuildingID;
            locationBoViewUc.RoomID = locationBo.RoomID;
            locationBoViewUc.BuildingName = locationBo.BuildingName;
            locationBoViewUc.RoomCapacity = locationBo.RoomCapacity;
            locationBoViewUc.RoomType = locationBo.RoomType;

            btnUpdateLocationUC.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRecords_Click(object sender, EventArgs e)
        {
            txtCapacity.Enabled = true;
            radioBtnLecture.Enabled = true;
            radioBtnLab.Enabled = true;
            btnUpdateLocationUC.Visible = true;
            btnEditRecords.Visible = false;

        }

        private void btnEditLocationUC_Click(object sender, EventArgs e)
        {


            locationBoViewUc.RoomCapacity = int.Parse(txtCapacity.Text);
            
            if(radioBtnLecture.Checked == true)
            {
                locationBoViewUc.RoomType = 1;
            }
            else
            {
                locationBoViewUc.RoomType = 2;
            }

            LocationController locationContol = new LocationController();

            int roomID = locationContol.SaveRoomOtherDetails(locationBoViewUc);
            if (roomID > 0)
            {
                //success Message
                SuccessfullMessageBox.ShowDialog("Room Details Updated successfully!!!", "Success!!!");
                //txtRoomCapacity.Text = "";
                //checkBoxLecture.Checked = false;
                //checkBoxLab.Checked = false;
                //LocationBO locationBO = new LocationBO();
                // this.Parent.Controls.Remove(this);

                btnUpdateLocationUC.Visible = false;
                btnEditRecords.Visible = true;
                txtCapacity.Enabled = false;
                radioBtnLecture.Enabled = false;
                radioBtnLab.Enabled = false;
            }
            else
            {
                ErrorDialogBox.ShowDialog("Cannot update room Details.", "Warning!!!");
            }


        }

        private void checkBoxLecture_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
