using System;
using System.Net.Mail;
using System.Windows.Forms;
using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using static System.Windows.Forms.DataFormats;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordPage changePasswordPage = new ChangePasswordPage();
            changePasswordPage.Show();
            this.Hide();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Hide();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            Name.Text = UserSession.EmployeeName;
            JobPosition.Text = UserSession.JobPosition;
            guna2CirclePictureBox1.Image = ImageHelper.ByteArrayToImage(UserSession.ProfilePicture);

            // Assuming UserSession.Schedule is stored as "Monday, 9:00 am to 6:00 pm, Tuesday, 9:00 am to 6:00 pm, ..."
            string[] dayTimePairs = UserSession.Schedule.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            // Assign each day and time to corresponding fields
            for (int i = 0; i < dayTimePairs.Length; i += 2)
            {
                string day = dayTimePairs[i];

                // Check if there are enough elements left in dayTimePairs
                if (i + 1 < dayTimePairs.Length)
                {
                    string time = dayTimePairs[i + 1];

                    // Assign values to the corresponding labels or text boxes
                    switch (day)
                    {
                        case "M":
                            Mondaysch.Text = "Monday";
                            Montime.Text = time;
                            break;
                        case "T":
                            Tuesdaysch.Text = "Tuesday";
                            tuestime.Text = time;
                            break;
                        case "W":
                            Wednesdaysch.Text = "Wednesday";
                            wedtime.Text = time;
                            break;
                        case "TH":
                            Thursdaysch.Text = "Thursday";
                            thurstime.Text = time;
                            break;
                        case "F":
                            Fridaysch.Text = "Friday";
                            fritime.Text = time;
                            break;
                        case "SAT":
                            Saturdaysch.Text = "Saturday";
                            sattime.Text = time;
                            break;
                        case "S":
                            SundaYSCH.Text = "Sunday";
                            Suntime.Text = time;
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            if (UserSession.JobPosition == "Admin")
            {
                Form_Admin form_admin = new Form_Admin();
                form_admin.Show();
            }
            else
            {
                Form_receptionist form_Receptionist = new Form_receptionist();
                form_Receptionist.Show();
            }

            this.Hide();
        }
    }
}
