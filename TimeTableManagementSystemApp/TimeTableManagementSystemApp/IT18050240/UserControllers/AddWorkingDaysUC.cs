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

        private void MWDMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void NoOfDaysPerWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(NoOfDaysPerWeek.Text) == "Weekend")
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDMonday.Hide(); MWDTuesday.Hide(); MWDWednesday.Hide(); MWDThursday.Hide(); MWDFriday.Hide();
                }
                else if (Convert.ToInt32(NoOfDaysPerWeek.Text) == 1)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDTuesday.Hide(); MWDWednesday.Hide(); MWDThursday.Hide(); MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(NoOfDaysPerWeek.Text) == 2)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDWednesday.Hide(); MWDThursday.Hide(); MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(NoOfDaysPerWeek.Text) == 3)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDThursday.Hide(); MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(NoOfDaysPerWeek.Text) == 4)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDFriday.Hide(); MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else if (Convert.ToInt32(NoOfDaysPerWeek.Text) == 5)
                {
                    MWDMonday.Show(); MWDTuesday.Show(); MWDWednesday.Show(); MWDThursday.Show(); MWDFriday.Show(); MWDSaturday.Show(); MWDSunday.Show();

                    MWDSaturday.Hide(); MWDSunday.Hide();
                }
                else
                {
                    Console.WriteLine("Invalid Number of day");
                }
            }
            catch (FormatException ex) { 
            
            }

        }
    }
}
