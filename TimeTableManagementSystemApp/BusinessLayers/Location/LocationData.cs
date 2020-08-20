using System;
using System.CodeDom;
using System.Collections.Generic;
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


    }
}
