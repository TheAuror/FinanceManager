using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.TransactionModels;

namespace FinanceManager.PresentationLayer.StatisticViews
{
    public class RowModel : BaseModel
    {
        public string RowName { get; set; }
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Dif => Num1 - Num2;
    }
    public class StatisticsViewModel
    {
        private readonly ITransactionService _transactionService;
        private List<TransactionModel> _allTransaction; 

        public StatisticsViewModel(ITransactionService transactionService)
        {
            _transactionService = transactionService;
            TopList = new BindingList<RowModel>();
            BottomLeftList = new BindingList<RowModel>();
            BottomRightList = new BindingList<RowModel>();
        }

        public BindingList<RowModel> TopList { get; set; }
        public BindingList<RowModel> BottomLeftList { get; set; }
        public BindingList<RowModel> BottomRightList { get; set; }
        public bool IsMontly { get; set; } = true;
        public string SumBy => IsMontly ? "MMMM" : "yyyy";
        public string SelectedRow { get; set; }

        public void UpdateTopList()
        {
            _allTransaction = _transactionService.GetTransactions();
            TopList.Clear();
            if (IsMontly)
            {
                foreach (var month in (DateTimeFormatInfo.CurrentInfo?.MonthNames).Where(month => !string.IsNullOrEmpty(month)))
                {
                    TopList.Add(new RowModel{ RowName = month });
                }                
            }
            else
            {
                int thisYear = int.Parse(DateTime.Now.ToString(SumBy));
                for (int i = thisYear; i > thisYear - 12; i--)
                {
                    TopList.Add(new RowModel{ RowName = i.ToString() });
                }
            }
            foreach (var transaction in _allTransaction)
            {
                if (TopList.All(e => e.RowName != transaction.CreatedTime.ToString(SumBy)))
                {
                    TopList.Add(new RowModel{ RowName = transaction.CreatedTime.ToString(SumBy) });
                }
                switch (transaction.Type)
                {
                    case BaseModel.TypeEnum.Income:
                        TopList.First(e => e.RowName == transaction.CreatedTime.ToString(SumBy)).Num1 += transaction.Value;
                        break;
                    case BaseModel.TypeEnum.Expense:
                        TopList.First(e => e.RowName == transaction.CreatedTime.ToString(SumBy)).Num2 += transaction.Value;
                        break;
                }
            }
        }

        public void UpdateBottomLists()
        {
            BottomLeftList.Clear();
            BottomRightList.Clear();
            int leftSum = 0, rightSum = 0;
            foreach (var transaction in _allTransaction)
            {
                if(transaction.CreatedTime.ToString(SumBy) != SelectedRow)
                    continue;
                var list = transaction.Type == BaseModel.TypeEnum.Income ? BottomLeftList : BottomRightList;
                if (list.All(e => e.RowName != transaction.CategoryName))
                {
                    list.Add(new RowModel { RowName = transaction.CategoryName });
                }
                list.First(e => e.RowName == transaction.CategoryName).Num1 += transaction.Value;
                if (transaction.Type == BaseModel.TypeEnum.Income)
                    leftSum += transaction.Value;
                else
                    rightSum += transaction.Value;
            }
            foreach (var category in BottomLeftList)
            {
                category.Num2 = category.Num1 / leftSum;
            }
            foreach (var category in BottomRightList)
            {
                category.Num2 = category.Num1 / rightSum;
            }
        }
    }
}