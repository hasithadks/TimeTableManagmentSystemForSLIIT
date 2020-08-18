using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    public partial class AddWorkingDaysUC : UserControl
    {
        private static AddWorkingDaysUC _AddWorkingDaysInstance;
        public static AddWorkingDaysUC AddWorkingInstance
        {
            get
            {
                if (_AddWorkingDaysInstance == null)
                    _AddWorkingDaysInstance = new AddWorkingDaysUC();
                return _AddWorkingDaysInstance;

            }
        }

        public AddWorkingDaysUC()
        {
            InitializeComponent();
        }
    }
}
