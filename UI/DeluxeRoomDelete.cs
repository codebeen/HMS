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
    public partial class DeluxeRoomDelete : Form
    {
        private DeluxeRoom roomToDelete = new DeluxeRoom();

        public DeluxeRoomDelete(DeluxeRoom room)
        {
            InitializeComponent();
            this.roomToDelete = room;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            DeluxeRoomConfirmPassword confirmPassword = new DeluxeRoomConfirmPassword(roomToDelete);
            confirmPassword.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
