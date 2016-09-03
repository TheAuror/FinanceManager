using System.Collections.Generic;

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
        void SaveTransaction(TransactionModel transactionModel);
        void SaveTransactionItem(TransactionItemModel transactionItemModel);
    }
}