using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class SuiteRoomDelete : Form
    {
        private Suite suiteToDelete = new Suite();

        public SuiteRoomDelete(Suite room)
        {
            InitializeComponent();
            this.suiteToDelete = room;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {


            this.Close();
            SuiteRoomConfirmPassword confirmPassword = new SuiteRoomConfirmPassword(suiteToDelete);
            confirmPassword.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
