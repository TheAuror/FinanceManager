using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.TransactionModels;
using FinanceManager.BusinessLayer.UserModels;

namespace FinanceManager.PresentationLayer.MainViews
{
    public class MainViewModel
    {
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly ITransactionService _transactionService;
        private List<TransactionItemModel> _allItems; 

        public MainViewModel(IUserService userService, ITransactionService transactionService, ICategoryService categoryService)
        {
            _userService = userService;
            _categoryService = categoryService;            
            _transactionService = transactionService;
            IncomeItems = new BindingList<TransactionItemModel>();
            ExpenseItems = new BindingList<TransactionItemModel>();
            ItemNames = new AutoCompleteStringCollection();
            Transaction = new TransactionModel
            {
                Item = new TransactionItemModel
                {
                    Type = BaseModel.TypeEnum.Expense            
                }
            };
        }

        public TransactionModel Transaction { get; set; }
        public BindingList<TransactionItemModel> IncomeItems { get; }
        public BindingList<TransactionItemModel> ExpenseItems { get; }
        public AutoCompleteStringCollection ItemNames { get; set; }

        public void LoadTransactionItems()
        {
            _allItems = _transactionService.ForceGetTransactionItems();
            if (Transaction.Type == BaseModel.TypeEnum.Income)
            {
                LoadIncomeItems();
            }
            else
            {
                LoadExpenseItems();
            }
        }

        public void LoadIncomeItems()
        {
            IncomeItems.Clear();
            ItemNames.Clear();
            var itemNamesTemp = new AutoCompleteStringCollection();
            foreach (var item in _allItems.Where(e => e.Name.Contains(Transaction.Item.Name ?? "") && e.Type == BaseModel.TypeEnum.Income))
            {
                IncomeItems.Add(item);
                itemNamesTemp.Add(item.Name);
            }
            ItemNames = itemNamesTemp;
        }

        public void LoadExpenseItems()
        {
            ExpenseItems.Clear();
            ItemNames.Clear();
            var itemNamesTemp = new AutoCompleteStringCollection();
            foreach (var item in _allItems.Where(e => e.Name.Contains(Transaction.Item.Name ?? "") && e.Type == BaseModel.TypeEnum.Expense))
            {
                ExpenseItems.Add(item);
                itemNamesTemp.Add(item.Name);
            }
            ItemNames = itemNamesTemp;
        }

        public void SaveTransaction()
        {
            Transaction.UserId = _userService.LoggedInUser.Id;
            Transaction.User = _userService.LoggedInUser;
            _transactionService.SaveTransaction(Transaction);
            LoadTransactionItems();
        }
    }
}