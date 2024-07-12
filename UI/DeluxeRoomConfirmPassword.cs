using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class DeluxeRoomConfirmPassword : Form
    {
        private DeluxeRoom roomToDelete = new DeluxeRoom();

        public DeluxeRoomConfirmPassword(DeluxeRoom room)
        {
            InitializeComponent();
            this.roomToDelete = room;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DataContext(DatabaseHelper.GetDatabaseConnectionString()))
                {
                    var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == UserSession.EmployeeNumber);

                    if (!PasswordHasher.VerifyPassword(PasswordTextbox.Text, user.Salt, user.SaltedPassword))
                    {
                        Validation.ShowErrorMessage("Current password is incorrect.");
                        return;
                    }

                    DeluxeRoomController deleteDeluxeRoom = new DeluxeRoomController();
                    bool deleteSuccess = deleteDeluxeRoom.DeleteDeluxeRoom(roomToDelete);

                    if (deleteSuccess)
                    {
                        // Add Transaction for booking
                        Transaction transaction = new Transaction();

                        transaction.TransactionType = "Delete Deluxe Room";
                        transaction.TransactionDate = DateTime.Now;
                        transaction.TransactionTime = DateTime.Now.TimeOfDay;
                        transaction.EmployeeName = UserSession.EmployeeName;

                        TransactionController transactionController = new TransactionController();
                        bool result = transactionController.AddTransaction(transaction);

                        if (result)
                        {
                            MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        MessageBox.Show("Room successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Failed to delete room.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
            DeluxeRoomDelete backDeleteRoom = new DeluxeRoomDelete(roomToDelete);
            backDeleteRoom.ShowDialog();
        }
    }
}
