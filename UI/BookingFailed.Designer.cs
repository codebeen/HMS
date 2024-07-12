namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class BookingFailed
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingFailed));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            okButton = new Guna.UI2.WinForms.Guna2Button();
            LABELBOOK = new Label();
            ErrorLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)ErrorLogo).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.BorderRadius = 12;
            okButton.CustomizableEdges = customizableEdges1;
            okButton.DisabledState.BorderColor = Color.DarkGray;
            okButton.DisabledState.CustomBorderColor = Color.DarkGray;
            okButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            okButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            okButton.FillColor = Color.RoyalBlue;
            okButton.Font = new Font("Segoe UI", 9F);
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(151, 193);
            okButton.Name = "okButton";
            okButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            okButton.Size = new Size(95, 32);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.Click += okButton_Click;
            // 
            // LABELBOOK
            // 
            LABELBOOK.AutoSize = true;
            LABELBOOK.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABELBOOK.Location = new Point(137, 141);
            LABELBOOK.Name = "LABELBOOK";
            LABELBOOK.Size = new Size(128, 19);
            LABELBOOK.TabIndex = 4;
            LABELBOOK.Text = "Booking Failed!";
            // 
            // ErrorLogo
            // 
            ErrorLogo.BackgroundImage = (Image)resources.GetObject("ErrorLogo.BackgroundImage");
            ErrorLogo.BackgroundImageLayout = ImageLayout.Stretch;
            ErrorLogo.FillColor = Color.Transparent;
            ErrorLogo.ImageRotate = 0F;
            ErrorLogo.Location = new Point(154, 30);
            ErrorLogo.Margin = new Padding(3, 2, 3, 2);
            ErrorLogo.Name = "ErrorLogo";
            ErrorLogo.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ErrorLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ErrorLogo.Size = new Size(90, 90);
            ErrorLogo.TabIndex = 6;
            ErrorLogo.TabStop = false;
            // 
            // BookingFailed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 250);
            Controls.Add(ErrorLogo);
            Controls.Add(okButton);
            Controls.Add(LABELBOOK);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingFailed";
            Text = "BookingFailed";
            ((System.ComponentModel.ISupportInitialize)ErrorLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button okButton;
        private Label LABELBOOK;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ErrorLogo;
    }
}