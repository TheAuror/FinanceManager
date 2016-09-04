namespace FinanceManager.DataLayer.Entities
{
    public class TransactionItemEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int? CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public virtual int? LastValue { get; set; }
        public virtual bool IsIncome { get; set; }
    }
}
