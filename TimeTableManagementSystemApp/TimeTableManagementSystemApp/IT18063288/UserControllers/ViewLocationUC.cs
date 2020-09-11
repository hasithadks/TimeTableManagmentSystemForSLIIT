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

namespace TimeTableManagementSystemApp.IT18063288.UserControls
{
    public partial class ViewLocationUC : UserControl
    {

        private LocationBO locationBO;
        private LocationController locationContol;

        public ViewLocationUC()
        {
            InitializeComponent();

            locationBO = new LocationBO();

            GetAllBuildings();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRecordLocationUC_Click(object sender, EventArgs e)
        {
            //EditLocationDataUC editLocationDataUC = new EditLocationDataUC();
            //CommonClass.showControl(editLocationDataUC, pnlEditRecords);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void GetAllBuildings()
        {
            locationContol = new LocationController();
            List<Building> buildingList = locationContol.getAllBuilding();
            //comboBoxBuilding.DataSource = buildingList;

            var BuildingStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Building building in buildingList)
            {

                BuildingStatus.Add(new KeyValuePair<string, string>(building.id.ToString(), building.BuidingName.ToString()));

            }


            buildingDataGrid.DataSource = BuildingStatus;
            buildingDataGrid.Columns[0].HeaderText = "Building ID";
            buildingDataGrid.Columns[1].HeaderText = "Building Name";


        }


        public void GetAllRooms()
        {
            locationContol = new LocationController();
            List<Room> roomList = locationContol.getAllRooms(locationBO.BuildingID);

            var roomStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Room room in roomList)
            {

                roomStatus.Add(new KeyValuePair<string, string>(room.id.ToString(), room.RoomName.ToString()));

            }




            roomDatagrid.DataSource = roomStatus;
            roomDatagrid.Columns[0].HeaderText = "Room ID";
            roomDatagrid.Columns[1].HeaderText = "Room Name";
            //roomDatagrid.Columns[2].HeaderText = "Room Capacity";
            //roomDatagrid.Columns[3].HeaderText = "Room type";


        }

        private void buildingDataGrid_DoubleClick(object sender, EventArgs e)
        {
            

            locationBO.BuildingID = Convert.ToInt32(buildingDataGrid.SelectedRows[0].Cells[0].Value);
            locationBO.BuildingName = buildingDataGrid.SelectedRows[0].Cells[1].Value.ToString();

            GetAllRooms();


        }

        private void roomDatagrid_DoubleClick(object sender, EventArgs e)
        {
            locationBO.RoomID = Convert.ToInt32(roomDatagrid.SelectedRows[0].Cells[0].Value);
            locationBO.RoomName = roomDatagrid.SelectedRows[0].Cells[1].Value.ToString();

            locationContol = new LocationController();

            LocationBO locationBO2 = new LocationBO();
            locationBO2 = locationContol.GetRoomDetails(Convert.ToInt32(roomDatagrid.SelectedRows[0].Cells[0].Value));

            locationBO.RoomCapacity = locationBO2.RoomCapacity;
            locationBO.RoomType = locationBO2.RoomType;

            EditLocationDataUC editLocationDataUC = new EditLocationDataUC(locationBO);
            CommonClass.showControl(editLocationDataUC, pnlEditRecords);
        }
    }
}
