using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Lecturer;

namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    public partial class ViewLecturerUC : UserControl
    {
        public ViewLecturerUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewLecturerUC_Load(object sender, EventArgs e)
        {
            LecturerController lecturerController = new LecturerController();

            var source = new BindingSource();
            source.DataSource = lecturerController.getAllLecturers();
            viewlecturers.DataSource = source;
        }

        private void lecturerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(viewlecturers.SelectedRows[0].Cells[0].Value);
            var lid = viewlecturers.SelectedRows[0].Cells[1].Value.ToString();
            var lname = viewlecturers.SelectedRows[0].Cells[2].Value.ToString();
            var lfaculty = viewlecturers.SelectedRows[0].Cells[3].Value.ToString();
            var ldepartment = viewlecturers.SelectedRows[0].Cells[4].Value.ToString();
            var lcenter = viewlecturers.SelectedRows[0].Cells[5].Value.ToString();
            var lbuilding = viewlecturers.SelectedRows[0].Cells[6].Value.ToString();
            var llevel = Convert.ToInt32(viewlecturers.SelectedRows[0].Cells[7].Value);
            var lrank = viewlecturers.SelectedRows[0].Cells[8].Value.ToString();

            EditLecturerUC editLecturerUC = new EditLecturerUC();
            editLecturerUC.editFormView(id,lid, lname, lfaculty, ldepartment, lcenter, lbuilding, llevel, lrank);

            this.Hide();
            this.Parent.Controls.Add(editLecturerUC);
        }
    }
}
