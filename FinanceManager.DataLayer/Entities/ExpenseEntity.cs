using System;

namespace FinanceManager.DataLayer.Entities
{
    public class ExpenseEntity
    {
        public virtual int Id { get; set; }
        public virtual int? UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual int? ExpenseItemId { get; set; }
        public virtual ExpenseItemEntity ExpenseItem { get; set; }
        public virtual int Value { get; set; }
        public virtual DateTime CreatedTime { get; set; }
    }
}
