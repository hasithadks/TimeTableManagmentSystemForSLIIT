using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.WorkingDays
{
    public class WorkingDaysController
    {
        private WorkingDaysData workingDaysData;

        public int InsertWorkingDays(WorkingDaysClass workingDaysClass) {
            workingDaysData = new WorkingDaysData();
            int id = workingDaysData.insertWorkingDaysData(workingDaysClass);
            return id;
        }

        public List<workingDaysAndHour> SelectAllWorkingDays()
        {
            workingDaysData = new WorkingDaysData();
            return workingDaysData.getAllWorkingDayData();
        }


        public workingDaysAndHour SelectWorkingDay(int id)
        {
            workingDaysData = new WorkingDaysData();
            return workingDaysData.SelectWorkingDay(id);
        }


        public void UpdateWorkingDays(WorkingDaysClass workingDaysClass)
        {
            workingDaysData = new WorkingDaysData();
            workingDaysData.UpdateWorkingDaysData(workingDaysClass);
        }

        public void DeleteWorkingDays(WorkingDaysClass workingDaysClass)
        {
            workingDaysData = new WorkingDaysData();
            workingDaysData.DeleteWorkingDaysData(workingDaysClass);
        }

    }
}
