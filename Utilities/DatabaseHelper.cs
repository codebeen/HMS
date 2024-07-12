using HOTEL_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public static class DatabaseHelper
    {
        private static readonly ExceptionHandling exception = new ExceptionHandling();

        public static void EnsureDatabaseAndMigrate()
        {
            try
            {
                string connectionString = GetDatabaseConnectionString();
                string dbPath = GetDatabasePath();

                using (var context = new DataContext(connectionString))
                {
                    // Check if the database file exists
                    if (!File.Exists(dbPath))
                    {
                        // If the database file does not exist, use EnsureCreated to create it
                        context.Database.EnsureCreated();
                        MessageBox.Show("Database created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If the database file exists, apply any pending migrations
                        context.Database.Migrate();
                        MessageBox.Show("Migrations applied successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
            }
        }

        public static string GetDatabaseConnectionString()
        {
            // Combine the project root with the Database folder and database file name
            string dbPath = GetDatabasePath();

            // Set the SQLite connection string
            return $"Data Source={dbPath}";
        }

        private static string GetDatabasePath()
        {
            // Get the current directory where the application is running
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Navigate up to the project's root directory (assumes this file is in bin/{Debug|Release}/{net5.0|netcoreapp3.1})
            string projectRoot = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;

            // Ensure the Database directory exists
            string databaseDirectory = Path.Combine(projectRoot, "Database");
            if (!Directory.Exists(databaseDirectory))
            {
                Directory.CreateDirectory(databaseDirectory);
            }

            // Combine the project root with the Database folder and database file name
            return Path.Combine(databaseDirectory, "HotelManagement.db");
        }
    }
}
