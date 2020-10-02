using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Student;
using DataLayer;
using BusinessLayers.TimeSessions;
using BusinessLayers.WorkingDays;
using System.Collections;
using Grpc.Core;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    public partial class StudentTimeTableUC : UserControl
    {
        
        public StudentTimeTableUC()
        {
            InitializeComponent();
            setGroupDropdown();
        }

        public void setGroupDropdown()
        {
            StudentController studentC = new StudentController();

            List<DataLayer.StudentDetail> studentDetails = studentC.GetAllStudentGroups();



            var studentStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (StudentDetail studentde in studentDetails)
            {


                studentStatus.Add(new KeyValuePair<string, string>(studentde.GroupNumber.ToString(), studentde.GroupId.ToString()));



            }

            comboBoxGroup.DataSource = studentStatus;
            comboBoxGroup.ValueMember = "Key";
            comboBoxGroup.DisplayMember = "Value";
            comboBoxGroup.SelectedIndex = -1;
        }



        private void generateBtn_Click(object sender, EventArgs e)
        {
            string GroupID = comboBoxGroup.Text;

            SessionController sessionController = new SessionController();
            List<TimeSession> SessionDetailsall;
            SessionDetailsall = sessionController.GetTimeSessionsAssignGroup(GroupID);

            WorkingDaysController workingDaysController = new WorkingDaysController();
            workingDaysAndHour workingDaysAndHour = workingDaysController.SelectWorkingDay(1003);

            int noOfTimeSlots = int.Parse(((double.Parse(workingDaysAndHour.workingTime) * 60.0) / 30.0).ToString());
            int noOfWorkingDays = int.Parse(workingDaysAndHour.WorkingDaysPerWeek.ToString());

            ArrayList DaysList = new ArrayList();

            for (int i = 0; i < noOfWorkingDays; i++)
            {
                DaysList.Add(new SlotsList(noOfTimeSlots));

            }


            foreach (var session in SessionDetailsall)
            {

                if (session.sIsConsecutive == 0)
                {
                    if (session.sConsecutiveSessionID > 0)
                    {
                        int duration = int.Parse(session.sSessionDuration.ToString());

                        int findTimeSlot = (duration * 60) / 30;


                        foreach (var day in DaysList)
                        {
                            int cumulativeFreeSlots = 0;
                            bool isFreeSlotFind = false;

                            int[] freeslotids = new int[noOfTimeSlots];


                            SlotsList slotsList = (SlotsList)day;

                            for (int j = 0; j < slotsList.slots.Length; j++)
                            {
                                if (slotsList.slots[j] == -1)
                                {
                                    cumulativeFreeSlots += 1;
                                    freeslotids[j] = j;
                                }
                                else
                                {
                                    freeslotids[j] = -1;
                                }

                                if (findTimeSlot == cumulativeFreeSlots)
                                {
                                    isFreeSlotFind = true;
                                }
                            }

                            if (isFreeSlotFind)
                            {
                                int updatedCount = 0;

                                for (int i = 0; i < slotsList.slots.Length; i++)
                                {

                                    for (int k = 0; k < freeslotids.Length; k++)
                                    {
                                        if (freeslotids[k] != -1 && findTimeSlot > updatedCount)
                                        {
                                            slotsList.slots[k] = session.id;
                                            updatedCount += 1;
                                        }
                                    }

                                }

                                if (updatedCount == findTimeSlot)
                                {
                                    break;
                                }

                            }

                        }

                        foreach (var getrecord in SessionDetailsall)
                        {
                            if (getrecord.sConsecutiveSessionID == session.sConsecutiveSessionID)
                            {
                                TimeSession timeSession = sessionController.GetDeleteSession(int.Parse(session.sConsecutiveSessionID.ToString()));
                                duration = int.Parse(timeSession.sSessionDuration.ToString());
                                findTimeSlot = (duration * 60) / 30;

                                foreach (var day in DaysList)
                                {
                                    int cumulativeFreeSlots = 0;
                                    bool isFreeSlotFind = false;

                                    int[] freeslotids = new int[noOfTimeSlots];


                                    SlotsList slotsList = (SlotsList)day;

                                    for (int j = 0; j < slotsList.slots.Length; j++)
                                    {
                                        if (slotsList.slots[j] == -1)
                                        {
                                            cumulativeFreeSlots += 1;
                                            freeslotids[j] = j;
                                        }
                                        else
                                        {
                                            freeslotids[j] = -1;
                                        }

                                        if (findTimeSlot == cumulativeFreeSlots)
                                        {
                                            isFreeSlotFind = true;
                                        }
                                    }

                                    if (isFreeSlotFind)
                                    {
                                        int updatedCount = 0;

                                        for (int i = 0; i < slotsList.slots.Length; i++)
                                        {

                                            for (int k = 0; k < freeslotids.Length; k++)
                                            {
                                                if (freeslotids[k] != -1 && findTimeSlot > updatedCount)
                                                {
                                                    slotsList.slots[k] = timeSession.id;
                                                    updatedCount += 1;
                                                }
                                            }




                                        }
                                        if (updatedCount == findTimeSlot)
                                        {
                                            break;
                                        }

                                    }

                                }

                            }
                        }
                    }
                    else
                    {

                        int duration = int.Parse(session.sSessionDuration.ToString());

                        int findTimeSlot = (duration * 60) / 30;

                        foreach (var day in DaysList)
                        {
                            int cumulativeFreeSlots = 0;
                            bool isFreeSlotFind = false;

                            int[] freeslotids = new int[noOfTimeSlots];


                            SlotsList slotsList = (SlotsList)day;

                            for (int j = 0; j < slotsList.slots.Length; j++)
                            {
                                if (slotsList.slots[j] == -1)
                                {
                                    cumulativeFreeSlots += 1;
                                    freeslotids[j] = j;
                                }
                                else
                                {
                                    freeslotids[j] = -1;
                                }

                                if (findTimeSlot == cumulativeFreeSlots)
                                {
                                    isFreeSlotFind = true;
                                }
                            }

                            if (isFreeSlotFind)
                            {
                                int updatedCount = 0;

                                for (int i = 0; i < slotsList.slots.Length; i++)
                                {

                                    for (int k = 0; k < freeslotids.Length; k++)
                                    {
                                        if (freeslotids[k] != -1 && findTimeSlot > updatedCount)
                                        {
                                            slotsList.slots[k] = session.id;
                                            updatedCount += 1;
                                        }
                                    }

                                }
                                if (updatedCount == findTimeSlot)
                                {
                                    break;
                                }
                            }

                        }
                    }

                }

            }





            DataTable dt = new DataTable();

            DataColumn timeColumn = new DataColumn("Time");

            dt.Columns.Add(timeColumn);

            DateTime starttime = new DateTime(2000, 1, 1, 8, 30, 00);


            for (int i = 0; i < noOfTimeSlots; i++)
            {
                dt.Rows.Add();
            }

            for (int b = 0; b < noOfTimeSlots; b++)
            {
                string olyTime = starttime.ToString("hh:mm tt");
                dt.Rows[b][0] = olyTime;
                starttime = starttime.AddMinutes(30);
            }

            


            ArrayList datacolumnList = new ArrayList();

            string[] DaysName = new string[] { "Monday", "Tuesday", "Wendnesday", "Thursday", "Friday" };

            for(int i = 0; i < noOfWorkingDays; i++)
            {
                dt.Columns.Add(new DataColumn(DaysName[i]));
            }
            

            for (int i = 0; i< DaysList.Count;i++)
            {
                SlotsList slotsList = (SlotsList)DaysList[i];
                for (int j = 0; j < slotsList.slots.Length; j++)
                {
                    //  DataRow dr = dt.NewRow();
                    


                    TimeSession timeSession = sessionController.GetDeleteSession(slotsList.slots[j]);
                    string day = "";
                    if (timeSession != null)
                    {
                        day = "" + timeSession.sGroup + "." + timeSession.sSubGroup + "\n " + timeSession.sSubjectCode + "" + timeSession.sSubject + "(" +
                                    timeSession.sTag + ")\n " + timeSession.RoomName + "";


                      
                    }
                    else
                    {
                        if (slotsList.slots[j] == -99)
                        {
                            day = "-X-";
                        }
                        else
                        {
                            day = "--";
                        }
                        
                    }
                    

                    dt.Rows[j][i+1] = day;
                }
            }

            dataGridView1.DataSource = dt;
        }

       

        

    }
}
