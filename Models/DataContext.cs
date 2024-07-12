using HOTEL_MANAGEMENT_SYSTEM.UI;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString;

        public DataContext()
        {
            // Default connection string for design-time tools
            _connectionString = DatabaseHelper.GetDatabaseConnectionString();
        }

        public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure your models here
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Room>()
            .HasDiscriminator<string>("RoomType")
            .HasValue<StandardRoom>("StandardRoom")
            .HasValue<DeluxeRoom>("DeluxeRoom")
            .HasValue<Suite>("Suite");

            modelBuilder.Entity<Guest>().ToTable("Guests");
            modelBuilder.Entity<Booking>().ToTable("Bookings");
            modelBuilder.Entity<Payment>().ToTable("Payments");

            base.OnModelCreating(modelBuilder);
        }

        // Create the tables for the database
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
    