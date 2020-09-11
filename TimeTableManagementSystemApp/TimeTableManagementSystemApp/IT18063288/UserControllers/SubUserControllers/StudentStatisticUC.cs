using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.StatisticF;
using DataLayer;
using TimeTableManagementSystemApp.CommonFiles;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    public partial class StudentStatisticUC : UserControl
    {
        public StatisticBO statisticBo;
        public StudentStatisticUC()
        {
            
            InitializeComponent();
            statisticBo = new StatisticBO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnYSPsearch01_Click(object sender, EventArgs e)
        {
            string year = SetYear(comboYear.SelectedIndex);
            string semester = SetSemester(comboBoxSemester.SelectedIndex);
            string YS = year + "." + semester;
            string programme = comboBoxProgramme.Text;

            StatisticBO statisticBO = new StatisticBO();
            statisticBO.Year = year;
            statisticBO.Semester = semester;
            statisticBO.AcadmicY_S = YS;
            statisticBO.Programme = programme;

            if (comboYear.Text != "" && comboBoxSemester.Text != "" && comboBoxProgramme.Text != "")
            {
                

                StatisticController statisticController = new StatisticController();
                List<StudentDetail> studentDetails = statisticController.GetYearSemesterProgrammeStudentData(statisticBO);

                dataGridViewStatistic.DataSource = studentDetails;

                lblCount.Text = studentDetails.Count.ToString();
            }
            else
            {
                if(comboYear.Text != "" && comboBoxSemester.Text != "")
                {
                    
                    

                    StatisticController statisticController = new StatisticController();
                    List<StudentDetail> studentDetails = statisticController.GetYearSemesterStudentData(statisticBO);

                    List<StudentDetail> StYear01Sem01 = new List<StudentDetail>();
                    List<StudentDetail> StYear01Sem02 = new List<StudentDetail>();
                    List<StudentDetail> StYear02Sem01 = new List<StudentDetail>();
                    List<StudentDetail> StYear02Sem02 = new List<StudentDetail>();
                    List<StudentDetail> StYear03Sem01 = new List<StudentDetail>();
                    List<StudentDetail> StYear03Sem02 = new List<StudentDetail>();
                    List<StudentDetail> StYear04Sem01 = new List<StudentDetail>();
                    List<StudentDetail> StYear04Sem02 = new List<StudentDetail>();


                    foreach (StudentDetail YearList in studentDetails)
                    {
                        if (YearList.AcademicYearSemester.Contains("Y1"))
                        {
                            if (YearList.AcademicYearSemester.Contains("S1"))
                            {
                                StYear01Sem01.Add(YearList);
                            }
                            else if (YearList.AcademicYearSemester.Contains("S2"))
                            {
                                StYear01Sem02.Add(YearList);
                            }
                            
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y2"))
                        {
                            if (YearList.AcademicYearSemester.Contains("S1"))
                            {
                                StYear02Sem01.Add(YearList);
                            }
                            else if (YearList.AcademicYearSemester.Contains("S2"))
                            {
                                StYear02Sem02.Add(YearList);
                            }
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y3"))
                        {
                            if (YearList.AcademicYearSemester.Contains("S1"))
                            {
                                StYear03Sem01.Add(YearList);
                            }
                            else if (YearList.AcademicYearSemester.Contains("S2"))
                            {
                                StYear03Sem02.Add(YearList);
                            }
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y4"))
                        {
                            if (YearList.AcademicYearSemester.Contains("S1"))
                            {
                                StYear04Sem01.Add(YearList);
                            }
                            else if (YearList.AcademicYearSemester.Contains("S2"))
                            {
                                StYear04Sem02.Add(YearList);
                            }
                        }
                    }

                    if (year == "Y1")
                    {
                        if(semester == "S1")
                        {
                            dataGridViewStatistic.DataSource = StYear01Sem01;
                            lblCount.Text = StYear01Sem01.Count.ToString();
                        }
                        else if(semester == "S2")
                        {
                            dataGridViewStatistic.DataSource = StYear01Sem02;
                            lblCount.Text = StYear01Sem02.Count.ToString();
                        }
                        
                    }
                    else if (year == "Y2")
                    {
                        if (semester == "S1")
                        {
                            dataGridViewStatistic.DataSource = StYear02Sem01;
                            lblCount.Text = StYear02Sem01.Count.ToString();
                        }
                        else if (semester == "S2")
                        {
                            dataGridViewStatistic.DataSource = StYear02Sem02;
                            lblCount.Text = StYear02Sem02.Count.ToString();
                        }
                    }
                    else if (year == "Y3")
                    {
                        if (semester == "S1")
                        {
                            dataGridViewStatistic.DataSource = StYear03Sem01;
                            lblCount.Text = StYear03Sem01.Count.ToString();
                        }
                        else if (semester == "S2")
                        {
                            dataGridViewStatistic.DataSource = StYear03Sem02;
                            lblCount.Text = StYear03Sem02.Count.ToString();
                        }
                    }
                    else if (year == "Y4")
                    {
                        if (semester == "S1")
                        {
                            dataGridViewStatistic.DataSource = StYear04Sem01;
                            lblCount.Text = StYear04Sem01.Count.ToString();
                        }
                        else if (semester == "S2")
                        {
                            dataGridViewStatistic.DataSource = StYear04Sem02;
                            lblCount.Text = StYear04Sem02.Count.ToString();
                        }
                    }

                }
                else if (comboYear.Text != "" && comboBoxProgramme.Text != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<StudentDetail> studentDetails = statisticController.GetYearSemesterStudentData(statisticBO);

                    List<StudentDetail> StYear01 = new List<StudentDetail>();
                    List<StudentDetail> StYear02 = new List<StudentDetail>();
                    List<StudentDetail> StYear03 = new List<StudentDetail>();
                    List<StudentDetail> StYear04 = new List<StudentDetail>();

                    foreach (StudentDetail YearList in studentDetails)
                    {
                        if (YearList.AcademicYearSemester.Contains("Y1"))
                        {
                            if(YearList.Programme == programme)
                            {
                                StYear01.Add(YearList);
                            }
                                
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y2"))
                        {
                            if (YearList.Programme == programme)
                            {
                                StYear02.Add(YearList);
                            }
                           
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y3"))
                        {
                            if (YearList.Programme == programme)
                            {
                                StYear03.Add(YearList);
                            }
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y4"))
                        {
                            if (YearList.Programme == programme)
                            {
                                StYear04.Add(YearList);
                            }
                        }
                    }

                    if(year == "Y1")
                    {
                        dataGridViewStatistic.DataSource = StYear01;

                        lblCount.Text = StYear01.Count.ToString();
                    }
                    else if (year == "Y2")
                    {
                        dataGridViewStatistic.DataSource = StYear02;

                        lblCount.Text = StYear02.Count.ToString();
                    }
                    else if (year == "Y3")
                    {
                        dataGridViewStatistic.DataSource = StYear03;

                        lblCount.Text = StYear03.Count.ToString();
                    }
                    else if (year == "Y4")
                    {
                        dataGridViewStatistic.DataSource = StYear04;

                        lblCount.Text = StYear04.Count.ToString();
                    }



                }
                else if (comboYear.Text != "")
                {

                    StatisticController statisticController = new StatisticController();
                    List<StudentDetail> studentDetails = statisticController.GetYearSemesterStudentData(statisticBO);

                    List<StudentDetail> StYear01 = new List<StudentDetail>();
                    List<StudentDetail> StYear02 = new List<StudentDetail>();
                    List<StudentDetail> StYear03 = new List<StudentDetail>();
                    List<StudentDetail> StYear04 = new List<StudentDetail>();

                    foreach (StudentDetail YearList in studentDetails)
                    {
                        if (YearList.AcademicYearSemester.Contains("Y1"))
                        {
                            StYear01.Add(YearList);
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y2"))
                        {
                            StYear02.Add(YearList);
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y3"))
                        {
                            StYear03.Add(YearList);
                        }
                        else if (YearList.AcademicYearSemester.Contains("Y4"))
                        {
                            StYear04.Add(YearList);
                        }
                    }

                    if (year == "Y1")
                    {
                        dataGridViewStatistic.DataSource = StYear01;

                        lblCount.Text = StYear01.Count.ToString();
                    }
                    else if (year == "Y2")
                    {
                        dataGridViewStatistic.DataSource = StYear02;

                        lblCount.Text = StYear02.Count.ToString();
                    }
                    else if (year == "Y3")
                    {
                        dataGridViewStatistic.DataSource = StYear03;

                        lblCount.Text = StYear03.Count.ToString();
                    }
                    else if (year == "Y4")
                    {
                        dataGridViewStatistic.DataSource = StYear04;

                        lblCount.Text = StYear04.Count.ToString();
                    }



                }
                else if (comboBoxSemester.Text != "")
                {

                    SuccessfullMessageBox.ShowDialog("These Records are Not meaningful. \n Please Select both Year and Semester!!!", "Information");

                    StatisticController statisticController = new StatisticController();
                    List<StudentDetail> studentDetails = statisticController.GetYearSemesterStudentData(statisticBO);

                    List<StudentDetail> StSem01 = new List<StudentDetail>();
                    List<StudentDetail> StSem02 = new List<StudentDetail>();
                    

                    foreach (StudentDetail YearList in studentDetails)
                    {
                        if (YearList.AcademicYearSemester.Contains("S1"))
                        {
                            StSem01.Add(YearList);
                        }
                        else if (YearList.AcademicYearSemester.Contains("S2"))
                        {
                            StSem02.Add(YearList);
                        }
                        
                    }

                    if (semester == "S1")
                    {
                        dataGridViewStatistic.DataSource = StSem01;

                        lblCount.Text = StSem01.Count.ToString();
                    }
                    else if (semester == "S2")
                    {
                        dataGridViewStatistic.DataSource = StSem02;

                        lblCount.Text = StSem02.Count.ToString();
                    }
                    



                }
                else
                {
                   

                   

                    StatisticController statisticController = new StatisticController();
                    List<StudentDetail> studentDetails = statisticController.GetProgrammeStudentData(statisticBO);

                    dataGridViewStatistic.DataSource = studentDetails;

                    lblCount.Text = studentDetails.Count.ToString();
                }

                
            }




        }

        public string SetYear(int index)
        {

            if(index == 0)
            {
                return "Y1";
            }
            else if(index == 1)
            {
                return "Y2";
            }
            else if (index == 2)
            {
                return "Y3";
            }
            else if (index == 3)
            {
                return "Y4";
            }
            else
            {
                return "";
            }

        }

        public string SetSemester(int index)
        {

            if (index == 0)
            {
                return "S1";
            }
            else if (index == 1)
            {
                return "S2";
            }
            else
            {
                return "";
            }

        }

        
    }
}
