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
    public partial class ViewTimeTableUC : UserControl
    {

        private static ViewTimeTableUC _ViewTimeTableInstance;

        public static ViewTimeTableUC ViewTimeTableInstance
        {
            get
            {
                if (_ViewTimeTableInstance == null)
                    _ViewTimeTableInstance = new ViewTimeTableUC();
                return _ViewTimeTableInstance;
            }
        }

        public ViewTimeTableUC()
        {
            InitializeComponent();
        }
    }
}
