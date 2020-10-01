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

        public List<DataLayer.Location> getLocations()
        {
            locationData = new LocationData();

            return locationData.GetLocation();

        }

        public List<Room> getAllRooms(int buildingID)
        {
            locationData = new LocationData();

            return locationData.GetAllRoomDetails(buildingID);
            
        }

        public List<Room> GetAllRoomsAccordingtostudentCount(int stdCount, string tag)
        {
            locationData = new LocationData();

            return locationData.GetAllRoomsAccordingtostudentCount(stdCount, tag);
            
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

        public int UpdateBuildingName(int bid, string bname)
        {
            locationData = new LocationData();
            return locationData.UpdateBuildingName(bid, bname);
        }

        public int DeleteBuilding(int bid)
        {
            locationData = new LocationData();
            return locationData.DeleteBuilding(bid);
        }

        public int UpdateRoomName(int rid, string rname)
        {
            locationData = new LocationData();
            return locationData.UpdateRoomName(rid, rname);
        }

        public int DeleteRoom(int rid)
        {
            locationData = new LocationData();
            return locationData.DeleteRoom(rid);
        }

    }
}
