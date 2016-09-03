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
        public TransactionService(ISampleContext context) : base(context)
        {

        }

        public List<TransactionModel> GetTransactions()
        {
            List<TransactionModel> transactions = GetIncomes();
            transactions.AddRange(GetExpenses());
            return transactions;
        }

        public List<TransactionModel> GetIncomes()
        {
            return Context.Incomes.Select(e => new TransactionModel
            {
                Id = e.Id,
                UserId = e.UserId,
                User = new UserModel
                {
                    Id = e.UserId,
                    UserName = e.User.UserName,
                    Password = e.User.Password
                },
                ItemId = e.IncomeItemId,
                TransactionItem = new TransactionItemModel
                {
                    Id = e.IncomeItem.Id,
                    CategoryId = e.IncomeItem.CategoryId,
                    Category = new CategoryModel
                    {
                        Id = e.IncomeItem.Category.Id,
                        Name = e.IncomeItem.Category.Name
                    },
                    LastValue = e.IncomeItem.LastValue,
                    Name = e.IncomeItem.Name
                },
                CreatedTime = e.CreatedTime,
                Value = e.Value,
                Type = BaseModel.TypeEnum.Income
            }).ToList();
        }

        public List<TransactionModel> GetExpenses()
        {
            return Context.Expenses.Select(e => new TransactionModel
            {
                Id = e.Id,
                UserId = e.UserId,
                User = new UserModel
                {
                    Id = e.UserId,
                    UserName = e.User.UserName,
                    Password = e.User.Password
                },
                ItemId = e.ExpenseItemId,
                TransactionItem = new TransactionItemModel
                {
                    Id = e.ExpenseItem.Id,
                    CategoryId = e.ExpenseItem.CategoryId,
                    Category = new CategoryModel
                    {
                        Id = e.ExpenseItem.Category.Id,
                        Name = e.ExpenseItem.Category.Name
                    },
                    LastValue = e.ExpenseItem.LastValue,
                    Name = e.ExpenseItem.Name
                },
                CreatedTime = e.CreatedTime,
                Value = e.Value,
                Type = BaseModel.TypeEnum.Expense
            }).ToList();
        }

        public List<TransactionItemModel> GetTransactionItems()
        {
            List<TransactionItemModel> transactionItems = GetIncomeItems();
            transactionItems.AddRange(GetExpenseItems());
            return transactionItems;
        }

        public List<TransactionItemModel> GetIncomeItems()
        {
            return Context.IncomeItems.Select(e => new TransactionItemModel
            {
                Id = e.Id,
                Name = e.Name,
                CategoryId = e.CategoryId,
                Category = new CategoryModel
                {
                    Id = e.Category.Id,
                    Name = e.Category.Name
                },
                LastValue = e.LastValue
            }).ToList();
        }

        public List<TransactionItemModel> GetExpenseItems()
        {
            return Context.ExpenseItems.Select(e => new TransactionItemModel
            {
                Id = e.Id,
                Name = e.Name,
                CategoryId = e.CategoryId,
                Category = new CategoryModel
                {
                    Id = e.Category.Id,
                    Name = e.Category.Name
                },
                LastValue = e.LastValue
            }).ToList();
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