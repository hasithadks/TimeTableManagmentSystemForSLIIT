using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystemApp.IT18063288;
using TimeTableManagementSystemApp.IT18058338;
using TimeTableManagementSystemApp.IT18058338.Forms;

namespace TimeTableManagementSystemApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SubjectForm());
        }
    }
}
