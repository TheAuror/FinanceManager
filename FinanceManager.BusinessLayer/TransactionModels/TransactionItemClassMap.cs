using CsvHelper.Configuration;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public sealed class TransactionItemClassMap : CsvClassMap<TransactionItemModel>
    {
        public TransactionItemClassMap()
        {
            Map(m => m.Id).Index(0);
            Map(m => m.Name).Index(1);
            Map(m => m.CategoryName).Index(2);
            Map(m => m.LastValue).Index(3);
        }
    }
}