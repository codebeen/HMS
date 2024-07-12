namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class LogOutPage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RoundedCornerElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            CancelButton = new Guna.UI2.WinForms.Guna2Button();
            LogOutButton = new Guna.UI2.WinForms.Guna2Button();
            Message = new Label();
            HeaderText = new Label();
            SuspendLayout();
            // 
            // RoundedCornerElipse
            // 
            RoundedCornerElipse.BorderRadius = 25;
            RoundedCornerElipse.TargetControl = this;
            // 
            // CancelButton
            // 
            CancelButton.BorderColor = Color.Transparent;
            CancelButton.BorderRadius = 10;
            CancelButton.CustomizableEdges = customizableEdges3;
            CancelButton.DisabledState.BorderColor = Color.DarkGray;
            CancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CancelButton.FillColor = Color.DarkGray;
            CancelButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.ImageSize = new Size(20, 30);
            CancelButton.Location = new Point(45, 202);
            CancelButton.Name = "CancelButton";
            CancelButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CancelButton.Size = new Size(185, 52);
            CancelButton.TabIndex = 12;
            CancelButton.Text = "CANCEL";
            CancelButton.Click += CancelButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BorderColor = Color.Transparent;
            LogOutButton.BorderRadius = 10;
            LogOutButton.CustomizableEdges = customizableEdges1;
            LogOutButton.DisabledState.BorderColor = Color.DarkGray;
            LogOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LogOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogOutButton.FillColor = Color.FromArgb(74, 3, 3);
            LogOutButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.ForeColor = Color.White;
            LogOutButton.ImageSize = new Size(20, 30);
            LogOutButton.Location = new Point(266, 202);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LogOutButton.Size = new Size(185, 52);
            LogOutButton.TabIndex = 13;
            LogOutButton.Text = "LOG OUT";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Message.Location = new Point(93, 126);
            Message.Name = "Message";
            Message.Size = new Size(315, 23);
            Message.TabIndex = 14;
            Message.Text = "Are you sure you want to log out?";
            // 
            // HeaderText
            // 
            HeaderText.AutoSize = true;
            HeaderText.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderText.ForeColor = SystemColors.ControlText;
            HeaderText.Location = new Point(45, 43);
            HeaderText.Name = "HeaderText";
            HeaderText.Size = new Size(132, 32);
            HeaderText.TabIndex = 15;
            HeaderText.Text = "LOG OUT";
            // 
            // LogOutPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 300);
            Controls.Add(HeaderText);
            Controls.Add(Message);
            Controls.Add(LogOutButton);
            Controls.Add(CancelButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogOutPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogOutPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse RoundedCornerElipse;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2Button LogOutButton;
        private Label HeaderText;
        private Label Message;
    }
}