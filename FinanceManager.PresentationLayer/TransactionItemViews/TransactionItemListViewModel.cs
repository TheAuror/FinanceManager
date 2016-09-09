using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.TransactionModels;

namespace FinanceManager.PresentationLayer.TransactionItemViews
{
    public class TransactionItemListViewModel
    {
        private readonly ITransactionService _transactionService;
        private List<TransactionItemModel> _allItems;

        public TransactionItemListViewModel(ITransactionService transactionService)
        {
            _transactionService = transactionService;
            _allItems = new List<TransactionItemModel>();
            TransactionItems = new BindingList<TransactionItemModel>();
            TransactionItem = new TransactionItemModel
            {
                Type = BaseModel.TypeEnum.Income,
                Category = new CategoryModel()
            };
        }

        public BindingList<TransactionItemModel> TransactionItems { get; }
        public TransactionItemModel TransactionItem { get; }
        public bool GetIncomes { get; set; } = true;
        public bool GetExpenses { get; set; } = true;

        public void LoadTransactionItems()
        {
            TransactionItems.Clear();
            _allItems = _transactionService.GetTransactionItems();
            if (GetIncomes)
            {
                foreach (var item in _allItems.Where(e => e.Type == BaseModel.TypeEnum.Income))
                {
                    TransactionItems.Add(item);
                }
            }
            if (GetExpenses)
            {
                foreach (var item in _allItems.Where(e => e.Type == BaseModel.TypeEnum.Expense))
                {
                    TransactionItems.Add(item);
                }
            }
        }

        public void SaveTransaction()
        {
            _transactionService.SaveTransactionItem(TransactionItem);
            _transactionService.ForceGetTransactionItems();
        }

        public async Task<bool> SaveTransactionItemsAsync(string filePath)
        {
            await _transactionService.SaveTransactionItemsAsync(filePath);
            _transactionService.ForceGetTransactionItems();
            return true;
        }
    }
}