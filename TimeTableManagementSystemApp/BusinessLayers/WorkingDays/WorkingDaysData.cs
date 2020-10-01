using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayers.WorkingDays
{
    class WorkingDaysData
    {
        public int insertWorkingDaysData(WorkingDaysClass workingDaysClass)
        {
            int workingdayID = 0;

            using (var context = new TimetableManagementSystemEntities2())
            {
                workingDaysAndHour working = new workingDaysAndHour()
                {
                    Monday = workingDaysClass.Monday,
                    Tuesday = workingDaysClass.Tuesday,
                    Wednesday =workingDaysClass.Wednesday,
                    Thursday = workingDaysClass.Thursday,
                    Friday = workingDaysClass.Friday,
                    Saturday = workingDaysClass.Saturday,
                    Sunday = workingDaysClass.Sunday,
                    workingTime = workingDaysClass.workingTime,
                    OneHourTimeSlots = workingDaysClass.OneHourTimeSlots,
                    ThirtyMinutesTimeSlots = workingDaysClass.ThirtyMinutesTimeSlots,
                    WorkingDaysPerWeek= workingDaysClass.WorkingDaysPerWeek
                };

                context.workingDaysAndHours.Add(working);
                context.SaveChanges();

                workingdayID = working.Id;
            }
            return workingdayID;
        }

        public List<workingDaysAndHour> getAllWorkingDayData() {

            using (var context = new TimetableManagementSystemEntities2())
            {

                List<workingDaysAndHour> multiple = context.workingDaysAndHours.ToList();
                return multiple;
            }
        }

        public workingDaysAndHour SelectWorkingDay(int id)
        {

            using (var context = new TimetableManagementSystemEntities2())
            {

                workingDaysAndHour multiple = context.workingDaysAndHours.Where(q => q.Id == id).FirstOrDefault();
                return multiple;
            }
        }

        public void UpdateWorkingDaysData(WorkingDaysClass workingDaysClass)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {

                var updatingWorkingDay = context.workingDaysAndHours.Where(p => p.Id == workingDaysClass.id).FirstOrDefault();

                if (updatingWorkingDay != null)
                {

                    updatingWorkingDay.Monday = workingDaysClass.Monday;
                    updatingWorkingDay.Tuesday = workingDaysClass.Tuesday;
                    updatingWorkingDay.Wednesday = workingDaysClass.Wednesday;
                    updatingWorkingDay.Thursday = workingDaysClass.Thursday;
                    updatingWorkingDay.Friday = workingDaysClass.Friday;
                    updatingWorkingDay.Saturday = workingDaysClass.Saturday;
                    updatingWorkingDay.Sunday = workingDaysClass.Sunday;
                    updatingWorkingDay.workingTime = workingDaysClass.workingTime;
                    updatingWorkingDay.OneHourTimeSlots = workingDaysClass.OneHourTimeSlots;
                    updatingWorkingDay.ThirtyMinutesTimeSlots = workingDaysClass.ThirtyMinutesTimeSlots;
                    updatingWorkingDay.WorkingDaysPerWeek = workingDaysClass.WorkingDaysPerWeek;
                    context.SaveChanges();
                }
              
            }
        }

        public void DeleteWorkingDaysData(WorkingDaysClass workingDaysClass)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                var deleteWorkingDays = context.workingDaysAndHours.Where(p => p.Id == workingDaysClass.id).FirstOrDefault();

                if (deleteWorkingDays != null)
                {
                    context.workingDaysAndHours.Remove(deleteWorkingDays);
                    context.SaveChanges();
                }
                
            }
        }
    }
}
