using System.Collections.Generic;
using System.Threading.Tasks;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public interface ITransactionService
    {
        List<TransactionModel> GetTransactions();
        List<TransactionModel> GetIncomes();
        List<TransactionModel> GetExpenses();
        List<TransactionItemModel> GetTransactionItems();
        List<TransactionItemModel> GetIncomeItems();
        List<TransactionItemModel> GetExpenseItems();
        TransactionEntity SaveTransaction(TransactionModel transactionModel);
        TransactionItemEntity SaveTransactionItem(TransactionItemModel transactionItemModel);
        Task<bool> SaveTransactionItemsAsync(string filePath);
    }
}