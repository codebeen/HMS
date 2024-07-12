using HOTEL_MANAGEMENT_SYSTEM.UI;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int selectedroomId;
            Guest guestInfo;
            Booking newBooking;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Ensure the database is created if it doesn't exist
            DatabaseHelper.EnsureDatabaseAndMigrate();

            // Start the application
            Application.Run(new LoginPage());

        }


    }
}

