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
    public partial class DeletePassword : Form
    {
        // object to hold the room to delete
        private StandardRoom roomToDelete = new StandardRoom();

        public DeletePassword(StandardRoom room)
        {
            InitializeComponent();
            this.roomToDelete = room;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Deleteroom backDeleteRoom = new Deleteroom(roomToDelete);
            backDeleteRoom.ShowDialog();
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

                    StandardRoomController deleteStandardRoom = new StandardRoomController();
                    bool deleteSuccess = deleteStandardRoom.DeleteStandardRoom(roomToDelete);

                    if (deleteSuccess)
                    {
                        // Add Transaction for booking
                        Transaction transaction = new Transaction();

                        transaction.TransactionType = "Delete Standard Room";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
