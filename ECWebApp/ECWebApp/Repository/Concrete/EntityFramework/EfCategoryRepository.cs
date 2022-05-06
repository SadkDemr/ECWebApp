using ECWebApp.Entity;
using ECWebApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

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
        public Category GetByName(string name)
        {
            return AppContext.Categories
                .Where(i => i.CategoryName == name)
                .FirstOrDefault();
        }
    }
}
