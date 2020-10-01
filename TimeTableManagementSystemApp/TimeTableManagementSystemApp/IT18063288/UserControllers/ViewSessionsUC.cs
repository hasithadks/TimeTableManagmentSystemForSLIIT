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
using BusinessLayers.TimeSessions;
using BusinessLayers.Lecturer;
using BusinessLayers.Subject;
using BusinessLayers.Student;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    public partial class ViewSessionsUC : UserControl
    {
        private int sessionCount = 0;

        public ViewSessionsUC()
        {
            InitializeComponent();

            SetLecturerNamestoDropDown();
            SetSubjectstoDropDown();
            SetGroupDropDown();

            sessionCount = 1;
            setVisibleSession01False();
            setVisibleSession02False();
            buttonCreateConSess.Visible = false;
            setDataGrid();
        }

       public void setDataGrid()
        {
            SessionController sessionController = new SessionController();
            List<TimeSession> SessionDetailsall;
            SessionDetailsall = sessionController.GetTimeSessions();

            if (SessionDetailsall.Count == 0)
            {
                ErrorDialogBox.ShowDialog("No Records Found! \nPlease Add Sessions to the System.", "Sorry!!!");
            }
            DataGridSessions.DataSource = SessionDetailsall;

            CountLabel.Text = SessionDetailsall.Count.ToString();

        }

        public void setVisibleSession01False()
        {
            label2.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label10.Visible = false;

            labelSubject.Visible = false;
            labelSubCode.Visible = false;
            labelTag.Visible = false;
            labelSessID.Visible = false;
        }

        public void setVisibleSession01True()
        {
            label2.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label10.Visible = true;

            labelSubject.Visible = true;
            labelSubCode.Visible = true;
            labelTag.Visible = true;
            labelSessID.Visible = true;
        }

        public void setSessionTextEmpty()
        {
            labelSubject.Text = "";
            labelSubCode.Text = "";
            labelTag.Text = "";
            labelSessID.Text = "";

            labelSubject02.Text = "";
            labelSubCode02.Text = "";
            labelTag02.Text = "";
            labelSessID02.Text = "";
        }



        public void setVisibleSession02False()
        {
            label3.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label11.Visible = false;

            labelSubject02.Visible = false;
            labelSubCode02.Visible = false;
            labelTag02.Visible = false;
            labelSessID02.Visible = false;
        }


        public void setVisibleSession02True()
        {
            label3.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label11.Visible = true;

            labelSubject02.Visible = true;
            labelSubCode02.Visible = true;
            labelTag02.Visible = true;
            labelSessID02.Visible = true;

        }
        private void DataGridSessions_DoubleClick(object sender, EventArgs e)
        {

            if(sessionCount == 1)
            {
                labelSubject.Text = DataGridSessions.SelectedRows[0].Cells[7].Value.ToString();
                labelSubCode.Text = DataGridSessions.SelectedRows[0].Cells[8].Value.ToString();
                labelTag.Text = DataGridSessions.SelectedRows[0].Cells[11].Value.ToString();
                labelSessID.Text = DataGridSessions.SelectedRows[0].Cells[0].Value.ToString();

                setVisibleSession01True();
                sessionCount += 1;
                SuccessfullMessageBox.ShowDialog("Good!!! \nNow You Can Double Click on the Second Record.", "Information!!!");
            }
            else if (sessionCount == 2)
            {
                labelSubject02.Text = DataGridSessions.SelectedRows[0].Cells[7].Value.ToString();
                labelSubCode02.Text = DataGridSessions.SelectedRows[0].Cells[8].Value.ToString();
                labelTag02.Text = DataGridSessions.SelectedRows[0].Cells[11].Value.ToString();
                labelSessID02.Text = DataGridSessions.SelectedRows[0].Cells[0].Value.ToString();

                buttonCreateConSess.Visible = true;
                setVisibleSession02True();

            }
        }

        private void AddConSessBtn_Click(object sender, EventArgs e)
        {
            SuccessfullMessageBox.ShowDialog("Please Double Click on the Record. \nThen you can add one session to list and then, " +
                "\ndouble click on the second record which you want to \ncreate consecutive sessions. ", "Information!!!");
        }

        private void buttonCreateConSess_Click(object sender, EventArgs e)
        {
            int session01ID = int.Parse(labelSessID.Text);
            int session02ID = int.Parse(labelSessID02.Text);

            SessionController sessionController = new SessionController();
            int id = sessionController.Createconsecutivesessions(session01ID, session02ID);

            if(id > 0)
            {
                SuccessfullMessageBox.ShowDialog("Consecutive Sessions Created Successfully.", "Successfully!!!");
            }

            setSessionTextEmpty();
            setVisibleSession01False();
            setVisibleSession02False();
            buttonCreateConSess.Visible = false;
            setDataGrid();
        }

        private void buttonSearchView_Click(object sender, EventArgs e)
        {
            if(comboBoxLecturer.Text != "" && comboBoxSubject.Text == "" && comboBoxGroup.Text == "")
            {
                SessionController sessionController = new SessionController();
                List<DataLayer.TimeSession> lecturers = sessionController.GetTimeSessionsAssignLecturer(comboBoxLecturer.Text);

                DataGridSessions.DataSource = lecturers;

                CountLabel.Text = lecturers.Count.ToString();

            }
            else if (comboBoxSubject.Text != "" && comboBoxLecturer.Text == "" && comboBoxGroup.Text == "")
            {

                SessionController sessionController = new SessionController();
                List<DataLayer.TimeSession> Subjects = sessionController.GetTimeSessionsAssignSubject(comboBoxSubject.Text);

                DataGridSessions.DataSource = Subjects;

                CountLabel.Text = Subjects.Count.ToString();

            }
            else if(comboBoxGroup.Text != "" && comboBoxLecturer.Text == "" && comboBoxSubject.Text == "")
            {

                SessionController sessionController = new SessionController();
                List<DataLayer.TimeSession> Groups = sessionController.GetTimeSessionsAssignGroup(comboBoxGroup.Text);

                DataGridSessions.DataSource = Groups;

                CountLabel.Text = Groups.Count.ToString();
            }
            else
            {
                ErrorDialogBox.ShowDialog("Please Select one category at a once!!!", "Warrning!!!!!!");
            }



        }


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
            
                SubjectController subjectcn = new SubjectController();

                List<DataLayer.Subject> subjects = subjectcn.getAllSubjects();

                var SubjectStatus = new BindingList<KeyValuePair<string, string>>();

                foreach (Subject subject in subjects)
                {

                    SubjectStatus.Add(new KeyValuePair<string, string>(subject.sCode.ToString(), subject.sName.ToString()));

                }

                comboBoxSubject.DataSource = SubjectStatus;
                comboBoxSubject.ValueMember = "Key";
                comboBoxSubject.DisplayMember = "Value";
                comboBoxSubject.SelectedIndex = -1;

        }

        public void SetGroupDropDown()
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
    }
}
