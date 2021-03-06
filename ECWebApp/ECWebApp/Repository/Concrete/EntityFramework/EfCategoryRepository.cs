using ECWebApp.Entity;
using ECWebApp.Models;
using ECWebApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ECWebApp.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(AppContext context): base(context)
        {

        }
        public AppContext AppContext
        {
            get { return context as AppContext; }
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel()
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                Count = i.ProductCategories.Count()
            });
        }

        public Category GetByName(string name)
        {
            return AppContext.Categories
                .Where(i => i.CategoryName == name)
                .FirstOrDefault();
        }

        public void RemoveFromCategory(int ProductId, int CategoryId)
        {
            var cmd = $"delete from ProductCategory where ProductId={ProductId} and CategoryId={CategoryId}";
            context.Database.ExecuteSqlRaw(cmd);
        }
    }
}
