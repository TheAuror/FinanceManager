using System;

namespace FinanceManager.DataLayer.Entities
{
    public class TransactionEntity
    {
        public virtual int Id { get; set; }
        public virtual int? UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual int? TransactionItemId { get; set; }
        public virtual TransactionItemEntity TransactionItem { get; set; }
        public virtual int Value { get; set; }
        public virtual DateTime CreatedTime { get; set; }
        public virtual bool IsIncome { get; set; }
    }
}
