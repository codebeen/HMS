using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System.Diagnostics;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class E_wallet : Form
    {
        private readonly PayMongoClient payMongoClient;
        private readonly ExceptionHandling eh = new ExceptionHandling();
        private string sourceId; // Store the source ID for later use

        public int selectedRoomId;
        public Guest guestInfo;
        public Booking newBooking;

        public E_wallet(int roomId, Guest guest, Booking booking)
        {
            InitializeComponent();

            payMongoClient = new PayMongoClient();

            // MouseEnter and MouseLeave events for hover effect
            GcashPanel.MouseEnter += Panel_MouseEnter;
            GcashPanel.MouseLeave += Panel_MouseLeave;
            mayapanel.MouseEnter += Panel_MouseEnter;
            mayapanel.MouseLeave += Panel_MouseLeave;
            bpipanel.MouseEnter += Panel_MouseEnter;
            bpipanel.MouseLeave += Panel_MouseLeave;
            bdopanel.MouseEnter += Panel_MouseEnter;
            bdopanel.MouseLeave += Panel_MouseLeave;
            eastwestpanel.MouseEnter += Panel_MouseEnter;
            eastwestpanel.MouseLeave += Panel_MouseLeave;
            unionbankpanel.MouseEnter += Panel_MouseEnter;
            unionbankpanel.MouseLeave += Panel_MouseLeave;
            landbankpanel.MouseEnter += Panel_MouseEnter;
            landbankpanel.MouseLeave += Panel_MouseLeave;

            selectedRoomId = roomId;
            guestInfo = guest;
            newBooking = booking;
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.LightGray; // Change to desired hover color
            }
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = SystemColors.Control; // Change to original color
            }
        }

        public async void payWithCard(string bankName, string Account, string Month, string Year, string cvv)
        {
            int mon = Convert.ToInt32(Month);
            int year = Convert.ToInt32(Year);

            await PayWithCard(bankName, Account, mon, year, cvv);
        }

        public async Task PayWithCard(string bankName, string cardNumber, int expMonth, int expYear, string cvc)
        {
            try
            {
                var paymentClient = new PayMongoClient();

                // Step 1: Create a payment method
                var paymentMethodId = await paymentClient.CreatePaymentMethod(bankName, cardNumber, expMonth, expYear, cvc);

                if (paymentMethodId != null)
                {
                    // Step 2: Create a payment intent
                    var paymentIntentId = await paymentClient.CreatePaymentIntent(15000m);

                    if (paymentIntentId != null)
                    {
                        // Step 3: Attach the payment method to the payment intent
                        var attachResult = await paymentClient.AttachPaymentMethodToIntent(paymentIntentId, paymentMethodId);

                        if (attachResult)
                        {
                            // Step 4: Check the status of the payment
                            string status = await paymentClient.CheckPaymentStatus(paymentIntentId);

                            MessageBox.Show("Initial Payment Status: " + status);

                            DateTime startTime = DateTime.Now;
                            TimeSpan timeout = TimeSpan.FromSeconds(60);
                            while (status != "succeeded" && status != "failed" && DateTime.Now - startTime < timeout)
                            {
                                await Task.Delay(5000); // Wait for 5 seconds before checking again
                                status = await paymentClient.CheckPaymentStatus(paymentIntentId);
                                MessageBox.Show("Payment Status: " + status);
                            }

                            MessageBox.Show("Final Payment Status: " + status);

                            // Redirect based on payment status
                            if (status == "succeeded")
                            {
                                using (var context = new DataContext())
                                {
                                    // get the room price of the selected roomId
                                    var roomPrice = context.Rooms.Where(r => r.RoomId == selectedRoomId).Select(r => r.RoomPrice).FirstOrDefault();

                                    double vat = roomPrice * 0.12;
                                    double localTax = roomPrice * 0.03;
                                    double serviceCharge = roomPrice * 0.10;

                                    double totalAmount = roomPrice + vat + localTax + serviceCharge;

                                    Payment payment = new Payment();

                                    payment.PaymentId = 0;
                                    payment.PaymentMethod = "Card Payment";
                                    payment.Amount = totalAmount;
                                    payment.Currency = "PHP";
                                    payment.Status = "Completed";
                                    payment.PaymentDate = DateTime.Now;

                                    payment.PayMongoTransactionId = "N/A";
                                    payment.PayMongoPaymentIntentId = paymentIntentId;
                                    payment.PayMongoPaymentMethodId = paymentMethodId;

                                    RedirectToBookingSummary(payment);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to attach payment method.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to create payment intent.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create payment method.");
                }
            }
            catch (Exception ex)
            {
                eh.HandleException(ex);
            }


        }

        private async void RunGcashPayment(object sender, EventArgs e)
        {
            try
            {
                var paymongoClient = new PayMongoClient();

                // Step 1: Create Payment Link
                var checkoutUrl = await paymongoClient.CreateGCashPaymentLink(15000m, "Payment thru GCash");

                if (checkoutUrl != null)
                {
                    Console.WriteLine("Checkout URL: " + checkoutUrl);

                    // Step 2: Open Checkout URL in Browser
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = checkoutUrl,
                        UseShellExecute = true
                    });

                    // Extract linkId from the checkoutUrl
                    var uri = new Uri(checkoutUrl);
                    var linkId = uri.Segments[^1].TrimEnd('/');

                    // Step 3: Wait for Payment Status
                    var status = await paymongoClient.WaitForPaymentStatus(linkId);

                    // Check payment status and display appropriate prompt
                    if (status == "paid")
                    {
                        using (var context = new DataContext())
                        {
                            // get the room price of the selected roomId
                            var roomPrice = context.Rooms.Where(r => r.RoomId == selectedRoomId).Select(r => r.RoomPrice).FirstOrDefault();

                            double vat = roomPrice * 0.12;
                            double localTax = roomPrice * 0.03;
                            double serviceCharge = roomPrice * 0.10;

                            double totalAmount = roomPrice + vat + localTax + serviceCharge;

                            Payment payment = new Payment();

                            payment.PaymentId = newBooking.BookingId;
                            payment.PaymentMethod = "E-Wallet Payment";
                            payment.Amount = totalAmount;
                            payment.Currency = "PHP";
                            payment.Status = "Completed";
                            payment.PaymentDate = DateTime.Now;

                            payment.PayMongoTransactionId = linkId;
                            payment.PayMongoPaymentIntentId = "N/A";
                            payment.PayMongoPaymentMethodId = "N/A";

                            RedirectToBookingSummary(payment);
                        }
                    }
                    else if (status == "failed")
                    {
                        MessageBox.Show("Payment Status: Failed");
                    }
                    else
                    {
                        MessageBox.Show("Payment Status: Unknown. Please check again.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create payment link.");
                }
            }
            catch (Exception ex)
            {
                // Error handling for payment link creation
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void RunPayMayaPayment(object sender, PaintEventArgs e)
        {
            try
            {
                var paymongoClient = new PayMongoClient();

                // Step 1: Create Payment Link
                var checkoutUrl = await paymongoClient.CreatePayMayaPaymentLink(15000m, "Payment thru PayMaya");

                if (checkoutUrl != null)
                {
                    Console.WriteLine("Checkout URL: " + checkoutUrl);

                    // Step 2: Open Checkout URL in Browser
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = checkoutUrl,
                        UseShellExecute = true
                    });

                    // Extract linkId from the checkoutUrl
                    var uri = new Uri(checkoutUrl);
                    var linkId = uri.Segments[^1].TrimEnd('/');

                    // Step 3: Wait for Payment Status
                    var status = await paymongoClient.WaitForPaymentStatus(linkId);

                    // Check payment status and display appropriate prompt
                    if (status == "paid")
                    {
                        using (var context = new DataContext())
                        {
                            // get the room price of the selected roomId
                            var roomPrice = context.Rooms.Where(r => r.RoomId == selectedRoomId).Select(r => r.RoomPrice).FirstOrDefault();

                            double vat = roomPrice * 0.12;
                            double localTax = roomPrice * 0.03;
                            double serviceCharge = roomPrice * 0.10;

                            double totalAmount = roomPrice + vat + localTax + serviceCharge;

                            Payment payment = new Payment();

                            payment.PaymentId = 0;
                            payment.PaymentMethod = "E-Wallet Payment";
                            payment.Amount = totalAmount;
                            payment.Currency = "PHP";
                            payment.Status = "Completed";
                            payment.PaymentDate = DateTime.Now;

                            payment.PayMongoTransactionId = linkId;
                            payment.PayMongoPaymentIntentId = "N/A";
                            payment.PayMongoPaymentMethodId = "N/A";

                            RedirectToBookingSummary(payment);
                        }
                    }
                    else if (status == "failed")
                    {
                        MessageBox.Show("Payment Status: Failed");
                    }
                    else
                    {
                        MessageBox.Show("Payment Status: Unknown. Please check again.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create payment link.");
                }
            }
            catch (Exception ex)
            {
                // Error handling for payment link creation
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bpipanel_Paint(object sender, PaintEventArgs e)
        {
            RedirectCardPayment("bpi");
        }

        private void bdopanel_Paint(object sender, PaintEventArgs e)
        {
            RedirectCardPayment("bdo");
        }

        private void eastwestpanel_Paint(object sender, PaintEventArgs e)
        {
            RedirectCardPayment("eastwest");
        }

        private void unionbankpanel_Paint(object sender, PaintEventArgs e)
        {
            RedirectCardPayment("ubp");
        }

        private void landbankpanel_Paint(object sender, PaintEventArgs e)
        {
            RedirectCardPayment("landbank");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            RedirectCardPayment("rcbc");
        }

        private void RedirectCardPayment(string bank)
        {
            this.Hide();
            CardPayment cardPayment = new CardPayment(bank, selectedRoomId, guestInfo, newBooking);
            cardPayment.Show();
        }

        private void RedirectToBookingSummary(Payment payment)
        {
            BookingSummary bookingSummaryForm = new BookingSummary(selectedRoomId, guestInfo, newBooking, payment);
            bookingSummaryForm.Show();
            this.Hide();
        }

        private void GcashPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
