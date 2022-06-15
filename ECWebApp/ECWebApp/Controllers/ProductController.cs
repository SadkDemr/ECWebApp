using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECWebApp.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using ECWebApp.Models;

namespace ECWebApp.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 2;
        private IProductRepository repository;

        public ProductController(IProductRepository _repository)
        {
            repository = _repository;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category, int page = 1)
        {
            var products = repository.GetAll();

            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .Where(i => i.ProductCategories.Any(a => a.Category.CategoryName == category));
            }
            var count = products.Count();

            products = products.Skip((page - 1) * PageSize).Take(PageSize);

            return View(
                new ProductListModel()
                {
                    Products = products,
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = count
                    }
                }
                );
        }

        public IActionResult Details(int id=5)
        {
            return View(repository
                .GetAll()
                .Where(i => i.ProductId == id)
                .Include(i => i.Images)
                .Include(i => i.Attributes)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .Select(i => new ProductDetailsModel()
                {
                 
                    Product = i,
                    Images = i.Images,
                    Attributes = i.Attributes,
                    Categories = i.ProductCategories.Select(a => a.Category).ToList()
                })
                .FirstOrDefault()); 
        }
    }
}