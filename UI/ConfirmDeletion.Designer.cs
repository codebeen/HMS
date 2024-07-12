namespace HOTEL_MANAGEMENT_SYSTEM
{
    partial class ConfirmDeletion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDeletion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ConfirmDelLab = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ContinueTxt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PasswordPanel = new Guna.UI2.WinForms.Guna2TextBox();
            ConfirmBttn = new Guna.UI2.WinForms.Guna2Button();
            NavBack = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)NavBack).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // ConfirmDelLab
            // 
            ConfirmDelLab.BackColor = Color.Transparent;
            ConfirmDelLab.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmDelLab.Location = new Point(214, 31);
            ConfirmDelLab.Name = "ConfirmDelLab";
            ConfirmDelLab.Size = new Size(172, 27);
            ConfirmDelLab.TabIndex = 0;
            ConfirmDelLab.Text = "Confirm Deletion";
            // 
            // ContinueTxt
            // 
            ContinueTxt.BackColor = Color.Transparent;
            ContinueTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContinueTxt.Location = new Point(114, 113);
            ContinueTxt.Name = "ContinueTxt";
            ContinueTxt.Size = new Size(372, 24);
            ContinueTxt.TabIndex = 1;
            ContinueTxt.Text = "To continue, please enter your password";
            // 
            // PasswordPanel
            // 
            PasswordPanel.BorderColor = Color.Black;
            PasswordPanel.BorderRadius = 10;
            PasswordPanel.CustomizableEdges = customizableEdges4;
            PasswordPanel.DefaultText = "";
            PasswordPanel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordPanel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordPanel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordPanel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordPanel.FocusedState.BorderColor = Color.Black;
            PasswordPanel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordPanel.HoverState.BorderColor = Color.Black;
            PasswordPanel.Location = new Point(82, 160);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.PasswordChar = '\0';
            PasswordPanel.PlaceholderForeColor = Color.DimGray;
            PasswordPanel.PlaceholderText = "Password";
            PasswordPanel.SelectedText = "";
            PasswordPanel.ShadowDecoration.CustomizableEdges = customizableEdges5;
            PasswordPanel.Size = new Size(430, 57);
            PasswordPanel.TabIndex = 2;
            // 
            // ConfirmBttn
            // 
            ConfirmBttn.BorderRadius = 10;
            ConfirmBttn.CustomizableEdges = customizableEdges2;
            ConfirmBttn.DisabledState.BorderColor = Color.DarkGray;
            ConfirmBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            ConfirmBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ConfirmBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ConfirmBttn.FillColor = Color.FromArgb(55, 73, 7);
            ConfirmBttn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmBttn.ForeColor = Color.White;
            ConfirmBttn.Location = new Point(195, 306);
            ConfirmBttn.Name = "ConfirmBttn";
            ConfirmBttn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ConfirmBttn.Size = new Size(210, 45);
            ConfirmBttn.TabIndex = 3;
            ConfirmBttn.Text = "Confirm";
            ConfirmBttn.Click += ConfirmBttn_Click;
            // 
            // NavBack
            // 
            NavBack.BackgroundImageLayout = ImageLayout.Stretch;
            NavBack.Image = (Image)resources.GetObject("NavBack.Image");
            NavBack.ImageRotate = 0F;
            NavBack.Location = new Point(28, 31);
            NavBack.Margin = new Padding(3, 2, 3, 2);
            NavBack.Name = "NavBack";
            NavBack.ShadowDecoration.CustomizableEdges = customizableEdges1;
            NavBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            NavBack.Size = new Size(38, 23);
            NavBack.TabIndex = 35;
            NavBack.TabStop = false;
            NavBack.Click += NavBack_Click;
            // 
            // ConfirmDeletion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 400);
            Controls.Add(NavBack);
            Controls.Add(ConfirmBttn);
            Controls.Add(PasswordPanel);
            Controls.Add(ContinueTxt);
            Controls.Add(ConfirmDelLab);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmDeletion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmDeletion";
            ((System.ComponentModel.ISupportInitialize)NavBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ConfirmDelLab;
        private Guna.UI2.WinForms.Guna2HtmlLabel ContinueTxt;
        private Guna.UI2.WinForms.Guna2TextBox PasswordPanel;
        private Guna.UI2.WinForms.Guna2Button ConfirmBttn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox NavBack;
    }
}