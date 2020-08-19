using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers;
using TimeTableManagementSystemApp.CommonFiles;

namespace TimeTableManagementSystemApp.IT18063288.UserControls
{
    public partial class ViewLocationUC : UserControl
    {
        public ViewLocationUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRecordLocationUC_Click(object sender, EventArgs e)
        {
            EditLocationDataUC editLocationDataUC = new EditLocationDataUC();
            CommonClass.showControl(editLocationDataUC, pnlEditRecords);
        }
    }
}
