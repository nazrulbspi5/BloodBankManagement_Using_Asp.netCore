using BBMSASP.Core.Areas.Admin.Models;
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
    public class BloodGroupController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public BloodGroupController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // [Route("Admin/Add-BloodGroup")]
        public IActionResult Index()
        {
            BloodGroupViewModel model = new BloodGroupViewModel();
            model.BloodGroupList = _dbContext.BloodGroups.ToList();
            model.BloodGroups = null;
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(BloodGroup model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.BloodGroups.Add(model);
                _dbContext.SaveChanges();
                ModelState.Clear();
            }

            BloodGroupViewModel viewModel = new BloodGroupViewModel();
            viewModel.BloodGroupList = _dbContext.BloodGroups.ToList();
            viewModel.BloodGroups = null;
            return View(viewModel);
        }
        [Route("/Admin/BloodGroup/Edit/{bloodGroupId:int}")]

        public IActionResult Edit(int bloodGroupId)
        {
            var bloodGroup = _dbContext.BloodGroups.Find(bloodGroupId);
            return View(bloodGroup);
        }
        [HttpPost]
        [Route("/Admin/BloodGroup/Edit/{bloodGroupId:int}")]
        public IActionResult Edit(int bloodGroupId, BloodGroup model)
        {
            var bloodGroup = _dbContext.BloodGroups.Find(bloodGroupId);
            bloodGroup.GroupName = model.GroupName;
            _dbContext.BloodGroups.Update(bloodGroup);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            BloodGroupViewModel model = new BloodGroupViewModel();
            model.BloodGroupList = _dbContext.BloodGroups.ToList();
            model.BloodGroups = null;
            return View(model);
        }
        //[HttpGet]
        [Route("/Admin/BloodGroup/Delete/{bloodGroupId:int}")]
        public IActionResult Delete(int bloodGroupId)
        {

            var bloodGroup = _dbContext.BloodGroups.Find(bloodGroupId);
            if (bloodGroup != null)
            {
                _dbContext.Remove(bloodGroup);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        //[HttpPost]
       
        //public IActionResult Delete(int bloodGroupId, BloodGroup bloodGroups)
        //{
            
        //    var bloodGroup = _dbContext.BloodGroups.Find(bloodGroupId);
        //    if (bloodGroup != null)
        //    {
        //        _dbContext.Remove(bloodGroup);
        //        _dbContext.SaveChanges();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    return View(bloodGroup);
        //}
    }
}
