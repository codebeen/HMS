using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using HOTEL_MANAGEMENT_SYSTEM.UI;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class PaymentInfo : Form
    {
        // variable that will hold the parameters from the previous form
        private int selectedRoomId;
        private Guest guestInfo;
        private Booking newBooking;

        public PaymentInfo(int roomId, Guest guest, Booking booking)
        {
            InitializeComponent();
            selectedRoomId = roomId;
            guestInfo = guest;
            newBooking = booking;
        }

        private void Transparentcontainer_Paint(object sender, PaintEventArgs e)
        {
            Transparentcontainer.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, Transparentcontainer.ClientRectangle);
            }
        }

        private void Cashbutton_Click(object sender, EventArgs e)
        {
            // assign the mode of payment to the booking
            newBooking.ModeOfPayment = "Cash Payment";

            this.Close();
            CashPayment cashPayment = new CashPayment(selectedRoomId, guestInfo, newBooking);
            cashPayment.Show();
        }

        private void Cardbutton_Click(object sender, EventArgs e)
        {
            // assign the mode of payment to the booking
            newBooking.ModeOfPayment = "Card Payment";

            this.Close();

            E_wallet e_Wallet = new E_wallet(selectedRoomId, guestInfo, newBooking);
            e_Wallet.Show();
        }
    }
}
