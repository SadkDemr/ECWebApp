using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECWebApp.Repository.Abstract;
using ECWebApp.Models;
using ECWebApp.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ECWebApp.Controllers
{
    public class AdminController : Controller
    {
        private IUnitOfWork unitofWork;

        public AdminController(IUnitOfWork _unitofWork)
        {
            unitofWork = _unitofWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CatalogList()
        {
            var model = new CatalogListModel()
            {
                Categories = unitofWork.Categories.GetAll().ToList(),
                Products = unitofWork.Products.GetAll().ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitofWork.Categories.Add(entity);
                unitofWork.SaveChanges();

                return Ok(entity);
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(Product entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", file.FileName);
                    var path_tn = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products\\tn", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        entity.Image = file.FileName;
                    }

                    using (var stream = new FileStream(path_tn, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                entity.DateAdded = DateTime.Now;
                unitofWork.Products.Add(entity);
                unitofWork.SaveChanges();
                return RedirectToAction("CatalogList");
            }

            return View(entity);
        }
    }
}