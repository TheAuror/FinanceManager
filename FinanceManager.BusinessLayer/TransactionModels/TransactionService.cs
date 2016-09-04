using System.Collections.Generic;
using System.Linq;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.UserModels;
using FinanceManager.DataLayer;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public class TransactionService : BaseService, ITransactionService
    {
        
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public TransactionService(ISampleContext context, ICategoryService categoryService, IUserService userService) : base(context)
        {
            _categoryService = categoryService;
            _userService = userService;
        }

        public List<TransactionModel> GetTransactions()
        {
            return Context.Transactions.Select(e => new TransactionModel
            {
                Id = e.Id,
                UserId = e.User.Id,
                User = _userService.GetUser(e.User.Id),
                ItemId = e.TransactionItem.Id,
                Item = GetTransactionItems().FirstOrDefault(f => f.Id == e.TransactionItem.Id),
                Value = e.Value,
                CreatedTime = e.CreatedTime,
                Type = e.IsIncome?BaseModel.TypeEnum.Income : BaseModel.TypeEnum.Expense
            }).ToList();
        }

        public List<TransactionModel> GetIncomes()
        {
            return GetTransactions().Where(e => e.Type == BaseModel.TypeEnum.Income).ToList();
        }

        public List<TransactionModel> GetExpenses()
        {
            return GetTransactions().Where(e => e.Type == BaseModel.TypeEnum.Expense).ToList();
        }

        public List<TransactionItemModel> GetTransactionItems()
        {
            return Context.TransactionItems.Select(e => new TransactionItemModel
            {
                Id = e.Id,
                Name = e.Name,
                CategoryId = e.Category.Id,
                Category = _categoryService.GetCategory(e.Category.Name),
                LastValue = e.LastValue,
                Type = e.IsIncome?BaseModel.TypeEnum.Income : BaseModel.TypeEnum.Expense
            }).ToList();
        }

        public List<TransactionItemModel> GetIncomeItems()
        {
            return GetTransactionItems().Where(e => e.Type == BaseModel.TypeEnum.Income).ToList();
        }

        public List<TransactionItemModel> GetExpenseItems()
        {
            return GetTransactionItems().Where(e => e.Type == BaseModel.TypeEnum.Expense).ToList();
        }

        public void SaveTransaction(TransactionModel transactionModel)
        {
            throw new System.NotImplementedException();
        }

        public void SaveTransactionItem(TransactionItemModel transactionItemModel)
        {
            throw new System.NotImplementedException();
        }
    }
}