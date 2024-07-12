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
    public partial class Reports_admin : UserControl
    {
        public Reports_admin()
        {
            InitializeComponent();
            GuestDemo uc = new GuestDemo();
            AddUserControl(uc);
        }

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelforrepoerts.Controls.Clear();
            panelforrepoerts.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Guestbutton_Click(object sender, EventArgs e)
        {
            GuestDemo uc = new GuestDemo();
            AddUserControl(uc);
        }

        private void panelline_Paint(object sender, PaintEventArgs e)
        {
            Pen blackpen = new Pen(Color.FromArgb(96, 94, 94), 3);
            PointF pnt1 = new PointF(-10.0F, 10.0F);
            PointF pnt2 = new PointF(2000.0F, 10.0F);
            e.Graphics.DrawLine(blackpen, pnt1, pnt2);
        }

        private void occupancyrate_reports_button_Click(object sender, EventArgs e)
        {
            OccupancyRate uc = new OccupancyRate();
            AddUserControl(uc);
        }

        private void Revenue_reports_button_Click(object sender, EventArgs e)
        {
            Revenue uc = new Revenue();
            AddUserControl(uc);
        }

        private void Staff_performance_button_Click(object sender, EventArgs e)
        {
            StaffPerformance_report uc = new StaffPerformance_report();
            AddUserControl(uc);
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
