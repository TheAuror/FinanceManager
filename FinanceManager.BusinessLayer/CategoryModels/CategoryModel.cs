using FinanceManager.BusinessLayer.Common;

namespace FinanceManager.BusinessLayer.CategoryModels
{
    public class CategoryModel : BaseModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
