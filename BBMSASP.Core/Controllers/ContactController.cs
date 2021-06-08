using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using BBMSASP.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMailService _emailService;
        public ContactController(ApplicationDbContext dbContext, IMailService mailService)
        {
            _dbContext = dbContext;
            _emailService = mailService;
        }
        [Route("/Contact-Us")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactUS model)
        {
            if (ModelState.IsValid)
            {
                model.EntryDate = DateTime.Now;
                model.IsRead = false;
                _dbContext.ContactUs.Add(model);
                _dbContext.SaveChanges();
                 _emailService.SendEmailAsync("nazrulbspi5@gmail.com", "Message From Contact Us", "<p>Name:"+model.Name+"<br>Email:"+model.Email+"<br> Message:"+model.Message+"<br></p>");

                ModelState.Clear();
            }
            return View();
        }

    }
}
