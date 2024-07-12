namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class successmessagebk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(successmessagebk));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            checkmark = new PictureBox();
            LABELBOOK = new Label();
            okButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)checkmark).BeginInit();
            SuspendLayout();
            // 
            // checkmark
            // 
            checkmark.Image = (Image)resources.GetObject("checkmark.Image");
            checkmark.Location = new Point(139, 21);
            checkmark.Margin = new Padding(3, 2, 3, 2);
            checkmark.Name = "checkmark";
            checkmark.Size = new Size(127, 104);
            checkmark.SizeMode = PictureBoxSizeMode.Zoom;
            checkmark.TabIndex = 0;
            checkmark.TabStop = false;
            // 
            // LABELBOOK
            // 
            LABELBOOK.AutoSize = true;
            LABELBOOK.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABELBOOK.Location = new Point(110, 142);
            LABELBOOK.Name = "LABELBOOK";
            LABELBOOK.Size = new Size(167, 19);
            LABELBOOK.TabIndex = 1;
            LABELBOOK.Text = "Successfully Booked!";
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
            okButton.Location = new Point(152, 194);
            okButton.Name = "okButton";
            okButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            okButton.Size = new Size(95, 32);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.Click += okButton_Click;
            // 
            // successmessagebk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(410, 250);
            Controls.Add(okButton);
            Controls.Add(LABELBOOK);
            Controls.Add(checkmark);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "successmessagebk";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)checkmark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox checkmark;
        private Label LABELBOOK;
        private Guna.UI2.WinForms.Guna2Button okButton;
    }
}