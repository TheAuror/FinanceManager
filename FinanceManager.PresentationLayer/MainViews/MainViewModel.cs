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
        public AutoCompleteStringCollection ItemNames { get; }

        public void LoadTransactionItems()
        {
            _allItems = _transactionService.GetTransactionItems();
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
            foreach (var item in _allItems.Where(e => e.Name.Contains(Transaction.Item.Name ?? "")))
            {
                IncomeItems.Add(item);
                ItemNames.Add(item.Name);
            }
        }

        public void LoadExpenseItems()
        {
            ExpenseItems.Clear();
            ItemNames.Clear();
            foreach (var item in _allItems.Where(e => e.Name.Contains(Transaction.Item.Name ?? "")))
            {
                ExpenseItems.Add(item);
                ItemNames.Add(item.Name);
            }
        }

        public void SaveTransaction()
        {
            Transaction.UserId = _userService.LoggedInUser.Id;
            Transaction.User = _userService.LoggedInUser;
            Transaction.Item.Type = Transaction.Type;
            _transactionService.SaveTransactionItem(Transaction.Item);
            Transaction.Item = _transactionService.GetTransactionItems().FirstOrDefault(e => e.Name == Transaction.Item.Name);
            Transaction.ItemId = Transaction.Item?.Id;
            _transactionService.SaveTransaction(Transaction);
            LoadTransactionItems();
        }
    }
}