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

        public List<StudentDetail> GetYearSemesterStudentData(StatisticBO statisticBO)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<StudentDetail> multiple = context.StudentDetails.ToList();


                return multiple;
            }

        }


    }
}
