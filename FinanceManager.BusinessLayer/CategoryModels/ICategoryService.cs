using System.Collections.Generic;

namespace FinanceManager.BusinessLayer.CategoryModels
{
    public interface ICategoryService
    {
        CategoryModel GetCategory(string name);
        List<CategoryModel> GetCategorys();
        void SaveCategory(CategoryModel category);
    }
}