using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Standardroom : Form
    {
        // instance of StandardRoom to store the room to edit
        private StandardRoom standardRoom = new StandardRoom();

        public Standardroom()
        {
            InitializeComponent();
        }

        private void Standardroom_Load(object sender, EventArgs e)
        {
            try
            {

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                // reset the selected row
                standardRoom = null;

                // reset the visibility of enableEditButton and enableDeleteButton
                disableEditButton.BringToFront();
                disableDeleteButton.BringToFront();

                // display the content of gridview
                var standardRoomController = new StandardRoomController();
                var listStandardRoom = standardRoomController.GetStandardRooms();

                Standardroomgridview.Rows.Clear();

                foreach (var room in listStandardRoom)
                {
                    Standardroomgridview.Rows.Add(
                        room.RoomId,
                        room.RoomNumber,
                        room.RoomPrice,
                        room.OccupancyLimit,
                        room.BedType,
                        room.BathroomInclusion,
                        room.RoomStatus,
                        room.IsDeleted);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void enableEditButton_Click(object sender, EventArgs e)
        {
            // pass the room to edit
            SREditRoom editForm = new SREditRoom(standardRoom);
            editForm.ShowDialog();
            LoadData(); // Refresh data after editing a room
        }

        private void Addroomicon_Click(object sender, EventArgs e)
        {
            SRAddroom Addroom = new SRAddroom();
            Addroom.ShowDialog();
            LoadData(); // Refresh data after adding a room
        }

        private void enableDeleteButton_Click(object sender, EventArgs e)
        {
            // pass the room to delete
            Deleteroom deleteStandardRoom = new Deleteroom(standardRoom);
            deleteStandardRoom.ShowDialog();
            LoadData(); // Refresh data after editing a room
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            this.Close();
            Rooms_admin rooms = new Rooms_admin();
            rooms.Show();

        }

        private void Standardroomgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the row data and store it in variable
                var row = Standardroomgridview.Rows[e.RowIndex].Cells;

                // checks if the cell clicked is not null
                if (row != null)
                {
                    // get the room id
                    int roomId = Convert.ToInt32(row[0].Value);

                    // get the room number
                    int roomNumber = Convert.ToInt32(row[1].Value);

                    // get the room price
                    double roomPrice = Convert.ToDouble(row[2].Value);

                    // get the occupancy limit
                    int occupancyLimit = Convert.ToInt32(row[3].Value);

                    // get the bed type
                    string bedType = row[4].Value.ToString();

                    // get the bathroom inclusion
                    string bathroomInclusion = row[5].Value.ToString();

                    // get the room status
                    string roomStatus = row[6].Value.ToString();

                    // get the is deleted status
                    bool isDeleted = Convert.ToBoolean(row[7].Value);

                    // create an instance of StandardRoom
                    standardRoom = new StandardRoom
                    {
                        RoomId = roomId,
                        RoomNumber = roomNumber,
                        RoomPrice = roomPrice,
                        OccupancyLimit = occupancyLimit,
                        BedType = bedType,
                        BathroomInclusion = bathroomInclusion,
                        RoomStatus = roomStatus,
                        IsDeleted = isDeleted
                    };

                    // change the visibility of enableEditButton and enableDeleteButton
                    enableEditButton.BringToFront();
                    enableDeleteButton.BringToFront();
                }
                else
                {
                    // reset the visibility of enableEditButton and enableDeleteButton
                    disableEditButton.BringToFront();
                    disableDeleteButton.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
