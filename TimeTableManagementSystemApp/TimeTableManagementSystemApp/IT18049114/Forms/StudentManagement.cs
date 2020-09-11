using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.CommonFiles;
using TimeTableManagementSystemApp.IT18049114.UserControllers;

namespace TimeTableManagementSystemApp.IT18049114.Forms
{
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
            TopManuBarUC topManuBarUC = new TopManuBarUC();
            //CommonClass.showControl(topManuBarUC, topPanel);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStudentBut_Click(object sender, EventArgs e)
        {
            AddStudent AddStudent = new AddStudent();
            CommonClass.showControl(AddStudent, contentPanel);
        }

        private void viewBut_Click(object sender, EventArgs e)
        {
            ViewStudent ViewStudent = new ViewStudent();
            CommonClass.showControl(ViewStudent, contentPanel);
        }

        private void addtagBut_Click(object sender, EventArgs e)
        {
            Tags Tags = new Tags();
            CommonClass.showControl(Tags, contentPanel);
        }

        private void addconseBut_Click(object sender, EventArgs e)
        {
            ConsecutiveSessions ConsecutiveSessions = new ConsecutiveSessions();
            CommonClass.showControl(ConsecutiveSessions, contentPanel);
        }

        private void addntavBut_Click(object sender, EventArgs e)
        {
            NotAvailableTimes NotAvailableTimes = new NotAvailableTimes();
            CommonClass.showControl(NotAvailableTimes, contentPanel);
        }

        private void addStudentBut_Click_1(object sender, EventArgs e)
        {
            AddStudent AddStudent = new AddStudent();
            CommonClass.showControl(AddStudent, contentPanel);
        }

        private void viewBut_Click_1(object sender, EventArgs e)
        {
            ViewStudent ViewStudent = new ViewStudent();
            CommonClass.showControl(ViewStudent, contentPanel);
        }

        private void addtagBut_Click_1(object sender, EventArgs e)
        {
            Tags Tags = new Tags();
            CommonClass.showControl(Tags, contentPanel);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {

        }

        private void editStudentBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
