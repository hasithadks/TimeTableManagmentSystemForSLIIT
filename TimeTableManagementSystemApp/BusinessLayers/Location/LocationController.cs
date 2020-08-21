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

        public List<Building> getAllBuilding()
        {
            locationData = new LocationData();
              
            return locationData.GetAllBuildingName();

        }
    }
}
