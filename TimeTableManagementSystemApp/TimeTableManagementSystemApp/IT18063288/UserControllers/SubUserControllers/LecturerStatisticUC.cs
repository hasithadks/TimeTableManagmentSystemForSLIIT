using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Lecturer;
using BusinessLayers.StatisticF;
using DataLayer;
using TimeTableManagementSystemApp.CommonFiles;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    public partial class LecturerStatisticUC : UserControl
    {

        public LecturerClass LecturerClass;

        StatisticController statisticController2 = new StatisticController();
        List<Lecturer> lecturerDetailsall;

        public LecturerStatisticUC()
        {
            InitializeComponent();
            setLecturerName();

            LecturerClass = new LecturerClass();

            lecturerDetailsall = statisticController2.GetAllLecturesdetailsm();

            if (lecturerDetailsall.Count == 0)
            {
                ErrorDialogBox.ShowDialog("No Records Found! \nPlease Add Lecture Details to the System.", "Sorry!!!");
            }

            dataGridLecStatistic.DataSource = lecturerDetailsall;

            lblLecCount.Text = lecturerDetailsall.Count.ToString();

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLecStatSearch01_Click(object sender, EventArgs e)
        {
            string faculty = "";
            int level = 0;
            if (comboBoxFaculty.Text != "")
            {
                 faculty = comboBoxFaculty.Text;
            }
            if(comboBoxLevel.Text != "")
            {
                level = int.Parse(comboBoxLevel.Text);
            }
           



            //            Malabe Center
            //            Metro Center
            //            Matara Center
            //            Kurunegala Center
            //            Jaffna Center
            string Center = "";

            if (comboBoxCenter.SelectedIndex == 0)
            {
                Center = "Malabe";
            }
            else if (comboBoxCenter.SelectedIndex == 1)
            {
                Center = "Metro";
            }
            else if (comboBoxCenter.SelectedIndex == 2)
            {
                Center = "Matara";
            }
            else if (comboBoxCenter.SelectedIndex == 3)
            {
                Center = "Kurunegala";
            }
            else if (comboBoxCenter.SelectedIndex == 4)
            {
                Center = "Jaffna";
            }
            else
            {
                Center = "";
            }

            LecturerClass.lFaculty = faculty;
            LecturerClass.lLevel = level;
            LecturerClass.lCenter = Center;

            if(comboBoxFaculty.Text != "" && comboBoxLevel.Text != "" && comboBoxCenter.Text != "")
            {

                StatisticController statisticController = new StatisticController();
                List<Lecturer> lecturerDetails = statisticController.GetLecturesFLCdetails(LecturerClass);

                if(lecturerDetails.Count == 0)
                {
                    ErrorDialogBox.ShowDialog("No Records Found", "Sorry!!!");

                }

                dataGridLecStatistic.DataSource = lecturerDetails;

                lblLecCount.Text = lecturerDetails.Count.ToString();

            }
            else
            {
                if (comboBoxFaculty.Text != "" && comboBoxLevel.Text != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<Lecturer> lecturerDetails = statisticController.GetLecturesFLdetails(LecturerClass);

                    if (lecturerDetails.Count == 0)
                    {
                        ErrorDialogBox.ShowDialog("No Records Found", "Sorry!!!");

                    }
                    dataGridLecStatistic.DataSource = lecturerDetails;

                    lblLecCount.Text = lecturerDetails.Count.ToString();

                }
                else if (comboBoxFaculty.Text != "" && comboBoxCenter.Text != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<Lecturer> lecturerDetails = statisticController.GetLecturesFCdetails(LecturerClass);

                    if (lecturerDetails.Count == 0)
                    {
                        ErrorDialogBox.ShowDialog("No Records Found", "Sorry!!!");

                    }
                    dataGridLecStatistic.DataSource = lecturerDetails;

                    lblLecCount.Text = lecturerDetails.Count.ToString();

                }
                else if (comboBoxLevel.Text != "" && comboBoxCenter.Text != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<Lecturer> lecturerDetails = statisticController.GetLecturesCLdetails(LecturerClass);

                    if (lecturerDetails.Count == 0)
                    {
                        ErrorDialogBox.ShowDialog("No Records Found", "Sorry!!!");

                    }
                    dataGridLecStatistic.DataSource = lecturerDetails;

                    lblLecCount.Text = lecturerDetails.Count.ToString();

                }
                else if (comboBoxLevel.Text != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<Lecturer> lecturerDetails = statisticController.GetAllLecturesdetailsm();

                    List<Lecturer> LecLevelList = new List<Lecturer>();

                    foreach(var levellist in lecturerDetails)
                    {
                        if(levellist.lLevel == level)
                        {
                            LecLevelList.Add(levellist);
                        }
                    }
                    if (LecLevelList.Count == 0)
                    {
                        ErrorDialogBox.ShowDialog("No Records Found", "Sorry!!!");

                    }

                    dataGridLecStatistic.DataSource = LecLevelList;

                    lblLecCount.Text = LecLevelList.Count.ToString();

                }
                else if (faculty != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<Lecturer> lecturerDetails = statisticController.GetAllLecturesdetailsm();

                    List<Lecturer> LecFacultyList = new List<Lecturer>();

                    foreach (var llist in lecturerDetails)
                    {
                        if (llist.lFaculty == faculty)
                        {
                            LecFacultyList.Add(llist);
                        }
                    }
                    if (LecFacultyList.Count == 0)
                    {
                        ErrorDialogBox.ShowDialog("No Records Found", "Sorry!!!");

                    }

                    dataGridLecStatistic.DataSource = LecFacultyList;

                    lblLecCount.Text = LecFacultyList.Count.ToString();

                }
                else if (Center != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<Lecturer> lecturerDetails = statisticController.GetAllLecturesdetailsm();

                    List<Lecturer> LecCenterList = new List<Lecturer>();

                    foreach (var llist in lecturerDetails)
                    {
                        if (llist.lCenter == Center)
                        {
                            LecCenterList.Add(llist);
                        }
                    }

                    if (LecCenterList.Count == 0)
                    {
                        ErrorDialogBox.ShowDialog("No Records Found", "Sorry!!!");

                    }
                    dataGridLecStatistic.DataSource = LecCenterList;

                    lblLecCount.Text = LecCenterList.Count.ToString();

                }
            }
            
            
        }

        private void btnSearchNameID_Click(object sender, EventArgs e)
        {

            string lecName = "";
            string lecID = "";

            lecID = textId.Text;
            lecName = comboBoxLecName.Text;

            LecturerClass.lName = lecName;
            LecturerClass.lID = lecID;

            StatisticController statisticController = new StatisticController();

            if (lecID != "" && lecName != "")
            {
                ErrorDialogBox.ShowDialog("Please Enter Once Name or ID!!!", "Sorry!!!");
            }
            else if(lecID != "")
            {
               
                List<Lecturer> lecturerDetails = statisticController.GetLecturesdetailFormID(lecID);
                dataGridLecStatistic.DataSource = lecturerDetails;

                lblLecCount.Text = lecturerDetails.Count.ToString();

            }
            else if (lecName != "")
            {

                List<Lecturer> lecturerDetails = statisticController.GetLecturesdetailFormName(lecName);
                dataGridLecStatistic.DataSource = lecturerDetails;

                lblLecCount.Text = lecturerDetails.Count.ToString();

            }





        }



        public void setLecturerName()
        {
            StatisticController statisticController = new StatisticController();
            
            List<Lecturer> lecturers = statisticController.GetAllLecturesdetailsm();
            //comboBoxBuilding.DataSource = buildingList;

            var lecStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Lecturer lecturer in lecturers)
            {

                lecStatus.Add(new KeyValuePair<string, string>(lecturer.id.ToString(), lecturer.lName.ToString()));

            }

            comboBoxLecName.DataSource = lecStatus;
            comboBoxLecName.ValueMember = "Key";
            comboBoxLecName.DisplayMember = "Value";
            comboBoxLecName.SelectedIndex = -1;

        }
        private void textLecName_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
