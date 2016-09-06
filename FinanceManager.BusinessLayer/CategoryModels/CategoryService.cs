using System;
using System.Collections.Generic;
using System.Linq;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.DataLayer;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.BusinessLayer.CategoryModels
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(ISampleContext context) : base(context)
        {
        }

        public CategoryModel GetCategory(string name)
        {
            if (Context.Categorys.Any(e => e.Name == name))
            {
                return GetCategorys().FirstOrDefault(e => string.Equals(name, e.Name, StringComparison.CurrentCultureIgnoreCase));
            }
            else
            {
                return null;
            }
        }

        public List<CategoryModel> GetCategorys()
        {
            return Context.Categorys.Select(e => new CategoryModel
            {
                Id = e.Id,
                Name = e.Name
            }).ToList();
        }

        public CategoryEntity SaveCategory(CategoryModel category)
        {
            if (category == null)
            {
                return Context.Categorys.First(e => e.Name == "Default");
            }
            if (Context.Categorys.Any(e => e.Name == category.Name))
            {
                return Context.Categorys.First(e => e.Name == category.Name);
            }
            CategoryEntity entity = new CategoryEntity
            {
                Name = category.Name
            };
            Context.Categorys.Add(entity);
            Context.SaveChanges();
            return entity;
        }
    }
}