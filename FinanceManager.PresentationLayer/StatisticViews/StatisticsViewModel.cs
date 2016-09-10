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
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Dif => Num1 - Num2;
    }
    public class StatisticsViewModel
    {
        private readonly ITransactionService _transactionService;
        private List<TransactionModel> _allTransaction; 

        public StatisticsViewModel(ITransactionService transactionService)
        {
            _transactionService = transactionService;
            TopList = new BindingList<RowModel>();
            BottomList = new BindingList<RowModel>();
        }

        public BindingList<RowModel> TopList { get; set; }
        public BindingList<RowModel> BottomList { get; set; }

        public void UpdateTopList(bool isMontly)
        {
            _allTransaction = _transactionService.GetTransactions();
            TopList.Clear();
            string sumBy = isMontly ? "MMMM" : "yyyy";
            if (isMontly)
            {
                foreach (var month in DateTimeFormatInfo.CurrentInfo?.MonthNames)
                {
                    if(!string.IsNullOrEmpty(month))
                        TopList.Add(new RowModel{ RowName = month });
                }                
            }
            else
            {
                int thisYear = int.Parse(DateTime.Now.ToString("yyyy"));
                for (int i = thisYear; i > thisYear - 12; i--)
                {
                    TopList.Add(new RowModel{ RowName = i.ToString() });
                }
            }
            foreach (var transaction in _allTransaction)
            {
                if (TopList.All(e => e.RowName != transaction.CreatedTime.ToString(sumBy)))
                {
                    TopList.Add(new RowModel{ RowName = transaction.CreatedTime.ToString(sumBy) });
                }
                if (transaction.Type == BaseModel.TypeEnum.Income)
                {
                    TopList.First(e => e.RowName == transaction.CreatedTime.ToString(sumBy)).Num1 += transaction.Value;
                }
                if (transaction.Type == BaseModel.TypeEnum.Expense)
                {
                    TopList.First(e => e.RowName == transaction.CreatedTime.ToString(sumBy)).Num2 += transaction.Value;
                }
            }
        }
    }
}