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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            HeaderText = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            transactionid = new DataGridViewTextBoxColumn();
            transactiontype = new DataGridViewTextBoxColumn();
            transactiondate = new DataGridViewTextBoxColumn();
            transactiontime = new DataGridViewTextBoxColumn();
            createdby = new DataGridViewTextBoxColumn();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HeaderText
            // 
            HeaderText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HeaderText.AutoSize = true;
            HeaderText.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderText.Location = new Point(635, 43);
            HeaderText.Name = "HeaderText";
            HeaderText.Size = new Size(308, 57);
            HeaderText.TabIndex = 3;
            HeaderText.Text = "Log Records";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.Controls.Add(guna2DataGridView2);
            guna2Panel1.Controls.Add(guna2DataGridView1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(115, 137);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1355, 477);
            guna2Panel1.TabIndex = 8;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView2.ColumnHeadersHeight = 50;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.Columns.AddRange(new DataGridViewColumn[] { transactionid, transactiontype, transactiondate, transactiontime, createdby });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            guna2DataGridView2.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.Location = new Point(0, 0);
            guna2DataGridView2.Margin = new Padding(3, 4, 3, 4);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowHeadersWidth = 51;
            guna2DataGridView2.RowTemplate.Height = 25;
            guna2DataGridView2.Size = new Size(1355, 477);
            guna2DataGridView2.TabIndex = 2;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 50;
            guna2DataGridView2.ThemeStyle.ReadOnly = false;
            guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.CellContentClick += guna2DataGridView2_CellContentClick;
            // 
            // transactionid
            // 
            transactionid.HeaderText = "Log Id";
            transactionid.MinimumWidth = 6;
            transactionid.Name = "transactionid";
            // 
            // transactiontype
            // 
            transactiontype.HeaderText = "Log Type";
            transactiontype.MinimumWidth = 6;
            transactiontype.Name = "transactiontype";
            // 
            // transactiondate
            // 
            transactiondate.HeaderText = "Date";
            transactiondate.MinimumWidth = 6;
            transactiondate.Name = "transactiondate";
            // 
            // transactiontime
            // 
            transactiontime.HeaderText = "Time";
            transactiontime.MinimumWidth = 6;
            transactiontime.Name = "transactiontime";
            // 
            // createdby
            // 
            createdby.HeaderText = "Employee Name";
            createdby.MinimumWidth = 6;
            createdby.Name = "createdby";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            guna2DataGridView1.Dock = DockStyle.Fill;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 0);
            guna2DataGridView1.Margin = new Padding(3, 4, 3, 4);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 25;
            guna2DataGridView1.Size = new Size(1355, 477);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Controls.Add(HeaderText);
            Name = "Transactions";
            Size = new Size(1600, 679);
            Load += Transactions_Load_1;
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label HeaderText;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private DataGridViewTextBoxColumn transactionid;
        private DataGridViewTextBoxColumn transactiontype;
        private DataGridViewTextBoxColumn transactiondate;
        private DataGridViewTextBoxColumn transactiontime;
        private DataGridViewTextBoxColumn createdby;
    }
}
