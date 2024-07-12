namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Form_receptionist
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Header_recep = new Panel();
            philtext = new Label();
            QCTEXT = new Label();
            locationpic = new PictureBox();
            logoheader_recep = new PictureBox();
            panel_navigation_transparent_recep = new Panel();
            profilegroup = new Guna.UI2.WinForms.Guna2GroupBox();
            labelnameprofile = new Label();
            labeljobposition = new Label();
            circilephotoprofile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            labelname = new Label();
            Guest_button_recep = new Guna.UI2.WinForms.Guna2Button();
            Reservation_button_recep = new Guna.UI2.WinForms.Guna2Button();
            Booknow_button_recep = new Guna.UI2.WinForms.Guna2Button();
            Transaction_button_recep = new Guna.UI2.WinForms.Guna2Button();
            panelinformreceptionist_usercontrol = new Panel();
            Header_recep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoheader_recep).BeginInit();
            panel_navigation_transparent_recep.SuspendLayout();
            profilegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circilephotoprofile).BeginInit();
            SuspendLayout();
            // 
            // Header_recep
            // 
            Header_recep.BackColor = Color.FromArgb(13, 22, 29);
            Header_recep.Controls.Add(philtext);
            Header_recep.Controls.Add(QCTEXT);
            Header_recep.Controls.Add(locationpic);
            Header_recep.Controls.Add(logoheader_recep);
            Header_recep.Dock = DockStyle.Top;
            Header_recep.Location = new Point(0, 0);
            Header_recep.Name = "Header_recep";
            Header_recep.Size = new Size(1440, 141);
            Header_recep.TabIndex = 0;
            // 
            // philtext
            // 
            philtext.AutoSize = true;
            philtext.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            philtext.ForeColor = Color.White;
            philtext.Location = new Point(53, 85);
            philtext.Name = "philtext";
            philtext.Size = new Size(84, 20);
            philtext.TabIndex = 17;
            philtext.Text = "Philippines";
            // 
            // QCTEXT
            // 
            QCTEXT.AutoSize = true;
            QCTEXT.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QCTEXT.ForeColor = Color.White;
            QCTEXT.Location = new Point(53, 65);
            QCTEXT.Name = "QCTEXT";
            QCTEXT.Size = new Size(102, 20);
            QCTEXT.TabIndex = 16;
            QCTEXT.Text = "Quezon City.";
            // 
            // locationpic
            // 
            locationpic.Image = Properties.Resources.icons8_location_24;
            locationpic.Location = new Point(53, 33);
            locationpic.Name = "locationpic";
            locationpic.Size = new Size(31, 29);
            locationpic.TabIndex = 15;
            locationpic.TabStop = false;
            // 
            // logoheader_recep
            // 
            logoheader_recep.Dock = DockStyle.Fill;
            logoheader_recep.Image = Properties.Resources.headerpic_removebg_preview;
            logoheader_recep.Location = new Point(0, 0);
            logoheader_recep.Name = "logoheader_recep";
            logoheader_recep.Size = new Size(1440, 141);
            logoheader_recep.SizeMode = PictureBoxSizeMode.CenterImage;
            logoheader_recep.TabIndex = 0;
            logoheader_recep.TabStop = false;
            // 
            // panel_navigation_transparent_recep
            // 
            panel_navigation_transparent_recep.BackColor = Color.Black;
            panel_navigation_transparent_recep.Controls.Add(profilegroup);
            panel_navigation_transparent_recep.Controls.Add(Guest_button_recep);
            panel_navigation_transparent_recep.Controls.Add(Reservation_button_recep);
            panel_navigation_transparent_recep.Controls.Add(Booknow_button_recep);
            panel_navigation_transparent_recep.Controls.Add(Transaction_button_recep);
            panel_navigation_transparent_recep.Dock = DockStyle.Top;
            panel_navigation_transparent_recep.Location = new Point(0, 141);
            panel_navigation_transparent_recep.Name = "panel_navigation_transparent_recep";
            panel_navigation_transparent_recep.Size = new Size(1440, 80);
            panel_navigation_transparent_recep.TabIndex = 1;
            panel_navigation_transparent_recep.Paint += panel_navigation_transparent_recep_Paint;
            // 
            // profilegroup
            // 
            profilegroup.BackColor = Color.Transparent;
            profilegroup.BorderColor = Color.White;
            profilegroup.BorderRadius = 20;
            profilegroup.BorderThickness = 2;
            profilegroup.Controls.Add(labelnameprofile);
            profilegroup.Controls.Add(labeljobposition);
            profilegroup.Controls.Add(circilephotoprofile);
            profilegroup.Controls.Add(labelname);
            profilegroup.CustomBorderColor = Color.White;
            profilegroup.CustomBorderThickness = new Padding(4);
            profilegroup.CustomizableEdges = customizableEdges13;
            profilegroup.FillColor = Color.Transparent;
            profilegroup.Font = new Font("Segoe UI", 9F);
            profilegroup.ForeColor = Color.FromArgb(125, 137, 149);
            profilegroup.Location = new Point(1166, 3);
            profilegroup.Name = "profilegroup";
            profilegroup.ShadowDecoration.CustomizableEdges = customizableEdges14;
            profilegroup.Size = new Size(262, 68);
            profilegroup.TabIndex = 18;
            profilegroup.Click += profilegroup_Click;
            // 
            // labelnameprofile
            // 
            labelnameprofile.AutoSize = true;
            labelnameprofile.BackColor = Color.Transparent;
            labelnameprofile.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnameprofile.ForeColor = Color.White;
            labelnameprofile.Location = new Point(87, 17);
            labelnameprofile.Name = "labelnameprofile";
            labelnameprofile.Size = new Size(156, 17);
            labelnameprofile.TabIndex = 16;
            labelnameprofile.Text = "Miyuki Mharie Parocha ";
            labelnameprofile.Click += label1name_Click;
            // 
            // labeljobposition
            // 
            labeljobposition.AutoSize = true;
            labeljobposition.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeljobposition.ForeColor = Color.White;
            labeljobposition.Location = new Point(80, 34);
            labeljobposition.Name = "labeljobposition";
            labeljobposition.Size = new Size(175, 17);
            labeljobposition.TabIndex = 1;
            labeljobposition.Text = "miyukimharie@gmail.com";
            labeljobposition.Click += labelemail_Click;
            // 
            // circilephotoprofile
            // 
            circilephotoprofile.Image = Properties.Resources.profile;
            circilephotoprofile.ImageRotate = 0F;
            circilephotoprofile.Location = new Point(21, 5);
            circilephotoprofile.Name = "circilephotoprofile";
            circilephotoprofile.ShadowDecoration.CustomizableEdges = customizableEdges12;
            circilephotoprofile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            circilephotoprofile.Size = new Size(60, 55);
            circilephotoprofile.SizeMode = PictureBoxSizeMode.StretchImage;
            circilephotoprofile.TabIndex = 2;
            circilephotoprofile.TabStop = false;
            circilephotoprofile.Click += circilephotoprofile_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.BackColor = Color.Transparent;
            labelname.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelname.ForeColor = Color.White;
            labelname.Location = new Point(94, -18);
            labelname.Name = "labelname";
            labelname.Size = new Size(156, 17);
            labelname.TabIndex = 0;
            labelname.Text = "Miyuki Mharie Parocha ";
            // 
            // Guest_button_recep
            // 
            Guest_button_recep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            Guest_button_recep.CheckedState.CustomBorderColor = Color.FromArgb(119, 85, 50);
            Guest_button_recep.CheckedState.FillColor = Color.FromArgb(100, 223, 182, 89);
            Guest_button_recep.CustomBorderThickness = new Padding(0, 5, 0, 0);
            Guest_button_recep.CustomizableEdges = customizableEdges15;
            Guest_button_recep.DisabledState.BorderColor = Color.Yellow;
            Guest_button_recep.DisabledState.CustomBorderColor = Color.Lime;
            Guest_button_recep.DisabledState.FillColor = Color.Cyan;
            Guest_button_recep.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guest_button_recep.FillColor = Color.Transparent;
            Guest_button_recep.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guest_button_recep.ForeColor = Color.White;
            Guest_button_recep.HoverState.CustomBorderColor = Color.Gray;
            Guest_button_recep.HoverState.FillColor = Color.FromArgb(115, 115, 115, 90);
            Guest_button_recep.Location = new Point(600, 3);
            Guest_button_recep.Name = "Guest_button_recep";
            Guest_button_recep.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Guest_button_recep.Size = new Size(200, 77);
            Guest_button_recep.TabIndex = 5;
            Guest_button_recep.Text = "GUEST";
            Guest_button_recep.Click += Guest_button_recep_Click;
            // 
            // Reservation_button_recep
            // 
            Reservation_button_recep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            Reservation_button_recep.CheckedState.CustomBorderColor = Color.FromArgb(119, 85, 50);
            Reservation_button_recep.CheckedState.FillColor = Color.FromArgb(100, 223, 182, 89);
            Reservation_button_recep.CustomBorderThickness = new Padding(0, 5, 0, 0);
            Reservation_button_recep.CustomizableEdges = customizableEdges17;
            Reservation_button_recep.DisabledState.BorderColor = Color.Yellow;
            Reservation_button_recep.DisabledState.CustomBorderColor = Color.Lime;
            Reservation_button_recep.DisabledState.FillColor = Color.Cyan;
            Reservation_button_recep.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reservation_button_recep.FillColor = Color.Transparent;
            Reservation_button_recep.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reservation_button_recep.ForeColor = Color.White;
            Reservation_button_recep.HoverState.CustomBorderColor = Color.Gray;
            Reservation_button_recep.HoverState.FillColor = Color.FromArgb(115, 115, 115, 90);
            Reservation_button_recep.Location = new Point(400, 3);
            Reservation_button_recep.Name = "Reservation_button_recep";
            Reservation_button_recep.ShadowDecoration.CustomizableEdges = customizableEdges18;
            Reservation_button_recep.Size = new Size(200, 77);
            Reservation_button_recep.TabIndex = 5;
            Reservation_button_recep.Text = "RESERVATIONS";
            Reservation_button_recep.Click += Reservation_button_recep_Click;
            // 
            // Booknow_button_recep
            // 
            Booknow_button_recep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            Booknow_button_recep.CheckedState.CustomBorderColor = Color.FromArgb(119, 85, 50);
            Booknow_button_recep.CheckedState.FillColor = Color.FromArgb(100, 223, 182, 89);
            Booknow_button_recep.CustomBorderThickness = new Padding(0, 5, 0, 0);
            Booknow_button_recep.CustomizableEdges = customizableEdges19;
            Booknow_button_recep.DisabledState.BorderColor = Color.Yellow;
            Booknow_button_recep.DisabledState.CustomBorderColor = Color.Lime;
            Booknow_button_recep.DisabledState.FillColor = Color.Cyan;
            Booknow_button_recep.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Booknow_button_recep.FillColor = Color.Transparent;
            Booknow_button_recep.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Booknow_button_recep.ForeColor = Color.White;
            Booknow_button_recep.HoverState.CustomBorderColor = Color.Gray;
            Booknow_button_recep.HoverState.FillColor = Color.FromArgb(115, 115, 115, 90);
            Booknow_button_recep.Location = new Point(200, 0);
            Booknow_button_recep.Name = "Booknow_button_recep";
            Booknow_button_recep.ShadowDecoration.CustomizableEdges = customizableEdges20;
            Booknow_button_recep.Size = new Size(200, 77);
            Booknow_button_recep.TabIndex = 4;
            Booknow_button_recep.Text = "BOOK NOW";
            Booknow_button_recep.Click += Booknow_button_recep_Click;
            // 
            // Transaction_button_recep
            // 
            Transaction_button_recep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            Transaction_button_recep.Checked = true;
            Transaction_button_recep.CheckedState.CustomBorderColor = Color.FromArgb(119, 85, 50);
            Transaction_button_recep.CheckedState.FillColor = Color.FromArgb(100, 223, 182, 89);
            Transaction_button_recep.CustomBorderThickness = new Padding(0, 5, 0, 0);
            Transaction_button_recep.CustomizableEdges = customizableEdges21;
            Transaction_button_recep.DisabledState.BorderColor = Color.Yellow;
            Transaction_button_recep.DisabledState.CustomBorderColor = Color.Lime;
            Transaction_button_recep.DisabledState.FillColor = Color.Cyan;
            Transaction_button_recep.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Transaction_button_recep.FillColor = Color.Transparent;
            Transaction_button_recep.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transaction_button_recep.ForeColor = Color.White;
            Transaction_button_recep.HoverState.CustomBorderColor = Color.Gray;
            Transaction_button_recep.HoverState.FillColor = Color.FromArgb(115, 115, 115, 90);
            Transaction_button_recep.Location = new Point(0, 3);
            Transaction_button_recep.Name = "Transaction_button_recep";
            Transaction_button_recep.ShadowDecoration.CustomizableEdges = customizableEdges22;
            Transaction_button_recep.Size = new Size(200, 77);
            Transaction_button_recep.TabIndex = 3;
            Transaction_button_recep.Text = "TRANSACTIONS";
            Transaction_button_recep.Click += Transaction_button_recep_Click;
            // 
            // panelinformreceptionist_usercontrol
            // 
            panelinformreceptionist_usercontrol.Dock = DockStyle.Fill;
            panelinformreceptionist_usercontrol.Location = new Point(0, 221);
            panelinformreceptionist_usercontrol.Name = "panelinformreceptionist_usercontrol";
            panelinformreceptionist_usercontrol.Size = new Size(1440, 679);
            panelinformreceptionist_usercontrol.TabIndex = 2;
            panelinformreceptionist_usercontrol.Paint += panelinformreceptionist_usercontrol_Paint;
            // 
            // Form_receptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 900);
            Controls.Add(panelinformreceptionist_usercontrol);
            Controls.Add(panel_navigation_transparent_recep);
            Controls.Add(Header_recep);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_receptionist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_receptionist";
            Header_recep.ResumeLayout(false);
            Header_recep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoheader_recep).EndInit();
            panel_navigation_transparent_recep.ResumeLayout(false);
            profilegroup.ResumeLayout(false);
            profilegroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circilephotoprofile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header_recep;
        private Panel panel_navigation_transparent_recep;
        private PictureBox logoheader_recep;
        private PictureBox locationpic;
        private Label QCTEXT;
        private Label philtext;
        private Guna.UI2.WinForms.Guna2Button Guest_button_recep;
        private Guna.UI2.WinForms.Guna2Button Reservation_button_recep;
        private Guna.UI2.WinForms.Guna2Button Booknow_button_recep;
        private Guna.UI2.WinForms.Guna2Button Transaction_button_recep;
        private Guna.UI2.WinForms.Guna2GroupBox profilegroup;
        private Label labeljobposition;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circilephotoprofile;
        private Label labelname;
        private Label labelnameprofile;
        private Panel panelinformreceptionist_usercontrol;
    }
}