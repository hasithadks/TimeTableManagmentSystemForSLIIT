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
using TimeTableManagementSystemApp.CommonFiles;

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
                ErrorDialogBox.ShowDialog("Academic Year Error", "Warning!!!");
            }

            if (yearsem.Contains("S1"))
            {
                acSem = 1;
            }else if (yearsem.Contains("S2"))
            {
                acSem = 2;
            }else
            {
                ErrorDialogBox.ShowDialog("Academic Semester Error", "Warning!!!");
            }

            //Assign existing values to fields
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

        //Edit Values Set Button Function
        private void EditSet_Click(object sender, EventArgs e)
        {
            var a = editYearText.Text;
            var b = editSemeserText.Text;
            var c = editProgrammeText.Text;
            var d = Convert.ToInt32(editGroupNoText.Value);
            var f = Convert.ToInt32(editSubGroupNo.Value);

            if (a != "" && b != "" && c != "" && d != 0 && f != 0)
            {
                editYearSemView.Text = "Y" + a + "." + "S" + b;
                editGroupIdView.Text = "Y" + a + "." + "S" + b + "." + c + "." + 0 + d;
                editSubGroupIdView.Text = "Y" + a + "." + "S" + b + "." + c + "." + 0 + d + "." + f;
            }
            else
            {
                ErrorDialogBox.ShowDialog("Please Fill All Fields", "Warning!!!");
            }
        }

        //Update Button Function
        private void editstdbut_Click(object sender, EventArgs e)
        {
            if (editIDtext.Text != "" && editProgrammeText.Text != "" && editGroupNoText.Value != 0 && editSubGroupNo.Value != 0)
            {

                StudentModel studentModel = new StudentModel(editIDtext.Text, editYearSemView.Text, editProgrammeText.Text, Convert.ToInt32(editGroupNoText.Value), editGroupIdView.Text, Convert.ToInt32(editSubGroupNo.Value), editSubGroupIdView.Text);

                StudentController studentController = new StudentController();
                studentController.updateStudentDetails(studentModel);

                //Successfull message
                SuccessfullMessageBox.ShowDialog("Student Details Updated Successfully!!!", "Success!!!");

                //Redirect to View Page
                ViewStudent viewStudent = new ViewStudent();
                this.Hide();
                this.Parent.Controls.Add(viewStudent);
            }
            else
            {
                ErrorDialogBox.ShowDialog("Please Enter All Fields", "Warning!!!");
            }
        }

        //Delete Button Function
        private void deletebut_Click(object sender, EventArgs e)
        {
            if (editIDtext.Text != "" && editProgrammeText.Text != "" && editGroupNoText.Value != 0 && editSubGroupNo.Value != 0)
            {
                StudentModel studentModel = new StudentModel(editIDtext.Text, editYearSemView.Text, editProgrammeText.Text, Convert.ToInt32(editGroupNoText.Value), editGroupIdView.Text, Convert.ToInt32(editSubGroupNo.Value), editSubGroupIdView.Text);

                StudentController studentController = new StudentController();
                studentController.deleteStudentDetails(studentModel);

                //Successfull message
                SuccessfullMessageBox.ShowDialog("Student Details Deleted!!!", "DELETE!!!");


                //Redirect to View Page
                ViewStudent viewStudent = new ViewStudent();
                this.Hide();
                this.Parent.Controls.Add(viewStudent);
            }
            else
            {
                ErrorDialogBox.ShowDialog("Something Wrong. Cannot Delete", "Warning!!!");
            }
        }
    }
}
