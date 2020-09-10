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
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addstdbut_Click(object sender, EventArgs e)
        {
            if (studentId.Text != "")
            {
                StudentModel studentModel = new StudentModel(studentId.Text, textBox1.Text, programme.Text, Convert.ToInt32(groupNo.Value), groupId.Text, Convert.ToInt32(subGroupNo.Value), subGroupId.Text);

                StudentController studentController = new StudentController();
                studentController.InsertStudent(studentModel);
            }
            else
            {
                MessageBox.Show("Error");
            }

                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void programme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void academicYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = year.Text;
            var b = semester.Text;
            var c = programme.Text;
            var d = Convert.ToInt32(groupNo.Value);
            var f = Convert.ToInt32(subGroupNo.Value);

            textBox1.Text = "Y"+a+"." +"S"+ b;
            groupId.Text = "Y" + a + "." + "S" + b + "." + c + "." + 0 +d;
            subGroupId.Text = "Y" + a + "." + "S" + b + "." + c + "." + 0 + d + "." + f;

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
