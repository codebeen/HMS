namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Deleteroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deleteroom));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cancelButton = new Guna.UI2.WinForms.Guna2Button();
            deletebutton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.BorderColor = Color.Gray;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(cancelButton);
            guna2Panel1.Controls.Add(deletebutton);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Location = new Point(43, 19);
            guna2Panel1.Margin = new Padding(3, 2, 3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(593, 309);
            guna2Panel1.TabIndex = 3;
            // 
            // cancelButton
            // 
            cancelButton.BorderRadius = 10;
            cancelButton.CustomizableEdges = customizableEdges1;
            cancelButton.DisabledState.BorderColor = Color.DarkGray;
            cancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelButton.FillColor = Color.Gray;
            cancelButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(312, 176);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cancelButton.Size = new Size(197, 34);
            cancelButton.TabIndex = 45;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;
            // 
            // deletebutton
            // 
            deletebutton.BorderRadius = 10;
            deletebutton.CustomizableEdges = customizableEdges3;
            deletebutton.DisabledState.BorderColor = Color.DarkGray;
            deletebutton.DisabledState.CustomBorderColor = Color.DarkGray;
            deletebutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deletebutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deletebutton.FillColor = Color.Maroon;
            deletebutton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebutton.ForeColor = Color.White;
            deletebutton.Location = new Point(100, 176);
            deletebutton.Margin = new Padding(3, 2, 3, 2);
            deletebutton.Name = "deletebutton";
            deletebutton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            deletebutton.Size = new Size(197, 34);
            deletebutton.TabIndex = 44;
            deletebutton.Text = "Delete";
            deletebutton.Click += deletebutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 110);
            label1.Name = "label1";
            label1.Size = new Size(332, 19);
            label1.TabIndex = 43;
            label1.Text = "Are you sure you want to delete this room?";
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(13, 22, 29);
            guna2Panel2.Controls.Add(label2);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Location = new Point(100, 58);
            guna2Panel2.Margin = new Padding(3, 2, 3, 2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(397, 23);
            guna2Panel2.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 5);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 0;
            label2.Text = "Confirm deletion";
            // 
            // Deleteroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 347);
            Controls.Add(guna2Panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Deleteroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deleteroom";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button deletebutton;
        private Label label1;
    }
}