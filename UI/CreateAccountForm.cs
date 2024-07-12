using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class CreateAccountForm : Form
    {
        private static readonly ExceptionHandling exception = new ExceptionHandling();
        public CreateAccountForm()
        {
            InitializeComponent();
            guna2Panel3.Parent = guna2Panel2;
            guna2Panel3.BackColor = Color.FromArgb(200, Color.White);
            guna2Panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, guna2Panel3.Width, guna2Panel3.Height, 20, 20));
            /*employeenumber.TextChanged += new EventHandler(TextBox_TextChanged);
            fullname.TextChanged += new EventHandler(TextBox_TextChanged);
            dob.TextChanged += new EventHandler(TextBox_TextChanged);
            passacc.TextChanged += new EventHandler(TextBox_TextChanged);
            confirmpass.TextChanged += new EventHandler(TextBox_TextChanged);*/
        }
        /*
        // Event handler to check if all fields are not null or empty
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            CreateAcc.Enabled = !string.IsNullOrWhiteSpace(employeenumber.Text)
                                && !string.IsNullOrWhiteSpace(fullname.Text) 
                                && !string.IsNullOrWhiteSpace(dob.Text)
                                && !string.IsNullOrWhiteSpace(passacc.Text)
                                && !string.IsNullOrWhiteSpace(confirmpass.Text);
        }*/

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        private void label3_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            this.Hide();
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the input fields
                string EmployeeNumber = employeenumber.Text;
                string FullName = fullname.Text;
                string Birthdate = dob.Text;
                string Password = passacc.Text;
                string ConfirmPass = confirmpass.Text;

                // Validate fields are not empty
                if (string.IsNullOrWhiteSpace(EmployeeNumber) || string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Birthdate) ||
                    string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPass))
                {
                    Validation.ShowErrorMessage("All fields must be filled out.");
                    return;
                }

                // Validate password requirements:
                // - one small letter,              (?=.*[a-z])
                // - one capital letter,            (?=.*[A-Z])
                // - one number,                    (?=.*\d)
                // - one special character, and     (?=.*[~`!@#$%^&*()_\-+={[}\]|\:;""'<,>.?/])
                // - at least 8 characters long     {8,}
                string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[~`!@#$%^&*()_\-+={[}\]|\:;""'<,>.?/]).{8,}$";
                if (!Regex.IsMatch(Password, passwordPattern))
                {
                    Validation.ShowErrorMessage("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.");
                    return;
                }

                // Validate password and confirm password match
                if (Password != ConfirmPass)
                {
                    Validation.ShowErrorMessage("Passwords do not match.");
                    return;
                }

                // If all validations pass, proceed with account creation
                var controller = new UserController();
                // Catching any exceptions that may occur
                var result = controller.CreateUser(EmployeeNumber, FullName, Birthdate, Password);
                switch (result) {
                    case 0:
                        Validation.ShowErrorMessage("The employee number already exists. Please enter a unique employee number.");
                        break;

                    case 1:
                        Validation.ShowErrorMessage("Account created successfully.");

                        LoginPage loginPage = new LoginPage();
                        loginPage.Show();

                        // Hide the CreateAccountForm
                        this.Hide();
                        break;

                    case 2:
                        Validation.ShowErrorMessage("Error creating your account.");
                        break;

                    default:
                        Validation.ShowErrorMessage("An unexpected error occurred. Please try again later.");
                        break;
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
            }
        }

        private void CreateShowPassBttn_Click(object sender, EventArgs e)
        {
            CreateHidePassBttn.BringToFront();
            passacc.PasswordChar = '*';
        }

        private void CreateHidePassBttn_Click(object sender, EventArgs e)
        {
            CreateShowPassBttn.BringToFront();
            passacc.PasswordChar = '\0';
        }

        private void ConfirmPassShowBttn_Click(object sender, EventArgs e)
        {
            ConfirmPassHideBttn.BringToFront();
            confirmpass.PasswordChar = '*';
        }

        private void ConfirmPassHideBttn_Click(object sender, EventArgs e)
        {
            ConfirmPassShowBttn.BringToFront();
            confirmpass.PasswordChar = '\0';
        }
    }
}
