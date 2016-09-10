using System.Collections.Generic;
using System.Threading.Tasks;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public interface ITransactionService
    {
        List<TransactionModel> GetTransactions();
        List<TransactionModel> GetIncomes();
        List<TransactionModel> GetExpenses();
        List<TransactionItemModel> GetTransactionItems();
        List<TransactionItemModel> ForceGetTransactionItems(); 
        List<TransactionItemModel> GetIncomeItems();
        List<TransactionItemModel> GetExpenseItems();
        TransactionEntity SaveTransaction(TransactionModel transactionModel);
        TransactionItemEntity SaveTransactionItem(TransactionItemModel transactionItemModel);
        Task<bool> SaveTransactionItemsAsync(string filePath);
        Task<bool> SaveTransactionsAsync(string filePath);
        void SaveTransactionItemsToFile(string filePath);
        void SaveTransactionsToFile(string filePath);
    }
}