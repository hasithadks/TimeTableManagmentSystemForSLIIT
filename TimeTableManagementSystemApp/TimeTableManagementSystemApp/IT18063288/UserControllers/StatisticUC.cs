using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.CommonFiles;
using TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers;

namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    public partial class StatisticUC : UserControl
    {
        public StatisticUC()
        {
            InitializeComponent();
            PanelBtnHorizontal.Visible = false;
        }

        private void btnViewSubjects_Click(object sender, EventArgs e)
        {
            PanelBtnHorizontal.Visible = true;
            PanelBtnHorizontal.Width = btnViewSubjects.Width;
            PanelBtnHorizontal.Left = btnViewSubjects.Left;

            SubjectStatisticUC subjectStatisticUC = new SubjectStatisticUC();
            CommonClass.showControl(subjectStatisticUC, statisticInnerPanel);
        }

        private void btnViewlecturers_Click(object sender, EventArgs e)
        {
            PanelBtnHorizontal.Visible = true;
            PanelBtnHorizontal.Width = btnViewlecturers.Width;
            PanelBtnHorizontal.Left = btnViewlecturers.Left;

            LecturerStatisticUC lecturerStatisticUC = new LecturerStatisticUC();
            CommonClass.showControl(lecturerStatisticUC, statisticInnerPanel);


        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            PanelBtnHorizontal.Visible = true;
            PanelBtnHorizontal.Width = btnViewStudents.Width;
            PanelBtnHorizontal.Left = btnViewStudents.Left;

            StudentStatisticUC studentStatisticUC = new StudentStatisticUC();
            CommonClass.showControl(studentStatisticUC, statisticInnerPanel);
        }
    }
}
