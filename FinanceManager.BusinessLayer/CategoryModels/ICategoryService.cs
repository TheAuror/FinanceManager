using System.Collections.Generic;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.BusinessLayer.CategoryModels
{
    public interface ICategoryService
    {
        CategoryModel GetCategory(string name);
        List<CategoryModel> GetCategorys();
        CategoryEntity SaveCategory(CategoryModel category);
    }
}