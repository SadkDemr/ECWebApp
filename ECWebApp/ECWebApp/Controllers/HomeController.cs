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

        public HomeController(IProductRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            return View(repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }

    }
}
