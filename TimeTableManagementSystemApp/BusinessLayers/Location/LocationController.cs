using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Location
{
    public class LocationController
    {
        private LocationData locationData;

        public int saveBuilding(string buildingname)
        {
            locationData = new LocationData();
            int id = locationData.saveBuildingData(buildingname);

            return id;
        }

        public int saveRoom(string roomName, int buildingId)
        {
            locationData = new LocationData();
            int id = locationData.SaveRoomData(roomName, buildingId);

            return id;
        }

        public List<Building> getAllBuilding()
        {
            locationData = new LocationData();
              
            return locationData.GetAllBuildingName();

        }

        public List<Room> getAllRooms(int buildingID)
        {
            locationData = new LocationData();

            return locationData.GetAllRoomDetails(buildingID);

        }

        public LocationBO GetRoomDetails(int RoomID)
        {
            locationData = new LocationData();

            return locationData.GetRoomDetails(RoomID);

        }

        public int SaveRoomOtherDetails(LocationBO locationBO)
        {

            locationData = new LocationData();
            return locationData.SaveRoomOtherDetails(locationBO);

        }
    }
}
