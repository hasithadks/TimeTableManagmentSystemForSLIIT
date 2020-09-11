using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayers.Lecturer
{
    class LecturerData
    {
        public int SaveLecturerData(string lid, string lname, string lfaculty, string ldepartment, string lcenter, string lbuilding, int llevel, string lrank) 
        {
            int id = 0;

            using (var context = new TimetableManagementSystemEntities2())
            {
                //insert
                DataLayer.Lecturer lecturer = new DataLayer.Lecturer()
                {
                   lId = lid,
                   lName = lname,
                   lFaculty = lfaculty,
                   lDepartment = ldepartment,
                   lCenter = lcenter,
                   lBuilding = lbuilding,
                   lLevel = llevel,
                   lRank = lrank
                };
                context.Lecturers.Add(lecturer);
                context.SaveChanges();

                id = lecturer.id;
            }

            return id;
        }

        public List<Building> GetAllBuildingName()
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                List<Building> multiple = context.Buildings.ToList();
                return multiple;
            }
        }

        public List<DataLayer.Lecturer> GetAllLecturersData()
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //View
                List<DataLayer.Lecturer> multiple = context.Lecturers.ToList();
                return multiple;
            }
        }

        public void UpdateLecturerData(LecturerClass lecturer)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                var updateLecturer = context.Lecturers.Where(p => p.id == lecturer.id).FirstOrDefault();

                //update
                //if (updateSubject != null)
                //{
                //updateSubject.id = subject.id;
                updateLecturer.lId = lecturer.lID;
                updateLecturer.lName = lecturer.lName;
                updateLecturer.lFaculty = lecturer.lFaculty;
                updateLecturer.lDepartment = lecturer.lDepartment;
                updateLecturer.lCenter = lecturer.lCenter;
                updateLecturer.lBuilding = lecturer.lBuilding;
                updateLecturer.lLevel = lecturer.lLevel;
                updateLecturer.lRank = lecturer.lRank;

                context.SaveChanges();
                //}

            }
        }

        public void DeleteLecturerData(LecturerClass lecturer)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //delete
                var DeleteLecturer = context.Lecturers.Where(p => p.id == lecturer.id).FirstOrDefault();

                //if (DeleteSubject != null)
                //{
                context.Lecturers.Remove(DeleteLecturer);
                context.SaveChanges();
                //}
            }
        }
    }
}
