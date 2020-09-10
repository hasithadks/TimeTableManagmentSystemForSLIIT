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
using DataLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TimeTableManagementSystemApp.CommonFiles;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    public partial class MoreRoomDetailsUC : UserControl
    {

        private LocationController locationContol;
        private int RoomID = 0;
        LocationBO locationBOall = new LocationBO();
        

        public MoreRoomDetailsUC(LocationBO locationBo)
        {
            InitializeComponent();
            txtRoomCapacity.Text = "";

            if (locationBo != null)
            {

                locationBOall.BuildingID = locationBo.BuildingID;
                locationBOall.BuildingName = locationBo.BuildingName;
                locationBOall.RoomID = locationBo.RoomID;
                locationBOall.RoomCapacity = locationBo.RoomCapacity;
                locationBOall.RoomType = locationBo.RoomType;

                
                GetRoomDetails(locationBo.RoomID);

            }
        }

       

        public void GetRoomDetails(int roomId)
        {
            locationContol = new LocationController();
            LocationBO roomDetailsBO = locationContol.GetRoomDetails(roomId);

            txtRoomCapacity.Text = roomDetailsBO.RoomCapacity.ToString();
            //Room Types 
            //    1- LectureHall
            //    2- Lab
            if (roomDetailsBO.RoomType == 1)
            {
                checkBoxLecture.Checked = true;
            }
            else if(roomDetailsBO.RoomType == 2)
            {
                checkBoxLab.Checked = true;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {

            locationBOall.RoomCapacity = int.Parse(txtRoomCapacity.Text.ToString());
            //Room Types 
            //    1- LectureHall
            //    2- Lab
            if (checkBoxLecture.Checked == true)
            {
                locationBOall.RoomType = 1;
            }
            else if(checkBoxLab.Checked == true)
            {
                locationBOall.RoomType = 2;
            }
            else
            {
                locationBOall.RoomType = 0;
            }

            locationContol = new LocationController();
            int roomID = locationContol.SaveRoomOtherDetails(locationBOall);
            if(roomID > 0)
            {
                //success Message
                SuccessfullMessageBox.ShowDialog("Room Details Updated successfully!!!", "Success!!!");
                //txtRoomCapacity.Text = "";
                //checkBoxLecture.Checked = false;
                //checkBoxLab.Checked = false;
                //LocationBO locationBO = new LocationBO();
                this.Parent.Controls.Remove(this);

            }
            else
            {
                ErrorDialogBox.ShowDialog("Cannot update room Details.", "Warning!!!");
            }


        }
    }
}
