using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Subject;
using TimeTableManagementSystemApp.CommonFiles;
using BusinessLayers.StatisticF;
using DataLayer;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    public partial class SubjectStatisticUC : UserControl
    {
        public SubjectStatisticUC()
        {
            InitializeComponent();

            StatisticController statisticController = new StatisticController();
            List<Subject> subjects = statisticController.GetAllSubjectDetails();

            if (subjects.Count == 0)
            {
                ErrorDialogBox.ShowDialog("No Records Found! \nPlease Add Subject to the System.", "Sorry!!!");
            }

            dataGridViewSubject.DataSource = subjects;
            studentCounttxt.Text = subjects.Count.ToString();
        }

        private void buttonSearchMain_Click(object sender, EventArgs e)
        {
            int year = 0;
            int semester = 0;

            if(comboBoxYear.Text != "")
            {
                year = (comboBoxYear.SelectedIndex + 1);
            }
            if (comboBoxSemster.Text != "")
            {
                semester = (comboBoxSemster.SelectedIndex + 1);
            }
            

            if(comboBoxYear.Text != "" && comboBoxSemster.Text != "")
            {
                StatisticController statisticController = new StatisticController();
                List<Subject> subjects = statisticController.GetSubjectYearAndSemDetails(year, semester);

                if(subjects.Count == 0)
                {
                    ErrorDialogBox.ShowDialog("No Records Found!.", "Sorry!!!");
                }

                dataGridViewSubject.DataSource = subjects;
                studentCounttxt.Text = subjects.Count.ToString();

            }
            else
            {
                if (comboBoxYear.Text == "" && comboBoxSemster.Text == "")
                {
                    ErrorDialogBox.ShowDialog("Please Select Atleast Year.", "Error!!!");

                }
                else if(comboBoxYear.Text != "")
                {
                    StatisticController statisticController = new StatisticController();
                    List<Subject> subjects = statisticController.GetSubjectYearDetails(year);

                    if (subjects.Count == 0)
                    {
                        ErrorDialogBox.ShowDialog("No Records Found!.", "Sorry!!!");
                    }

                    dataGridViewSubject.DataSource = subjects;
                    studentCounttxt.Text = subjects.Count.ToString();

                }
                else if(comboBoxSemster.Text != "")
                {
                    ErrorDialogBox.ShowDialog("Please Select year 01, 02, 03 or 04.", "Error!!!");
                }

            }

        }

        private void btnSearchSubCode_Click(object sender, EventArgs e)
        {
            string subjectCode = "";
            subjectCode = textBoxSubjectCode.Text;

            if(subjectCode != "")
            {
                StatisticController statisticController = new StatisticController();
                List<Subject> subjects = statisticController.GetSubjectDetailsFromCode(subjectCode);

                if (subjects.Count == 0)
                {
                    ErrorDialogBox.ShowDialog("No Records Found!.", "Sorry!!!");
                }

                dataGridViewSubject.DataSource = subjects;
                studentCounttxt.Text = subjects.Count.ToString();
            }
            else
            {
                ErrorDialogBox.ShowDialog("Please Enter Subject Code", "Sorry!!!");
            }

        }
    }
}
