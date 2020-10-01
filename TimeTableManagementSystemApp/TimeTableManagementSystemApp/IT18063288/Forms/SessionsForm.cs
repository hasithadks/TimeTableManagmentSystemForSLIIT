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
    public partial class SessionsForm : Form
    {
        public SessionsForm()
        {
            InitializeComponent();
            ViewSessionsUC viewSessionsUC = new ViewSessionsUC();
            CommonClass.showControl(viewSessionsUC, panelContent);

        }

        private void btnAddSessions_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = btnAddSessions.Height;
            panelLeft.Top = btnAddSessions.Top;
            // panelLeft.BackColor = btnAddLocation.BackColor;

            AddSessionsUC addSessionsUC = new AddSessionsUC();
            CommonClass.showControl(addSessionsUC, panelContent);
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

        private void btnViewSessions_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = btnViewSessions.Height;
            panelLeft.Top = btnViewSessions.Top;
            // panelLeft.BackColor = btnAddLocation.BackColor;

            ViewSessionsUC viewSessionsUC = new ViewSessionsUC();
            CommonClass.showControl(viewSessionsUC, panelContent);
        }

        private void buttonADDLocationToSession_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = buttonADDLocationToSession.Height;
            panelLeft.Top = buttonADDLocationToSession.Top;

            AddLocationToSessionUC addLocationToSession = new AddLocationToSessionUC();
            CommonClass.showControl(addLocationToSession, panelContent);
        }
    }
}
