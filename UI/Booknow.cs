using System;
//using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Booknow : UserControl
    {
        private Form_receptionist form_Receptionist;

        public Booknow()
        {
            InitializeComponent(); //for elements 
            InitializeHoverEffects(); //hover effects on diff room type
            InitializeClickEvents(); //mouse click for diff room type
        }

        /*
        public Booknow(Form1 form1)
        {
            this.form_Receptionist = form_Receptionist; //parent form
        }
        */
        private void InitializeHoverEffects()
        {
            // Adding event handlers for MouseEnter and MouseLeave events
            SRPanel.MouseEnter += new EventHandler(guna2Panel_MouseEnter);
            SRPanel.MouseLeave += new EventHandler(guna2Panel_MouseLeave);

            DRPanel.MouseEnter += new EventHandler(guna2Panel_MouseEnter);
            DRPanel.MouseLeave += new EventHandler(guna2Panel_MouseLeave);

            SuitesPanel.MouseEnter += new EventHandler(guna2Panel_MouseEnter);
            SuitesPanel.MouseLeave += new EventHandler(guna2Panel_MouseLeave);
        }

        //Clicked event for SRPANEL only
        private void InitializeClickEvents()
        {
            SRPanel.Click += SRPanel_Click;
            DRPanel.Click += DRPanel_Click;
            SuitesPanel.Click += SuitesPanel_Click;
        }

        // Event handler method for SRPanel click event
        private void SRPanel_Click(object sender, EventArgs e)
        {
            SRSelectRoom sRSelectRoom = new SRSelectRoom();
            sRSelectRoom.Show();
        }


        // Event handler method for DRPanel click event
        private void DRPanel_Click(object sender, EventArgs e)
        {
            DRselectroom dRselectroom = new DRselectroom();
            dRselectroom.Show();
        }

        // Event handler method for SuitesPanel click event
        private void SuitesPanel_Click(object sender, EventArgs e)
        {
            SSelectRoom sSelectRoom = new SSelectRoom();
            sSelectRoom.Show();
        }

        //Hover color for panel 1 when mouse is hovered (Standard Room)
        private void guna2Panel_MouseEnter(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Panel panel = sender as Guna.UI2.WinForms.Guna2Panel;
            panel.FillColor = Color.LightGray;
        }

        //Revert the background color when mouse is not hovered
        private void guna2Panel_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Panel panel = sender as Guna.UI2.WinForms.Guna2Panel;
            panel.FillColor = Color.Transparent;
        }

        private void Booknow_Load(object sender, EventArgs e)
        {
            DateDefault.Text = DateTime.Now.ToString();
        }
    }
}