using Guna.UI2.WinForms;
using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using System;
//using System.Drawing;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Dashboard_admin : UserControl
    {
        public Dashboard_admin()
        {
            InitializeComponent();
            InitializeHoverEffects();
            Guestdemographics_db uc = new Guestdemographics_db();
            addUserControl(uc);
        }

        private void panelline_Paint(object sender, PaintEventArgs e)
        {
            Pen blackpen = new Pen(Color.FromArgb(96, 94, 94), 3);
            PointF pnt1 = new PointF(-10.0F, 10.0F);
            PointF pnt2 = new PointF(2000.0F, 10.0F);
            e.Graphics.DrawLine(blackpen, pnt1, pnt2);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelreportsummary.Controls.Clear();
            panelreportsummary.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Guestbutton_Click(object sender, EventArgs e)
        {
            Guestdemographics_db uc = new Guestdemographics_db();
            addUserControl(uc);
        }

        private void Ocupancyratebutton_Click(object sender, EventArgs e)
        {
            OccupancyRate_db uc = new OccupancyRate_db();
            addUserControl(uc);
        }

        private void Revenuebutton_Click(object sender, EventArgs e)
        {
            Revenue_db uc = new Revenue_db();
            addUserControl(uc);
        }

        private void InitializeHoverEffects()
        {
            // Add event handlers for MouseEnter and MouseLeave events
            Newbookingspanel.MouseEnter += panel_MouseEnter;
            Newbookingspanel.MouseLeave += panel_MouseLeave;

            transactionpaneldash.MouseEnter += panel_MouseEnter;
            transactionpaneldash.MouseLeave += panel_MouseLeave;

            Staynowpanel.MouseEnter += panel_MouseEnter;
            Staynowpanel.MouseLeave += panel_MouseLeave;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            var panel = sender as Guna2CustomGradientPanel; // Ensure correct type casting
            panel.FillColor = Color.Black; // Change to the desired hover color
            panel.FillColor2 = Color.Gray;
            panel.FillColor3 = Color.Gray;
            panel.FillColor4 = Color.Black;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Guna2CustomGradientPanel; // Ensure correct type casting
            panel.FillColor = Color.FromArgb(13, 29, 20); // Change back to the original color
            panel.FillColor2 = Color.FromArgb(13, 29, 20);
            panel.FillColor3 = Color.FromArgb(16, 19, 20);
            panel.FillColor4 = Color.FromArgb(16, 19, 20);
        }

        private void Dashboard_admin_Load(object sender, EventArgs e)
        {
            // display the data for total of rooms
            RoomController roomController = new RoomController();
            totalRoomsTxt.Text = roomController.CountTotalRooms().ToString();

            //  display the total staying guests
            BookingController bookingController = new BookingController();
            stayTxt.Text = bookingController.CountStayingGuests().ToString();

            // display the upcoming bookings
            upcomingBookingsTxt.Text = bookingController.CountUpcomingBookings().ToString();
        }
    }
}