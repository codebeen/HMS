using HOTEL_MANAGEMENT_SYSTEM.Utilities;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class ProfilePopUp : Form
    {
        private static Form _parentForm;
        private static Image _parentImage;

        public ProfilePopUp(Form form, Image image)
        {
            InitializeComponent();
            _parentForm = form;
            _parentImage = image;
            this.Deactivate += new EventHandler(ProfilePopUp_Deactivate);
        }

        private void ProfilePopUp_Deactivate(object? sender, EventArgs e)
        {
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogOutPage logOutPage = new LogOutPage();
            logOutPage.Show();
            this.Hide();
        }

        private void ViewProfileButton_Click_1(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            _parentForm.Hide();
            _parentImage.Dispose();
            ProfilePicturePopUp.Dispose();
            this.Hide();
        }

        private void ProfilePopUp_Load(object sender, EventArgs e)
        {
            ProfileNamePopUp.Text = UserSession.EmployeeName;
            ProfilePicturePopUp.Image = ImageHelper.ByteArrayToImage(UserSession.ProfilePicture);
        }
    }
}
