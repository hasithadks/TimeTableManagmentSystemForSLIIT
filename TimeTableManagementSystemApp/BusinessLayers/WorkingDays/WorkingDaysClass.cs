using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.WorkingDays
{
    public class WorkingDaysClass
    {

        public int id { set; get; }
        public string Monday { set; get; }
        public string Tuesday { set; get; }
        public string Wednesday { set; get; }

        public string Thursday { set; get; }
        public string Friday { set; get; }
        public string Saturday { set; get; }
        public string Sunday { set; get; }
        public string workingTime { set; get; }
        public int OneHourTimeSlots { set; get; }

        public int WorkingDaysPerWeek { set; get; }
        public int ThirtyMinutesTimeSlots { set; get; }

        public WorkingDaysClass(int id, string Monday, string Tuesday, string Wednesday, string Thursday, string Friday, string Saturday, string Sunday, string workingTime, int OneHourTimeSlots, int ThirtyMinutesTimeSlots ,int WorkingDaysPerWeek) {

            this.id = id;
            this.Monday = Monday;
            this.Tuesday = Tuesday;
            this.Wednesday = Wednesday;
            this.Thursday = Thursday;
            this.Friday = Friday;
            this.Saturday = Saturday;
            this.Sunday = Sunday;
            this.workingTime = workingTime;
            this.OneHourTimeSlots = OneHourTimeSlots;
            this.ThirtyMinutesTimeSlots = ThirtyMinutesTimeSlots;
            this.WorkingDaysPerWeek = WorkingDaysPerWeek;
        }


    }
}
