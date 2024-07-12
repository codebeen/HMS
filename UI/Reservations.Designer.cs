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
            components = new System.ComponentModel.Container();
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
            isCancelled = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)ReservationGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBar
            // 
            SearchBar.Anchor = AnchorStyles.Top;
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
            SearchBar.Location = new Point(1039, 20);
            SearchBar.Margin = new Padding(3, 5, 3, 5);
            SearchBar.Name = "SearchBar";
            SearchBar.PasswordChar = '\0';
            SearchBar.PlaceholderForeColor = Color.Gray;
            SearchBar.PlaceholderText = "Search by guest, reservation";
            SearchBar.SelectedText = "";
            SearchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchBar.Size = new Size(336, 49);
            SearchBar.TabIndex = 0;
            SearchBar.TextChanged += SearchBar_TextChanged_1;
            SearchBar.KeyDown += SearchBar_KeyDown;
            // 
            // ReservationCalendar
            // 
            ReservationCalendar.Anchor = AnchorStyles.Top;
            ReservationCalendar.BorderRadius = 10;
            ReservationCalendar.Checked = true;
            ReservationCalendar.CustomizableEdges = customizableEdges3;
            ReservationCalendar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReservationCalendar.ForeColor = Color.WhiteSmoke;
            ReservationCalendar.Format = DateTimePickerFormat.Custom;
            ReservationCalendar.HoverState.FillColor = Color.FromArgb(13, 22, 29);
            ReservationCalendar.Location = new Point(64, 20);
            ReservationCalendar.Margin = new Padding(3, 4, 3, 4);
            ReservationCalendar.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ReservationCalendar.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ReservationCalendar.Name = "ReservationCalendar";
            ReservationCalendar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ReservationCalendar.Size = new Size(336, 49);
            ReservationCalendar.TabIndex = 1;
            ReservationCalendar.TextOffset = new Point(10, 0);
            ReservationCalendar.Value = new DateTime(2024, 7, 5, 0, 0, 0, 0);
            ReservationCalendar.ValueChanged += ReservationCalendar_ValueChanged;
            // 
            // ReservationEditBttn
            // 
            ReservationEditBttn.Anchor = AnchorStyles.Bottom;
            ReservationEditBttn.BorderRadius = 10;
            ReservationEditBttn.CustomizableEdges = customizableEdges5;
            ReservationEditBttn.DisabledState.BorderColor = Color.DarkGray;
            ReservationEditBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReservationEditBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReservationEditBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReservationEditBttn.FillColor = Color.FromArgb(214, 164, 38);
            ReservationEditBttn.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            ReservationEditBttn.ForeColor = Color.White;
            ReservationEditBttn.Location = new Point(1113, 626);
            ReservationEditBttn.Margin = new Padding(3, 4, 3, 4);
            ReservationEditBttn.Name = "ReservationEditBttn";
            ReservationEditBttn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ReservationEditBttn.Size = new Size(125, 40);
            ReservationEditBttn.TabIndex = 3;
            ReservationEditBttn.Text = "Edit";
            ReservationEditBttn.Click += ReservationEditBttn_Click;
            // 
            // ReservationCancelBttn
            // 
            ReservationCancelBttn.Anchor = AnchorStyles.Bottom;
            ReservationCancelBttn.BorderRadius = 10;
            ReservationCancelBttn.CustomizableEdges = customizableEdges7;
            ReservationCancelBttn.DisabledState.BorderColor = Color.DarkGray;
            ReservationCancelBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReservationCancelBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReservationCancelBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReservationCancelBttn.FillColor = Color.FromArgb(126, 6, 6);
            ReservationCancelBttn.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            ReservationCancelBttn.ForeColor = Color.White;
            ReservationCancelBttn.Location = new Point(1247, 626);
            ReservationCancelBttn.Margin = new Padding(3, 4, 3, 4);
            ReservationCancelBttn.Name = "ReservationCancelBttn";
            ReservationCancelBttn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ReservationCancelBttn.Size = new Size(125, 40);
            ReservationCancelBttn.TabIndex = 4;
            ReservationCancelBttn.Text = "Cancel";
            ReservationCancelBttn.Click += ReservationCancelBttn_Click;
            // 
            // ReservationGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ReservationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ReservationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ReservationGridView.ColumnHeadersHeight = 40;
            ReservationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ReservationGridView.Columns.AddRange(new DataGridViewColumn[] { bookingID, roomID, guestID, roomNumber, guestName, roomType, noOfGuest, modeOfPayment, checkInDate, checkOutDate, bookingDate, isCancelled });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ReservationGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ReservationGridView.Dock = DockStyle.Fill;
            ReservationGridView.GridColor = Color.FromArgb(231, 229, 255);
            ReservationGridView.Location = new Point(0, 0);
            ReservationGridView.Margin = new Padding(3, 4, 3, 4);
            ReservationGridView.Name = "ReservationGridView";
            ReservationGridView.RowHeadersVisible = false;
            ReservationGridView.RowHeadersWidth = 51;
            ReservationGridView.RowTemplate.Height = 25;
            ReservationGridView.Size = new Size(1307, 542);
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
            bookingID.MinimumWidth = 6;
            bookingID.Name = "bookingID";
            bookingID.Visible = false;
            // 
            // roomID
            // 
            roomID.HeaderText = "Room ID";
            roomID.MinimumWidth = 6;
            roomID.Name = "roomID";
            roomID.Visible = false;
            // 
            // guestID
            // 
            guestID.HeaderText = "Guest ID";
            guestID.MinimumWidth = 6;
            guestID.Name = "guestID";
            guestID.Visible = false;
            // 
            // roomNumber
            // 
            roomNumber.HeaderText = "Room Number";
            roomNumber.MinimumWidth = 6;
            roomNumber.Name = "roomNumber";
            // 
            // guestName
            // 
            guestName.HeaderText = "Guest Name";
            guestName.MinimumWidth = 6;
            guestName.Name = "guestName";
            // 
            // roomType
            // 
            roomType.HeaderText = "Room Type";
            roomType.MinimumWidth = 6;
            roomType.Name = "roomType";
            // 
            // noOfGuest
            // 
            noOfGuest.HeaderText = "Number of Occupants";
            noOfGuest.MinimumWidth = 6;
            noOfGuest.Name = "noOfGuest";
            // 
            // modeOfPayment
            // 
            modeOfPayment.HeaderText = "Mode of Payment";
            modeOfPayment.MinimumWidth = 6;
            modeOfPayment.Name = "modeOfPayment";
            // 
            // checkInDate
            // 
            checkInDate.HeaderText = "Check In Date";
            checkInDate.MinimumWidth = 6;
            checkInDate.Name = "checkInDate";
            // 
            // checkOutDate
            // 
            checkOutDate.HeaderText = "Check Out Date";
            checkOutDate.MinimumWidth = 6;
            checkOutDate.Name = "checkOutDate";
            // 
            // bookingDate
            // 
            bookingDate.HeaderText = "Booking Date";
            bookingDate.MinimumWidth = 6;
            bookingDate.Name = "bookingDate";
            // 
            // isCancelled
            // 
            isCancelled.HeaderText = "IsCancelled";
            isCancelled.MinimumWidth = 6;
            isCancelled.Name = "isCancelled";
            isCancelled.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(ReservationGridView);
            panel1.Location = new Point(67, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 542);
            panel1.TabIndex = 6;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = ReservationGridView;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(ReservationCancelBttn);
            Controls.Add(ReservationEditBttn);
            Controls.Add(ReservationCalendar);
            Controls.Add(SearchBar);
            Controls.Add(panel1);
            Name = "Reservations";
            Size = new Size(1440, 679);
            Load += Reservations_Load;
            ((System.ComponentModel.ISupportInitialize)ReservationGridView).EndInit();
            panel1.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn isCancelled;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
