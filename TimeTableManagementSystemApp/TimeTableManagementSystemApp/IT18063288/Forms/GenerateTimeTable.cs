using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.CommonFiles;
using TimeTableManagementSystemApp.IT18063288.UserControllers;

namespace TimeTableManagementSystemApp.IT18063288.Forms
{
    public partial class GenerateTimeTable : Form
    {
        public GenerateTimeTable()
        {
            InitializeComponent();
        }

        private void btnstdTimeTable_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = btnstdTimeTable.Height;
            panelLeft.Top = btnstdTimeTable.Top;
            // panelLeft.BackColor = btnAddLocation.BackColor;

            StudentTimeTableUC viewSessionsUC = new StudentTimeTableUC();
            CommonClass.showControl(viewSessionsUC, panelContent);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
