using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.UI;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System.Runtime.InteropServices;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class LoginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public LoginPage()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(200, Color.White);
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Createacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccountForm createAccountform = new CreateAccountForm();
            createAccountform.Show();
        }

        private void EmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Createacc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }

        private void HidePassBttn_Click_1(object sender, EventArgs e)
        {
            ShowPassIcon.BringToFront();
            PasswordTextbox.PasswordChar = '\0';
        }

        private void ShowPassIcon_Click_1(object sender, EventArgs e)
        {
            HidePassBttn.BringToFront();
            PasswordTextbox.PasswordChar = '*';
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            string employeeNumber = EmployeeNum.Text;
            string password = PasswordTextbox.Text;

            var controller = new UserController();

            if (string.IsNullOrWhiteSpace(employeeNumber) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = controller.LoginUser(employeeNumber, password);

            if (result == 1)
            {
                string jobPosition = UserSession.JobPosition;

                if (jobPosition != null)
                {
                    if (jobPosition.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        Form_Admin form_admin = new Form_Admin();
                        form_admin.Show();
                    }
                    else if (jobPosition.Equals("Receptionist", StringComparison.OrdinalIgnoreCase))
                    {
                        Form_receptionist form_receptionist = new Form_receptionist();
                        form_receptionist.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.Hide();
                }
                else if (result == 2)
                {
                    MessageBox.Show("Failed to retrieve user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error while logging in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // a methor that will update the status of booking and its corresponding room status
        private void BookingUpdater()
        {
            BookingController bookingController = new BookingController();
            bookingController.UpdateBookingStatus();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // call the booking updater method on page load
            BookingUpdater();
        }
    }
}