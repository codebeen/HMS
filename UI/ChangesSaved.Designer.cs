namespace HOTEL_MANAGEMENT_SYSTEM
{
    partial class ChangesSaved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangesSaved));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            CheckPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ChangesSavedTxt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)CheckPic).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // CheckPic
            // 
            CheckPic.Image = (Image)resources.GetObject("CheckPic.Image");
            CheckPic.ImageRotate = 0F;
            CheckPic.Location = new Point(223, 115);
            CheckPic.Margin = new Padding(3, 4, 3, 4);
            CheckPic.Name = "CheckPic";
            CheckPic.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CheckPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CheckPic.Size = new Size(131, 147);
            CheckPic.TabIndex = 0;
            CheckPic.TabStop = false;
            // 
            // ChangesSavedTxt
            // 
            ChangesSavedTxt.BackColor = Color.Transparent;
            ChangesSavedTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangesSavedTxt.Location = new Point(199, 253);
            ChangesSavedTxt.Margin = new Padding(3, 4, 3, 4);
            ChangesSavedTxt.Name = "ChangesSavedTxt";
            ChangesSavedTxt.Size = new Size(193, 30);
            ChangesSavedTxt.TabIndex = 1;
            ChangesSavedTxt.Text = "Changes saved!";
            // 
            // ChangesSaved
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 400);
            Controls.Add(ChangesSavedTxt);
            Controls.Add(CheckPic);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangesSaved";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangesSaved";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)CheckPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CheckPic;
        private Guna.UI2.WinForms.Guna2HtmlLabel ChangesSavedTxt;
    }
}