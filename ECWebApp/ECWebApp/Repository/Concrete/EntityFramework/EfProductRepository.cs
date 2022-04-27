using ECWebApp.Entity;
using ECWebApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECWebApp.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        private AppContext context;

        public EfProductRepository(AppContext ctx)
        {
            context = ctx;
        }

        public void Add(Product entity)
        {
            context.Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            context.Products.Remove(entity);
        }

        public void Edit(Product entity)
        {
            context.Entry<Product>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            return context.Products.Where(predicate);
        }

        public Product Get(int id)
        {
            return context.Products.FirstOrDefault(i => i.ProductId == id);
        }

        public IQueryable<Product> GetAll()
        {
            return context.Products;
        }

        public List<Product> GetTop5Products()
        {
            return context.Products.OrderByDescending(i => i.ProductId)
                .Take(5)
                .ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
