using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.WorkingDays;
using TimeTableManagementSystemApp.CommonFiles;

namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    public partial class AddWorkingDaysUC : UserControl
    {
        int id;
        int oneHourdb;
        int ThirtyMinutesdb;
        private static AddWorkingDaysUC _AddWorkingDaysInstance;
        public static AddWorkingDaysUC AddWorkingInstance
        {
            get
            {
                if (_AddWorkingDaysInstance == null)
                    _AddWorkingDaysInstance = new AddWorkingDaysUC();
                return _AddWorkingDaysInstance;

            }
        }

        public AddWorkingDaysUC()
        {
            InitializeComponent();
        }

        private void MWDMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void NoOfDaysPerWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(WorkingDaysPerWeek.Text) == "Weekend")
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDMonday.Hide(); MWDTuesday.Hide(); MWDWednesday.Hide(); MWDThursday.Hide(); MWDFriday.Hide();
                }
                else if (Convert.ToInt32(WorkingDaysPerWeek.Text) == 1)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDTuesday.Hide(); MWDWednesday.Hide(); MWDThursday.Hide(); MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(WorkingDaysPerWeek.Text) == 2)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDWednesday.Hide(); MWDThursday.Hide(); MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(WorkingDaysPerWeek.Text) == 3)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDThursday.Hide(); MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(WorkingDaysPerWeek.Text) == 4)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(WorkingDaysPerWeek.Text) == 5)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(WorkingDaysPerWeek.Text) == 6)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDSunday.Hide();
                }
                else if (Convert.ToInt32(WorkingDaysPerWeek.Text) == 7)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                  
                }
                else
                {
                    Console.WriteLine("Invalid Number of day");
                }
            }
            catch (FormatException ex) { 
            
            }

        }

        private void addWorkingDaysBtn_Click(object sender, EventArgs e)
        {
            int oneHour;
            int ThirtyMinutes;

            //if (oneHourCheckBox.Checked)
            //{
            //    oneHour = 1;
            //}
            //else {
            //    oneHour = 0;
            //}

            //if (ThirtyMinutesCheckBox.Checked)
            //{
            //    ThirtyMinutes = 1;
            //}
            //else
            //{
            //    ThirtyMinutes = 0;
            //}

            if (Convert.ToDouble(WorkingTimePerDay.Text) % 1 == 0)
            {
                oneHour = Convert.ToInt32(Math.Round(Convert.ToDouble(WorkingTimePerDay.Text)) / 1);
                ThirtyMinutes = 0;
            }
            else {
                oneHour = Convert.ToInt32(Math.Round(Convert.ToDouble(WorkingTimePerDay.Text)) / 1);
                ThirtyMinutes = 1;
            }

            WorkingDaysController workingDaysController = new WorkingDaysController();

            WorkingDaysClass workingDaysClass = new WorkingDaysClass(1, MWDMonday.Text, MWDTuesday.Text, MWDWednesday.Text, MWDThursday.Text, MWDFriday.Text, MWDSaturday.Text, MWDSunday.Text, WorkingTimePerDay.Text, oneHour, ThirtyMinutes, Convert.ToInt32(WorkingDaysPerWeek.Text));
       
            workingDaysController.InsertWorkingDays(workingDaysClass);
      
            SuccessfullMessageBox.ShowDialog("Working Day Added Successfully", "Success");

            

            var source = new BindingSource();
            source.DataSource = workingDaysController.SelectAllWorkingDays();
            WorkingDayData.DataSource = source;

            reset();
        }

        private void AddWorkingDaysUC_Load(object sender, EventArgs e)
        {
            WorkingDaysController workingDaysController = new WorkingDaysController();

            var source = new BindingSource();
            source.DataSource = workingDaysController.SelectAllWorkingDays();
            WorkingDayData.DataSource = source;
        }

        private void workingDayCellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                id = Convert.ToInt32(WorkingDayData.SelectedRows[0].Cells[0].Value);
                WorkingDaysPerWeek.Text = WorkingDayData.SelectedRows[0].Cells[1].Value.ToString();
                MWDMonday.Text = WorkingDayData.SelectedRows[0].Cells[2].Value.ToString();
                MWDTuesday.Text = WorkingDayData.SelectedRows[0].Cells[3].Value.ToString();
                MWDWednesday.Text = WorkingDayData.SelectedRows[0].Cells[4].Value.ToString();
                MWDThursday.Text = WorkingDayData.SelectedRows[0].Cells[5].Value.ToString();
                MWDFriday.Text = WorkingDayData.SelectedRows[0].Cells[6].Value.ToString();
                MWDSaturday.Text = WorkingDayData.SelectedRows[0].Cells[7].Value.ToString();
                MWDSunday.Text = WorkingDayData.SelectedRows[0].Cells[8].Value.ToString();
                WorkingTimePerDay.Text = WorkingDayData.SelectedRows[0].Cells[9].Value.ToString();

                oneHourdb = Convert.ToInt32(WorkingDayData.SelectedRows[0].Cells[10].Value);
                ThirtyMinutesdb = Convert.ToInt32(WorkingDayData.SelectedRows[0].Cells[11].Value);

                //if (oneHourdb == 1)
                //{
                //    oneHourCheckBox.Checked = true;
                //}
                //else
                //    oneHourCheckBox.Checked = false;

                //if (ThirtyMinutesdb == 1)
                //{
                //    ThirtyMinutesCheckBox.Checked = true;
                //}
                //else
                //    ThirtyMinutesCheckBox.Checked = false;
            }
            catch (NullReferenceException ex) { 
            }
        }

        private void updateWorkingDaysBtn_Click(object sender, EventArgs e)
        {
            int oneHour;
            int ThirtyMinutes;

            //if (oneHourCheckBox.Checked)
            //{
            //    oneHour = 1;
            //}
            //else
            //{
            //    oneHour = 0;
            //}

            //if (ThirtyMinutesCheckBox.Checked)
            //{
            //    ThirtyMinutes = 1;
            //}
            //else
            //{
            //    ThirtyMinutes = 0;
            //}

            if (Convert.ToDouble(WorkingTimePerDay.Text) % 1 == 0)
            {
                oneHour = Convert.ToInt32(Math.Round(Convert.ToDouble(WorkingTimePerDay.Text)) / 1);
                ThirtyMinutes = 0;
            }
            else
            {
                oneHour = Convert.ToInt32(Math.Round(Convert.ToDouble(WorkingTimePerDay.Text)) / 1);
                ThirtyMinutes = 1;
            }

            WorkingDaysController workingDaysController = new WorkingDaysController();

            WorkingDaysClass workingDaysClass = new WorkingDaysClass(id, MWDMonday.Text, MWDTuesday.Text, MWDWednesday.Text, MWDThursday.Text, MWDFriday.Text, MWDSaturday.Text, MWDSunday.Text, WorkingTimePerDay.Text, oneHour, ThirtyMinutes, Convert.ToInt32(WorkingDaysPerWeek.Text));

            workingDaysController.UpdateWorkingDays(workingDaysClass);

            SuccessfullMessageBox.ShowDialog("Working Day Update Successfully", "Success");



            var source = new BindingSource();
            source.DataSource = workingDaysController.SelectAllWorkingDays();
            WorkingDayData.DataSource = source;

            reset();
        }

        private void deleteWorkingDaysBtn_Click(object sender, EventArgs e)
        {
            int oneHour;
            int ThirtyMinutes;

            //if (oneHourCheckBox.Checked)
            //{
            //    oneHour = 1;
            //}
            //else
            //{
            //    oneHour = 0;
            //}

            //if (ThirtyMinutesCheckBox.Checked)
            //{
            //    ThirtyMinutes = 1;
            //}
            //else
            //{
            //    ThirtyMinutes = 0;
            //}
            WorkingDaysController workingDaysController = new WorkingDaysController();

            WorkingDaysClass workingDaysClass = new WorkingDaysClass(id, MWDMonday.Text, MWDTuesday.Text, MWDWednesday.Text, MWDThursday.Text, MWDFriday.Text, MWDSaturday.Text, MWDSunday.Text, WorkingTimePerDay.Text, 1, 1 , Convert.ToInt32(WorkingDaysPerWeek.Text));

            workingDaysController.DeleteWorkingDays(workingDaysClass);

            SuccessfullMessageBox.ShowDialog("Working Day Delete Successfully", "Success");


            var source = new BindingSource();
            source.DataSource = workingDaysController.SelectAllWorkingDays();
            WorkingDayData.DataSource = source;

            reset();
        }


        public void reset() {
            //SelectGroup.Text = "";
            //SelectYear.Text = "";
            //SelectSem.Text = "";
            MWDMonday.Text = "";
            MWDTuesday.Text = "";
            MWDWednesday.Text = "";
            MWDThursday.Text = "";
            MWDFriday.Text = "";
            MWDSaturday.Text = "";
            MWDSunday.Text = "";
            //oneHourCheckBox.Checked = false;
            //ThirtyMinutesCheckBox.Checked = false;
            WorkingDaysPerWeek.Text = "";
            WorkingTimePerDay.Text = "";
        }

        private void ResetWorkingDaysBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
