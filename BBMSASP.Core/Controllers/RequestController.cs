using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using BBMSASP.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Controllers
{
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMailService _emailService;
        public RequestController(ApplicationDbContext dbContext, IMailService mailService)
        {
            _dbContext = dbContext;
            _emailService = mailService;
        }
        [Route("Blood-Request")]
        [HttpGet]
        public IActionResult Index()
        {
           
            ViewBag.BloodGroupList = _dbContext.BloodGroups.ToList();
            ViewBag.DivisionList = _dbContext.Divisions.ToList();
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        [Route("Blood-Request")]
        public IActionResult Index(RequestModel model)
        {
            if (ModelState.IsValid)
            {
                model.Status = "Pending";
                model.IsApproved = false;
                _dbContext.BloodRequests.Add(model);
                _dbContext.SaveChanges();
                
                
                ViewBag.Message = "Blood request send successfully";
                ViewBag.Type = "Success";
                ModelState.Clear();
                
            }
            ViewBag.BloodGroupList = _dbContext.BloodGroups.ToList();
            ViewBag.DivisionList = _dbContext.Divisions.ToList();
            return View();
        }
    }
}
