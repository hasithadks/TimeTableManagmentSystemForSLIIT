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
using TimeTableManagementSystemApp.IT18063288.UserControls;

namespace TimeTableManagementSystemApp.IT18063288
{
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
            TopManuBarUC topManuBarUC = new TopManuBarUC();
           // CommonClass.showControl(topManuBarUC, panelMainMenubar);
            //panelLeft.Height = btnViewLocation.Height;
            //  panelLeft.Top = btnViewLocation.Top;
            panelLeft.Visible = false;
        }

        
        private void btnViewLocation_Click(object sender, EventArgs e)
        {
            
            panelLeft.Height = btnViewLocation.Height;
            panelLeft.Top = btnViewLocation.Top;
            panelLeft.Visible = true;
            // panelLeft.BackColor = btnViewLocation.BackColor;
            ViewLocationUC viewLocationUC = new ViewLocationUC();
            CommonClass.showControl(viewLocationUC, panelContent); 
        }

        private void btnAddlocation_Click(object sender, EventArgs e)
        {

            
        }

        private void btnAddLocation_Click_1(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = btnAddLocation.Height;
            panelLeft.Top = btnAddLocation.Top;
           // panelLeft.BackColor = btnAddLocation.BackColor;

            AddLocationUC addLocationUC = new AddLocationUC();
            CommonClass.showControl(addLocationUC, panelContent);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = btnStatistic.Height;
            panelLeft.Top = btnStatistic.Top;
            StatisticUC statisticUC = new StatisticUC();
            CommonClass.showControl(statisticUC, panelContent);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
