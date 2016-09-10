using System;
using System.ComponentModel;
using System.Linq;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.TransactionModels;

namespace FinanceManager.PresentationLayer.StatisticViews
{
    public class RowModel
    {
        public string RowName;
        public int Num1;
        public int Num2;
    }
    public class StatisticsViewModel
    {
        private readonly ITransactionService _transactionService;
        public BindingList<RowModel> TopList = new BindingList<RowModel>();
        public BindingList<RowModel> BottomList;

        public StatisticsViewModel(ITransactionService transactionService)
        {
            _transactionService = transactionService;
            TopList = new BindingList<RowModel>();
            BottomList = new BindingList<RowModel>();
        }

        public void UpdateTopList(bool isMontly)
        {
            var transactions = _transactionService.GetTransactions();
            TopList.Clear();
            if (isMontly)
            {
                foreach (var transaction in transactions)
                {
                    if (transaction.CreatedTime.ToString("yyyy") != DateTime.Now.ToString("yyyy"))
                    {
                        continue;
                    }
                    if (TopList.All(e => e.RowName != transaction.CreatedTime.ToString("MMMM")))
                    {
                        TopList.Add(new RowModel
                        {
                            RowName = transaction.CreatedTime.ToString("MMMM"),
                            Num1 = 0,
                            Num2 = 0
                        });
                    }
                    if (transaction.Type == BaseModel.TypeEnum.Income)
                    {
                        var temp = TopList.FirstOrDefault(e => e.RowName == transaction.CreatedTime.ToString("MMMM"));
                        if (temp != null) temp.Num1 += transaction.Value;
                    }
                    if (transaction.Type == BaseModel.TypeEnum.Expense)
                    {
                        var temp = TopList.FirstOrDefault(e => e.RowName == transaction.CreatedTime.ToString("MMMM"));
                        if (temp != null) temp.Num2 -= transaction.Value;
                    }
                }
            }
        }
    }
}