using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayers.Location
{
    class LocationData
    {

        public int saveBuildingData(string bName)
        {
            int BuildingID = 0;

            using (var context = new TimetableManagementSystemEntities2())
            {

                //insert
                Building newBuilding = new Building()
                {
                    BuidingName = bName
                };

                context.Buildings.Add(newBuilding);
                context.SaveChanges();

                BuildingID = newBuilding.id;




                //update
                //var updatingBuilding = context.Buildings.Where(q => q.id == 12).FirstOrDefault();

                //if(updatingBuilding != null)
                //{
                //    updatingBuilding.BuidingName = "updated name";
                //context.SaveChanges();
                //}

                //select single
                //var singleBuilding = context.Buildings.Where(q => q.id == 12).FirstOrDefault();


                //select multiple
                //List<Building> multiple = context.Buildings.ToList();

                //delete
                //var deletingBuilding = context.Buildings.Where(q => q.id == 12).FirstOrDefault();

                //if(deletingBuilding != null)
                //{
                //    context.Buildings.Remove(deletingBuilding);
                //    context.SaveChanges();
                //}
            }

            return BuildingID;
        }

        public int SaveRoomData(string rName, int buildingID)
        {
            int RoomID = 0;

            using (var context = new TimetableManagementSystemEntities2())
            {

                //insert
                var building = context.Buildings.Where(p => p.id == buildingID).FirstOrDefault();
                Room NewRoom = new Room()
                {
                    RoomName = rName,
                    BuildingID = building.id
                };

                context.Rooms.Add(NewRoom);
                context.SaveChanges();

                RoomID = NewRoom.id;
            }
            return RoomID;
        }


        public List<Building> GetAllBuildingName()
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

               List<Building> multiple = context.Buildings.ToList();



                return multiple;
            }

            
        }


        public List<Room> GetAllRoomDetails(int buildingID)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<Room> multiple = context.Rooms.Where(q => q.BuildingID == buildingID).ToList();



                return multiple;
            }


        }


        public LocationBO GetRoomDetails(int RoomID)
        {
            LocationBO locationBO = new LocationBO();

            using (var context = new TimetableManagementSystemEntities2())
            {

                var Roomdetails = context.Rooms.Where(q => q.id == RoomID).FirstOrDefault();

                if(Roomdetails != null)
                {
                    locationBO.RoomID = Roomdetails.id;
                    locationBO.RoomName = Roomdetails.RoomName.ToString();
                    locationBO.RoomCapacity = (int)Roomdetails.Capacity;  // Handle If != null 
                    locationBO.RoomType = (int)Roomdetails.RoomType;
                }
                

                return locationBO;
            }


        }

        public int SaveRoomOtherDetails(LocationBO locationBO)
        {
            int RoomID = 0;

            using (var context = new TimetableManagementSystemEntities2())
            {

                //Update
                //var updatingBuilding = context.Buildings.Where(q => q.id == 12).FirstOrDefault();
                var updatingRoom = context.Rooms.Where(p => p.id == locationBO.RoomID).FirstOrDefault();

                if(updatingRoom != null)
                {
                    updatingRoom.Capacity = locationBO.RoomCapacity;
                    updatingRoom.RoomType = locationBO.RoomType;
                    context.SaveChanges();
                    RoomID = updatingRoom.id;
                }
                
               
            }

            return RoomID;
        }
    }
}
