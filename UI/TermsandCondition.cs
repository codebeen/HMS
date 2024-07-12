using HOTEL_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class TermsandCondition : Form
    {
        private Booking bookingToDelete = new Booking();

        public TermsandCondition(Booking booking)
        {
            InitializeComponent();
            bookingToDelete = booking;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ConfirmDeletion calldeleteform = new ConfirmDeletion(bookingToDelete);
            calldeleteform.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
