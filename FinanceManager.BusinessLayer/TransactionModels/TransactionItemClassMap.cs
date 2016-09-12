using CsvHelper.Configuration;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public sealed class TransactionItemClassMap : CsvClassMap<TransactionItemModel>
    {
        public TransactionItemClassMap()
        {
            Map(m => m.Id).Name("Id").Default(0);
            Map(m => m.Name).Name("Name");
            Map(m => m.CategoryName).Name("CategoryName");
            Map(m => m.LastValue).Name("Value");
        }
    }
}