namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class GuestDemo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            forradius = new Guna.UI2.WinForms.Guna2Elipse(components);
            gridviewguesdemo = new Guna.UI2.WinForms.Guna2DataGridView();
            Classification = new DataGridViewTextBoxColumn();
            Variables = new DataGridViewTextBoxColumn();
            Frequency = new DataGridViewTextBoxColumn();
            radiusdown = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)gridviewguesdemo).BeginInit();
            SuspendLayout();
            // 
            // forradius
            // 
            forradius.BorderRadius = 10;
            forradius.TargetControl = this;
            // 
            // gridviewguesdemo
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            gridviewguesdemo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridviewguesdemo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridviewguesdemo.ColumnHeadersHeight = 50;
            gridviewguesdemo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridviewguesdemo.Columns.AddRange(new DataGridViewColumn[] { Classification, Variables, Frequency });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridviewguesdemo.DefaultCellStyle = dataGridViewCellStyle3;
            gridviewguesdemo.Dock = DockStyle.Fill;
            gridviewguesdemo.Enabled = false;
            gridviewguesdemo.GridColor = Color.White;
            gridviewguesdemo.Location = new Point(0, 0);
            gridviewguesdemo.Name = "gridviewguesdemo";
            gridviewguesdemo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridviewguesdemo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridviewguesdemo.RowHeadersVisible = false;
            gridviewguesdemo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            gridviewguesdemo.Size = new Size(1045, 425);
            gridviewguesdemo.TabIndex = 0;
            gridviewguesdemo.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridviewguesdemo.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridviewguesdemo.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridviewguesdemo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridviewguesdemo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridviewguesdemo.ThemeStyle.BackColor = Color.White;
            gridviewguesdemo.ThemeStyle.GridColor = Color.White;
            gridviewguesdemo.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gridviewguesdemo.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridviewguesdemo.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridviewguesdemo.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridviewguesdemo.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridviewguesdemo.ThemeStyle.HeaderStyle.Height = 50;
            gridviewguesdemo.ThemeStyle.ReadOnly = true;
            gridviewguesdemo.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridviewguesdemo.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridviewguesdemo.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridviewguesdemo.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridviewguesdemo.ThemeStyle.RowsStyle.Height = 29;
            gridviewguesdemo.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridviewguesdemo.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            gridviewguesdemo.CellContentClick += gridviewguesdemo_CellContentClick;
            // 
            // Classification
            // 
            Classification.HeaderText = "Classification";
            Classification.MinimumWidth = 6;
            Classification.Name = "Classification";
            Classification.ReadOnly = true;
            // 
            // Variables
            // 
            Variables.HeaderText = "Variables";
            Variables.MinimumWidth = 6;
            Variables.Name = "Variables";
            Variables.ReadOnly = true;
            // 
            // Frequency
            // 
            Frequency.HeaderText = "Frequency";
            Frequency.MinimumWidth = 6;
            Frequency.Name = "Frequency";
            Frequency.ReadOnly = true;
            // 
            // radiusdown
            // 
            radiusdown.BorderRadius = 10;
            radiusdown.TargetControl = this;
            // 
            // GuestDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridviewguesdemo);
            Name = "GuestDemo";
            Size = new Size(1045, 425);
            ((System.ComponentModel.ISupportInitialize)gridviewguesdemo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse forradius;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewguesdemo;
        private DataGridViewTextBoxColumn Classification;
        private DataGridViewTextBoxColumn Variables;
        private DataGridViewTextBoxColumn Frequency;
       // private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse radiusdown;
    }
}
