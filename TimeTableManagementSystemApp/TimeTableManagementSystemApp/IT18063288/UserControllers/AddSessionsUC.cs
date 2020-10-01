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
using DataLayer;
using BusinessLayers.Subject;
using TimeTableManagementSystemApp.CommonFiles;
using BusinessLayers.Student;
using BusinessLayers.Tag;
using BusinessLayers.TimeSessions;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    public partial class AddSessionsUC : UserControl
    {

        private int year = 0;
        private int Sem = 0;
        private static int lecturerCount = 0;


        public AddSessionsUC()  
        {
            InitializeComponent();
            setLecturelabelDefault();
            SetLecturerNamestoDropDown();
            SetSubjectstoDropDown();
            setTagsDropDown();
            setDropdownToDefault();
            lecturerCount = 0;
        }

        private void btnCreateSession_Click(object sender, EventArgs e)
        {
            lecturerCount = 0;
            if (Lecturer01.Text == "")
            {
                ErrorDialogBox.ShowDialog("Please Add atleast one Lecturer.", "Warning!!!");
            }
            else if(comboBoxSubject.Text == "")
            {
                ErrorDialogBox.ShowDialog("Select a Subject.", "Warning!!!");
            }
            else if (comboBoxGroup.Text == "")
            {
                ErrorDialogBox.ShowDialog("Select a Group.", "Warning!!!");
            }
            else if (comboBoxTag.Text == "")
            {
                ErrorDialogBox.ShowDialog("Select a Tag.", "Warning!!!");
            }
            else if (textNoFoStudent.Text == "")
            {
                ErrorDialogBox.ShowDialog("Enter No of student for this session.", "Warning!!!");
            }
            else if (txtSessionDuration.Text == "")
            {
                ErrorDialogBox.ShowDialog("Enter Session Duration.", "Warning!!!");
            }
            else
            {


                SessionBO sessionBo = new SessionBO();
                sessionBo.sYear = year;
                sessionBo.sSem = Sem;
                sessionBo.sLecturer01 = Lecturer01.Text.ToString();
                sessionBo.sLecturer02 = Lecturer02.Text.ToString();
                sessionBo.sLecturer03 = Lecturer03.Text.ToString();
                sessionBo.sLecturer04 = Lecturer04.Text.ToString();
                sessionBo.sSubject = comboBoxSubject.Text.ToString();
                sessionBo.sSubjectCode = comboBoxSubject.SelectedValue.ToString();
                sessionBo.sGroup = comboBoxGroup.Text.ToString();
                sessionBo.sSubGroup = comboBoxSubGroup.Text.ToString();
                sessionBo.sTag = comboBoxTag.Text.ToString();
                sessionBo.sNoOfStudent = int.Parse(textNoFoStudent.Text);
                sessionBo.sSessionDuration = int.Parse(txtSessionDuration.Text);
                sessionBo.sIsConsecutive = false;
                sessionBo.sConsecutiveSessionID = 0;

                SessionController sessionController = new SessionController();
                int id = sessionController.CreateSession(sessionBo);
                if(id > 0)
                {
                    SuccessfullMessageBox.ShowDialog("Session Create Successfully!!!", "Success!!!");
                    setDropdownToDefault();
                }
                else
                {
                    ErrorDialogBox.ShowDialog("Session Not Created!!!.", "Warning!!!");
                }
                

            }
            


        }

        public void setLecturelabelDefault()
        {
            Lecturer01.Text = "";
            Lecturer02.Text = "";
            Lecturer03.Text = "";
            Lecturer04.Text = "";

        }

        //get lecturer Names
        public void SetLecturerNamestoDropDown()
        {

            LecturerController lecturerController = new LecturerController();

            List<DataLayer.Lecturer> lecturers = lecturerController.getAllLecturers();

            var LecStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Lecturer lecturer in lecturers)
            {

                LecStatus.Add(new KeyValuePair<string, string>(lecturer.id.ToString(), lecturer.lName.ToString()));

            }

            comboBoxLecturer.DataSource = LecStatus;
            comboBoxLecturer.ValueMember = "Key";
            comboBoxLecturer.DisplayMember = "Value";
            comboBoxLecturer.SelectedIndex = -1;

        }

        public void SetSubjectstoDropDown()
        {
            if(year > 0 && Sem > 0)
            {
                SubjectController subjectcn = new SubjectController();

                List<DataLayer.Subject> subjects = subjectcn.getAllSubjectsMatchToYearAndSem(year, Sem);

                var SubjectStatus = new BindingList<KeyValuePair<string, string>>();

                foreach (Subject subject in subjects)
                {

                    SubjectStatus.Add(new KeyValuePair<string, string>(subject.sCode.ToString(), subject.sName.ToString()));

                }

                comboBoxSubject.DataSource = SubjectStatus;
                comboBoxSubject.ValueMember = "Key";
                comboBoxSubject.DisplayMember = "Value";
                comboBoxSubject.SelectedIndex = -1;

                SetGroupDropDown();
            }

            

        }

        public void SetGroupDropDown()
        {
            string yAndS = "";
            if(year >0 && Sem > 0)
            {
                if(year == 1)
                {
                    if(Sem == 1)
                    {
                        yAndS = "Y1.S1";
                    }
                    else if(Sem == 2)
                    {
                        yAndS = "Y1.S2";
                    }
                }
                else if (year == 2)
                {
                    if (Sem == 1)
                    {
                        yAndS = "Y2.S1";
                    }
                    else if (Sem == 2)
                    {
                        yAndS = "Y2.S2";
                    }
                }
                else if (year == 3)
                {
                    if (Sem == 1)
                    {
                        yAndS = "Y3.S1";
                    }
                    else if (Sem == 2)
                    {
                        yAndS = "Y3.S2";
                    }
                }
                else if (year == 4)
                {
                    if (Sem == 1)
                    {
                        yAndS = "Y4.S1";
                    }
                    else if (Sem == 2)
                    {
                        yAndS = "Y4.S2";
                    }
                }
                else
                {
                    //error Massage
                    ErrorDialogBox.ShowDialog("Please select Year and Semester!", "Warning!!!");
                }


                StudentController studentC = new StudentController();

                List<DataLayer.StudentDetail> studentDetails = studentC.SelectStudentsYearAndSem(yAndS);



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
        }


        public void setTagsDropDown()
        {
            TagController tagC = new TagController();

            List<DataLayer.Tag> tags = tagC.SelectAllTags();

            var tagsStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Tag tag in tags)
            {

                tagsStatus.Add(new KeyValuePair<string, string>(tag.id.ToString(), tag.TagName.ToString()));

            }

            comboBoxTag.DataSource = tagsStatus;
            comboBoxTag.ValueMember = "Key";
            comboBoxTag.DisplayMember = "Value";
            comboBoxTag.SelectedIndex = -1;
        }

        public void setDropdownToDefault()
        {
            comboBoxYear.SelectedIndex = 0;
            comboBoxSemester.SelectedIndex = 0;
            comboBoxSubGroup.SelectedIndex = 0;
            comboBoxLecturer.SelectedIndex = -1;
            comboBoxSubject.SelectedIndex = -1;
            comboBoxGroup.SelectedIndex = -1;
            comboBoxTag.SelectedIndex = -1;
            textNoFoStudent.Text = "";
            txtSessionDuration.Text = "";
            setLecturelabelDefault();
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxYear.SelectedIndex == 1)
            {
                year = 1;
            }
            else if (comboBoxYear.SelectedIndex == 2)
            {
                year = 2;
            }
            else if (comboBoxYear.SelectedIndex == 3)
            {
                year = 3;
            }
            else if (comboBoxYear.SelectedIndex == 4)
            {
                year = 4;
            }

            SetSubjectstoDropDown();

        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSemester.SelectedIndex == 1)
            {
                Sem = 1;
            }
            else if (comboBoxSemester.SelectedIndex == 2)
            {
                Sem = 2;
            }

            SetSubjectstoDropDown();
        }

        private void AddlecturerBtn_Click(object sender, EventArgs e)
        {
            if(comboBoxLecturer.Text != "")
            {
                if(lecturerCount < 4)
                {
                    if(lecturerCount == 0)
                    {
                        Lecturer01.Text = comboBoxLecturer.Text;
                        lecturerCount += 1;
                        comboBoxLecturer.SelectedIndex = -1;
                    }
                    else if(lecturerCount == 1)
                    {
                        Lecturer02.Text = comboBoxLecturer.Text;
                        lecturerCount += 1;
                        comboBoxLecturer.SelectedIndex = -1;
                    }
                    else if (lecturerCount == 2)
                    {
                        Lecturer03.Text = comboBoxLecturer.Text;
                        lecturerCount += 1;
                        comboBoxLecturer.SelectedIndex = -1;
                    }
                    else if (lecturerCount == 3)
                    {
                        Lecturer04.Text = comboBoxLecturer.Text;
                        lecturerCount += 1;
                        comboBoxLecturer.SelectedIndex = -1;
                    }
                }
                else
                {
                    ErrorDialogBox.ShowDialog("Can't Add More Lecturer to this Session.", "Warning!!!");
                }


            }
            else
            {
                ErrorDialogBox.ShowDialog("Select Lecturer.", "Warning!!!");
            }
        }
    }
}
