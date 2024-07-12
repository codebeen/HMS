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
    public partial class Guest_recep : UserControl
    {
        public Guest_recep()
        {
            InitializeComponent();
        }
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ModifyGuest modifyGuest = new ModifyGuest();
            modifyGuest.Show();
            this.Hide();
        }
    }
}
