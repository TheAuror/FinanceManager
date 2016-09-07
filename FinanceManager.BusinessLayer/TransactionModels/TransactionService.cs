using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
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
            List<TransactionItemModel> list = new List<TransactionItemModel>();
            foreach (var e in Context.TransactionItems.AsParallel())
            {
                list.Add(new TransactionItemModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    CategoryId = e.Category.Id,
                    Category = _categoryService.GetCategory(e.Category.Name),
                    LastValue = e.LastValue,
                    Type = e.IsIncome ? BaseModel.TypeEnum.Income : BaseModel.TypeEnum.Expense
                });
            }
            return list;
        }

        public List<TransactionItemModel> GetIncomeItems()
        {
            return GetTransactionItems().Where(e => e.Type == BaseModel.TypeEnum.Income).ToList();
        }

        public List<TransactionItemModel> GetExpenseItems()
        {
            return GetTransactionItems().Where(e => e.Type == BaseModel.TypeEnum.Expense).ToList();
        }

        public TransactionEntity SaveTransaction(TransactionModel transactionModel)
        {
            TransactionEntity entity = new TransactionEntity
            {
                TransactionItem = SaveTransactionItem(transactionModel.Item),
                CreatedTime = transactionModel.CreatedTime,
                User = Context.Users.FirstOrDefault(e => e.UserName == transactionModel.User.UserName),
                IsIncome = transactionModel.Type == BaseModel.TypeEnum.Income,
                Value = transactionModel.Value
            };
            entity.TransactionItemId = entity.TransactionItem.Id;
            entity.UserId = entity.User.Id;
            Context.Transactions.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public TransactionItemEntity SaveTransactionItem(TransactionItemModel transactionItemModel)
        {
            if (Context.TransactionItems.Any(e => e.Name == transactionItemModel.Name))
            {
                return Context.TransactionItems.FirstOrDefault(e => e.Name == transactionItemModel.Name);
            }
            TransactionItemEntity entity = new TransactionItemEntity
            {
                Name = transactionItemModel.Name,
                Category = _categoryService.SaveCategory(transactionItemModel.Category),
                IsIncome = transactionItemModel.Type == BaseModel.TypeEnum.Income,
                LastValue = transactionItemModel.LastValue
            };
            entity.CategoryId = entity.Category.Id;
            Context.TransactionItems.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public async Task<bool> SaveTransactionItemsAsync(string filePath)
        {
            List<TransactionItemModel> students = null;
            await Task.Run(() =>
            {
                using (StreamReader reader = (new StreamReader(filePath, Encoding.GetEncoding("ISO-8859-2"))))
                {
                    var csv = new CsvReader(reader);
                    csv.Configuration.Delimiter = ";";
                    csv.Configuration.HasHeaderRecord = true;
                    csv.Configuration.RegisterClassMap<TransactionItemClassMap>();
                    students = new List<TransactionItemModel>(csv.GetRecords<TransactionItemModel>().ToList());
                }
            });
            foreach (var item in students)
            {
                var itemTemp = item;
                await Task.Run(() =>
                {
                    SaveTransactionItem(itemTemp);
                });
            }
            return true;
        }
    }    
}