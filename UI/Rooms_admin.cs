using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
//using System.Drawing;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Rooms_admin : UserControl
    {
        private Form_receptionist form_receptionist;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Rooms_admin()
        {
            InitializeComponent();
            InitializeHoverEffects();
            InitializeClickEvents();
            //panelforbgroomtypes.BackColor = Color.FromArgb(200, Color.White);
            //panelforbgroomtypes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelforbgroomtypes.Width, Standardroom.Height, 20, 20));
        }

        private void InitializeHoverEffects()
        {
            // Add event handlers for MouseEnter and MouseLeave events
            Standardroom.MouseEnter += panel_MouseEnter;
            Standardroom.MouseLeave += panel_MouseLeave;

            DeluxeRoom.MouseEnter += panel_MouseEnter;
            DeluxeRoom.MouseLeave += panel_MouseLeave;

            Suitesrooms.MouseEnter += panel_MouseEnter;
            Suitesrooms.MouseLeave += panel_MouseLeave;
        }

        private void InitializeClickEvents()
        {
            Standardroom.Click += Standardrooms_Click;
            DeluxeRoom.Click += Deluxrooms_Click;
            Suitesrooms.Click += Suitesrooms_Click;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            var panel = sender as Guna2CustomGradientPanel; // Ensure correct type casting
            if (panel != null)
            {
                panel.FillColor = Color.Gray;
                panel.FillColor2 = Color.Gray;
                panel.FillColor3 = Color.Gray;
                panel.FillColor4 = Color.Gray;
            }
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Guna2CustomGradientPanel; // Ensure correct type casting
            if (panel != null)
            {
                panel.FillColor = Color.White; // Change back to the original color
                panel.FillColor2 = Color.White;
                panel.FillColor3 = Color.White;
                panel.FillColor4 = Color.White;
            }
        }

        private void Standardrooms_Click(object sender, EventArgs e)
        {
            Standardroom standardroomForm = new Standardroom();
            standardroomForm.Show();
        }

        private void Deluxrooms_Click(object sender, EventArgs e)
        {
            DeluxeRooms deluxeRoomsForm = new DeluxeRooms();
            deluxeRoomsForm.Show();
        }

        private void Suitesrooms_Click(object sender, EventArgs e)
        {
            SuitesRoom suitesRoomForm = new SuitesRoom();
            suitesRoomForm.Show();
        }

        private void ChangeTextColor(Guna2CustomGradientPanel panel, Color color)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = color;
                }
            }
        }

        private void SetRoundedCorners(Control control, int radius)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
        }
    }
}
