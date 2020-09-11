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

        public List<DataLayer.StudentDetail> GetYearSemesterStudentData(StatisticBO statisticBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetYearSemesterStudentData(statisticBO);
        }

        public List<DataLayer.StudentDetail> GetStudentDataFromID(StatisticBO statisticBO)
        {
            StatisticData statisticData = new StatisticData();
            return statisticData.GetStudentDataFromID(statisticBO);
        }
    }
}
