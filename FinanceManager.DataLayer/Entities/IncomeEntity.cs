using System;

namespace FinanceManager.DataLayer.Entities
{
    public class IncomeEntity
    {
        public virtual int Id { get; set; }
        public virtual int? UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual int? IncomeItemId { get; set; }
        public virtual IncomeItemEntity IncomeItem { get; set; }
        public virtual int Value { get; set; }
        public virtual DateTime CreatedTime { get; set; }
    }
}
