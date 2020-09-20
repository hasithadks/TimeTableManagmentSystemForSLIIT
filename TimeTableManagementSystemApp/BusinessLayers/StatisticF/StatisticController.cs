using BusinessLayers.Lecturer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.StatisticF
{
    public class StatisticController
    {

        public List<DataLayer.StudentDetail> GetYearSemesterProgrammeStudentData(StatisticBO statisticBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetYearSemesterProgrammeStudentData(statisticBO);
        }

        public List<DataLayer.StudentDetail> GetProgrammeStudentData(StatisticBO statisticBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetProgrammeStudentData(statisticBO);
        }

        public List<DataLayer.StudentDetail> GetYearSemesterStudentData()
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetYearSemesterStudentData();
        }

        public List<DataLayer.StudentDetail> GetStudentDataFromID(StatisticBO statisticBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetStudentDataFromID(statisticBO);
        }

        
        public List<DataLayer.Lecturer> GetLecturesFLCdetails(LecturerClass lecturerBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetLecturesFLCdetails(lecturerBO);
        }

        public List<DataLayer.Lecturer> GetLecturesFLdetails(LecturerClass lecturerBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetLecturesFLdetails(lecturerBO);
        }

        public List<DataLayer.Lecturer> GetLecturesFCdetails(LecturerClass lecturerBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetLecturesFCdetails(lecturerBO);
        }

        public List<DataLayer.Lecturer> GetLecturesCLdetails(LecturerClass lecturerBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetLecturesCLdetails(lecturerBO);
        }

        public List<DataLayer.Lecturer> GetAllLecturesdetailsm()
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetAllLecturesdetails();
        }

        public List<DataLayer.Lecturer> GetLecturesdetailFormID(string id)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetLecturesdetailFormID(id);
        }

        public List<DataLayer.Lecturer> GetLecturesdetailFormName(string name)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetLecturesdetailFormName(name);
        }

        public List<DataLayer.Subject> GetSubjectYearAndSemDetails(int year, int sem)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetSubjectYearAndSemDetails(year, sem);
        }

        public List<DataLayer.Subject> GetSubjectYearDetails(int year)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetSubjectYearDetails(year);
        }
        
        public List<DataLayer.Subject> GetAllSubjectDetails()
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetAllSubjectDetails();
        }

        public List<DataLayer.Subject> GetSubjectDetailsFromCode(string scode)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetSubjectDetailsFromCode(scode);
        }
    }
}
