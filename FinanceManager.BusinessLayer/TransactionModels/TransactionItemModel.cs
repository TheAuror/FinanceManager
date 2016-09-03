using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.Common;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public class TransactionItemModel : BaseModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int? CategoryId { get; set; }
        public virtual CategoryModel Category { get; set; }
        public virtual int? LastValue { get; set; }
        public virtual TypeEnum Type { get; set; }
    }
}
