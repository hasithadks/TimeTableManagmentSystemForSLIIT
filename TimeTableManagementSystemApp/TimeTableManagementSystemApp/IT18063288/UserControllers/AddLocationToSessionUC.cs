using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.TimeSessions;
using TimeTableManagementSystemApp.CommonFiles;
using DataLayer;
using BusinessLayers.Location;
using BusinessLayers.Lecturer;
using BusinessLayers.Subject;
using BusinessLayers.Student;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    public partial class AddLocationToSessionUC : UserControl
    {
        private bool isNotListed = false;
        private bool isListed = false;


        public AddLocationToSessionUC()
        {
            InitializeComponent();
            setVisibleSessionFalse();
            SetNotAddedList();


            SetLecturerNamestoDropDown();
            SetSubjectstoDropDown();
            SetGroupDropDown();
        }

        private void buttonNotAdded_Click(object sender, EventArgs e)
        {
            isNotListed = true;
            isListed = false;
            PanelBtnHorizontal.Visible = true;
            PanelBtnHorizontal.Width = buttonNotAdded.Width;
            PanelBtnHorizontal.Left = buttonNotAdded.Left;

            setVisibleSessionFalse();
            SetNotAddedList();

        }

        private void buttonAdded_Click(object sender, EventArgs e)
        {
            isNotListed = false;
            isListed = true;

            PanelBtnHorizontal.Visible = true;
            PanelBtnHorizontal.Width = buttonAdded.Width;
            PanelBtnHorizontal.Left = buttonAdded.Left;

            setVisibleSessionFalse();
            setAddedList();

        }


        public void setVisibleSessionFalse()
        {
            label2.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label5.Visible = false;
            label7.Visible = false;

            subGroupTxt.Visible = false;
            grouptxt.Visible = false;
            labelSubject.Visible = false;
            comboBoxRoom.Visible = false;
            labelTag.Visible = false;
            labelSessID.Visible = false;

            buttonUpdateSession.Visible = false;
        }

        public void setVisibleSessionTrue()
        {
            label2.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            label5.Visible = true;
            label7.Visible = true;

            subGroupTxt.Visible = true;
            grouptxt.Visible = true;
            labelSubject.Visible = true;
            comboBoxRoom.Visible = true;
            labelTag.Visible = true;
            labelSessID.Visible = true;

            buttonUpdateSession.Visible = true;
        }

        public void SetNotAddedList()
        {
            SessionController sessionController = new SessionController();
            List<TimeSession> SessionDetailsall;
            SessionDetailsall = sessionController.GetLocationNotAddedTimeSessions();

            if (SessionDetailsall.Count == 0)
            {
                ErrorDialogBox.ShowDialog("No Sessions Found!", "Sorry!!!");
            }
            DataGridSessions.DataSource = SessionDetailsall;

            CountLabel.Text = SessionDetailsall.Count.ToString();
        }


        public void setAddedList()
        {
            SessionController sessionController = new SessionController();
            List<TimeSession> SessionDetailsall;
            SessionDetailsall = sessionController.GetLocationAddedTimeSessions();

            if (SessionDetailsall.Count == 0)
            {
                ErrorDialogBox.ShowDialog("No Sessions Found! \n please Add locations.", "Sorry!!!");
            }
            DataGridSessions.DataSource = SessionDetailsall;

            CountLabel.Text = SessionDetailsall.Count.ToString();
        }

        private void buttonSearchView_Click(object sender, EventArgs e)
        {
            if (isNotListed)
            {
                if (comboBoxLecturer.Text != "" && comboBoxSubject.Text == "" && comboBoxGroup.Text == "")
                {
                    SessionController sessionController = new SessionController();
                    List<DataLayer.TimeSession> lecturers = sessionController.GetTimeSessionsAssignLecturerNotListed(comboBoxLecturer.Text);

                    DataGridSessions.DataSource = lecturers;

                    CountLabel.Text = lecturers.Count.ToString();

                }
                else if (comboBoxSubject.Text != "" && comboBoxLecturer.Text == "" && comboBoxGroup.Text == "")
                {

                    SessionController sessionController = new SessionController();
                    List<DataLayer.TimeSession> Subjects = sessionController.GetTimeSessionsAssignSubjectNotListed(comboBoxSubject.Text);

                    DataGridSessions.DataSource = Subjects;

                    CountLabel.Text = Subjects.Count.ToString();

                }
                else if (comboBoxGroup.Text != "" && comboBoxLecturer.Text == "" && comboBoxSubject.Text == "")
                {

                    SessionController sessionController = new SessionController();
                    List<DataLayer.TimeSession> Groups = sessionController.GetTimeSessionsAssignGroupNotListed(comboBoxGroup.Text);

                    DataGridSessions.DataSource = Groups;

                    CountLabel.Text = Groups.Count.ToString();
                }
                else
                {
                    ErrorDialogBox.ShowDialog("Please Select one category at a once!!!", "Warrning!!!!!!");
                }
            }
            else if (isListed)
            {
                if (comboBoxLecturer.Text != "" && comboBoxSubject.Text == "" && comboBoxGroup.Text == "")
                {
                    SessionController sessionController = new SessionController();
                    List<DataLayer.TimeSession> lecturers = sessionController.GetTimeSessionsAssignLecturerListed(comboBoxLecturer.Text);

                    DataGridSessions.DataSource = lecturers;

                    CountLabel.Text = lecturers.Count.ToString();

                }
                else if (comboBoxSubject.Text != "" && comboBoxLecturer.Text == "" && comboBoxGroup.Text == "")
                {

                    SessionController sessionController = new SessionController();
                    List<DataLayer.TimeSession> Subjects = sessionController.GetTimeSessionsAssignSubjectListed(comboBoxSubject.Text);

                    DataGridSessions.DataSource = Subjects;

                    CountLabel.Text = Subjects.Count.ToString();

                }
                else if (comboBoxGroup.Text != "" && comboBoxLecturer.Text == "" && comboBoxSubject.Text == "")
                {

                    SessionController sessionController = new SessionController();
                    List<DataLayer.TimeSession> Groups = sessionController.GetTimeSessionsAssignGroupListed(comboBoxGroup.Text);

                    DataGridSessions.DataSource = Groups;

                    CountLabel.Text = Groups.Count.ToString();
                }
                else
                {
                    ErrorDialogBox.ShowDialog("Please Select one category at a once!!!", "Warrning!!!!!!");
                }
            }

            
        }

        private void DataGridSessions_DoubleClick(object sender, EventArgs e)
        {
            int studentCount = 0;
            string tag = "";

            labelSubject.Text = DataGridSessions.SelectedRows[0].Cells[7].Value.ToString();
            
            labelTag.Text = DataGridSessions.SelectedRows[0].Cells[11].Value.ToString();
            labelSessID.Text = DataGridSessions.SelectedRows[0].Cells[0].Value.ToString();
            grouptxt.Text = DataGridSessions.SelectedRows[0].Cells[9].Value.ToString();
            subGroupTxt.Text = DataGridSessions.SelectedRows[0].Cells[10].Value.ToString();

            studentCount = int.Parse(DataGridSessions.SelectedRows[0].Cells[12].Value.ToString()) > 0 ? int.Parse(DataGridSessions.SelectedRows[0].Cells[12].Value.ToString()) : 0;
            tag = DataGridSessions.SelectedRows[0].Cells[11].Value.ToString();
            setRoomDropDown(studentCount,tag);
            comboBoxRoom.SelectedText = DataGridSessions.SelectedRows[0].Cells[17].Value.ToString();
            setVisibleSessionTrue();



        }


        public void setRoomDropDown(int sdtCount, string tag)
        {

            LocationController locationContol = new LocationController();
            List<Room> roomList = locationContol.GetAllRoomsAccordingtostudentCount(sdtCount, tag);

            var roomStatus = new BindingList<KeyValuePair<string, string>>();

            foreach (Room room in roomList)
            {

                roomStatus.Add(new KeyValuePair<string, string>(room.id.ToString(), room.RoomName.ToString()));

            }

            comboBoxRoom.DataSource = roomStatus;
            comboBoxRoom.ValueMember = "Key";
            comboBoxRoom.DisplayMember = "Value";
            comboBoxRoom.SelectedIndex = -1;
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

        private void buttonUpdateSession_Click(object sender, EventArgs e)
        {

            if(labelSessID.Text!= "" && comboBoxRoom.Text != "")
            {
                int sessionID = int.Parse(labelSessID.Text);
                int roomID = int.Parse(comboBoxRoom.SelectedValue.ToString());
                string RoomName = comboBoxRoom.Text;

                SessionController sessionController = new SessionController();
                int id = sessionController.UpdateSession(sessionID, roomID, RoomName);

                if (id > 0)
                {
                    SuccessfullMessageBox.ShowDialog("Location Added Successfully!!!", "Success!!!");
                    setVisibleSessionFalse();
                    SetNotAddedList();
                }
                else
                {
                    ErrorDialogBox.ShowDialog("SomeThing Wrong!!!.", "Warning!!!");
                }
            }
            else
            {
                ErrorDialogBox.ShowDialog("Please Select a Room.", "Warning!!!");
            }
            
        }
    }
}
