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
    public partial class EditLecturerUC : UserControl
    {
        public EditLecturerUC()
        {
            InitializeComponent();
        }

        private void EditLecturerUC_Load(object sender, EventArgs e)
        {

        }

        int edId;
        public void editFormView(int id,string lid, string lname, string lfaculty, string ldepartment, string lcenter, string lbuilding, int llevel, string lrank)
        {
            edId = id;
            edittextBoxid.Text = lid;
            edittextBoxname.Text = lname;
            editcheckedListBoxfaculty.Text = lfaculty;
            edittextBoxdepartment.Text = ldepartment;
            editcheckedListBoxCenter.Text = lcenter;
            editcomboBoxBuilding.Text = lbuilding;
            edittextBoxlevel.Text = llevel.ToString();
            edittextBoxrank.Text = lrank;
        }

        private void buttonaddlecturer_Click(object sender, EventArgs e)
        {
            LecturerClass lecturer = new LecturerClass(edId,edittextBoxid.Text, edittextBoxname.Text, editcheckedListBoxfaculty.Text, edittextBoxdepartment.Text, editcheckedListBoxCenter.Text, edittextBoxlevel.Text, Convert.ToInt32(edittextBoxlevel.Text), edittextBoxrank.Text);

            LecturerController lecturerController = new LecturerController();
            lecturerController.updateLecturer(lecturer);

            MessageBox.Show("Lecturer Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeleteLecturer_Click(object sender, EventArgs e)
        {
            LecturerClass lecturer = new LecturerClass(edId, edittextBoxid.Text, edittextBoxname.Text, editcheckedListBoxfaculty.Text, edittextBoxdepartment.Text, editcheckedListBoxCenter.Text, edittextBoxlevel.Text, Convert.ToInt32(edittextBoxlevel.Text), edittextBoxrank.Text);
            
            LecturerController lecturerController = new LecturerController();
            lecturerController.deleteLecturer(lecturer);

            //Fields clear
            edittextBoxid.Clear();
            edittextBoxname.Clear();
            edittextBoxdepartment.Clear();
            edittextBoxlevel.Clear();
            edittextBoxrank.Clear();

            MessageBox.Show("Subject Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
