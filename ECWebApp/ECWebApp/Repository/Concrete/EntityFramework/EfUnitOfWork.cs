using ECWebApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly AppContext dbcontext;
        public EfUnitOfWork(AppContext _dbcontext)
        {
            dbcontext = _dbcontext ?? throw new ArgumentNullException("dbcontext can not be null");
        }
        private IProductRepository _products;
        private ICategoryRepository _categories;

        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(dbcontext));
            }
        }
        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbcontext));
            }
        }

        public void Dispose()
        {
            dbcontext.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
             return   dbcontext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
