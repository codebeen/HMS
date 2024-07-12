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
    public partial class SuiteAddroom : Form
    {
        public SuiteAddroom()
        {
            InitializeComponent();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            // checks if all fields are empty
            if (roomnumber.Text == null)
            {
                MessageBox.Show("Room Number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roomnumber.Focus();
                return;
            }
            if (roomprice.Text == null)
            {
                MessageBox.Show("Room Price is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roomprice.Focus();
                return;
            }
            if (occupancylimit.Text == null)
            {
                MessageBox.Show("Occupancy Limit is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                occupancylimit.Focus();
                return;
            }
            if (roomstatus.Text == null)
            {
                MessageBox.Show("Room Status is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roomstatus.Focus();
                return;
            }
            if (numberofrooms.Text == null)
            {
                MessageBox.Show("Number of Rooms is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberofrooms.Focus();
                return;
            }
            if (suitetype.Text == null)
            {
                MessageBox.Show("Suite Type is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                suitetype.Focus();
                return;
            }


            // create instance of Suite
            Suite suiteRoom = new Suite();

            // assign the value of the textboxes to the properties of the suiteRoom object
            suiteRoom.RoomNumber = Convert.ToInt32(roomnumber.Text);
            suiteRoom.RoomPrice = Convert.ToDouble(roomprice.Text);
            suiteRoom.OccupancyLimit = Convert.ToInt32(occupancylimit.Text);
            suiteRoom.RoomStatus = roomstatus.Text;
            suiteRoom.NumberOfRooms = Convert.ToInt32(numberofrooms.Text);
            suiteRoom.SuiteType = suitetype.Text;

            // create SuiteRoomController instance
            SuiteRoomController suiteRoomController = new SuiteRoomController();

            bool success = suiteRoomController.AddSuiteRoom(suiteRoom);

            // checks if added to the database
            if (success == true)
            {
                // Add Transaction (Suite Room)
                Transaction transaction = new Transaction();

                transaction.TransactionType = "Add Suite Room";
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
            roomnumber.Clear();
            roomprice.Clear();
            occupancylimit.Clear();
            roomstatus.Clear();
            numberofrooms.Clear();
            suitetype.Clear();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
