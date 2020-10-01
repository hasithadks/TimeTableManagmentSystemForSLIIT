using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayers.Lecturer
{
    public class LecturerController
    {
        private LecturerData lecturerData;

        public int saveLecturer(string lid,string lname,string lfaculty,string ldepartment,string lcenter,string lbuilding,int llevel,string lrank) 
        {
            lecturerData = new LecturerData();
            int id = lecturerData.SaveLecturerData(lid,lname,lfaculty,ldepartment,lcenter,lbuilding,llevel,lrank);

            return id;
        }

        public List<Building> getAllBuilding()
        {
            lecturerData = new LecturerData();

            return lecturerData.GetAllBuildingName();

        }

        public List<DataLayer.Lecturer> getAllLecturers()
        {
            lecturerData = new LecturerData();
            return lecturerData.GetAllLecturersData();
        }

        public void updateLecturer(LecturerClass lecturer)
        {
            lecturerData = new LecturerData();
            lecturerData.UpdateLecturerData(lecturer);
        }

        public void deleteLecturer(LecturerClass lecturer)
        {
            lecturerData = new LecturerData();
            lecturerData.DeleteLecturerData(lecturer);
        }


    }
}
