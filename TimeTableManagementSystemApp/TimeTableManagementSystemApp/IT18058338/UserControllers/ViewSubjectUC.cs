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
    public partial class ViewSubjectUC : UserControl
    {
        public ViewSubjectUC()
        {
            InitializeComponent();
        }

        private void SubjectCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(viewsubjects.SelectedRows[0].Cells[0].Value);
            var scode = viewsubjects.SelectedRows[0].Cells[1].Value.ToString();
            var sname = viewsubjects.SelectedRows[0].Cells[2].Value.ToString();
            var offyear = Convert.ToInt32(viewsubjects.SelectedRows[0].Cells[3].Value);
            var offsemester = Convert.ToInt32(viewsubjects.SelectedRows[0].Cells[4].Value);
            var lechours = Convert.ToInt32(viewsubjects.SelectedRows[0].Cells[5].Value);
            var tuthours = Convert.ToInt32(viewsubjects.SelectedRows[0].Cells[6].Value);
            var labhours = Convert.ToInt32(viewsubjects.SelectedRows[0].Cells[7].Value);
            var evahours = Convert.ToInt32(viewsubjects.SelectedRows[0].Cells[8].Value);

            EditSubjectUC editSubjectUC = new EditSubjectUC();
            editSubjectUC.editFormView(id, scode, sname, offyear, offsemester, lechours, tuthours, labhours, evahours);

            this.Hide();
            this.Parent.Controls.Add(editSubjectUC);
        }

        private void ViewSubjectUC_Load(object sender, EventArgs e)
        {
            SubjectController subjectController = new SubjectController();

            var source = new BindingSource();
            source.DataSource = subjectController.getAllSubjects();
            viewsubjects.DataSource = source;
        }

        private void viewsubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
