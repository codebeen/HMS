namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class PasswordChangeConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeConfirmation));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RoundedCornerElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            CheckPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            MessageText = new Label();
            ((System.ComponentModel.ISupportInitialize)CheckPicture).BeginInit();
            SuspendLayout();
            // 
            // RoundedCornerElipse
            // 
            RoundedCornerElipse.BorderRadius = 25;
            RoundedCornerElipse.TargetControl = this;
            // 
            // CheckPicture
            // 
            CheckPicture.BackgroundImage = (Image)resources.GetObject("CheckPicture.BackgroundImage");
            CheckPicture.BackgroundImageLayout = ImageLayout.Stretch;
            CheckPicture.FillColor = Color.Transparent;
            CheckPicture.ImageRotate = 0F;
            CheckPicture.Location = new Point(216, 80);
            CheckPicture.Margin = new Padding(3, 4, 3, 4);
            CheckPicture.Name = "CheckPicture";
            CheckPicture.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CheckPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CheckPicture.Size = new Size(131, 147);
            CheckPicture.TabIndex = 0;
            CheckPicture.TabStop = false;
            // 
            // MessageText
            // 
            MessageText.AutoSize = true;
            MessageText.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MessageText.Location = new Point(194, 257);
            MessageText.Name = "MessageText";
            MessageText.Size = new Size(206, 28);
            MessageText.TabIndex = 3;
            MessageText.Text = "Password saved!";
            // 
            // PasswordChangeConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 400);
            Controls.Add(MessageText);
            Controls.Add(CheckPicture);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PasswordChangeConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordChangeConfirmation";
            Click += PasswordChangeConfirmation_Click;
            ((System.ComponentModel.ISupportInitialize)CheckPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundedCornerElipse;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CheckPicture;
        private Label MessageText;
    }
}