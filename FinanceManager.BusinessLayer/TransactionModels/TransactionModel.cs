using System;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.UserModels;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public class TransactionModel : BaseModel
    {
        public virtual int Id { get; set; }
        public virtual int? UserId { get; set; }
        public virtual UserModel User { get; set; }
        public virtual int? ItemId { get; set; }
        public virtual TransactionItemModel Item { get; set; }
        public virtual int Value { get; set; }
        public virtual DateTime CreatedTime { get; set; }
        public virtual TypeEnum Type { get; set; }
    }
}
