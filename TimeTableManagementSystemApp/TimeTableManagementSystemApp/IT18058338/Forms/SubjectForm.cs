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
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
            TopManuBarUC topManuBarUC = new TopManuBarUC();
           // CommonClass.showControl(topManuBarUC, panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewSubjectUC viewSubjectUC = new ViewSubjectUC();
            CommonClass.showControl(viewSubjectUC, mainpanelsubject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSubjectUC addSubjectUC = new AddSubjectUC();
            CommonClass.showControl(addSubjectUC, mainpanelsubject);
        }

        private void viewlecturerbtn_Click(object sender, EventArgs e)
        {
            EditSubjectUC editSubjectUC = new EditSubjectUC();
            CommonClass.showControl(editSubjectUC, mainpanelsubject);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
