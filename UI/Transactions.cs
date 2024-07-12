using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Transactions : UserControl
    {
        private TransactionController transactionController;
        private List<Transaction> allTransactions;
        private Transaction selectedTransaction;

        public Transactions()
        {
            InitializeComponent();
            transactionController = new TransactionController();
            selectedTransaction = new Transaction();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadTransactions()
        {
            try
            {
                // Fetch all transactions from the database
                allTransactions = transactionController.GetAllTransactions();

                // Clear existing rows in DataGridView
                guna2DataGridView2.Rows.Clear();

                // Add each transaction to DataGridView
                foreach (var transaction in allTransactions)
                {
                    guna2DataGridView2.Rows.Add(
                        transaction.TransactionId,
                        transaction.TransactionType,
                        transaction.TransactionDate.ToShortDateString(), // Display only date part
                        transaction.TransactionTime.ToString(@"hh\:mm\:ss"), // Display only time part
                        transaction.EmployeeName
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBookingRecords(string searchText)
        {
            try
            {
                // Reset the selected transaction
                selectedTransaction = null;

                // Check if the search text is empty or whitespace
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    // Reload all transactions
                    LoadTransactions();
                }
                else
                {
                    // Filter transactions based on transaction type or employee name
                    var filteredTransactions = allTransactions.FindAll(t =>
                        t.TransactionType.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                        t.EmployeeName.Contains(searchText, StringComparison.OrdinalIgnoreCase));

                    // Clear existing rows in DataGridView
                    guna2DataGridView2.Rows.Clear();

                    // Add filtered transactions to DataGridView
                    foreach (var transaction in filteredTransactions)
                    {
                        guna2DataGridView2.Rows.Add(
                            transaction.TransactionId,
                            transaction.TransactionType,
                            transaction.TransactionDate.ToShortDateString(), // Display only date part
                            transaction.TransactionTime.ToString(@"hh\:mm\:ss"), // Display only time part
                            transaction.EmployeeName
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }

        private void Transactions_Load_1(object sender, EventArgs e)
        {
            LoadTransactions();
        }
    }
}
