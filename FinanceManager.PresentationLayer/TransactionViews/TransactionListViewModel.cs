using System;
using System.ComponentModel;
using FinanceManager.BusinessLayer.TransactionModels;
using System.Collections.Generic;
using System.Linq;
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
        public string Year { get; set; } = DateTime.Now.ToString("yyyy");
        public string Month { get; set; } = DateTime.Now.ToString("MMMM");

        public void LoadTransactions()
        {
            Transactions.Clear();
            _allTransaction = _transactionService.GetTransactions();
            foreach (var transaction in _allTransaction.Where(e=> e.CreatedTime.ToString("yyyy") == Year && e.CreatedTime.ToString("MMMM") == Month))
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

        public void SaveDataToFile(string filePath)
        {
            _transactionService.SaveTransactionsToFile(filePath);
        }
    }
}