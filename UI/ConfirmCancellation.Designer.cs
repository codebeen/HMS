namespace HOTEL_MANAGEMENT_SYSTEM
{
    partial class ConfirmCancellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmCancellation));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            CancellationCheckedPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            CancellationConTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)CancellationCheckedPic).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // CancellationCheckedPic
            // 
            CancellationCheckedPic.Image = (Image)resources.GetObject("CancellationCheckedPic.Image");
            CancellationCheckedPic.ImageRotate = 0F;
            CancellationCheckedPic.Location = new Point(194, 89);
            CancellationCheckedPic.Name = "CancellationCheckedPic";
            CancellationCheckedPic.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CancellationCheckedPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CancellationCheckedPic.Size = new Size(115, 110);
            CancellationCheckedPic.TabIndex = 0;
            CancellationCheckedPic.TabStop = false;
            CancellationCheckedPic.Click += CancellationCheckedPic_Click;
            // 
            // CancellationConTxt
            // 
            CancellationConTxt.AutoSize = true;
            CancellationConTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancellationConTxt.Location = new Point(132, 189);
            CancellationConTxt.Name = "CancellationConTxt";
            CancellationConTxt.Size = new Size(237, 23);
            CancellationConTxt.TabIndex = 1;
            CancellationConTxt.Text = "Cancellation Confirmed!";
            CancellationConTxt.Click += CancellationConTxt_Click;
            // 
            // ConfirmCancellation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 300);
            Controls.Add(CancellationConTxt);
            Controls.Add(CancellationCheckedPic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmCancellation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmCancellation";
            Load += ConfirmCancellation_Load;
            ((System.ComponentModel.ISupportInitialize)CancellationCheckedPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label CancellationConTxt;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CancellationCheckedPic;
    }
}