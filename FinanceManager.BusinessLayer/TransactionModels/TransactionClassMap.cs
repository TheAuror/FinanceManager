using CsvHelper.Configuration;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public sealed class TransactionClassMap : CsvClassMap<TransactionModel>
    {
        public TransactionClassMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.ItemName).Name("Name");
            Map(m => m.CategoryName).Name("CategoryName");
            Map(m => m.Value).Name("Value");
            Map(m => m.CreatedTime).Name("CreatedDate");
        }
    }
}