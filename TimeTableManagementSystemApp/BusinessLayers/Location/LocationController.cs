using System;
using System.Collections.Generic;
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
    }
}
