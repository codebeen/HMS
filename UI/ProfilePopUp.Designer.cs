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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RoundedCornerElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            ProfilePicturePopUp = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ViewProfileButton = new Guna.UI2.WinForms.Guna2Button();
            LogOutButton = new Guna.UI2.WinForms.Guna2Button();
            ProfileNamePopUp = new Label();
            ((System.ComponentModel.ISupportInitialize)ProfilePicturePopUp).BeginInit();
            SuspendLayout();
            // 
            // RoundedCornerElipse
            // 
            RoundedCornerElipse.BorderRadius = 25;
            RoundedCornerElipse.TargetControl = this;
            // 
            // ProfilePicturePopUp
            // 
            ProfilePicturePopUp.BackgroundImage = (Image)resources.GetObject("ProfilePicturePopUp.BackgroundImage");
            ProfilePicturePopUp.BackgroundImageLayout = ImageLayout.Stretch;
            ProfilePicturePopUp.FillColor = Color.Transparent;
            ProfilePicturePopUp.ImageRotate = 0F;
            ProfilePicturePopUp.Location = new Point(151, 20);
            ProfilePicturePopUp.Name = "ProfilePicturePopUp";
            ProfilePicturePopUp.ShadowDecoration.CustomizableEdges = customizableEdges5;
            ProfilePicturePopUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProfilePicturePopUp.Size = new Size(79, 71);
            ProfilePicturePopUp.TabIndex = 0;
            ProfilePicturePopUp.TabStop = false;
            // 
            // ViewProfileButton
            // 
            ViewProfileButton.BorderColor = Color.Transparent;
            ViewProfileButton.BorderRadius = 10;
            ViewProfileButton.CustomizableEdges = customizableEdges3;
            ViewProfileButton.DisabledState.BorderColor = Color.DarkGray;
            ViewProfileButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ViewProfileButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ViewProfileButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ViewProfileButton.FillColor = Color.FromArgb(13, 22, 29);
            ViewProfileButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewProfileButton.ForeColor = Color.White;
            ViewProfileButton.ImageSize = new Size(20, 30);
            ViewProfileButton.Location = new Point(38, 137);
            ViewProfileButton.Name = "ViewProfileButton";
            ViewProfileButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ViewProfileButton.Size = new Size(300, 25);
            ViewProfileButton.TabIndex = 12;
            ViewProfileButton.Text = "View Profile";
            ViewProfileButton.Click += ViewProfileButton_Click_1;
            // 
            // LogOutButton
            // 
            LogOutButton.BorderRadius = 10;
            LogOutButton.BorderThickness = 1;
            LogOutButton.CustomizableEdges = customizableEdges1;
            LogOutButton.DisabledState.BorderColor = Color.DarkGray;
            LogOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LogOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogOutButton.FillColor = Color.Transparent;
            LogOutButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.ForeColor = Color.Black;
            LogOutButton.ImageSize = new Size(20, 30);
            LogOutButton.Location = new Point(38, 171);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LogOutButton.Size = new Size(300, 25);
            LogOutButton.TabIndex = 13;
            LogOutButton.Text = "Log Out";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // ProfileNamePopUp
            // 
            ProfileNamePopUp.AutoSize = true;
            ProfileNamePopUp.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileNamePopUp.Location = new Point(101, 94);
            ProfileNamePopUp.Name = "ProfileNamePopUp";
            ProfileNamePopUp.Size = new Size(179, 18);
            ProfileNamePopUp.TabIndex = 14;
            ProfileNamePopUp.Text = "Miyuki Mharie Parocha";
            // 
            // ProfilePopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 230);
            Controls.Add(ProfileNamePopUp);
            Controls.Add(LogOutButton);
            Controls.Add(ViewProfileButton);
            Controls.Add(ProfilePicturePopUp);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1255, 280);
            Name = "ProfilePopUp";
            StartPosition = FormStartPosition.Manual;
            Text = "ProfilePopUp";
            Load += ProfilePopUp_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePicturePopUp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundedCornerElipse;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfilePicturePopUp;
        private Guna.UI2.WinForms.Guna2Button ViewProfileButton;
        private Guna.UI2.WinForms.Guna2Button LogOutButton;
        private Label ProfileNamePopUp;
    }
}