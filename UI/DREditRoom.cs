using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.UI;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class DREditRoom : Form
    {
        private DeluxeRoom deluxeRoomToEdit = new DeluxeRoom();

        public DREditRoom(DeluxeRoom room)
        {
            InitializeComponent();
            deluxeRoomToEdit = room;
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DREditRoom_Load(object sender, EventArgs e)
        {
            try
            {
                // assign the values to the textboxes
                roomId.Text = deluxeRoomToEdit.RoomId.ToString();
                Roomnumberdeluxe.Text = deluxeRoomToEdit.RoomNumber.ToString();
                roompricedeluxe.Text = deluxeRoomToEdit.RoomPrice.ToString();
                occupancyratedeluxe.Text = deluxeRoomToEdit.OccupancyLimit.ToString();
                roomstatus.Text = deluxeRoomToEdit.RoomStatus;
                typeOfView.Text = deluxeRoomToEdit.TypeOfView;
                isDeleted.Text = deluxeRoomToEdit.IsDeleted.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DeluxeRoom editDeluxeRoom = new DeluxeRoom();

                // assign the values to the property of editDeluxeRoom object
                editDeluxeRoom.RoomId = Convert.ToInt32(roomId.Text);
                editDeluxeRoom.RoomNumber = Convert.ToInt32(Roomnumberdeluxe.Text);
                editDeluxeRoom.RoomPrice = Convert.ToDouble(roompricedeluxe.Text);
                editDeluxeRoom.OccupancyLimit = Convert.ToInt32(occupancyratedeluxe.Text);
                editDeluxeRoom.RoomStatus = roomstatus.Text;
                editDeluxeRoom.TypeOfView = typeOfView.Text;
                editDeluxeRoom.IsDeleted = Convert.ToBoolean(isDeleted.Text);

                // create instance of DeluxeRoomController
                DeluxeRoomController deluxeRoomController = new DeluxeRoomController();
                // calls the update method
                bool success = deluxeRoomController.EditDeluxeRoom(editDeluxeRoom);

                if (success)
                {
                    // Add Transaction for booking
                    Transaction transaction = new Transaction();

                    transaction.TransactionType = "Modify Deluxe Room";
                    transaction.TransactionDate = DateTime.Now;
                    transaction.TransactionTime = DateTime.Now.TimeOfDay;
                    transaction.EmployeeName = UserSession.EmployeeName;

                    TransactionController transactionController = new TransactionController();
                    bool result = transactionController.AddTransaction(transaction);

                    if (result)
                    {
                        MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Room Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    throw new Exception("Failed to Update Room");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
