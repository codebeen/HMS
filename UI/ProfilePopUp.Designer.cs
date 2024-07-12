namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class ProfilePopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePopUp));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RoundedCornerElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            ProfilePicturePopUp = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ViewProfileButton = new Guna.UI2.WinForms.Guna2Button();
            LogOutButton = new Guna.UI2.WinForms.Guna2Button();
            ProfileNamePopUp = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)ProfilePicturePopUp).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RoundedCornerElipse
            // 
            RoundedCornerElipse.BorderRadius = 25;
            RoundedCornerElipse.TargetControl = this;
            // 
            // ProfilePicturePopUp
            // 
            ProfilePicturePopUp.Anchor = AnchorStyles.None;
            ProfilePicturePopUp.BackgroundImage = (Image)resources.GetObject("ProfilePicturePopUp.BackgroundImage");
            ProfilePicturePopUp.BackgroundImageLayout = ImageLayout.Stretch;
            ProfilePicturePopUp.FillColor = Color.Transparent;
            ProfilePicturePopUp.ImageRotate = 0F;
            ProfilePicturePopUp.Location = new Point(158, 14);
            ProfilePicturePopUp.Margin = new Padding(0);
            ProfilePicturePopUp.Name = "ProfilePicturePopUp";
            ProfilePicturePopUp.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ProfilePicturePopUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProfilePicturePopUp.Size = new Size(70, 60);
            ProfilePicturePopUp.TabIndex = 0;
            ProfilePicturePopUp.TabStop = false;
            // 
            // ViewProfileButton
            // 
            ViewProfileButton.BorderColor = Color.Transparent;
            ViewProfileButton.BorderRadius = 10;
            ViewProfileButton.CustomizableEdges = customizableEdges6;
            ViewProfileButton.DisabledState.BorderColor = Color.DarkGray;
            ViewProfileButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ViewProfileButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ViewProfileButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ViewProfileButton.FillColor = Color.FromArgb(13, 22, 29);
            ViewProfileButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewProfileButton.ForeColor = Color.White;
            ViewProfileButton.ImageSize = new Size(20, 30);
            ViewProfileButton.Location = new Point(26, 121);
            ViewProfileButton.Margin = new Padding(3, 4, 3, 4);
            ViewProfileButton.Name = "ViewProfileButton";
            ViewProfileButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            ViewProfileButton.Size = new Size(340, 34);
            ViewProfileButton.TabIndex = 12;
            ViewProfileButton.Text = "View Profile";
            ViewProfileButton.Click += ViewProfileButton_Click_1;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.Silver;
            LogOutButton.BorderRadius = 10;
            LogOutButton.BorderThickness = 1;
            LogOutButton.CustomizableEdges = customizableEdges4;
            LogOutButton.DisabledState.BorderColor = Color.DarkGray;
            LogOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LogOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogOutButton.FillColor = Color.Transparent;
            LogOutButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.ForeColor = Color.Black;
            LogOutButton.ImageSize = new Size(20, 30);
            LogOutButton.Location = new Point(26, 163);
            LogOutButton.Margin = new Padding(3, 4, 3, 4);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.ShadowDecoration.CustomizableEdges = customizableEdges5;
            LogOutButton.Size = new Size(340, 28);
            LogOutButton.TabIndex = 13;
            LogOutButton.Text = "Log Out";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // ProfileNamePopUp
            // 
            ProfileNamePopUp.AutoSize = true;
            ProfileNamePopUp.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileNamePopUp.Location = new Point(113, 90);
            ProfileNamePopUp.Name = "ProfileNamePopUp";
            ProfileNamePopUp.Size = new Size(179, 18);
            ProfileNamePopUp.TabIndex = 14;
            ProfileNamePopUp.Text = "Miyuki Mharie Parocha";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(ProfilePicturePopUp);
            guna2Panel1.CustomizableEdges = customizableEdges2;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel1.Size = new Size(399, 87);
            guna2Panel1.TabIndex = 15;
            // 
            // ProfilePopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(399, 232);
            Controls.Add(guna2Panel1);
            Controls.Add(ProfileNamePopUp);
            Controls.Add(LogOutButton);
            Controls.Add(ViewProfileButton);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1270, 280);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProfilePopUp";
            StartPosition = FormStartPosition.Manual;
            Text = "ProfilePopUp";
            Load += ProfilePopUp_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePicturePopUp).EndInit();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundedCornerElipse;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfilePicturePopUp;
        private Guna.UI2.WinForms.Guna2Button ViewProfileButton;
        private Guna.UI2.WinForms.Guna2Button LogOutButton;
        private Label ProfileNamePopUp;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}