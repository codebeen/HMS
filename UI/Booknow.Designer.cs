namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Booknow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booknow));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SelectRoom = new Label();
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            DRPanel = new Guna.UI2.WinForms.Guna2Panel();
            DRDescription = new Label();
            DRLabel = new Label();
            DRAmount = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            SuitesPanel = new Guna.UI2.WinForms.Guna2Panel();
            SDescription = new Label();
            SLabel = new Label();
            SAmount = new Label();
            SRPanel = new Guna.UI2.WinForms.Guna2Panel();
            SRDescription = new Label();
            SRLabel = new Label();
            SRAmount = new Label();
            panel1 = new Panel();
            guna2CustomGradientPanel1.SuspendLayout();
            DRPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuitesPanel.SuspendLayout();
            SRPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectRoom
            // 
            SelectRoom.Anchor = AnchorStyles.None;
            SelectRoom.AutoSize = true;
            SelectRoom.BackColor = Color.Transparent;
            guna2Transition1.SetDecoration(SelectRoom, Guna.UI2.AnimatorNS.DecorationType.None);
            SelectRoom.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectRoom.Location = new Point(64, -25);
            SelectRoom.Name = "SelectRoom";
            SelectRoom.Padding = new Padding(50, 40, 20, 20);
            SelectRoom.Size = new Size(415, 117);
            SelectRoom.TabIndex = 0;
            SelectRoom.Text = "Select a room";
            SelectRoom.Click += SelectRoom_Click;
            // 
            // guna2Transition1
            // 
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation1;
            guna2Transition1.TimeStep = 0.03F;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Anchor = AnchorStyles.None;
            guna2CustomGradientPanel1.BackColor = Color.Transparent;
            guna2CustomGradientPanel1.BorderColor = Color.Gray;
            guna2CustomGradientPanel1.BorderRadius = 20;
            guna2CustomGradientPanel1.BorderThickness = 1;
            guna2CustomGradientPanel1.Controls.Add(DRPanel);
            guna2CustomGradientPanel1.Controls.Add(pictureBox3);
            guna2CustomGradientPanel1.Controls.Add(pictureBox2);
            guna2CustomGradientPanel1.Controls.Add(pictureBox1);
            guna2CustomGradientPanel1.Controls.Add(SuitesPanel);
            guna2CustomGradientPanel1.Controls.Add(SRPanel);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges7;
            guna2Transition1.SetDecoration(guna2CustomGradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2CustomGradientPanel1.Location = new Point(111, 87);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CustomGradientPanel1.Size = new Size(1249, 562);
            guna2CustomGradientPanel1.TabIndex = 1;
            guna2CustomGradientPanel1.Paint += guna2CustomGradientPanel1_Paint;
            // 
            // DRPanel
            // 
            DRPanel.BorderColor = Color.Transparent;
            DRPanel.BorderRadius = 12;
            DRPanel.Controls.Add(DRDescription);
            DRPanel.Controls.Add(DRLabel);
            DRPanel.Controls.Add(DRAmount);
            DRPanel.CustomizableEdges = customizableEdges1;
            guna2Transition1.SetDecoration(DRPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            DRPanel.FillColor = Color.White;
            DRPanel.Location = new Point(318, 210);
            DRPanel.Name = "DRPanel";
            DRPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DRPanel.Size = new Size(831, 142);
            DRPanel.TabIndex = 1;
            // 
            // DRDescription
            // 
            DRDescription.AutoSize = true;
            guna2Transition1.SetDecoration(DRDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            DRDescription.Location = new Point(13, 80);
            DRDescription.Name = "DRDescription";
            DRDescription.Size = new Size(646, 40);
            DRDescription.TabIndex = 2;
            DRDescription.Text = "Our Deluxe Rooms are crafted to provide a luxurious retreat, offering the perfect blend \r\nof comfort, style, and modern conveniences. ";
            // 
            // DRLabel
            // 
            DRLabel.AutoSize = true;
            guna2Transition1.SetDecoration(DRLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            DRLabel.Font = new Font("Century Gothic", 12F);
            DRLabel.Location = new Point(15, 45);
            DRLabel.Name = "DRLabel";
            DRLabel.Size = new Size(141, 23);
            DRLabel.TabIndex = 1;
            DRLabel.Text = "Deluxe Room";
            // 
            // DRAmount
            // 
            DRAmount.AutoSize = true;
            guna2Transition1.SetDecoration(DRAmount, Guna.UI2.AnimatorNS.DecorationType.None);
            DRAmount.Font = new Font("Century Gothic", 19.2F, FontStyle.Bold);
            DRAmount.Location = new Point(13, 6);
            DRAmount.Name = "DRAmount";
            DRAmount.Size = new Size(165, 38);
            DRAmount.TabIndex = 0;
            DRAmount.Text = "PHP 5,500";
            // 
            // pictureBox3
            // 
            guna2Transition1.SetDecoration(pictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(99, 364);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(207, 142);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            guna2Transition1.SetDecoration(pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            guna2Transition1.SetDecoration(pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SuitesPanel
            // 
            SuitesPanel.BorderColor = Color.Transparent;
            SuitesPanel.BorderRadius = 12;
            SuitesPanel.Controls.Add(SDescription);
            SuitesPanel.Controls.Add(SLabel);
            SuitesPanel.Controls.Add(SAmount);
            SuitesPanel.CustomizableEdges = customizableEdges3;
            guna2Transition1.SetDecoration(SuitesPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            SuitesPanel.FillColor = Color.White;
            SuitesPanel.Location = new Point(318, 366);
            SuitesPanel.Name = "SuitesPanel";
            SuitesPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SuitesPanel.Size = new Size(831, 142);
            SuitesPanel.TabIndex = 2;
            // 
            // SDescription
            // 
            SDescription.AutoSize = true;
            guna2Transition1.SetDecoration(SDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            SDescription.Location = new Point(15, 86);
            SDescription.Name = "SDescription";
            SDescription.Size = new Size(689, 40);
            SDescription.TabIndex = 2;
            SDescription.Text = "Our Suites are designed to provide an extraordinary stay, offering the perfect blend of luxury, \r\ncomfort, and modern amenities. ";
            // 
            // SLabel
            // 
            SLabel.AutoSize = true;
            guna2Transition1.SetDecoration(SLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            SLabel.Font = new Font("Century Gothic", 12F);
            SLabel.Location = new Point(18, 50);
            SLabel.Name = "SLabel";
            SLabel.Size = new Size(63, 23);
            SLabel.TabIndex = 1;
            SLabel.Text = "Suites";
            // 
            // SAmount
            // 
            SAmount.AutoSize = true;
            guna2Transition1.SetDecoration(SAmount, Guna.UI2.AnimatorNS.DecorationType.None);
            SAmount.Font = new Font("Century Gothic", 19.2F, FontStyle.Bold);
            SAmount.Location = new Point(13, 12);
            SAmount.Name = "SAmount";
            SAmount.Size = new Size(183, 38);
            SAmount.TabIndex = 0;
            SAmount.Text = "PHP 13,000";
            // 
            // SRPanel
            // 
            SRPanel.BorderColor = Color.Transparent;
            SRPanel.BorderRadius = 12;
            SRPanel.Controls.Add(SRDescription);
            SRPanel.Controls.Add(SRLabel);
            SRPanel.Controls.Add(SRAmount);
            SRPanel.CustomizableEdges = customizableEdges5;
            guna2Transition1.SetDecoration(SRPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            SRPanel.FillColor = Color.White;
            SRPanel.Location = new Point(316, 55);
            SRPanel.Name = "SRPanel";
            SRPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SRPanel.Size = new Size(830, 142);
            SRPanel.TabIndex = 0;
            // 
            // SRDescription
            // 
            SRDescription.AutoSize = true;
            guna2Transition1.SetDecoration(SRDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            SRDescription.Location = new Point(16, 78);
            SRDescription.Name = "SRDescription";
            SRDescription.Size = new Size(613, 40);
            SRDescription.TabIndex = 2;
            SRDescription.Text = "Our Standard Rooms are designed to provide a serene and pleasant environment, \r\nwhether you're here for a short stay or an extended visit. \r\n";
            // 
            // SRLabel
            // 
            SRLabel.AutoSize = true;
            guna2Transition1.SetDecoration(SRLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            SRLabel.Font = new Font("Century Gothic", 12F);
            SRLabel.Location = new Point(16, 42);
            SRLabel.Name = "SRLabel";
            SRLabel.Size = new Size(164, 23);
            SRLabel.TabIndex = 1;
            SRLabel.Text = "Standard Room";
            // 
            // SRAmount
            // 
            SRAmount.AutoSize = true;
            guna2Transition1.SetDecoration(SRAmount, Guna.UI2.AnimatorNS.DecorationType.None);
            SRAmount.Font = new Font("Century Gothic", 19.2F, FontStyle.Bold);
            SRAmount.Location = new Point(15, 5);
            SRAmount.Name = "SRAmount";
            SRAmount.Size = new Size(165, 38);
            SRAmount.TabIndex = 0;
            SRAmount.Text = "PHP 3,000";
            // 
            // panel1
            // 
            panel1.Controls.Add(SelectRoom);
            guna2Transition1.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 679);
            panel1.TabIndex = 2;
            // 
            // Booknow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(panel1);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            Font = new Font("Century Gothic", 9F);
            Name = "Booknow";
            Size = new Size(1440, 679);
            Load += Booknow_Load;
            guna2CustomGradientPanel1.ResumeLayout(false);
            DRPanel.ResumeLayout(false);
            DRPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SuitesPanel.ResumeLayout(false);
            SuitesPanel.PerformLayout();
            SRPanel.ResumeLayout(false);
            SRPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SelectRoom;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel SuitesPanel;
        private Label SDescription;
        private Label SLabel;
        private Label SAmount;
        private Guna.UI2.WinForms.Guna2Panel DRPanel;
        private Label DRDescription;
        private Label DRLabel;
        private Label DRAmount;
        private Guna.UI2.WinForms.Guna2Panel SRPanel;
        private Label SRDescription;
        private Label SRLabel;
        private Label SRAmount;
        private Panel panel1;
    }
}
