using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemApp.CommonFiles
{
    class CommonClass
    {

        //1st parameter : UserController object 2nd parameter : Pannel 
        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control panelContent)
        {
            panelContent.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelContent.Controls.Add(control);
        }



    }
}
