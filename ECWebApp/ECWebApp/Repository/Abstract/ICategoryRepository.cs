using ECWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECWebApp.Repository.Abstract
{
    public interface ICategoryRepository: IGenericRepository<Category>
    {
        Category GetByName(string name);
     
    }
}
