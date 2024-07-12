namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Revenue
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelforfirsttable = new Panel();
            gridviewtable1 = new Guna.UI2.WinForms.Guna2DataGridView();
            Classification = new DataGridViewTextBoxColumn();
            Rooms = new DataGridViewTextBoxColumn();
            Rooms_Open = new DataGridViewTextBoxColumn();
            Rooms_Night = new DataGridViewTextBoxColumn();
            gridviewtable2 = new Guna.UI2.WinForms.Guna2DataGridView();
            labelmonth1 = new DataGridViewTextBoxColumn();
            labelmonth2 = new DataGridViewTextBoxColumn();
            labelmonth3 = new DataGridViewTextBoxColumn();
            forreve = new Guna.UI2.WinForms.Guna2Elipse(components);
            forreve2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            revenuedown = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelforfirsttable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewtable1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridviewtable2).BeginInit();
            SuspendLayout();
            // 
            // panelforfirsttable
            // 
            panelforfirsttable.Controls.Add(gridviewtable1);
            panelforfirsttable.Dock = DockStyle.Top;
            panelforfirsttable.Location = new Point(0, 0);
            panelforfirsttable.Name = "panelforfirsttable";
            panelforfirsttable.Size = new Size(1045, 181);
            panelforfirsttable.TabIndex = 6;
            // 
            // gridviewtable1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            gridviewtable1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridviewtable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridviewtable1.ColumnHeadersHeight = 50;
            gridviewtable1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridviewtable1.Columns.AddRange(new DataGridViewColumn[] { Classification, Rooms, Rooms_Open, Rooms_Night });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridviewtable1.DefaultCellStyle = dataGridViewCellStyle3;
            gridviewtable1.Dock = DockStyle.Fill;
            gridviewtable1.Enabled = false;
            gridviewtable1.GridColor = Color.FromArgb(231, 229, 255);
            gridviewtable1.Location = new Point(0, 0);
            gridviewtable1.Name = "gridviewtable1";
            gridviewtable1.RowHeadersVisible = false;
            gridviewtable1.RowHeadersWidth = 51;
            gridviewtable1.Size = new Size(1045, 181);
            gridviewtable1.TabIndex = 0;
            gridviewtable1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridviewtable1.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridviewtable1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridviewtable1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridviewtable1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridviewtable1.ThemeStyle.BackColor = Color.White;
            gridviewtable1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gridviewtable1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gridviewtable1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridviewtable1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridviewtable1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridviewtable1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridviewtable1.ThemeStyle.HeaderStyle.Height = 50;
            gridviewtable1.ThemeStyle.ReadOnly = false;
            gridviewtable1.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridviewtable1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridviewtable1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridviewtable1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridviewtable1.ThemeStyle.RowsStyle.Height = 29;
            gridviewtable1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridviewtable1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Classification
            // 
            Classification.HeaderText = "Classification";
            Classification.MinimumWidth = 6;
            Classification.Name = "Classification";
            Classification.ReadOnly = true;
            // 
            // Rooms
            // 
            Rooms.HeaderText = "Rooms";
            Rooms.MinimumWidth = 6;
            Rooms.Name = "Rooms";
            Rooms.ReadOnly = true;
            // 
            // Rooms_Open
            // 
            Rooms_Open.HeaderText = "Rooms Open";
            Rooms_Open.MinimumWidth = 6;
            Rooms_Open.Name = "Rooms_Open";
            Rooms_Open.ReadOnly = true;
            // 
            // Rooms_Night
            // 
            Rooms_Night.HeaderText = "Rooms Night";
            Rooms_Night.MinimumWidth = 6;
            Rooms_Night.Name = "Rooms_Night";
            Rooms_Night.ReadOnly = true;
            // 
            // gridviewtable2
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            gridviewtable2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridviewtable2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridviewtable2.ColumnHeadersHeight = 50;
            gridviewtable2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridviewtable2.Columns.AddRange(new DataGridViewColumn[] { labelmonth1, labelmonth2, labelmonth3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridviewtable2.DefaultCellStyle = dataGridViewCellStyle6;
            gridviewtable2.Dock = DockStyle.Fill;
            gridviewtable2.Enabled = false;
            gridviewtable2.GridColor = Color.FromArgb(231, 229, 255);
            gridviewtable2.Location = new Point(0, 181);
            gridviewtable2.Name = "gridviewtable2";
            gridviewtable2.RowHeadersVisible = false;
            gridviewtable2.RowHeadersWidth = 51;
            gridviewtable2.Size = new Size(1045, 244);
            gridviewtable2.TabIndex = 7;
            gridviewtable2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridviewtable2.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridviewtable2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridviewtable2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridviewtable2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridviewtable2.ThemeStyle.BackColor = Color.White;
            gridviewtable2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gridviewtable2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gridviewtable2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridviewtable2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridviewtable2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridviewtable2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridviewtable2.ThemeStyle.HeaderStyle.Height = 50;
            gridviewtable2.ThemeStyle.ReadOnly = false;
            gridviewtable2.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridviewtable2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridviewtable2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridviewtable2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridviewtable2.ThemeStyle.RowsStyle.Height = 29;
            gridviewtable2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridviewtable2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // labelmonth1
            // 
            labelmonth1.HeaderText = "labelmonth";
            labelmonth1.MinimumWidth = 6;
            labelmonth1.Name = "labelmonth1";
            labelmonth1.ReadOnly = true;
            // 
            // labelmonth2
            // 
            labelmonth2.HeaderText = "labelmonth2";
            labelmonth2.MinimumWidth = 6;
            labelmonth2.Name = "labelmonth2";
            labelmonth2.ReadOnly = true;
            // 
            // labelmonth3
            // 
            labelmonth3.HeaderText = "labelmonth3";
            labelmonth3.MinimumWidth = 6;
            labelmonth3.Name = "labelmonth3";
            labelmonth3.ReadOnly = true;
            // 
            // forreve
            // 
            forreve.BorderRadius = 10;
            forreve.TargetControl = gridviewtable1;
            // 
            // forreve2
            // 
            forreve2.BorderRadius = 10;
            forreve2.TargetControl = gridviewtable2;
            // 
            // revenuedown
            // 
            revenuedown.TargetControl = this;
            // 
            // Revenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridviewtable2);
            Controls.Add(panelforfirsttable);
            Name = "Revenue";
            Size = new Size(1045, 425);
            panelforfirsttable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridviewtable1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridviewtable2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelforfirsttable;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewtable1;
        private DataGridViewTextBoxColumn Classification;
        private DataGridViewTextBoxColumn Rooms;
        private DataGridViewTextBoxColumn Rooms_Open;
        private DataGridViewTextBoxColumn Rooms_Night;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewtable2;
        private DataGridViewTextBoxColumn labelmonth1;
        private DataGridViewTextBoxColumn labelmonth2;
        private DataGridViewTextBoxColumn labelmonth3;
        private Guna.UI2.WinForms.Guna2Elipse forreve;
        private Guna.UI2.WinForms.Guna2Elipse forreve2;
        private Guna.UI2.WinForms.Guna2Elipse revenuedown;
    }
}
