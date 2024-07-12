namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class EmailErrorPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailErrorPopUp));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ErrorLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ErrorMessage = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)ErrorLogo).BeginInit();
            SuspendLayout();
            // 
            // ErrorLogo
            // 
            ErrorLogo.BackgroundImage = (Image)resources.GetObject("ErrorLogo.BackgroundImage");
            ErrorLogo.BackgroundImageLayout = ImageLayout.Stretch;
            ErrorLogo.FillColor = Color.Transparent;
            ErrorLogo.ImageRotate = 0F;
            ErrorLogo.Location = new Point(31, 24);
            ErrorLogo.Name = "ErrorLogo";
            ErrorLogo.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ErrorLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ErrorLogo.Size = new Size(45, 45);
            ErrorLogo.TabIndex = 1;
            ErrorLogo.TabStop = false;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorMessage.Location = new Point(82, 27);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(220, 42);
            ErrorMessage.TabIndex = 4;
            ErrorMessage.Text = "Email address must be a\r\nvalid gmail address";
            ErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            ErrorMessage.Click += ErrorMessage_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = this;
            // 
            // EmailErrorPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 94);
            Controls.Add(ErrorMessage);
            Controls.Add(ErrorLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmailErrorPopUp";
            Text = "EmailErrorPopUp";
            ((System.ComponentModel.ISupportInitialize)ErrorLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ErrorLogo;
        private Label ErrorMessage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}