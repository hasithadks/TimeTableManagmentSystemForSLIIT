using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemApp.IT18050240.UserControllers
{
    public partial class GenerateTimeTableUC : UserControl
    {
        private static GenerateTimeTableUC _GenerateTimeTableInstance;

        public static GenerateTimeTableUC GenerateTimeTableInstance
        {
            get
            {
                if (_GenerateTimeTableInstance == null)
                    _GenerateTimeTableInstance = new GenerateTimeTableUC();
                return _GenerateTimeTableInstance;
            }
        }

        public GenerateTimeTableUC()
        {
            InitializeComponent();
        }
    }
}
