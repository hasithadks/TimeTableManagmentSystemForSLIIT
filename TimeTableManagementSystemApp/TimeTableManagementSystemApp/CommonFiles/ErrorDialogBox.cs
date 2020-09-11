using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemApp.CommonFiles
{
    public partial class ErrorDialogBox : Form
    {
        public ErrorDialogBox(string msg, string tMsg)
        {
            InitializeComponent();
            ErrorMsg.Text = msg;
            TitleErrorMsg.Text = tMsg;
        }

        public static void ShowDialog(string msg, string tMsg)
        {
            ErrorDialogBox sdb = new ErrorDialogBox(msg, tMsg);
            sdb.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
