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
    public partial class SuiteEditRoom : Form
    {
        private Suite suiteToEdit = new Suite();
        public SuiteEditRoom(Suite room)
        {
            InitializeComponent();
            suiteToEdit = room;
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuiteEditRoom_Load(object sender, EventArgs e)
        {
            try
            {
                // assign the values to the textboxes
                roomId.Text = suiteToEdit.RoomId.ToString();
                roomnumbersuites.Text = suiteToEdit.RoomNumber.ToString();
                Roompricesuites.Text = suiteToEdit.RoomPrice.ToString();
                Occupancyreatesuites.Text = suiteToEdit.OccupancyLimit.ToString();
                roomstatus.Text = suiteToEdit.RoomStatus;
                numberofrooms.Text = suiteToEdit.NumberOfRooms.ToString();
                suitetype.Text = suiteToEdit.SuiteType;
                isDeleted.Text = suiteToEdit.IsDeleted.ToString();
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
                Suite editSuiteRoom = new Suite();

                // assign the values to the property of editSuiteRoom object
                editSuiteRoom.RoomId = Convert.ToInt32(roomId.Text);
                editSuiteRoom.RoomNumber = Convert.ToInt32(roomnumbersuites.Text);
                editSuiteRoom.RoomPrice = Convert.ToDouble(Roompricesuites.Text);
                editSuiteRoom.OccupancyLimit = Convert.ToInt32(Occupancyreatesuites.Text);
                editSuiteRoom.RoomStatus = roomstatus.Text;
                editSuiteRoom.NumberOfRooms = Convert.ToInt32(numberofrooms.Text);
                editSuiteRoom.SuiteType = suitetype.Text;
                editSuiteRoom.IsDeleted = Convert.ToBoolean(isDeleted.Text);

                // create instance of SuiteRoomController
                SuiteRoomController suiteRoomController = new SuiteRoomController();
                // calls the update method
                bool success = suiteRoomController.EditSuiteRoom(editSuiteRoom);

                if (success)
                {
                    // Add Transaction (Suite Room)
                    Transaction transaction = new Transaction();

                    transaction.TransactionType = "Modify Suite Room";
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
