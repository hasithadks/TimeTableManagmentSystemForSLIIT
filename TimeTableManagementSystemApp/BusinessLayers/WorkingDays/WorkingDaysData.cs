using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayers.WorkingDays
{
    class WorkingDaysData
    {
        public int insertWorkingDaysData() {
            int workingdayID = 0;

            using (var context = new TimetableManagementSystemEntities2())
            {
                WorkingDay working = new WorkingDay()
                {
                    workingdayGroup = "Y1Y2",
                    workingdayYear = 2017,
                    workingdaySemester = 2,
                    workingday1 ="Monday"
                };

                context.WorkingDays.Add(working);
                context.SaveChanges();

                workingdayID = working.WorkingDayID;
            }
            return workingdayID;
        }
        public int updateWorkingDaysData()
        {
            return workingdayID;
        }
}
