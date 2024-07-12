namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class CashPayment
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            transparentbg = new Panel();
            whitebg = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            Confirmbutton = new Guna.UI2.WinForms.Guna2Button();
            totalAmountLabel = new Label();
            Totalammounttext = new Label();
            codetextbox = new Guna.UI2.WinForms.Guna2TextBox();
            Enterthecodetext = new Label();
            headercash = new Panel();
            cashpaytext = new Label();
            backicon = new PictureBox();
            transparentbg.SuspendLayout();
            whitebg.SuspendLayout();
            headercash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            SuspendLayout();
            // 
            // transparentbg
            // 
            transparentbg.Controls.Add(whitebg);
            transparentbg.Dock = DockStyle.Fill;
            transparentbg.Location = new Point(0, 0);
            transparentbg.Margin = new Padding(3, 2, 3, 2);
            transparentbg.Name = "transparentbg";
            transparentbg.Size = new Size(1213, 591);
            transparentbg.TabIndex = 0;
            transparentbg.Paint += transparentbg_Paint;
            // 
            // whitebg
            // 
            whitebg.BackColor = Color.Transparent;
            whitebg.BorderRadius = 10;
            whitebg.Controls.Add(Confirmbutton);
            whitebg.Controls.Add(totalAmountLabel);
            whitebg.Controls.Add(Totalammounttext);
            whitebg.Controls.Add(codetextbox);
            whitebg.Controls.Add(Enterthecodetext);
            whitebg.Controls.Add(headercash);
            whitebg.Controls.Add(backicon);
            whitebg.CustomizableEdges = customizableEdges5;
            whitebg.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            whitebg.Location = new Point(74, 57);
            whitebg.Margin = new Padding(3, 2, 3, 2);
            whitebg.Name = "whitebg";
            whitebg.ShadowDecoration.CustomizableEdges = customizableEdges6;
            whitebg.Size = new Size(1113, 554);
            whitebg.TabIndex = 0;
            // 
            // Confirmbutton
            // 
            Confirmbutton.BorderRadius = 10;
            Confirmbutton.CustomizableEdges = customizableEdges1;
            Confirmbutton.DisabledState.BorderColor = Color.DarkGray;
            Confirmbutton.DisabledState.CustomBorderColor = Color.DarkGray;
            Confirmbutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Confirmbutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Confirmbutton.FillColor = Color.FromArgb(55, 73, 7);
            Confirmbutton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Confirmbutton.ForeColor = Color.White;
            Confirmbutton.Location = new Point(454, 416);
            Confirmbutton.Margin = new Padding(3, 2, 3, 2);
            Confirmbutton.Name = "Confirmbutton";
            Confirmbutton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Confirmbutton.Size = new Size(205, 45);
            Confirmbutton.TabIndex = 7;
            Confirmbutton.Text = "Confirm";
            Confirmbutton.Click += Confirmbutton_Click;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalAmountLabel.Location = new Point(407, 271);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(53, 20);
            totalAmountLabel.TabIndex = 6;
            totalAmountLabel.Text = "label1";
            // 
            // Totalammounttext
            // 
            Totalammounttext.AutoSize = true;
            Totalammounttext.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Totalammounttext.Location = new Point(220, 271);
            Totalammounttext.Name = "Totalammounttext";
            Totalammounttext.Size = new Size(181, 19);
            Totalammounttext.TabIndex = 5;
            Totalammounttext.Text = "Total Amount with Tax:";
            // 
            // codetextbox
            // 
            codetextbox.BorderColor = Color.FromArgb(64, 64, 64);
            codetextbox.BorderRadius = 10;
            codetextbox.BorderThickness = 3;
            codetextbox.CustomizableEdges = customizableEdges3;
            codetextbox.DefaultText = "";
            codetextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            codetextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            codetextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            codetextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            codetextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            codetextbox.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codetextbox.HoverState.BorderColor = Color.FromArgb(64, 64, 64);
            codetextbox.IconLeftOffset = new Point(10, 0);
            codetextbox.IconLeftSize = new Size(10, 10);
            codetextbox.Location = new Point(206, 206);
            codetextbox.Margin = new Padding(4, 3, 4, 3);
            codetextbox.Name = "codetextbox";
            codetextbox.PasswordChar = '\0';
            codetextbox.PlaceholderText = "Enter password*";
            codetextbox.SelectedText = "";
            codetextbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            codetextbox.Size = new Size(703, 54);
            codetextbox.TabIndex = 4;
            // 
            // Enterthecodetext
            // 
            Enterthecodetext.AutoSize = true;
            Enterthecodetext.BackColor = Color.Transparent;
            Enterthecodetext.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enterthecodetext.Location = new Point(387, 149);
            Enterthecodetext.Name = "Enterthecodetext";
            Enterthecodetext.Size = new Size(323, 28);
            Enterthecodetext.TabIndex = 3;
            Enterthecodetext.Text = "Enter your password below";
            // 
            // headercash
            // 
            headercash.BackColor = Color.FromArgb(13, 22, 29);
            headercash.Controls.Add(cashpaytext);
            headercash.Location = new Point(129, 58);
            headercash.Margin = new Padding(3, 2, 3, 2);
            headercash.Name = "headercash";
            headercash.Size = new Size(911, 48);
            headercash.TabIndex = 1;
            // 
            // cashpaytext
            // 
            cashpaytext.AutoSize = true;
            cashpaytext.BackColor = Color.Transparent;
            cashpaytext.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashpaytext.ForeColor = Color.White;
            cashpaytext.Location = new Point(362, 16);
            cashpaytext.Name = "cashpaytext";
            cashpaytext.Size = new Size(168, 19);
            cashpaytext.TabIndex = 2;
            cashpaytext.Text = "Cash Payment Code";
            // 
            // backicon
            // 
            backicon.Image = Properties.Resources.icons8_back_64;
            backicon.Location = new Point(32, 26);
            backicon.Margin = new Padding(3, 2, 3, 2);
            backicon.Name = "backicon";
            backicon.Size = new Size(41, 35);
            backicon.SizeMode = PictureBoxSizeMode.Zoom;
            backicon.TabIndex = 0;
            backicon.TabStop = false;
            backicon.Click += backicon_Click;
            // 
            // CashPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 591);
            Controls.Add(transparentbg);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CashPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cash Payment";
            WindowState = FormWindowState.Maximized;
            Load += CashPayment_Load;
            transparentbg.ResumeLayout(false);
            whitebg.ResumeLayout(false);
            whitebg.PerformLayout();
            headercash.ResumeLayout(false);
            headercash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel transparentbg;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel whitebg;
        private PictureBox backicon;
        private Label Enterthecodetext;
        private Panel headercash;
        private Label cashpaytext;
        private Guna.UI2.WinForms.Guna2TextBox codetextbox;
        private Guna.UI2.WinForms.Guna2Button Confirmbutton;
        private Label totalAmountLabel;
        private Label Totalammounttext;
    }
}