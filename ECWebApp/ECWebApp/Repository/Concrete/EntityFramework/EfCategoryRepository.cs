﻿using ECWebApp.Entity;
using ECWebApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECWebApp.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private AppContext context;
        public EfCategoryRepository(AppContext ctx)
        {
            context = ctx;
        }
        public void Add(Category entity)
        {
            context.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            context.Categories.Remove(entity);
        }

        public void Edit(Category entity)
        {
            context.Entry<Category>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Category> Find(Expression<Func<Category, bool>> predicate)
        {
            return context.Categories.Where(predicate);
        }

        public Category Get(int id)
        {
            return context.Categories.FirstOrDefault(i => i.CategoryId == id);
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public Category GetByName(string name)
        {
            return context.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}