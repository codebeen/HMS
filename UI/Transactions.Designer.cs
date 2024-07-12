namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Transactions
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            HeaderText = new Label();
            SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            TransactionGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            TransactionNum = new DataGridViewTextBoxColumn();
            Transaction_Type = new DataGridViewTextBoxColumn();
            Dates = new DataGridViewTextBoxColumn();
            Times = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionGridView).BeginInit();
            SuspendLayout();
            // 
            // DateTimePicker
            // 
            DateTimePicker.BorderColor = Color.FromArgb(13, 22, 29);
            DateTimePicker.BorderRadius = 10;
            DateTimePicker.Checked = true;
            DateTimePicker.CustomizableEdges = customizableEdges1;
            DateTimePicker.FillColor = Color.FromArgb(13, 22, 29);
            DateTimePicker.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateTimePicker.ForeColor = Color.White;
            DateTimePicker.Format = DateTimePickerFormat.Short;
            DateTimePicker.Location = new Point(89, 43);
            DateTimePicker.Margin = new Padding(3, 4, 3, 4);
            DateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DateTimePicker.Size = new Size(238, 40);
            DateTimePicker.TabIndex = 0;
            DateTimePicker.TextAlign = HorizontalAlignment.Center;
            DateTimePicker.Value = new DateTime(2024, 6, 15, 8, 24, 55, 570);
            // 
            // HeaderText
            // 
            HeaderText.AutoSize = true;
            HeaderText.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderText.Location = new Point(571, 82);
            HeaderText.Name = "HeaderText";
            HeaderText.Size = new Size(302, 57);
            HeaderText.TabIndex = 3;
            HeaderText.Text = "Transactions";
            // 
            // SearchTextBox
            // 
            SearchTextBox.BorderColor = Color.Black;
            SearchTextBox.BorderRadius = 15;
            SearchTextBox.CustomizableEdges = customizableEdges3;
            SearchTextBox.DefaultText = "";
            SearchTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.IconLeft = (Image)resources.GetObject("SearchTextBox.IconLeft");
            SearchTextBox.Location = new Point(1007, 43);
            SearchTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PasswordChar = '\0';
            SearchTextBox.PlaceholderForeColor = Color.Gray;
            SearchTextBox.PlaceholderText = "Search by guest, reservation";
            SearchTextBox.SelectedText = "";
            SearchTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SearchTextBox.Size = new Size(339, 52);
            SearchTextBox.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(TransactionGridView);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(69, 149);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1277, 477);
            guna2Panel1.TabIndex = 8;
            // 
            // TransactionGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            TransactionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TransactionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TransactionGridView.ColumnHeadersHeight = 50;
            TransactionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            TransactionGridView.Columns.AddRange(new DataGridViewColumn[] { TransactionNum, Transaction_Type, Dates, Times });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TransactionGridView.DefaultCellStyle = dataGridViewCellStyle3;
            TransactionGridView.Dock = DockStyle.Fill;
            TransactionGridView.GridColor = Color.FromArgb(231, 229, 255);
            TransactionGridView.Location = new Point(0, 0);
            TransactionGridView.Name = "TransactionGridView";
            TransactionGridView.RowHeadersVisible = false;
            TransactionGridView.RowHeadersWidth = 51;
            TransactionGridView.Size = new Size(1277, 477);
            TransactionGridView.TabIndex = 0;
            TransactionGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            TransactionGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            TransactionGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            TransactionGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            TransactionGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            TransactionGridView.ThemeStyle.BackColor = Color.White;
            TransactionGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            TransactionGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            TransactionGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            TransactionGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            TransactionGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            TransactionGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            TransactionGridView.ThemeStyle.HeaderStyle.Height = 50;
            TransactionGridView.ThemeStyle.ReadOnly = false;
            TransactionGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            TransactionGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TransactionGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            TransactionGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            TransactionGridView.ThemeStyle.RowsStyle.Height = 29;
            TransactionGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            TransactionGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // TransactionNum
            // 
            TransactionNum.HeaderText = "Transaction No.";
            TransactionNum.MinimumWidth = 6;
            TransactionNum.Name = "TransactionNum";
            // 
            // Transaction_Type
            // 
            Transaction_Type.HeaderText = "Transaction Type";
            Transaction_Type.MinimumWidth = 6;
            Transaction_Type.Name = "Transaction_Type";
            // 
            // Dates
            // 
            Dates.HeaderText = "Date";
            Dates.MinimumWidth = 6;
            Dates.Name = "Dates";
            // 
            // Times
            // 
            Times.HeaderText = "Time";
            Times.MinimumWidth = 6;
            Times.Name = "Times";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Controls.Add(SearchTextBox);
            Controls.Add(HeaderText);
            Controls.Add(DateTimePicker);
            Name = "Transactions";
            Size = new Size(1600, 679);
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TransactionGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Label HeaderText;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView TransactionGridView;
        private DataGridViewTextBoxColumn TransactionNum;
        private DataGridViewTextBoxColumn Transaction_Type;
        private DataGridViewTextBoxColumn Dates;
        private DataGridViewTextBoxColumn Times;
    }
}
