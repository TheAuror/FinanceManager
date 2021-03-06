﻿using System.Collections.Generic;
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

        List<TransactionItemModel> TransactionItems { get; set; }

        //GetTransactions()
        //GetTransactionItems()
        //ForceGetTransactionItems()
        #region Gets
        public List<TransactionModel> GetTransactions()
        {
            List<TransactionEntity> entities = Context.Transactions.ToList();
            List<TransactionModel> models = new List<TransactionModel>();
            foreach (var entity in entities)
            {
                models.Add(new TransactionModel
                {
                    Id = entity.Id,
                    UserId = entity.User.Id,
                    User = _userService.GetUser(entity.User.Id),
                    ItemId = entity.TransactionItem.Id,
                    Item = GetTransactionItems().FirstOrDefault(f => f.Id == entity.TransactionItem.Id),
                    Value = entity.Value,
                    CreatedTime = entity.CreatedTime,
                    Type = entity.IsIncome ? BaseModel.TypeEnum.Income : BaseModel.TypeEnum.Expense
                });
            }
            return models;
        }

        public List<TransactionItemModel> GetTransactionItems()
        {
            if (TransactionItems == null)
            {
                return ForceGetTransactionItems();
            }
            return TransactionItems;
        }

        public List<TransactionItemModel> ForceGetTransactionItems()
        {
            var transactions = Context.TransactionItems.ToList();
            TransactionItems = new List<TransactionItemModel>();
            foreach (var e in transactions)
            {
                TransactionItems.Add(new TransactionItemModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    CategoryId = e.Category.Id,
                    Category = _categoryService.GetCategory(e.Category.Name),
                    LastValue = e.LastValue,
                    Type = e.IsIncome ? BaseModel.TypeEnum.Income : BaseModel.TypeEnum.Expense
                });
            }
            return TransactionItems;
        }
        #endregion
        
        //SaveTransaction()
        //SaveTransactionItem()
        //SaveTransactionItemFromFile()
        #region SaveToDB
        public TransactionEntity SaveTransaction(TransactionModel transactionModel)
        {
            if (string.IsNullOrWhiteSpace(transactionModel.Item.Name))
                return null;
            transactionModel.Item.LastValue = transactionModel.Value;
            transactionModel.Item.Type = transactionModel.Type;
            TransactionEntity entity = new TransactionEntity
            {
                TransactionItem = SaveTransactionItem(transactionModel.Item),
                CreatedTime = transactionModel.CreatedTime,
                User = Context.Users.First(e => e.Id == _userService.LoggedInUser.Id) ??
                       Context.Users.First(e => e.UserName == _userService.LoggedInUser.UserName),
                UserId = _userService.LoggedInUser.Id,
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
            var entity = Context.TransactionItems.FirstOrDefault(e => e.Name == transactionItemModel.Name);
            if (entity != null)
            {
                if (entity.LastValue != transactionItemModel.LastValue)
                {
                    entity.LastValue = transactionItemModel.LastValue;
                    Context.SaveChanges();
                }
                if (entity.Category.Name != transactionItemModel.CategoryName
                 && !string.IsNullOrWhiteSpace(transactionItemModel.CategoryName))
                {
                    entity.Category = _categoryService.SaveCategory(transactionItemModel.Category);
                    Context.SaveChanges();
                }
                return Context.TransactionItems.FirstOrDefault(e => e.Name == transactionItemModel.Name);
            }
            entity = new TransactionItemEntity
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

        public TransactionItemEntity SaveTransactionItemFromFile(TransactionItemModel transactionItemModel)
        {
            bool isNew = false;
            var entity = Context.TransactionItems.FirstOrDefault(e => e.Id == transactionItemModel.Id);
            if (entity == null)
            {
                entity = new TransactionItemEntity();
                isNew = true;
            }
            if(!isNew && entity.Name != transactionItemModel.Name ||
                entity.IsIncome != (transactionItemModel.Type == BaseModel.TypeEnum.Income) ||
                entity.LastValue != transactionItemModel.LastValue ||
               (entity.Category.Name != transactionItemModel.CategoryName && 
               !string.IsNullOrWhiteSpace(transactionItemModel.CategoryName)))
            {
                entity.Name = transactionItemModel.Name;
                entity.Category = _categoryService.SaveCategory(transactionItemModel.Category);
                entity.IsIncome = transactionItemModel.Type == BaseModel.TypeEnum.Income;
                entity.LastValue = transactionItemModel.LastValue;
                entity.CategoryId = entity.Category.Id;
            }
            if(isNew) Context.TransactionItems.Add(entity);
            Context.SaveChanges();
            return entity;
        }
        #endregion

        //SaveTransactionsAsync()
        //SaveTransactionItemsAsync()
        #region SaveToDBAsync
        public async Task<bool> SaveTransactionsAsync(string filePath)
        {
            List<TransactionModel> transactions;
            using (StreamReader reader = (new StreamReader(filePath, Encoding.GetEncoding("ISO-8859-2"))))
            {
                var csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ";";
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.RegisterClassMap<TransactionClassMap>();
                transactions = new List<TransactionModel>(csv.GetRecords<TransactionModel>().ToList());
            }
            foreach (var transaction in transactions)
            {
                var transactionTemp = transaction;
                transactionTemp.User = _userService.LoggedInUser;
                await Task.Run(() =>
                {
                    SaveTransaction(transactionTemp);
                });
            }
            return true;
        }

        public async Task<bool> SaveTransactionItemsAsync(string filePath)
        {
            List<TransactionItemModel> items = null;
            await Task.Run(() =>
            {
                using (StreamReader reader = (new StreamReader(filePath, Encoding.GetEncoding("ISO-8859-2"))))
                {
                    var csv = new CsvReader(reader);
                    csv.Configuration.Delimiter = ";";
                    csv.Configuration.HasHeaderRecord = true;
                    csv.Configuration.RegisterClassMap<TransactionItemClassMap>();
                    items = new List<TransactionItemModel>(csv.GetRecords<TransactionItemModel>().ToList());
                }
            });
            foreach (var item in items)
            {
                var itemTemp = item;
                await Task.Run(() =>
                {
                    SaveTransactionItemFromFile(itemTemp);
                });
            }
            return true;
        }
        #endregion

        //SaveTransactionsToFile()
        //SaveTransactionItemsToFile()
        #region SaveToFile
        public void SaveTransactionsToFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                CsvWriter csv = new CsvWriter(sw);
                csv.Configuration.RegisterClassMap<TransactionClassMap>();
                csv.Configuration.Delimiter = ";";
                csv.Configuration.QuoteAllFields = true;
                csv.WriteRecords(GetTransactions());
            }
        }

        public void SaveTransactionItemsToFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                CsvWriter csv = new CsvWriter(sw);
                csv.Configuration.RegisterClassMap<TransactionItemClassMap>();
                csv.Configuration.Delimiter = ";";
                csv.Configuration.QuoteAllFields = true;
                csv.WriteRecords(GetTransactionItems());
            }
        }
        #endregion
    }
}