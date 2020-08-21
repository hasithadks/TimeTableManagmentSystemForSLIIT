using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Location
{
    public class LocationBO
    {

        public int locationID { set; get; }
        public int BuildingID { set; get; }
        public int RoomID { set; get; }

        public string BuildingName { set; get; }
        public string RoomName { set; get; }

        public int RoomCapacity { set; get; }
        public int RoomType { set; get; } 
        //Room Types 
        //    1- LectureHall
        //    2- Lab

        public LocationBO()
        {
            this.locationID = 0;
            this.BuildingID = 0;
            this.RoomID = 0;
            this.BuildingName = string.Empty;
            this.RoomName = string.Empty;

            this.RoomCapacity = 0;
            this.RoomType = 0;
        }

    }
}
