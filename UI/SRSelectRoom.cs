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

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class SRSelectRoom : Form
    {
        private Form_receptionist parentForm;
        private DateTime checkinDate;
        private DateTime checkoutDate;
        private int selectedRoomId;
        private int numberOfGuests;
        private string roomType = "Standard Room";

        public SRSelectRoom()
        {
            InitializeComponent();

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void InitializeParentForm()
        {
            parentForm = new Form_receptionist();  // Create an instance of form1
        }

        private void SRNavback_Click(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);

            // Close the parent form
            Form parentForm = this.FindForm();
            this.Hide();
        }
        /*
        private void SRSelectRoom_Load(object sender, EventArgs e)
        {
            {
                Booknow booknow = new Booknow(); // Create an instance of Booknow
                addUserControl(uc); // Add Booknow to form1
            }
        }
        */

        private void NextNav_Click(object sender, EventArgs e)
        {
            try
            {
                // check if the user selected a room
                if (selectedRoomId != 0)
                {
                    // get the room status of the selected room
                    var roomStatus = new DataContext().Rooms.Find(selectedRoomId).RoomStatus.ToLower();

                    // proceed if selected room id is available, if not ask the user to choose again
                    if (roomStatus == "available")
                    {
                        // create a new booking
                        Booking booking = new Booking();
                        booking.CheckInDate = checkinDate;
                        booking.CheckOutDate = checkoutDate;
                        booking.BookingDate = DateTime.Now;
                        booking.NumberOfGuest = numberOfGuests;
                        booking.RoomId = selectedRoomId;
                        booking.RoomType = roomType;
                        booking.Status = "Upcoming";

                        // navigate to the next page
                        this.Close();
                        ContactInfo contactInfo = new ContactInfo(selectedRoomId, booking);
                        contactInfo.Show();
                    }
                    else if (roomStatus == "occupied")
                    {
                        MessageBox.Show("Room is currently occupied. Please select another room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (roomStatus == "under maintenance")
                    {
                        MessageBox.Show("Room is currently under maintenance. Please select another room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception("Please select a room first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SRSelectRoom_Load(object sender, EventArgs e)
        {
            try
            {
                // assign values to date time picker
                CheckinDate.Value = DateTime.Now;
                CheckoutDate.Value = DateTime.Now;


                // reset dates
                checkinDate = DateTime.Now;
                checkoutDate = DateTime.Now;

                // load the available rooms
                LoadAvailableRooms(checkinDate, checkoutDate);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableRooms(DateTime? checkInDate, DateTime? checkOutDate, int numberOfGuest = 1)
        {
            try
            {
                // reset the selectedRoomId
                selectedRoomId = 0;
                numberOfGuests = numberOfGuest;

                // load room numbers that are available depending on the checkin and checkout date that was selected
                using (var context = new DataContext())
                {
                    //get the available rooms that can accomodate number of guest and does not overlap to existing checkin and checkout date on that room
                    var availableRooms = context.Rooms
                        .OfType<StandardRoom>()
                        .Where(sr => !sr.IsDeleted && sr.OccupancyLimit >= numberOfGuest)
                        .ToList()
                        /*
                        .Where(r => !context.Bookings
                            .Where(b => b.RoomId == r.RoomId && !b.IsCancelled)
                            .Any(b => (checkInDate >= b.CheckInDate && checkInDate <= b.CheckOutDate) ||
                                      (checkOutDate >= b.CheckInDate && checkOutDate <= b.CheckOutDate) ||
                                      (checkInDate <= b.CheckInDate && checkOutDate >= b.CheckOutDate)))
                        */
                        .Select(r => new
                        {
                            RoomId = r.RoomId,
                            RoomNumber = r.RoomNumber,
                            RoomStatus = r.RoomStatus
                        })
                        .ToList();


                    // clear the existing controls in the panel
                    standardRoomPanel.Controls.Clear();

                    // set the properties for each room representation
                    int numberOfColumns = 10;
                    int rowIndex = 0;
                    int columnIndex = 0;
                    int roomWidth = 50;
                    int roomHeight = 50;
                    int padding = 10; // distance between each room representation

                    // loop through the available rooms and create a representation for each room
                    foreach (var room in availableRooms)
                    {
                        // create button to represent the room
                        Button roomButton = new Button();
                        roomButton.Size = new Size(roomWidth, roomHeight);
                        roomButton.TextAlign = ContentAlignment.MiddleCenter;
                        roomButton.Text = room.RoomNumber.ToString();

                        // set the background color based on the status
                        string status = room.RoomStatus.ToLower();
                        switch (status)
                        {
                            case "available":
                                roomButton.BackColor = Color.Green;
                                break;
                            case "occupied":
                                roomButton.BackColor = Color.Maroon;
                                break;
                            case "under maintenance":
                                roomButton.BackColor = Color.Gray;
                                break;
                            default:
                                roomButton.BackColor = Color.White;
                                break;
                        }

                        // calculate position of the room representation
                        int xPosition = columnIndex * (roomWidth + padding);
                        int yPosition = rowIndex * (roomHeight + padding);
                        roomButton.Location = new Point(xPosition, yPosition);

                        // Add the button to the panel
                        standardRoomPanel.Controls.Add(roomButton);

                        // update rowIndex and columnIndex
                        columnIndex++;
                        if (columnIndex == numberOfColumns)
                        {
                            columnIndex = 0;
                            rowIndex++;
                        }

                        // add click event handler to handle room selection
                        roomButton.Click += (sender, e) => RoomButton_Click(sender, e, room.RoomId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RoomButton_Click(object sender, EventArgs e, int roomId)
        {
            // assign the roomId to the selectedRoomId variable
            selectedRoomId = roomId;
        }

        private void CheckinDate_ValueChanged_1(object sender, EventArgs e)
        {
            // Assign the selected date to the checkinDate variable
            checkinDate = CheckinDate.Value;
        }

        private void CheckoutDate_ValueChanged_1(object sender, EventArgs e)
        {
            // Assign the selected date to the checkOutDate variable
            checkoutDate = CheckoutDate.Value;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // get the number of guest
                numberOfGuests = Convert.ToInt32(numberOfGuestText.Text);

                // check if checkout date is greater than checkin date
                if (checkoutDate <= checkinDate)
                {
                    throw new Exception("Checkout date must be greater than checkin date.");
                }

                // update the room status based on filtered checkin and checkout date
                UpdateRoomStatus();

                // Reload the available rooms
                LoadAvailableRooms(checkinDate, checkoutDate, numberOfGuests);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // method to update the room status based on the filtered checkin and checkout date on that same room
        private void UpdateRoomStatus()
        {
            try
            {
                using (var context = new DataContext())
                {
                    // get all the rooms
                    var rooms = context.Rooms.ToList();

                    // loop through each room
                    foreach (var room in rooms)
                    {
                        // get the room status
                        var roomStatus = room.RoomStatus.ToLower();

                        // get the bookings that are not cancelled
                        var bookings = context.Bookings
                            .Where(b => b.RoomId == room.RoomId && (b.Status != "Cancelled" || b.Status != "Done"))
                            .ToList();

                        // loop through each booking
                        foreach (var booking in bookings)
                        {
                            // check if the checkin and checkout date overlaps to the existing booking
                            if ((checkinDate >= booking.CheckInDate && checkinDate <= booking.CheckOutDate) ||
                                (checkoutDate >= booking.CheckInDate && checkoutDate <= booking.CheckOutDate) ||
                                (checkinDate <= booking.CheckInDate && checkoutDate >= booking.CheckOutDate))
                            {
                                // update the room status to occupied
                                room.RoomStatus = "Occupied";
                            }
                            else
                            {
                                // update the room status to available
                                room.RoomStatus = "Available";
                            }
                        }
                    }

                    // save the changes
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}