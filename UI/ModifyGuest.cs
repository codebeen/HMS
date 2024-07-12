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
    public partial class ModifyGuest : Form
    {
        private Form_receptionist parentForm;
        public ModifyGuest()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void NavBack_Click(object sender, EventArgs e)
        {
           Guest_recep guest_Recep = new Guest_recep();
           guest_Recep.Show();
            this.Hide();
        }
    }
}
