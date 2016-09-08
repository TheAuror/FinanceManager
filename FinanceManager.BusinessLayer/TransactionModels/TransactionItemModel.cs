using System.Dynamic;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.Common;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public sealed class TransactionItemModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public CategoryModel Category { get; set; } = new CategoryModel();

        public string CategoryName
        {
            get { return Category.Name; }
            set { Category.Name = value; }
        }
        public int? LastValue { get; set; }
        public TypeEnum Type { get; set; }
        public string TypeString => Type == TypeEnum.Income ? "Bevétel" : "Kiadás";
    }
}
