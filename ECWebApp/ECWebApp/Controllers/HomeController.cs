using ECWebApp.Entity;
using ECWebApp.Models;
using ECWebApp.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            return View(uow.Products.GetAll().Where(i => i.IsApproved && i.IsHome).ToList());
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactModel sendMailDto)
        {
            if (!ModelState.IsValid) return View();

            try
            {
                MailMessage mail = new MailMessage();
                // you need to enter your mail address
                mail.From = new MailAddress("alexander.romaguera96@ethereal.email");

                //To Email Address - your need to enter your to email address
                mail.To.Add("alexander.romaguera96@ethereal.email");

                mail.Subject = sendMailDto.Subject;

                //you can specify also CC and BCC - i will skip this
                //mail.CC.Add("");
                //mail.Bcc.Add("");

                mail.IsBodyHtml = true;

                string content = "Name : " + sendMailDto.Name;
                content += "<br/> Message : " + sendMailDto.Message;

                mail.Body = content;


                //create SMTP instant

                //you need to pass mail server address and you can also specify the port number if you required
                SmtpClient smtpClient = new SmtpClient("smtp.ethereal.email");

                //Create nerwork credential and you need to give from email address and password
                NetworkCredential networkCredential = new NetworkCredential("alexander.romaguera96@ethereal.email", "kPh9W1KVvtn4jXwDSB");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587; // this is default port number - you can also change this
                smtpClient.EnableSsl = false; // if ssl required you need to enable it
                smtpClient.Send(mail);

                ViewBag.Message = "Mail Send";

                // now i need to create the from 
                ModelState.Clear();

            }
            catch (Exception ex)
            {
                //If any error occured it will show
                ViewBag.Message = ex.Message.ToString();
            }
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
