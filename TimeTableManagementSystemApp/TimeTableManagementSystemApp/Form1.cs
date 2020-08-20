using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.IT18049114.Forms;
using TimeTableManagementSystemApp.IT18058338.Forms;
using TimeTableManagementSystemApp.IT18063288;

namespace TimeTableManagementSystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationForm att = new LocationForm();
            att.Show();
        }

        private void addStudentBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagement att = new StudentManagement();
            att.Show();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
        
        }

        private void daysBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDaysForm att = new WorkingDaysForm();
            att.Show();
        }

        private void SubjectBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void tagbtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
