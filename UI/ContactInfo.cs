using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOTEL_MANAGEMENT_SYSTEM.Models;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class ContactInfo : Form
    {
        // variable that will hold the parameters from the previous form
        private int selectedRoomId;
        private Booking newBooking;


        public ContactInfo(int roomId, Booking booking)
        {
            InitializeComponent();
            selectedRoomId = roomId;
            newBooking = booking;
        }

        private void NextNavSummary_Click(object sender, EventArgs e)
        {
            try
            {
                // create instance of Guest to store the information from text box
                Guest guestInfo = new Guest();

                guestInfo.LastName = lastNameText.Text;
                guestInfo.FirstName = firstNameText.Text;
                guestInfo.DateOfBirth = Convert.ToDateTime(birthdayText.Text);
                guestInfo.PhoneNumber = Convert.ToInt64(phoneNumText.Text);
                guestInfo.Email = emailAddressText.Text;
                guestInfo.City = cityText.Text;
                guestInfo.Country = countryText.Text;
                guestInfo.HouseAddress = houseAddressText.Text;
                guestInfo.ZipCode = Convert.ToInt32(zipcodeText.Text);

                // choose payment information
                this.Close();
                PaymentInfo payment = new PaymentInfo(selectedRoomId, guestInfo, newBooking);
                payment.Show();

                // Close the parent form
                // Form parentForm = this.FindForm();
                // parentForm.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            //SelectRoom selectRoom = new SelectRoom ();
            // selectRoom.Show();

            // Close the parent form
            // Form parentForm = this.FindForm();
            // parentForm.Hide();
        }

    }
}
