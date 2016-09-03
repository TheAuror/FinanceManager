using System.Collections.Generic;
using System.Linq;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.UserModels;
using FinanceManager.DataLayer;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public class TransactionService : BaseService, ITransactionService
    {
        private readonly ICategoryService _categoryService;

        public TransactionService(ISampleContext context, ICategoryService categoryService) : base(context)
        {
            _categoryService = categoryService;
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
                    Name = e.IncomeItem.Name,
                    Type = BaseModel.TypeEnum.Income
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
                    Name = e.ExpenseItem.Name,
                    Type = BaseModel.TypeEnum.Expense
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
                LastValue = e.LastValue,
                Type = BaseModel.TypeEnum.Income
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
                LastValue = e.LastValue,
                Type = BaseModel.TypeEnum.Expense
            }).ToList();
        }

        public void SaveTransaction(TransactionModel transactionModel)
        {
            if (transactionModel.Type == BaseModel.TypeEnum.Income)
            {
                IncomeEntity income = new IncomeEntity
                {
                    
                };
                Context.Incomes.Add(income);
            }
            else
            {
                ExpenseEntity expense = new ExpenseEntity
                {
                    
                };
                Context.Expenses.Add(expense);
            }
            Context.SaveChanges();
        }

        public void SaveTransactionItem(TransactionItemModel transactionItemModel)
        {
            CategoryModel category = _categoryService.GetCategory(transactionItemModel.Category.Name);
            object item;
            if (transactionItemModel.Type == BaseModel.TypeEnum.Income)
            {
                item = new IncomeItemEntity
                {
                    Name = transactionItemModel.Name,
                    Category = Context.Categorys.FirstOrDefault(e => e.Id == category.Id),
                    CategoryId = category.Id,
                    LastValue = transactionItemModel.LastValue
                };
            }
            else
            {                
                item = new ExpenseItemEntity
                {
                    Name = transactionItemModel.Name,
                    Category = Context.Categorys.FirstOrDefault(e => e.Id == category.Id),
                    CategoryId = category.Id,
                    LastValue = transactionItemModel.LastValue
                };
            }
            Context.ExpenseItems.Add(item);
            Context.SaveChanges();
        }
    }
}