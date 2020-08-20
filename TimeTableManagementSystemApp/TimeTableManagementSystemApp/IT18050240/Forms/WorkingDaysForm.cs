using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.IT18050240.UserControllers;
using TimeTableManagementSystemApp.IT18058338.UserControllers;

namespace TimeTableManagementSystemApp.IT18058338.Forms
{
    public partial class WorkingDaysForm : Form
    {
        public WorkingDaysForm()
        {
            InitializeComponent();
            workingDaysPanel.Controls.Add(AddWorkingDaysUC.AddWorkingInstance);
            AddWorkingDaysUC.AddWorkingInstance.BringToFront();
        }

        private void addWorkingDaysBtn_Click(object sender, EventArgs e)
        {
            if (!workingDaysPanel.Controls.Contains(AddWorkingDaysUC.AddWorkingInstance))
            {
                workingDaysPanel.Controls.Add(AddWorkingDaysUC.AddWorkingInstance);
                AddWorkingDaysUC.AddWorkingInstance.BringToFront();
            }
            else
                AddWorkingDaysUC.AddWorkingInstance.BringToFront();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void genarateTimeTableBtn_Click(object sender, EventArgs e)
        {
            if (!workingDaysPanel.Controls.Contains(GenerateTimeTableUC.GenerateTimeTableInstance))
            {
                workingDaysPanel.Controls.Add(GenerateTimeTableUC.GenerateTimeTableInstance);
                GenerateTimeTableUC.GenerateTimeTableInstance.BringToFront();
            }
            else
                GenerateTimeTableUC.GenerateTimeTableInstance.BringToFront();
        }

        private void viewTimeTableBtn_Click(object sender, EventArgs e)
        {
            if (!workingDaysPanel.Controls.Contains(ViewTimeTableUC.ViewTimeTableInstance))
            {
                workingDaysPanel.Controls.Add(ViewTimeTableUC.ViewTimeTableInstance);
                ViewTimeTableUC.ViewTimeTableInstance.BringToFront();
            }
            else
                ViewTimeTableUC.ViewTimeTableInstance.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
