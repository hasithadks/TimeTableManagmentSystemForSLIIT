using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers.Tag;
using System.Data.SqlClient;
using DataLayer;
using TimeTableManagementSystemApp.CommonFiles;

namespace TimeTableManagementSystemApp.IT18049114.UserControllers
{
    public partial class Tags : UserControl
    {

        public int tagid = 0;


        public Tags()
        {
            InitializeComponent();
        }

        //Tags Details load to DataGrid Function
        private void Tags_Load(object sender, EventArgs e)
        {
            TagController tagController = new TagController();
            var source = new BindingSource();
            source.DataSource = tagController.SelectAllTags();
            dataGridView1.DataSource = source;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //DataGrid Cell Click Function
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TagController tagController = new TagController();
            var source = new BindingSource();
            source.DataSource = tagController.SelectAllTags();
            dataGridView1.DataSource = source;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //Add Function and Redirect to Edit Function
        private void addedittagbut_Click(object sender, EventArgs e)
        {
            if (tagid == 0)
            {

                if (tagname.Text != "" && shName.Text != "")
                {
                    TagModel tagModel = new TagModel(0, tagname.Text, shName.Text);

                    TagController tagController = new TagController();
                    tagController.InsertTag(tagModel);

                    //Successfull Message
                    SuccessfullMessageBox.ShowDialog("New Tag Added Successfully!!!", "Success!!!");

                    //After Adding DataGrid View
                    var source = new BindingSource();
                    source.DataSource = tagController.SelectAllTags();
                    dataGridView1.DataSource = source;

                    //Fields clear
                    tagname.Clear();
                    shName.Clear();
                }
                else
                {
                    ErrorDialogBox.ShowDialog("Please Enter All Fields", "Warning!!!");
                }
                
            }
            else
            {
                //Redirect To Edit Function
                edit();
            }
        }

        //After Cell Click details View Function
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tagid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            tagname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            shName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        //Edit Function
        private void edit() {

            if (tagid != 0 && tagname.Text != "" && shName.Text != "")
            {
                TagModel tagModel = new TagModel(tagid, tagname.Text, shName.Text);

                TagController tagController = new TagController();
                tagController.UpdateTag(tagModel);

                //Successfull Message
                SuccessfullMessageBox.ShowDialog("Tag Updated Successfully!!!", "Success!!!");

                //After Editing Datagrid View
                var source = new BindingSource();
                source.DataSource = tagController.SelectAllTags();
                dataGridView1.DataSource = source;

                //Fields clear
                tagname.Clear();
                shName.Clear();
            }
            else
            {
                ErrorDialogBox.ShowDialog("Please Enter All Fields", "Warning!!!");
            }

            
        }

        //Delete Function
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tagid != 0 && tagname.Text != "" && shName.Text != "")
            {
                TagModel tagModel = new TagModel(tagid, tagname.Text, shName.Text);

                TagController tagController = new TagController();
                tagController.DeleteTag(tagModel);

                //Successfull message
                SuccessfullMessageBox.ShowDialog("Tag Deleted!!!", "DELETE!!!");

                //After Delete Datagrid View
                var source = new BindingSource();
                source.DataSource = tagController.SelectAllTags();
                dataGridView1.DataSource = source;

                //Fields clear
                tagname.Clear();
                shName.Clear();
            }
            else
            {
                ErrorDialogBox.ShowDialog("Something Wrong. Cannot Delete", "Warning!!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
