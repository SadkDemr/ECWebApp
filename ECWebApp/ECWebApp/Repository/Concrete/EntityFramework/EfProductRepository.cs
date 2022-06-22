using ECWebApp.Entity;
using ECWebApp.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
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

        public void Update(Product entity, int[] CategoryIds)
        {
           
                var product = AppContext.Products
                    .Include(i => i.ProductCategories) // güncelleyeceğimiz alan
                    .FirstOrDefault(i => i.ProductId == entity.ProductId);
                if (product != null)
                {
                    product.ProductName = entity.ProductName;
                    product.Description = entity.Description;
                    product.Image = entity.Image;
                    product.IsHome = entity.IsHome;
                    product.IsApproved = entity.IsApproved;
                    product.IsFeatured = entity.IsFeatured;


                    product.ProductCategories = CategoryIds.Select(catid => new ProductCategory()
                    {
                        CategoryId = catid,
                        ProductId = entity.ProductId
                    }).ToList();

                    context.SaveChanges(); // veritabanında değişiklikleri yaptır.
                }
            
        }

        List<Product> IProductRepository.GetTop5Products()
        {
            throw new NotImplementedException();
        }
    }
}
