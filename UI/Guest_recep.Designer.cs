namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Guest_recep
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            PanelforGuest = new Guna.UI2.WinForms.Guna2Panel();
            guestGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ModifyButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
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
            PanelforGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 28);
            label1.Name = "label1";
            label1.Size = new Size(295, 39);
            label1.TabIndex = 0;
            label1.Text = "Guest Information";
            // 
            // PanelforGuest
            // 
            PanelforGuest.BackColor = Color.White;
            PanelforGuest.Controls.Add(guestGridView);
            PanelforGuest.CustomizableEdges = customizableEdges1;
            PanelforGuest.Location = new Point(87, 80);
            PanelforGuest.Margin = new Padding(3, 2, 3, 2);
            PanelforGuest.Name = "PanelforGuest";
            PanelforGuest.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PanelforGuest.Size = new Size(1116, 360);
            PanelforGuest.TabIndex = 1;
            // 
            // guestGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guestGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guestGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guestGridView.ColumnHeadersHeight = 40;
            guestGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guestGridView.Columns.AddRange(new DataGridViewColumn[] { bookingID, roomID, guestID, roomNumber, guestName, roomType, noOfGuest, modeOfPayment, checkInDate, checkOutDate, bookingDate, status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guestGridView.DefaultCellStyle = dataGridViewCellStyle3;
            guestGridView.Dock = DockStyle.Fill;
            guestGridView.GridColor = Color.FromArgb(231, 229, 255);
            guestGridView.Location = new Point(0, 0);
            guestGridView.Name = "guestGridView";
            guestGridView.RowHeadersVisible = false;
            guestGridView.Size = new Size(1116, 360);
            guestGridView.TabIndex = 6;
            guestGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guestGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            guestGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guestGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guestGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guestGridView.ThemeStyle.BackColor = Color.White;
            guestGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guestGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guestGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guestGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guestGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guestGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guestGridView.ThemeStyle.HeaderStyle.Height = 40;
            guestGridView.ThemeStyle.ReadOnly = false;
            guestGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            guestGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guestGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guestGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guestGridView.ThemeStyle.RowsStyle.Height = 25;
            guestGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guestGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guestGridView.CellContentClick += guestGridView_CellContentClick;
            // 
            // ModifyButton
            // 
            ModifyButton.BorderRadius = 10;
            ModifyButton.CustomizableEdges = customizableEdges3;
            ModifyButton.DisabledState.BorderColor = Color.DarkGray;
            ModifyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ModifyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ModifyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ModifyButton.FillColor = Color.FromArgb(214, 164, 38);
            ModifyButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyButton.ForeColor = Color.White;
            ModifyButton.Location = new Point(1073, 459);
            ModifyButton.Margin = new Padding(3, 2, 3, 2);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ModifyButton.Size = new Size(116, 34);
            ModifyButton.TabIndex = 2;
            ModifyButton.Text = "Edit";
            ModifyButton.Click += ModifyButton_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = PanelforGuest;
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
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // Guest_recep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelforGuest);
            Controls.Add(ModifyButton);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Guest_recep";
            Size = new Size(1260, 509);
            Load += Guest_recep_Load;
            PanelforGuest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guestGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel PanelforGuest;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button ModifyButton;
        private Guna.UI2.WinForms.Guna2DataGridView guestGridView;
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