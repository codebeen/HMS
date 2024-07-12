namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class SuitesRoom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            headersuites = new Panel();
            philtext = new Label();
            QCTEXT = new Label();
            locationpic = new PictureBox();
            pictureBox1 = new PictureBox();
            transparentpanelsuites = new Panel();
            Addroomicon = new Panel();
            suitesroomgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            roomId = new DataGridViewTextBoxColumn();
            roomNumber = new DataGridViewTextBoxColumn();
            roomPrice = new DataGridViewTextBoxColumn();
            occupancyLimit = new DataGridViewTextBoxColumn();
            numberOfRooms = new DataGridViewTextBoxColumn();
            suiteType = new DataGridViewTextBoxColumn();
            roomStatus = new DataGridViewTextBoxColumn();
            isDeleted = new DataGridViewTextBoxColumn();
            disableDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            disableEditButton = new Guna.UI2.WinForms.Guna2Button();
            enableEditButton = new Guna.UI2.WinForms.Guna2Button();
            enableDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            Addroombutton = new Guna.UI2.WinForms.Guna2Button();
            Suitestext = new Label();
            backicon = new PictureBox();
            upperradius = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipsepanelinsuites = new Guna.UI2.WinForms.Guna2Elipse(components);
            headersuites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Addroomicon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suitesroomgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            SuspendLayout();
            // 
            // headersuites
            // 
            headersuites.BackColor = Color.FromArgb(13, 22, 29);
            headersuites.Controls.Add(philtext);
            headersuites.Controls.Add(QCTEXT);
            headersuites.Controls.Add(locationpic);
            headersuites.Controls.Add(pictureBox1);
            headersuites.Dock = DockStyle.Top;
            headersuites.Location = new Point(0, 0);
            headersuites.Margin = new Padding(3, 2, 3, 2);
            headersuites.Name = "headersuites";
            headersuites.Size = new Size(1213, 106);
            headersuites.TabIndex = 0;
            // 
            // philtext
            // 
            philtext.AutoSize = true;
            philtext.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            philtext.ForeColor = Color.White;
            philtext.Location = new Point(48, 74);
            philtext.Name = "philtext";
            philtext.Size = new Size(70, 17);
            philtext.TabIndex = 15;
            philtext.Text = "Philippines";
            // 
            // QCTEXT
            // 
            QCTEXT.AutoSize = true;
            QCTEXT.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QCTEXT.ForeColor = Color.White;
            QCTEXT.Location = new Point(48, 59);
            QCTEXT.Name = "QCTEXT";
            QCTEXT.Size = new Size(82, 17);
            QCTEXT.TabIndex = 14;
            QCTEXT.Text = "Quezon City.";
            // 
            // locationpic
            // 
            locationpic.Image = Properties.Resources.icons8_location_24;
            locationpic.Location = new Point(48, 35);
            locationpic.Margin = new Padding(3, 2, 3, 2);
            locationpic.Name = "locationpic";
            locationpic.Size = new Size(27, 22);
            locationpic.TabIndex = 13;
            locationpic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.headerpic_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1213, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // transparentpanelsuites
            // 
            transparentpanelsuites.BackColor = Color.DimGray;
            transparentpanelsuites.Dock = DockStyle.Top;
            transparentpanelsuites.Location = new Point(0, 106);
            transparentpanelsuites.Margin = new Padding(3, 2, 3, 2);
            transparentpanelsuites.Name = "transparentpanelsuites";
            transparentpanelsuites.Size = new Size(1213, 50);
            transparentpanelsuites.TabIndex = 1;
            transparentpanelsuites.Paint += transparentpanelsuites_Paint;
            // 
            // Addroomicon
            // 
            Addroomicon.BackColor = Color.White;
            Addroomicon.Controls.Add(suitesroomgridview);
            Addroomicon.Controls.Add(disableDeleteButton);
            Addroomicon.Controls.Add(disableEditButton);
            Addroomicon.Controls.Add(enableEditButton);
            Addroomicon.Controls.Add(enableDeleteButton);
            Addroomicon.Controls.Add(Addroombutton);
            Addroomicon.Controls.Add(Suitestext);
            Addroomicon.Controls.Add(backicon);
            Addroomicon.Dock = DockStyle.Fill;
            Addroomicon.Location = new Point(0, 156);
            Addroomicon.Margin = new Padding(3, 2, 3, 2);
            Addroomicon.Name = "Addroomicon";
            Addroomicon.Size = new Size(1213, 492);
            Addroomicon.TabIndex = 2;
            // 
            // suitesroomgridview
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            suitesroomgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            suitesroomgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            suitesroomgridview.ColumnHeadersHeight = 17;
            suitesroomgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            suitesroomgridview.Columns.AddRange(new DataGridViewColumn[] { roomId, roomNumber, roomPrice, occupancyLimit, numberOfRooms, suiteType, roomStatus, isDeleted });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            suitesroomgridview.DefaultCellStyle = dataGridViewCellStyle3;
            suitesroomgridview.GridColor = Color.FromArgb(231, 229, 255);
            suitesroomgridview.Location = new Point(42, 67);
            suitesroomgridview.Name = "suitesroomgridview";
            suitesroomgridview.RowHeadersVisible = false;
            suitesroomgridview.Size = new Size(1146, 379);
            suitesroomgridview.TabIndex = 17;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            suitesroomgridview.ThemeStyle.BackColor = Color.White;
            suitesroomgridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            suitesroomgridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            suitesroomgridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            suitesroomgridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            suitesroomgridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            suitesroomgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            suitesroomgridview.ThemeStyle.HeaderStyle.Height = 17;
            suitesroomgridview.ThemeStyle.ReadOnly = false;
            suitesroomgridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            suitesroomgridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            suitesroomgridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            suitesroomgridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            suitesroomgridview.ThemeStyle.RowsStyle.Height = 25;
            suitesroomgridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            suitesroomgridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            suitesroomgridview.CellContentClick += suitesroomgridview_CellContentClick_1;
            // 
            // roomId
            // 
            roomId.HeaderText = "Room Id";
            roomId.Name = "roomId";
            roomId.Visible = false;
            // 
            // roomNumber
            // 
            roomNumber.HeaderText = "Room Number";
            roomNumber.Name = "roomNumber";
            // 
            // roomPrice
            // 
            roomPrice.HeaderText = "Price";
            roomPrice.Name = "roomPrice";
            // 
            // occupancyLimit
            // 
            occupancyLimit.HeaderText = "Occupancy Limit";
            occupancyLimit.Name = "occupancyLimit";
            // 
            // numberOfRooms
            // 
            numberOfRooms.HeaderText = "Number of Rooms";
            numberOfRooms.Name = "numberOfRooms";
            // 
            // suiteType
            // 
            suiteType.HeaderText = "Suite Type";
            suiteType.Name = "suiteType";
            // 
            // roomStatus
            // 
            roomStatus.HeaderText = "RoomStatus";
            roomStatus.Name = "roomStatus";
            // 
            // isDeleted
            // 
            isDeleted.HeaderText = "Is Deleted";
            isDeleted.Name = "isDeleted";
            isDeleted.Visible = false;
            // 
            // disableDeleteButton
            // 
            disableDeleteButton.BorderRadius = 10;
            disableDeleteButton.CustomizableEdges = customizableEdges1;
            disableDeleteButton.DisabledState.BorderColor = Color.DarkGray;
            disableDeleteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            disableDeleteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            disableDeleteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            disableDeleteButton.FillColor = Color.DarkGray;
            disableDeleteButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            disableDeleteButton.ForeColor = Color.White;
            disableDeleteButton.Location = new Point(1019, 449);
            disableDeleteButton.Margin = new Padding(3, 2, 3, 2);
            disableDeleteButton.Name = "disableDeleteButton";
            disableDeleteButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            disableDeleteButton.Size = new Size(116, 34);
            disableDeleteButton.TabIndex = 14;
            disableDeleteButton.Text = "Delete";
            // 
            // disableEditButton
            // 
            disableEditButton.BorderRadius = 10;
            disableEditButton.CustomizableEdges = customizableEdges3;
            disableEditButton.DisabledState.BorderColor = Color.DarkGray;
            disableEditButton.DisabledState.CustomBorderColor = Color.DarkGray;
            disableEditButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            disableEditButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            disableEditButton.FillColor = Color.DarkGray;
            disableEditButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            disableEditButton.ForeColor = Color.White;
            disableEditButton.Location = new Point(892, 449);
            disableEditButton.Margin = new Padding(3, 2, 3, 2);
            disableEditButton.Name = "disableEditButton";
            disableEditButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            disableEditButton.Size = new Size(116, 34);
            disableEditButton.TabIndex = 13;
            disableEditButton.Text = "Edit";
            // 
            // enableEditButton
            // 
            enableEditButton.BorderRadius = 10;
            enableEditButton.CustomizableEdges = customizableEdges5;
            enableEditButton.DisabledState.BorderColor = Color.DarkGray;
            enableEditButton.DisabledState.CustomBorderColor = Color.DarkGray;
            enableEditButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            enableEditButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            enableEditButton.FillColor = Color.FromArgb(214, 164, 38);
            enableEditButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enableEditButton.ForeColor = Color.White;
            enableEditButton.Location = new Point(892, 449);
            enableEditButton.Margin = new Padding(3, 2, 3, 2);
            enableEditButton.Name = "enableEditButton";
            enableEditButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            enableEditButton.Size = new Size(116, 34);
            enableEditButton.TabIndex = 11;
            enableEditButton.Text = "Edit";
            enableEditButton.Click += enableEditButton_Click_1;
            // 
            // enableDeleteButton
            // 
            enableDeleteButton.BorderRadius = 10;
            enableDeleteButton.CustomizableEdges = customizableEdges7;
            enableDeleteButton.DisabledState.BorderColor = Color.DarkGray;
            enableDeleteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            enableDeleteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            enableDeleteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            enableDeleteButton.FillColor = Color.FromArgb(126, 6, 6);
            enableDeleteButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enableDeleteButton.ForeColor = Color.White;
            enableDeleteButton.Location = new Point(1019, 449);
            enableDeleteButton.Margin = new Padding(3, 2, 3, 2);
            enableDeleteButton.Name = "enableDeleteButton";
            enableDeleteButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            enableDeleteButton.Size = new Size(116, 34);
            enableDeleteButton.TabIndex = 12;
            enableDeleteButton.Text = "Delete";
            enableDeleteButton.Click += enableDeleteButton_Click;
            // 
            // Addroombutton
            // 
            Addroombutton.BorderRadius = 10;
            Addroombutton.CustomizableEdges = customizableEdges9;
            Addroombutton.DisabledState.BorderColor = Color.DarkGray;
            Addroombutton.DisabledState.CustomBorderColor = Color.DarkGray;
            Addroombutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Addroombutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Addroombutton.FillColor = Color.FromArgb(55, 73, 7);
            Addroombutton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addroombutton.ForeColor = Color.White;
            Addroombutton.Location = new Point(1019, 28);
            Addroombutton.Margin = new Padding(3, 2, 3, 2);
            Addroombutton.Name = "Addroombutton";
            Addroombutton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Addroombutton.Size = new Size(175, 34);
            Addroombutton.TabIndex = 9;
            Addroombutton.Text = "Add Room";
            Addroombutton.Click += Addroombutton_Click;
            // 
            // Suitestext
            // 
            Suitestext.AutoSize = true;
            Suitestext.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Suitestext.Location = new Point(93, 34);
            Suitestext.Name = "Suitestext";
            Suitestext.Size = new Size(55, 19);
            Suitestext.TabIndex = 2;
            Suitestext.Text = "Suites ";
            // 
            // backicon
            // 
            backicon.Image = Properties.Resources.icons8_back_64;
            backicon.Location = new Point(42, 28);
            backicon.Margin = new Padding(3, 2, 3, 2);
            backicon.Name = "backicon";
            backicon.Size = new Size(33, 28);
            backicon.SizeMode = PictureBoxSizeMode.Zoom;
            backicon.TabIndex = 1;
            backicon.TabStop = false;
            backicon.Click += backicon_Click;
            // 
            // upperradius
            // 
            upperradius.BorderRadius = 10;
            // 
            // guna2Elipsepanelinsuites
            // 
            guna2Elipsepanelinsuites.BorderRadius = 10;
            // 
            // SuitesRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 648);
            Controls.Add(Addroomicon);
            Controls.Add(transparentpanelsuites);
            Controls.Add(headersuites);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SuitesRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suites Rooms";
            WindowState = FormWindowState.Maximized;
            Load += SuitesRoom_Load;
            headersuites.ResumeLayout(false);
            headersuites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Addroomicon.ResumeLayout(false);
            Addroomicon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)suitesroomgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headersuites;
        private Panel transparentpanelsuites;
        private PictureBox pictureBox1;
        private PictureBox locationpic;
        private Label QCTEXT;
        private Label philtext;
        private Panel Addroomicon;
        private PictureBox backicon;
        private Label Suitestext;
        private Guna.UI2.WinForms.Guna2Button Addroombutton;
        private Guna.UI2.WinForms.Guna2Elipse upperradius;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipsepanelinsuites;
        private Guna.UI2.WinForms.Guna2Button enableDeleteButton;
        private Guna.UI2.WinForms.Guna2Button enableEditButton;
        private Guna.UI2.WinForms.Guna2Button disableEditButton;
        private Guna.UI2.WinForms.Guna2Button disableDeleteButton;
        private Guna.UI2.WinForms.Guna2DataGridView suitesroomgridview;
        private DataGridViewTextBoxColumn roomId;
        private DataGridViewTextBoxColumn roomNumber;
        private DataGridViewTextBoxColumn roomPrice;
        private DataGridViewTextBoxColumn occupancyLimit;
        private DataGridViewTextBoxColumn numberOfRooms;
        private DataGridViewTextBoxColumn suiteType;
        private DataGridViewTextBoxColumn roomStatus;
        private DataGridViewTextBoxColumn isDeleted;
    }
}