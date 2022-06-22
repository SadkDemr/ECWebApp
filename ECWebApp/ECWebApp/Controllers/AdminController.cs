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
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ECWebApp.Controllers
{
    public class AdminController : Controller
    {
        private IUnitOfWork unitofWork;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        

        public AdminController(IUnitOfWork _unitofWork, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            unitofWork = _unitofWork;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var entity = unitofWork.Categories.GetAll()
                                .Include(i => i.ProductCategories)
                                .ThenInclude(i => i.Product)
                                .Where(i => i.CategoryId == id)
                                .Select(i => new AdminEditCategoryModel()
                                {
                                    CategoryId = i.CategoryId,
                                    CategoryName = i.CategoryName,
                                    Products = i.ProductCategories.Select(a => new AdminEditCategoryProduct()
                                    {
                                        ProductId = a.ProductId,
                                        ProductName = a.Product.ProductName,
                                        Image = a.Product.Image,
                                        IsApproved = a.Product.IsApproved,
                                        IsFeatured = a.Product.IsFeatured,
                                        IsHome = a.Product.IsHome
                                    }).ToList()
                                }).FirstOrDefault();

            return View(entity);
        }

        [HttpPost]
        public IActionResult EditCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitofWork.Categories.Edit(entity);
                unitofWork.SaveChanges();

                return RedirectToAction("CatalogList");
            }

            return View("Error");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromCategory(int ProductId, int CategoryId)
        {
            if (ModelState.IsValid)
            {
                //silme
                unitofWork.Categories.RemoveFromCategory(ProductId, CategoryId);
                unitofWork.SaveChanges();
                return Ok();
            }
            return BadRequest();
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

        [HttpPost]
        public IActionResult DeleteCategory(int CategoryId)
        {
            var entity = unitofWork.Categories.Get(CategoryId);

            if (entity != null)
            {
                unitofWork.Categories.Delete(entity);
                
            }

            unitofWork.SaveChanges();
            return RedirectToAction("CatalogList");
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

        [HttpGet]
        public IActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = unitofWork.Products.GetAll()
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Product)
                .Where(i => i.ProductId == id)
                .Select(i => new ProductModel()
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Image = i.Image,
                    Description = i.Description,
                    IsApproved = i.IsApproved,
                    IsFeatured = i.IsFeatured,
                    IsHome = i.IsHome,

                    SelectedCategories = i.ProductCategories.Select(c => c.Category).ToList()

                }).FirstOrDefault();

            ViewBag.Categories = unitofWork.Categories.GetAll();
            unitofWork.SaveChanges();

            return View(entity);

        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductModel model, int[] CategoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {

                var entity = unitofWork.Products.Get(model.ProductId);
                //var id = model.ProductId;
                //var entity = _productRepository.Get(model.ProductId);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.ProductName = model.ProductName;
                entity.Description = model.Description;
                entity.IsHome = model.IsHome;
                entity.IsApproved = model.IsApproved;
                entity.IsFeatured = model.IsFeatured;
             
                //entity.ImageUrl = model.ImageUrl; --> ImageUrl yi file olarak yüklüyoruz.
                

                if (file != null) // kullanıcı bir resim göndermiş ise.
                {
                    entity.Image = file.FileName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", file.FileName);
                    var path_tn = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products\\tn", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream); // asenktron saklama
                    }
                }

                entity.DateAdded = DateTime.Now;
                unitofWork.Products.Update(entity, CategoryIds);

                ViewBag.Categories = unitofWork.Categories.GetAll();

                unitofWork.SaveChanges();

                return RedirectToAction("CatalogList");
            }

          /*  ViewBag.Categories = unitofWork.Categories.GetAll();*/ // GetAll  ile bütün Category bilgilerini alıyoruz.

            
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            var entity = unitofWork.Products.Get(ProductId);

            if (entity != null)
            {
                unitofWork.Products.Delete(entity);
            }

            unitofWork.SaveChanges();
            return RedirectToAction("CatalogList");
        }

    }
}