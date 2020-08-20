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
using TimeTableManagementSystemApp.IT18058338.UserControllers;

namespace TimeTableManagementSystemApp.IT18058338.Forms
{
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
            TopManuBarUC topManuBarUC = new TopManuBarUC();
           // CommonClass.showControl(topManuBarUC, headerpanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addlecturerbtn_Click(object sender, EventArgs e)
        {
            AddLecturerUC addLecturerUC = new AddLecturerUC();
            CommonClass.showControl(addLecturerUC, mainpanel);
        }

        private void editlecturerbtn_Click(object sender, EventArgs e)
        {
            EditLecturerUC editLecturerUC = new EditLecturerUC();
            CommonClass.showControl(editLecturerUC, mainpanel);
        }

        private void viewlecturerbtn_Click(object sender, EventArgs e)
        {
            ViewLecturerUC viewLecturerUC = new ViewLecturerUC();
            CommonClass.showControl(viewLecturerUC, mainpanel);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
