using System;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class TransactionController
    {
        private readonly DataContext dbContext; // Replace YourDbContext with your actual DbContext class
        private readonly ExceptionHandling eh = new();

        public TransactionController()
        {
            dbContext = new DataContext(); // Initialize your DbContext here
        }

        // Method to add a new transaction
        public bool AddTransaction(Transaction transactions)
        {
            try
            {
                // add the transaction record to the database
                using (var context = new DataContext())
                {
                    context.Transactions.Add(transactions);
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                eh.HandleException(ex);
                return false;
            }
        }

        public List<Transaction> GetAllTransactions()
        {
            try
            {
                return dbContext.Transactions.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to Retrieve Transactions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Transaction>();
            }
        }

        // Dispose method to clean up DbContext
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
