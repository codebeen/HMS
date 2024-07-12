namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class ErrorPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorPopUp));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ErrorIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ErrorMessage = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            SuspendLayout();
            // 
            // ErrorIcon
            // 
            ErrorIcon.BackgroundImage = (Image)resources.GetObject("ErrorIcon.BackgroundImage");
            ErrorIcon.BackgroundImageLayout = ImageLayout.Stretch;
            ErrorIcon.FillColor = Color.Transparent;
            ErrorIcon.ImageRotate = 0F;
            ErrorIcon.Location = new Point(63, 12);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ErrorIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ErrorIcon.Size = new Size(41, 43);
            ErrorIcon.TabIndex = 0;
            ErrorIcon.TabStop = false;
            ErrorIcon.Click += ErrorIcon_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorMessage.Location = new Point(122, 25);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(234, 21);
            ErrorMessage.TabIndex = 1;
            ErrorMessage.Text = "All fields must be filled out";
            ErrorMessage.Click += ErrorMessage_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = this;
            // 
            // ErrorPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 72);
            Controls.Add(ErrorMessage);
            Controls.Add(ErrorIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorPopUp";
            Text = "ErrorPopUp";
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ErrorIcon;
        private Label ErrorMessage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}