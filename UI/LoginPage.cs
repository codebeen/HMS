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
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.FromArgb(200, Color.White);
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }

        private void Createacc_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountform = new CreateAccountForm();
            createAccountform.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            var controller = new UserController();
            var eh = new ExceptionHandling();

            try
            {
                string employeeNumber = EmployeeNum.Text;
                string password = PasswordTextbox.Text;

                if (!Validation.ValidateLogin(employeeNumber, password))
                { 
                    Validation.ShowErrorMessage("All fields must be filled out.");
                    return;
                }

                int result = controller.LoginUser(employeeNumber, password);

                switch (result)
                {
                    case 1:
                        string jobPosition = UserSession.JobPosition;
                        if (jobPosition != null)
                        {
                            if (jobPosition.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                Form_Admin form_admin = new Form_Admin();
                                form_admin.Show();
                            }
                            else
                            {
                                Form_receptionist form_receptionist = new Form_receptionist();
                                form_receptionist.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            Validation.ShowErrorMessage("Failed to retrieve user role.");
                        }
                        break;
                    case 2:
                        Validation.ShowErrorMessage("User not found. Please check your Employee Number.");
                        break;
                    case 3:
                        Validation.ShowErrorMessage("Incorrect password. Please try again.");
                        break;
                    case 0:
                    default:
                        Validation.ShowErrorMessage("An unexpected error occurred. Please try again later.");
                        break;
                }
            }
            catch (Exception ex)
            {
                eh.HandleException(ex);
            }
        }

        private void ShowPassIcon_Click(object sender, EventArgs e)
        {
            HidePassBttn.BringToFront();
            PasswordTextbox.PasswordChar = '*';
        }

        private void HidePassBttn_Click(object sender, EventArgs e)
        {
            ShowPassIcon.BringToFront();
            PasswordTextbox.PasswordChar = '\0';
        }
    }
}
