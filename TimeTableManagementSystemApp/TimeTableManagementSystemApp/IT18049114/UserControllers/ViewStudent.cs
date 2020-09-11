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
    public partial class ViewStudent : UserControl
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //DataGrid View Function
        private void ViewStudent_Load(object sender, EventArgs e)
        {
            StudentController studentController = new StudentController();
            var source = new BindingSource();
            source.DataSource = studentController.SelectAllStudents();
            dataGridView1.DataSource = source;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void editstdpagebut_Click(object sender, EventArgs e)
        {
            //EditStudent AddStudent = new EditStudent();
            //AddStudent.Show();
        }

        //DataGrid Cell Click Function
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var stId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var yearsem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            var program = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            var groupno = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            var groupid = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            var subgroupno = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
            var subgroupid = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            //Pass Row values to edit page function
            EditStudent editusercontroller = new EditStudent();
            editusercontroller.editStudentDetailsView(stId, yearsem, program, groupno,groupid, subgroupno, subgroupid);

            //Redirect to Edit Page
            this.Hide();
            this.Parent.Controls.Add(editusercontroller);
        }
    }
}
