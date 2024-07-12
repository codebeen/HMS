namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Guest_recep
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            ModifyButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            PanelforGuest = new Guna.UI2.WinForms.Guna2Panel();
            InfoTableGuest = new Guna.UI2.WinForms.Guna2DataGridView();
            GuestInfo = new DataGridViewTextBoxColumn();
            checkindate = new DataGridViewTextBoxColumn();
            CheckinTime = new DataGridViewTextBoxColumn();
            CheckoutTime = new DataGridViewTextBoxColumn();
            ModifyGuest = new DataGridViewTextBoxColumn();
            PanelforGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoTableGuest).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(534, 44);
            label1.Name = "label1";
            label1.Size = new Size(373, 49);
            label1.TabIndex = 0;
            label1.Text = "Guest Information";
            // 
            // ModifyButton
            // 
            ModifyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ModifyButton.BorderRadius = 10;
            ModifyButton.CustomizableEdges = customizableEdges1;
            ModifyButton.DisabledState.BorderColor = Color.DarkGray;
            ModifyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ModifyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ModifyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ModifyButton.FillColor = Color.FromArgb(214, 164, 38);
            ModifyButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyButton.ForeColor = Color.White;
            ModifyButton.Location = new Point(1124, 621);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ModifyButton.Size = new Size(125, 40);
            ModifyButton.TabIndex = 2;
            ModifyButton.Text = "Extend Stay";
            ModifyButton.Click += ModifyButton_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = PanelforGuest;
            // 
            // PanelforGuest
            // 
            PanelforGuest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelforGuest.BackColor = Color.White;
            PanelforGuest.Controls.Add(InfoTableGuest);
            PanelforGuest.CustomizableEdges = customizableEdges3;
            PanelforGuest.Location = new Point(184, 106);
            PanelforGuest.Name = "PanelforGuest";
            PanelforGuest.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PanelforGuest.Size = new Size(1073, 505);
            PanelforGuest.TabIndex = 1;
            // 
            // InfoTableGuest
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5);
            InfoTableGuest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            InfoTableGuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            InfoTableGuest.ColumnHeadersHeight = 50;
            InfoTableGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            InfoTableGuest.Columns.AddRange(new DataGridViewColumn[] { GuestInfo, checkindate, CheckinTime, CheckoutTime, ModifyGuest });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            InfoTableGuest.DefaultCellStyle = dataGridViewCellStyle3;
            InfoTableGuest.Dock = DockStyle.Fill;
            InfoTableGuest.Enabled = false;
            InfoTableGuest.GridColor = Color.Silver;
            InfoTableGuest.Location = new Point(0, 0);
            InfoTableGuest.Name = "InfoTableGuest";
            InfoTableGuest.RowHeadersVisible = false;
            InfoTableGuest.RowHeadersWidth = 51;
            InfoTableGuest.Size = new Size(1073, 505);
            InfoTableGuest.TabIndex = 0;
            InfoTableGuest.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            InfoTableGuest.ThemeStyle.AlternatingRowsStyle.Font = null;
            InfoTableGuest.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            InfoTableGuest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            InfoTableGuest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            InfoTableGuest.ThemeStyle.BackColor = Color.White;
            InfoTableGuest.ThemeStyle.GridColor = Color.Silver;
            InfoTableGuest.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            InfoTableGuest.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            InfoTableGuest.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            InfoTableGuest.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            InfoTableGuest.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            InfoTableGuest.ThemeStyle.HeaderStyle.Height = 50;
            InfoTableGuest.ThemeStyle.ReadOnly = false;
            InfoTableGuest.ThemeStyle.RowsStyle.BackColor = Color.White;
            InfoTableGuest.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            InfoTableGuest.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            InfoTableGuest.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            InfoTableGuest.ThemeStyle.RowsStyle.Height = 29;
            InfoTableGuest.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            InfoTableGuest.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // GuestInfo
            // 
            GuestInfo.HeaderText = "Guest";
            GuestInfo.MinimumWidth = 6;
            GuestInfo.Name = "GuestInfo";
            // 
            // checkindate
            // 
            checkindate.HeaderText = "Date";
            checkindate.MinimumWidth = 6;
            checkindate.Name = "checkindate";
            // 
            // CheckinTime
            // 
            CheckinTime.HeaderText = "Check in Time";
            CheckinTime.MinimumWidth = 6;
            CheckinTime.Name = "CheckinTime";
            // 
            // CheckoutTime
            // 
            CheckoutTime.HeaderText = "Check out Time";
            CheckoutTime.MinimumWidth = 6;
            CheckoutTime.Name = "CheckoutTime";
            // 
            // ModifyGuest
            // 
            ModifyGuest.HeaderText = "Modify";
            ModifyGuest.MinimumWidth = 6;
            ModifyGuest.Name = "ModifyGuest";
            // 
            // Guest_recep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelforGuest);
            Controls.Add(ModifyButton);
            Controls.Add(label1);
            Name = "Guest_recep";
            Size = new Size(1440, 679);
            PanelforGuest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InfoTableGuest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button ModifyButton;
        private Guna.UI2.WinForms.Guna2Panel PanelforGuest;
        private Guna.UI2.WinForms.Guna2DataGridView InfoTableGuest;
        private DataGridViewTextBoxColumn GuestInfo;
        private DataGridViewTextBoxColumn checkindate;
        private DataGridViewTextBoxColumn CheckinTime;
        private DataGridViewTextBoxColumn CheckoutTime;
        private DataGridViewTextBoxColumn ModifyGuest;
    }
}
