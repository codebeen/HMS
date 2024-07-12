using HOTEL_MANAGEMENT_SYSTEM.Utilities;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Form_receptionist : Form
    {
        private Image image;

        public Form_receptionist()
        {
            InitializeComponent();
            Transactions uc = new Transactions();
            addUserControl(uc);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelinformreceptionist_usercontrol.Controls.Clear();
            panelinformreceptionist_usercontrol.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel_navigation_transparent_recep_Paint(object sender, PaintEventArgs e)
        {
            panel_navigation_transparent_recep.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) // Transparency
            {
                e.Graphics.FillRectangle(brush, panel_navigation_transparent_recep.ClientRectangle);
            }
        }

        private void Transaction_button_recep_Click(object sender, EventArgs e)
        {
            Transactions uc = new Transactions();
            addUserControl(uc);
        }

        private void Booknow_button_recep_Click(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);
        }

        private void Reservation_button_recep_Click(object sender, EventArgs e)
        {
            Reservations uc = new Reservations();
            addUserControl(uc);
        }

        private void Guest_button_recep_Click(object sender, EventArgs e)
        {
            Guest_recep uc = new Guest_recep();
            addUserControl(uc);
        }

        private void circilephotoprofile_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp(this, image);
            profilePopUp.Show();
        }

        private void label1name_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp(this, image);
            profilePopUp.Show();
        }

        private void labelemail_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp(this, image);
            profilePopUp.Show();
        }

        private void profilegroup_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp(this, image);
            profilePopUp.Show();
        }

        private void panelinformreceptionist_usercontrol_Paint(object sender, PaintEventArgs e)
        {
            labelnameprofile.Text = UserSession.EmployeeName;
            labeljobposition.Text = UserSession.JobPosition;
            circilephotoprofile.Image = ImageHelper.ByteArrayToImage(UserSession.ProfilePicture);

            image = circilephotoprofile.Image;
        }
    }
}
