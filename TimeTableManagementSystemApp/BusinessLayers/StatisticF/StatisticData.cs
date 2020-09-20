using BusinessLayers.Lecturer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.StatisticF
{
    public class StatisticData
    {

        public List<StudentDetail> GetYearSemesterProgrammeStudentData(StatisticBO statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<StudentDetail> multiple = context.StudentDetails.Where(q => q.AcademicYearSemester == statisticBO.AcadmicY_S && q.Programme == statisticBO.Programme).ToList();


                return multiple;
            }

        }

        public List<StudentDetail> GetProgrammeStudentData(StatisticBO statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<StudentDetail> multiple = context.StudentDetails.Where(q => q.Programme == statisticBO.Programme).ToList();


                return multiple;
            }

        }

        public List<StudentDetail> GetYearSemesterStudentData()
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<StudentDetail> multiple = context.StudentDetails.ToList();


                return multiple;
            }

        }

        public List<StudentDetail> GetStudentDataFromID(StatisticBO statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<StudentDetail> multiple = context.StudentDetails.Where(q => q.StudentId == statisticBO.StudentID).ToList();
                

                return multiple;
            }

        }

        public List<DataLayer.Lecturer> GetLecturesFLCdetails(LecturerClass statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Lecturer> multiple = context.Lecturers.Where(q => q.lFaculty == statisticBO.lFaculty && q.lCenter == statisticBO.lCenter && q.lLevel == statisticBO.lLevel).ToList();
                

                return multiple;
            }

        }

        public List<DataLayer.Lecturer> GetLecturesFLdetails(LecturerClass statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Lecturer> multiple = context.Lecturers.Where(q => q.lFaculty == statisticBO.lFaculty && q.lLevel == statisticBO.lLevel).ToList();


                return multiple;
            }

        }

        public List<DataLayer.Lecturer> GetLecturesFCdetails(LecturerClass statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Lecturer> multiple = context.Lecturers.Where(q => q.lLevel == statisticBO.lLevel && q.lCenter == statisticBO.lCenter).ToList();


                return multiple;
            }

        }

        public List<DataLayer.Lecturer> GetLecturesCLdetails(LecturerClass statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Lecturer> multiple = context.Lecturers.Where(q => q.lFaculty == statisticBO.lFaculty && q.lCenter == statisticBO.lCenter).ToList();


                return multiple;
            }

        }

        public List<DataLayer.Lecturer> GetAllLecturesdetails()
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Lecturer> multiple = context.Lecturers.ToList();


                return multiple;
            }

        }

        public List<DataLayer.Lecturer> GetLecturesdetailFormID(string id)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Lecturer> lecture = context.Lecturers.Where(q => q.lId == id).ToList();


                return lecture;
            }

        }

        public List<DataLayer.Lecturer> GetLecturesdetailFormName(string name)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Lecturer> lecture = context.Lecturers.Where(q => q.lName == name).ToList();


                return lecture;
            }

        }


        public List<DataLayer.Subject> GetSubjectYearAndSemDetails(int year, int sem)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Subject> Subject = context.Subjects.Where(q => q.offYear == year && q.offSemester == sem).ToList();


                return Subject;
            }

        }

        public List<DataLayer.Subject> GetSubjectYearDetails(int year)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Subject> Subject = context.Subjects.Where(q => q.offYear == year).ToList();


                return Subject;
            }

        }

        public List<DataLayer.Subject> GetAllSubjectDetails()
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Subject> Subject = context.Subjects.ToList();


                return Subject;
            }

        }

        public List<DataLayer.Subject> GetSubjectDetailsFromCode(string sCode)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<DataLayer.Subject> Subject = context.Subjects.Where(q => q.sCode == sCode).ToList();


                return Subject;
            }

        }
    }
}
