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
using TimeTableManagementSystemApp.IT18063288.UserControls;

namespace TimeTableManagementSystemApp.IT18063288
{
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
        }

        
        private void btnViewLocation_Click(object sender, EventArgs e)
        {
            ViewLocationUC viewLocationUC = new ViewLocationUC();
            CommonClass.showControl(viewLocationUC, panelContent); 
        }
    }
}
