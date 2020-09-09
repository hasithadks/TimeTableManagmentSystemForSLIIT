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
            int rID = 0;

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

                rID = NewRoom.id;

                DataLayer.Location location = new DataLayer.Location()
                {
                    BuildingID = buildingID,
                    RoomID = rID
                };

                context.Locations.Add(location);
                context.SaveChanges();
            }
            return rID;
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
                    locationBO.RoomName = Roomdetails.RoomName == null ? string.Empty : Roomdetails.RoomName.ToString();
                    locationBO.RoomCapacity = Roomdetails.Capacity ==  null ? 0 : (int)Roomdetails.Capacity;  // Handle If != null  // Donne
                    locationBO.RoomType = Roomdetails.RoomType == null ? 0 : (int)Roomdetails.RoomType;
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


        public int UpdateBuildingName(int bid, string bname)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                //update
                var updatingBuilding = context.Buildings.Where(q => q.id == bid).FirstOrDefault();

                if (updatingBuilding != null)
                {
                    updatingBuilding.BuidingName = bname;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }


            }


        }

        public int UpdateRoomName(int rid, string rname)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                //update
                var updatingRoom = context.Rooms.Where(q => q.id == rid).FirstOrDefault();

                if (updatingRoom != null)
                {
                    updatingRoom.RoomName = rname;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }


            }


        }


        public int DeleteBuilding(int bid)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                //update
                var deletingBuilding = context.Buildings.Where(q => q.id == bid).FirstOrDefault();

                if (deletingBuilding != null)
                {
                    context.Buildings.Remove(deletingBuilding);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }


            }


        }

        public int DeleteRoom(int rid)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                //update
                var deletingRoom = context.Rooms.Where(q => q.id == rid).FirstOrDefault();

                if (deletingRoom != null)
                {
                    context.Rooms.Remove(deletingRoom);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }


            }


        }


    }
}
