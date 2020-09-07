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

        public int InsertWorkingDays() {
            workingDaysData = new WorkingDaysData();
            int id = workingDaysData.insertWorkingDaysData();
            return id;
        }
    }
}
