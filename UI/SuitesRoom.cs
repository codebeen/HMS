using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class SuitesRoom : Form
    {
        private Suite suiteRoom = new Suite();
        public SuitesRoom()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            transparentpanelsuites.Controls.Clear();
            transparentpanelsuites.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void transparentpanelsuites_Paint(object sender, PaintEventArgs e)
        {
            transparentpanelsuites.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, transparentpanelsuites.ClientRectangle);
            }
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            Rooms_admin rooms = new Rooms_admin();
            rooms.Show();
            this.Hide();
        }

        private void Addroombutton_Click(object sender, EventArgs e)
        {
            SuiteAddroom suiteAddroom = new SuiteAddroom();
            suiteAddroom.ShowDialog();
            LoadData(); // refresh the data in gridview
        }


        public void SuitesRoom_Load(object sender, EventArgs e)
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
                suiteRoom = null;

                // reset the visibility of edit and delete button
                disableEditButton.BringToFront();
                disableDeleteButton.BringToFront();

                var suiteRoomController = new SuiteRoomController();
                var listSuiteRoom = suiteRoomController.GetSuiteRooms();

                suitesroomgridview.Rows.Clear();

                foreach (var room in listSuiteRoom)
                {
                    suitesroomgridview.Rows.Add(
                        room.RoomId,
                        room.RoomNumber,
                        room.RoomPrice,
                        room.OccupancyLimit,
                        room.NumberOfRooms,
                        room.SuiteType,
                        room.RoomStatus,
                        room.IsDeleted);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void suitesroomgridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the row data and store it in variable
                var row = suitesroomgridview.Rows[e.RowIndex].Cells;

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

                    // get the number of rooms
                    int numberOfRooms = Convert.ToInt32(row[4].Value);

                    // get the suite type
                    string suiteType = row[5].Value.ToString();

                    // get the room status
                    string roomStatus = row[6].Value.ToString();

                    // get the is deleted status
                    bool isDeleted = Convert.ToBoolean(row[7].Value);

                    // create an instance of StandardRoom
                    suiteRoom = new Suite
                    {
                        RoomId = roomId,
                        RoomNumber = roomNumber,
                        RoomPrice = roomPrice,
                        OccupancyLimit = occupancyLimit,
                        NumberOfRooms = numberOfRooms,
                        SuiteType = suiteType,
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

        private void enableEditButton_Click_1(object sender, EventArgs e)
        {
            SuiteEditRoom suiteeditRoom = new SuiteEditRoom(suiteRoom);
            suiteeditRoom.ShowDialog();
            LoadData(); // refresh the data in gridview
        }

        private void enableDeleteButton_Click(object sender, EventArgs e)
        {
            SuiteRoomDelete delroom = new SuiteRoomDelete(suiteRoom);
            delroom.ShowDialog();
            LoadData(); // refresh the data in gridview
        }
    }
}
