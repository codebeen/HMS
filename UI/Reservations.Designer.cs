namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Reservations
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            ReservationCalendar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ReservationEditBttn = new Guna.UI2.WinForms.Guna2Button();
            ReservationCancelBttn = new Guna.UI2.WinForms.Guna2Button();
            ReservationGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            bookingID = new DataGridViewTextBoxColumn();
            roomID = new DataGridViewTextBoxColumn();
            guestID = new DataGridViewTextBoxColumn();
            roomNumber = new DataGridViewTextBoxColumn();
            guestName = new DataGridViewTextBoxColumn();
            roomType = new DataGridViewTextBoxColumn();
            noOfGuest = new DataGridViewTextBoxColumn();
            modeOfPayment = new DataGridViewTextBoxColumn();
            checkInDate = new DataGridViewTextBoxColumn();
            checkOutDate = new DataGridViewTextBoxColumn();
            bookingDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ReservationGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.Control;
            SearchBar.BorderColor = Color.Black;
            SearchBar.BorderRadius = 10;
            SearchBar.CustomizableEdges = customizableEdges1;
            SearchBar.DefaultText = "";
            SearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.FillColor = SystemColors.Control;
            SearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBar.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBar.HoverState.BorderColor = Color.Black;
            SearchBar.IconLeft = (Image)resources.GetObject("SearchBar.IconLeft");
            SearchBar.IconLeftOffset = new Point(10, 0);
            SearchBar.Location = new Point(866, 35);
            SearchBar.Name = "SearchBar";
            SearchBar.PasswordChar = '\0';
            SearchBar.PlaceholderForeColor = Color.Gray;
            SearchBar.PlaceholderText = "Search by guest, reservation";
            SearchBar.SelectedText = "";
            SearchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchBar.Size = new Size(296, 32);
            SearchBar.TabIndex = 0;
            SearchBar.TextChanged += SearchBar_TextChanged_1;
            SearchBar.KeyDown += SearchBar_KeyDown;
            // 
            // ReservationCalendar
            // 
            ReservationCalendar.BorderRadius = 10;
            ReservationCalendar.Checked = true;
            ReservationCalendar.CustomizableEdges = customizableEdges3;
            ReservationCalendar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReservationCalendar.ForeColor = Color.WhiteSmoke;
            ReservationCalendar.Format = DateTimePickerFormat.Custom;
            ReservationCalendar.HoverState.FillColor = Color.FromArgb(13, 22, 29);
            ReservationCalendar.Location = new Point(108, 35);
            ReservationCalendar.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ReservationCalendar.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ReservationCalendar.Name = "ReservationCalendar";
            ReservationCalendar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ReservationCalendar.Size = new Size(186, 32);
            ReservationCalendar.TabIndex = 1;
            ReservationCalendar.TextOffset = new Point(10, 0);
            ReservationCalendar.Value = new DateTime(2024, 7, 5, 0, 0, 0, 0);
            ReservationCalendar.ValueChanged += ReservationCalendar_ValueChanged;
            // 
            // ReservationEditBttn
            // 
            ReservationEditBttn.BorderRadius = 10;
            ReservationEditBttn.CustomizableEdges = customizableEdges5;
            ReservationEditBttn.DisabledState.BorderColor = Color.DarkGray;
            ReservationEditBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReservationEditBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReservationEditBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReservationEditBttn.FillColor = Color.FromArgb(214, 164, 38);
            ReservationEditBttn.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            ReservationEditBttn.ForeColor = Color.White;
            ReservationEditBttn.Location = new Point(934, 460);
            ReservationEditBttn.Name = "ReservationEditBttn";
            ReservationEditBttn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ReservationEditBttn.Size = new Size(116, 34);
            ReservationEditBttn.TabIndex = 3;
            ReservationEditBttn.Text = "Edit";
            ReservationEditBttn.Click += ReservationEditBttn_Click;
            // 
            // ReservationCancelBttn
            // 
            ReservationCancelBttn.BorderRadius = 10;
            ReservationCancelBttn.CustomizableEdges = customizableEdges7;
            ReservationCancelBttn.DisabledState.BorderColor = Color.DarkGray;
            ReservationCancelBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReservationCancelBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReservationCancelBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReservationCancelBttn.FillColor = Color.FromArgb(126, 6, 6);
            ReservationCancelBttn.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            ReservationCancelBttn.ForeColor = Color.White;
            ReservationCancelBttn.Location = new Point(1073, 460);
            ReservationCancelBttn.Name = "ReservationCancelBttn";
            ReservationCancelBttn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ReservationCancelBttn.Size = new Size(116, 34);
            ReservationCancelBttn.TabIndex = 4;
            ReservationCancelBttn.Text = "Cancel";
            ReservationCancelBttn.Click += ReservationCancelBttn_Click;
            // 
            // ReservationGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ReservationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ReservationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ReservationGridView.ColumnHeadersHeight = 40;
            ReservationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ReservationGridView.Columns.AddRange(new DataGridViewColumn[] { bookingID, roomID, guestID, roomNumber, guestName, roomType, noOfGuest, modeOfPayment, checkInDate, checkOutDate, bookingDate, status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ReservationGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ReservationGridView.GridColor = Color.FromArgb(231, 229, 255);
            ReservationGridView.Location = new Point(72, 88);
            ReservationGridView.Name = "ReservationGridView";
            ReservationGridView.RowHeadersVisible = false;
            ReservationGridView.Size = new Size(1117, 332);
            ReservationGridView.TabIndex = 5;
            ReservationGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ReservationGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            ReservationGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ReservationGridView.ThemeStyle.BackColor = Color.White;
            ReservationGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ReservationGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ReservationGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ReservationGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ReservationGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ReservationGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ReservationGridView.ThemeStyle.HeaderStyle.Height = 40;
            ReservationGridView.ThemeStyle.ReadOnly = false;
            ReservationGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            ReservationGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ReservationGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ReservationGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ReservationGridView.ThemeStyle.RowsStyle.Height = 25;
            ReservationGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ReservationGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ReservationGridView.CellContentClick += ReservationGridView_CellContentClick;
            // 
            // bookingID
            // 
            bookingID.HeaderText = "Booking Id";
            bookingID.Name = "bookingID";
            bookingID.Visible = false;
            // 
            // roomID
            // 
            roomID.HeaderText = "Room ID";
            roomID.Name = "roomID";
            roomID.Visible = false;
            // 
            // guestID
            // 
            guestID.HeaderText = "Guest ID";
            guestID.Name = "guestID";
            guestID.Visible = false;
            // 
            // roomNumber
            // 
            roomNumber.HeaderText = "Room Number";
            roomNumber.Name = "roomNumber";
            // 
            // guestName
            // 
            guestName.HeaderText = "Guest Name";
            guestName.Name = "guestName";
            // 
            // roomType
            // 
            roomType.HeaderText = "Room Type";
            roomType.Name = "roomType";
            // 
            // noOfGuest
            // 
            noOfGuest.HeaderText = "Number of Occupants";
            noOfGuest.Name = "noOfGuest";
            // 
            // modeOfPayment
            // 
            modeOfPayment.HeaderText = "Mode of Payment";
            modeOfPayment.Name = "modeOfPayment";
            // 
            // checkInDate
            // 
            checkInDate.HeaderText = "Check In Date";
            checkInDate.Name = "checkInDate";
            // 
            // checkOutDate
            // 
            checkOutDate.HeaderText = "Check Out Date";
            checkOutDate.Name = "checkOutDate";
            // 
            // bookingDate
            // 
            bookingDate.HeaderText = "Booking Date";
            bookingDate.Name = "bookingDate";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(ReservationGridView);
            Controls.Add(ReservationCancelBttn);
            Controls.Add(ReservationEditBttn);
            Controls.Add(ReservationCalendar);
            Controls.Add(SearchBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reservations";
            Size = new Size(1260, 509);
            Load += Reservations_Load;
            ((System.ComponentModel.ISupportInitialize)ReservationGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReservationCalendar;
        private Guna.UI2.WinForms.Guna2Button ReservationEditBttn;
        private Guna.UI2.WinForms.Guna2Button ReservationCancelBttn;
        private Guna.UI2.WinForms.Guna2DataGridView ReservationGridView;
        private DataGridViewTextBoxColumn bookingID;
        private DataGridViewTextBoxColumn roomID;
        private DataGridViewTextBoxColumn guestID;
        private DataGridViewTextBoxColumn roomNumber;
        private DataGridViewTextBoxColumn guestName;
        private DataGridViewTextBoxColumn roomType;
        private DataGridViewTextBoxColumn noOfGuest;
        private DataGridViewTextBoxColumn modeOfPayment;
        private DataGridViewTextBoxColumn checkInDate;
        private DataGridViewTextBoxColumn checkOutDate;
        private DataGridViewTextBoxColumn bookingDate;
        private DataGridViewTextBoxColumn status;
    }
}