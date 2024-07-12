using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class SRAddroom : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public SRAddroom()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // create instance of StandardRoom
                StandardRoom standardRoom = new StandardRoom();

                // assign the value of the textboxes to the properties of the standardRoom object
                standardRoom.RoomNumber = Convert.ToInt32(Roomnumberadd.Text);
                standardRoom.RoomPrice = Convert.ToDouble(Roompriceadd.Text);
                standardRoom.OccupancyLimit = Convert.ToInt32(occupancylimitadd.Text);
                standardRoom.RoomStatus = roomStatusadd.Text;
                standardRoom.BedType = bedTypeadd.Text;
                standardRoom.BathroomInclusion = bathroomInclusionadd.Text;

                // create standardRoomController instance 
                StandardRoomController standardRoomController = new StandardRoomController();

                bool success = standardRoomController.AddStandardRoom(standardRoom);

                // checks if added to the database
                if (success == true)
                {
                    
                    // Add Transaction (Standard Room)
                    Transaction transaction = new Transaction();

                    transaction.TransactionType = "Add Standard Room";
                    transaction.TransactionDate = DateTime.Now;
                    transaction.TransactionTime = DateTime.Now.TimeOfDay;
                    transaction.EmployeeName = UserSession.EmployeeName;

                    TransactionController transactionController = new TransactionController();
                    bool result = transactionController.AddTransaction(transaction);

                    if (result)
                    {
                        MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not added transac, add room");
                    }

                    // show success message
                    MessageBox.Show("Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // show error message
                    throw new Exception("Failed to Add Room");
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to reset all fields
        private void Reset()
        {
            Roomnumberadd.Clear();
            Roompriceadd.Clear();
            occupancylimitadd.Clear();
            roomStatusadd.Clear();
            bedTypeadd.Clear();
            bathroomInclusionadd.Clear();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
