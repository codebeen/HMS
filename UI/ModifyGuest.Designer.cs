namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class ModifyGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyGuest));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            checkInDateTxt = new Label();
            label2 = new Label();
            PhoneNoLbl = new Label();
            CheckOutDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            Savebutton = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            NavBack = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NavBack).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.BorderColor = Color.Gray;
            guna2Panel1.Controls.Add(checkInDateTxt);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(PhoneNoLbl);
            guna2Panel1.Controls.Add(CheckOutDatePicker);
            guna2Panel1.Controls.Add(Savebutton);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(NavBack);
            guna2Panel1.CustomizableEdges = customizableEdges8;
            guna2Panel1.Location = new Point(56, 48);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Panel1.Size = new Size(678, 412);
            guna2Panel1.TabIndex = 0;
            // 
            // checkInDateTxt
            // 
            checkInDateTxt.AutoSize = true;
            checkInDateTxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInDateTxt.Location = new Point(265, 130);
            checkInDateTxt.Name = "checkInDateTxt";
            checkInDateTxt.Size = new Size(136, 21);
            checkInDateTxt.TabIndex = 46;
            checkInDateTxt.Text = "[Check In Date]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 188);
            label2.Name = "label2";
            label2.Size = new Size(139, 19);
            label2.TabIndex = 45;
            label2.Text = "Check Out Date: ";
            // 
            // PhoneNoLbl
            // 
            PhoneNoLbl.AutoSize = true;
            PhoneNoLbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNoLbl.Location = new Point(120, 130);
            PhoneNoLbl.Name = "PhoneNoLbl";
            PhoneNoLbl.Size = new Size(122, 19);
            PhoneNoLbl.TabIndex = 44;
            PhoneNoLbl.Text = "Check In Date:";
            // 
            // CheckOutDatePicker
            // 
            CheckOutDatePicker.BackColor = Color.Transparent;
            CheckOutDatePicker.BorderRadius = 5;
            CheckOutDatePicker.BorderThickness = 1;
            CheckOutDatePicker.Checked = true;
            CheckOutDatePicker.CheckedState.FillColor = Color.White;
            CheckOutDatePicker.CheckedState.ForeColor = Color.Black;
            CheckOutDatePicker.CustomFormat = "MM DD yyyy";
            CheckOutDatePicker.CustomizableEdges = customizableEdges1;
            CheckOutDatePicker.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckOutDatePicker.ForeColor = Color.Black;
            CheckOutDatePicker.Format = DateTimePickerFormat.Short;
            CheckOutDatePicker.Location = new Point(265, 179);
            CheckOutDatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            CheckOutDatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            CheckOutDatePicker.Name = "CheckOutDatePicker";
            CheckOutDatePicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CheckOutDatePicker.Size = new Size(200, 36);
            CheckOutDatePicker.TabIndex = 43;
            CheckOutDatePicker.TextAlign = HorizontalAlignment.Center;
            CheckOutDatePicker.Value = new DateTime(2024, 6, 11, 21, 44, 38, 836);
            CheckOutDatePicker.ValueChanged += CheckOutDatePicker_ValueChanged;
            // 
            // Savebutton
            // 
            Savebutton.BackColor = Color.Transparent;
            Savebutton.BorderRadius = 10;
            Savebutton.CustomizableEdges = customizableEdges3;
            Savebutton.DisabledState.BorderColor = Color.DarkGray;
            Savebutton.DisabledState.CustomBorderColor = Color.DarkGray;
            Savebutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Savebutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Savebutton.FillColor = Color.FromArgb(0, 64, 0);
            Savebutton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(249, 327);
            Savebutton.Name = "Savebutton";
            Savebutton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Savebutton.Size = new Size(210, 33);
            Savebutton.TabIndex = 42;
            Savebutton.Text = "Save changes";
            Savebutton.Click += Savebutton_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(13, 22, 29);
            guna2Panel2.Controls.Add(label1);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Location = new Point(120, 67);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(454, 31);
            guna2Panel2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(166, 8);
            label1.Name = "label1";
            label1.Size = new Size(109, 16);
            label1.TabIndex = 0;
            label1.Text = "Guest Information";
            // 
            // NavBack
            // 
            NavBack.BackgroundImageLayout = ImageLayout.Stretch;
            NavBack.Image = (Image)resources.GetObject("NavBack.Image");
            NavBack.ImageRotate = 0F;
            NavBack.Location = new Point(53, 39);
            NavBack.Name = "NavBack";
            NavBack.ShadowDecoration.CustomizableEdges = customizableEdges7;
            NavBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            NavBack.Size = new Size(44, 31);
            NavBack.TabIndex = 34;
            NavBack.TabStop = false;
            NavBack.Click += NavBack_Click;
            // 
            // ModifyGuest
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 510);
            Controls.Add(guna2Panel1);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModifyGuest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModifyGuest";
            Load += ModifyGuest_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NavBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox NavBack;
        private Guna.UI2.WinForms.Guna2Button Savebutton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker CheckOutDatePicker;
        private Label label2;
        private Label PhoneNoLbl;
        private Label checkInDateTxt;
    }
}