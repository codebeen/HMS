namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class OccupancyRate
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
            gridviewoccupancy = new Guna.UI2.WinForms.Guna2DataGridView();
            Classification = new DataGridViewTextBoxColumn();
            Number_of_Rooms = new DataGridViewTextBoxColumn();
            Occupancy = new DataGridViewTextBoxColumn();
            froradius = new Guna.UI2.WinForms.Guna2Elipse(components);
            radiusdown = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)gridviewoccupancy).BeginInit();
            SuspendLayout();
            // 
            // gridviewoccupancy
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            gridviewoccupancy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridviewoccupancy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridviewoccupancy.ColumnHeadersHeight = 50;
            gridviewoccupancy.Columns.AddRange(new DataGridViewColumn[] { Classification, Number_of_Rooms, Occupancy });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridviewoccupancy.DefaultCellStyle = dataGridViewCellStyle3;
            gridviewoccupancy.Dock = DockStyle.Fill;
            gridviewoccupancy.Enabled = false;
            gridviewoccupancy.GridColor = Color.FromArgb(231, 229, 255);
            gridviewoccupancy.Location = new Point(0, 0);
            gridviewoccupancy.Name = "gridviewoccupancy";
            gridviewoccupancy.RowHeadersVisible = false;
            gridviewoccupancy.RowHeadersWidth = 51;
            gridviewoccupancy.Size = new Size(1045, 425);
            gridviewoccupancy.TabIndex = 0;
            gridviewoccupancy.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridviewoccupancy.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridviewoccupancy.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridviewoccupancy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridviewoccupancy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridviewoccupancy.ThemeStyle.BackColor = Color.White;
            gridviewoccupancy.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gridviewoccupancy.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gridviewoccupancy.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridviewoccupancy.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridviewoccupancy.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridviewoccupancy.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridviewoccupancy.ThemeStyle.HeaderStyle.Height = 50;
            gridviewoccupancy.ThemeStyle.ReadOnly = false;
            gridviewoccupancy.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridviewoccupancy.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridviewoccupancy.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridviewoccupancy.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridviewoccupancy.ThemeStyle.RowsStyle.Height = 29;
            gridviewoccupancy.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridviewoccupancy.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Classification
            // 
            Classification.HeaderText = "Classification";
            Classification.MinimumWidth = 6;
            Classification.Name = "Classification";
            // 
            // Number_of_Rooms
            // 
            Number_of_Rooms.HeaderText = "Number of Rooms";
            Number_of_Rooms.MinimumWidth = 6;
            Number_of_Rooms.Name = "Number_of_Rooms";
            Number_of_Rooms.ReadOnly = true;
            // 
            // Occupancy
            // 
            Occupancy.HeaderText = "Occupancy";
            Occupancy.MinimumWidth = 6;
            Occupancy.Name = "Occupancy";
            Occupancy.ReadOnly = true;
            // 
            // froradius
            // 
            froradius.BorderRadius = 10;
            // 
            // radiusdown
            // 
            radiusdown.BorderRadius = 10;
            radiusdown.TargetControl = this;
            // 
            // OccupancyRate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridviewoccupancy);
            Name = "OccupancyRate";
            Size = new Size(1045, 425);
            ((System.ComponentModel.ISupportInitialize)gridviewoccupancy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridviewoccupancy;
        private DataGridViewTextBoxColumn Classification;
        private DataGridViewTextBoxColumn Number_of_Rooms;
        private DataGridViewTextBoxColumn Occupancy;
        private Guna.UI2.WinForms.Guna2Elipse froradius;
        private Guna.UI2.WinForms.Guna2Elipse radiusdown;
    }
}
