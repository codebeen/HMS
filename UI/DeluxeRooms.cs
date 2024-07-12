using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class DeluxeRooms : Form
    {
        private DeluxeRoom deluxeRoom = new DeluxeRoom();

        public DeluxeRooms()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            transparentpaneldeluxe.Controls.Clear();
            transparentpaneldeluxe.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void transparentpaneldeluxe_Paint(object sender, PaintEventArgs e)
        {
            transparentpaneldeluxe.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, transparentpaneldeluxe.ClientRectangle);
            }
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            Rooms_admin rooms = new Rooms_admin();
            rooms.Show();
            this.Hide();
        }

        private void Addroomicon_Click(object sender, EventArgs e)
        {
            DRAddroom drAddroom = new DRAddroom();
            drAddroom.ShowDialog();
            LoadData(); // refresh the gridview
        }

        private void Editbuttondeluxe_Click(object sender, EventArgs e)
        {
            DREditRoom dreditRoom = new DREditRoom(deluxeRoom);
            dreditRoom.ShowDialog();
            LoadData(); // refresh the gridview
        }

        private void Deletebuttondeluxe_Click(object sender, EventArgs e)
        {
            DeluxeRoomDelete delroom = new DeluxeRoomDelete(deluxeRoom);
            delroom.ShowDialog();
            LoadData(); // refresh the gridview
        }


        private void DeluxeRooms_Load(object sender, EventArgs e)
        {
            try
            {
                // reset the selected row
                deluxeRoom = null;
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
                // reset selected row
                deluxeRoom = null;

                // reset the visibility of edit and delete button
                disableEditButton.BringToFront();
                disableDeleteButton.BringToFront();

                // display the data
                var deluxeRoomController = new DeluxeRoomController();
                var listDeluxeRoom = deluxeRoomController.GetDeluxeRooms();

                deluxeroomgridview.Rows.Clear();

                foreach (var room in listDeluxeRoom)
                {
                    deluxeroomgridview.Rows.Add(
                        room.RoomId,
                        room.RoomNumber,
                        room.RoomPrice,
                        room.OccupancyLimit,
                        room.TypeOfView,
                        room.RoomStatus,
                        room.IsDeleted);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void deluxeroomgridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the row data and store it in variable
                var row = deluxeroomgridview.Rows[e.RowIndex].Cells;

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

                    // get the type of view
                    string typeOfView = row[4].Value.ToString();

                    // get the room status
                    string roomStatus = row[5].Value.ToString();

                    // get the is deleted status
                    bool isDeleted = Convert.ToBoolean(row[6].Value);

                    // create an instance of StandardRoom
                    deluxeRoom = new DeluxeRoom
                    {
                        RoomId = roomId,
                        RoomNumber = roomNumber,
                        RoomPrice = roomPrice,
                        OccupancyLimit = occupancyLimit,
                        TypeOfView = typeOfView,
                        RoomStatus = roomStatus,
                        IsDeleted = isDeleted
                    };

                    // change the visibility of enableEditButton and enableDeleteButton
                    enableEditButton.BringToFront();
                    enableDeleteButton.BringToFront();
                }
                else
                {
                    // reset the visibility of edit and delete button
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
