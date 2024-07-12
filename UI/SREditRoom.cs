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
    public partial class SREditRoom : Form
    {
        // instance of StandardRoom to store the room to edit
        private StandardRoom standardRoomToEdit = new StandardRoom();

        public SREditRoom(StandardRoom roomToEdit)
        {
            InitializeComponent();
            standardRoomToEdit = roomToEdit;
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                StandardRoom standardRoomEdit = new StandardRoom();

                // assign the values to the property of standardRoomEdit object
                standardRoomEdit.RoomId = Convert.ToInt32(roomId.Text);
                standardRoomEdit.RoomNumber = Convert.ToInt32(Roomnumberedit.Text);
                standardRoomEdit.RoomPrice = Convert.ToDouble(Roompriceedit.Text);
                standardRoomEdit.OccupancyLimit = Convert.ToInt32(Occupancylimitedit.Text);
                standardRoomEdit.RoomStatus = roomstatus.Text;
                standardRoomEdit.BedType = bedtype.Text;
                standardRoomEdit.BathroomInclusion = bathroominclusion.Text;
                standardRoomEdit.IsDeleted = Convert.ToBoolean(isDeleted.Text);

                // create instance of StandardRoomController
                StandardRoomController standardRoomController = new StandardRoomController();
                // calls the update method
                bool success = standardRoomController.EditStandardRoom(standardRoomEdit);

                if (success)
                {
                    // Add Transation (Modify SR)
                    Transaction transaction = new Transaction();

                    transaction.TransactionType = "Modify Standard Room";
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
                    MessageBox.Show("Failed to Update Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SREditRoom_Load(object sender, EventArgs e)
        {
            try
            {
                // assign the values to the textboxes
                roomId.Text = standardRoomToEdit.RoomId.ToString();
                Roomnumberedit.Text = standardRoomToEdit.RoomNumber.ToString();
                Roompriceedit.Text = standardRoomToEdit.RoomPrice.ToString();
                Occupancylimitedit.Text = standardRoomToEdit.OccupancyLimit.ToString();
                roomstatus.Text = standardRoomToEdit.RoomStatus;
                bedtype.Text = standardRoomToEdit.BedType;
                bathroominclusion.Text = standardRoomToEdit.BathroomInclusion;
                isDeleted.Text = standardRoomToEdit.IsDeleted.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
