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
    public partial class AddSubjectUC : UserControl
    {
        private SubjectController subjectController;

        public AddSubjectUC()
        {
            InitializeComponent();
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void buttonaddlecturer_Click(object sender, EventArgs e)
        {
            subjectController = new SubjectController();

            string scode = textBoxCode.Text;
            string sname = textBoxName.Text;
            int offyear = Convert.ToInt32(comboBoxYear.Text);
            int offsemester = Convert.ToInt32(comboBoxSemester.Text);
            int lechours = Convert.ToInt32(textBoxLecHours.Text);
            int tuthours = Convert.ToInt32(textBoxTutHours.Text);
            int labhours = Convert.ToInt32(textBoxLabHours.Text);
            int evahours = Convert.ToInt32(textBoxEvaHours.Text);

            subjectController.saveSubject(scode,sname,offyear,offsemester,lechours,tuthours,labhours,evahours);

            MessageBox.Show("New Subject Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxCode.Clear();
            textBoxName.Clear();
            textBoxLecHours.Clear();
            textBoxTutHours.Clear();
            textBoxLabHours.Clear();
            textBoxEvaHours.Clear();
        }

    }
}
