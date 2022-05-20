using ECWebApp.Entity;
using ECWebApp.Models;
using ECWebApp.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        private IUnitOfWork uow;

        public HomeController(IUnitOfWork _uow, IProductRepository _repository)
        {
            repository = _repository;
            uow = _uow;
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(uow.Products.GetAll().Where(i=>i.IsApproved && i.IsHome).ToList());
        }

        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }

        public IActionResult Create()
        {
            var prd = new Product() { ProductName = "Yeni ürün" };
            uow.Products.Add(prd);
            uow.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
