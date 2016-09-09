using System.ComponentModel;
using FinanceManager.BusinessLayer.TransactionModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinanceManager.BusinessLayer.Common;

namespace FinanceManager.PresentationLayer.TransactionViews
{
    public class TransactionListViewModel
    {
        private readonly ITransactionService _transactionService;
        private List<TransactionModel> _allTransaction;

        public TransactionListViewModel(ITransactionService transactionService)
        {
            _transactionService = transactionService;
            Transactions = new BindingList<TransactionModel>();
        }

        public BindingList<TransactionModel> Transactions { get; set; }
        public bool GetIncomes { get; set; } = true;
        public bool GetExpenses { get; set; } = true;

        public void LoadTransactions()
        {
            Transactions.Clear();
            _allTransaction = _transactionService.GetTransactions();
            foreach (var transaction in _allTransaction)
            {
                if (transaction.Type == BaseModel.TypeEnum.Income && GetIncomes ||
                    transaction.Type == BaseModel.TypeEnum.Expense && GetExpenses)
                {
                    Transactions.Add(transaction);
                }
            }
        }

        public async Task<bool> SaveTransactionsAsync(string filePath)
        {
            return await _transactionService.SaveTransactionsAsync(filePath);
        }
    }
}