using ECWebApp.Entity;
using ECWebApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECWebApp.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {
        public EfProductRepository(AppContext context) :base(context)
        {

        }
        public AppContext AppContext
        {
            get { return context as AppContext; }
        }

        public List<Product> GetTop5Products()
        {
            return AppContext.Products.OrderByDescending(i => i.ProductId)
                .Take(5)
                .ToList();
        }

        
    }
}
