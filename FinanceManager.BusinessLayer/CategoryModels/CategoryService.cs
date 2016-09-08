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

        private List<CategoryModel> Categorys { get; set; }     

        public CategoryModel GetCategory(string name)
        {
            if(Categorys == null)
                GetCategorys();
            if (Categorys != null && Categorys.Any(e => e.Name == name))
            {
                return GetCategorys().FirstOrDefault(e => string.Equals(name, e.Name, StringComparison.CurrentCultureIgnoreCase));
            }
            return null;
        }

        public List<CategoryModel> GetCategorys()
        {
            return Categorys ?? (Categorys = Context.Categorys.Select(e => new CategoryModel
            {
                Id = e.Id,
                Name = e.Name
            }).ToList());
        }

        public CategoryEntity SaveCategory(CategoryModel category)
        {
            if (string.IsNullOrEmpty(category.Name))
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
            ForceUpdateCategorys();
            return entity;
        }

        public List<CategoryModel> ForceUpdateCategorys()
        {
            return (Categorys = Context.Categorys.Select(e => new CategoryModel
            {
                Id = e.Id,
                Name = e.Name
            }).ToList());
        }
    }
}