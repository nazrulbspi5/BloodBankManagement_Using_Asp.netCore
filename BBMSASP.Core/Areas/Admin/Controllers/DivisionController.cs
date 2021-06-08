using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DivisionController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public DivisionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.Divisions.ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public IActionResult Create(DivisionModel model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Divisions.Add(model);
                _dbContext.SaveChanges();
                ViewBag.Message = "Division Add Successfully";
                ViewBag.Type = "Success";
                ModelState.Clear();
            }
            return View();
        }
        [Route("/Admin/Division/Edit/{divisionId:int}")]
        public IActionResult Edit(int divisionId)
        {
            var division = _dbContext.Divisions.Find(divisionId);
            return View(division);
           
        }
        [HttpPost]
        [Route("/Admin/Division/Edit/{divisionId:int}")]
        public IActionResult Edit(int divisionId, DivisionModel model)
        {
            var division = _dbContext.Divisions.Find(divisionId);
            division.DivisionName = model.DivisionName;
            _dbContext.Divisions.Update(division);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
