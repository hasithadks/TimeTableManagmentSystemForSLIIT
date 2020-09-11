using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Subject;

namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    public partial class EditSubjectUC : UserControl
    {
        public EditSubjectUC()
        {
            InitializeComponent();
        }

        private void EditSubjectUC_Load(object sender, EventArgs e)
        {

        }

        int edId;
        public void editFormView(int id,string scode,string sname,int offyear,int offsemester,int lechours,int tuthours,int labhours,int evahours)
        {
            edId = id;
            textBoxEditCode.Text = scode;
            textBoxEditName.Text = sname;
            comboBoxEditYear.Text = offyear.ToString();
            comboBoxEditSemester.Text = offsemester.ToString();
            textBoxEditLecHours.Text = lechours.ToString();
            textBoxEditTutHours.Text = tuthours.ToString();
            textBoxEditLabHours.Text = labhours.ToString();
            textBoxEditEvaHours.Text = evahours.ToString();
        }

        private void buttonupdatesubject_Click(object sender, EventArgs e)
        {
            SubjectClass subjectClass = new SubjectClass(edId,textBoxEditCode.Text, textBoxEditName.Text, Convert.ToInt32(comboBoxEditYear.Text), Convert.ToInt32(comboBoxEditSemester.Text), Convert.ToInt32(textBoxEditLecHours.Text), Convert.ToInt32(textBoxEditTutHours.Text), Convert.ToInt32(textBoxEditLabHours.Text), Convert.ToInt32(textBoxEditEvaHours.Text));
            SubjectController subjectController = new SubjectController();
            subjectController.updateStudent(subjectClass);

            MessageBox.Show("Subject Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SubjectClass subject = new SubjectClass(edId,textBoxEditCode.Text, textBoxEditName.Text, Convert.ToInt32(comboBoxEditYear.Text), Convert.ToInt32(comboBoxEditSemester.Text), Convert.ToInt32(textBoxEditLecHours.Text), Convert.ToInt32(textBoxEditTutHours.Text), Convert.ToInt32(textBoxEditLabHours.Text), Convert.ToInt32(textBoxEditEvaHours.Text));
            SubjectController subjectController = new SubjectController();
            subjectController.deleteStudent(subject);

            //Fields clear
            textBoxEditCode.Clear();
            textBoxEditName.Clear();
            textBoxEditLecHours.Clear();
            textBoxEditLabHours.Clear();
            textBoxEditTutHours.Clear();
            textBoxEditEvaHours.Clear();

            MessageBox.Show("Subject Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
