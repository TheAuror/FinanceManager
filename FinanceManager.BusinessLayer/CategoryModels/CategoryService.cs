using System.Collections.Generic;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.DataLayer;

namespace FinanceManager.BusinessLayer.CategoryModels
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(ISampleContext context) : base(context)
        {
        }

        public CategoryModel GetCategory(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<CategoryModel> GetCategorys()
        {
            throw new System.NotImplementedException();
        }

        public void SaveCategory(CategoryModel category)
        {
            throw new System.NotImplementedException();
        }
    }
}