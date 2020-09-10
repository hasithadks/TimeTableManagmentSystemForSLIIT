using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Student;

namespace TimeTableManagementSystemApp.IT18049114.UserControllers
{
    public partial class EditStudent : UserControl
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {

        }

        public void editStudentDetailsView(string stId, string yearsem, string program, int groupno, string groupid,int subgroupno, string subgroupid)
        {
            int acYear = 0;
            int acSem = 0;

            if (yearsem.Contains("Y1"))
            {
                acYear = 1;
            }else if (yearsem.Contains("Y2"))
            {
                acYear = 2;
            }else if (yearsem.Contains("Y3"))
            {
                acYear = 3;
            }else if (yearsem.Contains("Y4"))
            {
                acYear = 4;
            }else
            {
                MessageBox.Show("Academic Year Error");
            }

            if (yearsem.Contains("S1"))
            {
                acSem = 1;
            }else if (yearsem.Contains("S2"))
            {
                acSem = 2;
            }else
            {
                MessageBox.Show("Academic Semester Error");
            }

            editIDtext.Text = stId;
            editYearText.Text = acYear.ToString();
            editSemeserText.Text = acSem.ToString();
            editProgrammeText.Text = program;
            editGroupNoText.Value = groupno;
            editSubGroupNo.Value = subgroupno;
            editYearSemView.Text = yearsem;
            editGroupIdView.Text = groupid;
            editSubGroupIdView.Text = subgroupid;
        }

        private void EditSet_Click(object sender, EventArgs e)
        {
            var a = editYearText.Text;
            var b = editSemeserText.Text;
            var c = editProgrammeText.Text;
            var d = Convert.ToInt32(editGroupNoText.Value);
            var f = Convert.ToInt32(editSubGroupNo.Value);

            editYearSemView.Text = "Y" + a + "." + "S" + b;
            editGroupIdView.Text = "Y" + a + "." + "S" + b + "." + c + "." + d;
            editSubGroupIdView.Text = "Y" + a + "." + "S" + b + "." + c + "." + d + "." + f;
        }

        private void editstdbut_Click(object sender, EventArgs e)
        {
            StudentModel studentModel = new StudentModel(editIDtext.Text, editYearSemView.Text, editProgrammeText.Text, Convert.ToInt32(editGroupNoText.Value), editGroupIdView.Text, Convert.ToInt32(editSubGroupNo.Value), editSubGroupIdView.Text);

            StudentController studentController = new StudentController();
            studentController.updateStudentDetails(studentModel);
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            StudentModel studentModel = new StudentModel(editIDtext.Text, editYearSemView.Text, editProgrammeText.Text, Convert.ToInt32(editGroupNoText.Value), editGroupIdView.Text, Convert.ToInt32(editSubGroupNo.Value), editSubGroupIdView.Text);

            StudentController studentController = new StudentController();
            studentController.deleteStudentDetails(studentModel);
        }
    }
}
