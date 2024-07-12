using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.UI;
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

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class DRAddroom : Form
    {
        public DRAddroom()
        {
            InitializeComponent();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            // checks if all fields are empty
            if (roomnumberadd.Text == null)
            {
                MessageBox.Show("Room Number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roomnumberadd.Focus();
                return;
            }
            if (roompriceadd.Text == null)
            {
                MessageBox.Show("Room Price is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roompriceadd.Focus();
                return;
            }
            if (occupancylimitadd.Text == null)
            {
                MessageBox.Show("Occupancy Limit is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                occupancylimitadd.Focus();
                return;
            }
            if (roomstatusadd.Text == null)
            {
                MessageBox.Show("Room Status is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roomstatusadd.Focus();
                return;
            }
            if (typeofviewadd.Text == null)
            {
                MessageBox.Show("Type of View is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                typeofviewadd.Focus();
                return;
            }


            // create instance of DeluxeRoom
            DeluxeRoom deluxeRoom = new DeluxeRoom();

            // assign the value of the textboxes to the properties of the standardRoom object
            deluxeRoom.RoomNumber = Convert.ToInt32(roomnumberadd.Text);
            deluxeRoom.RoomPrice = Convert.ToDouble(roompriceadd.Text);
            deluxeRoom.OccupancyLimit = Convert.ToInt32(occupancylimitadd.Text);
            deluxeRoom.RoomStatus = roomstatusadd.Text;
            deluxeRoom.TypeOfView = typeofviewadd.Text;

            // create DeluxeRoomController instance
            DeluxeRoomController deluxeRoomController = new DeluxeRoomController();

            bool success = deluxeRoomController.AddDeluxeRoom(deluxeRoom);

            // checks if added to the database
            if (success == true)
            {
                // Add Transaction (Deluxe Room)
                Transaction transaction = new Transaction();

                transaction.TransactionType = "Add Deluxe Room";
                transaction.TransactionDate = DateTime.Now;
                transaction.TransactionTime = DateTime.Now.TimeOfDay;
                transaction.EmployeeName = UserSession.EmployeeName;

                TransactionController transactionController = new TransactionController();
                bool result = transactionController.AddTransaction(transaction);

                if (result)
                {
                    MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // show success message
                MessageBox.Show("Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // show error message
                MessageBox.Show("Failed to Add Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
        }

        // method to reset all fields
        private void Reset()
        {
            roomnumberadd.Clear();
            roompriceadd.Clear();
            occupancylimitadd.Clear();
            roomstatusadd.Clear();
            typeofviewadd.Clear();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
