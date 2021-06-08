using BBMSASP.Core.Areas.Admin.Models;
using BBMSASP.Core.Areas.Admin.Services;
using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Donor")]
    public class DonorController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IProfileService _profile;
       
        public DonorController(ApplicationDbContext dbContext, IProfileService profileService)
        {
            _dbContext = dbContext;
            _profile = profileService;
           
        }
        
        public IActionResult Index()
        {
            
            return View(_dbContext.Donors.Include(x=>x.BloodGroup).Include(x=>x.Divisions).Include(x=>x.Districts).Include(x=>x.Upazilas).ToList());
        }
        [Route("/Admin/Blood-Donation")]
        [HttpGet]
        public IActionResult Donation()
        {
            return View();
        }
        [HttpPost]
        [Route("/Admin/Blood-Donation")]
        public IActionResult Donation(Donation model)
        {
            if (ModelState.IsValid)
            {
               DonorModel donorModel = _profile.Donors(User.Identity.Name);
                model.DonorId = donorModel.DonorId;
                donorModel.LastDonationDate = model.DonationDate;
                _dbContext.Donors.Update(donorModel);
                _dbContext.SaveChanges();
                _dbContext.Donations.Add(model);
                _dbContext.SaveChanges();
                ModelState.Clear();
                TempData["saved"] = "Succuessfully added.";
                return RedirectToAction(nameof(DonationHistory));
            }
            return View();
        }
        [Route("/Admin/Donation-History")]
        public IActionResult DonationHistory()
        {
            return View(_dbContext.Donations.ToList());
        }
        [Route("/Admin/Dono/{donationId:int}")]
        public IActionResult DeleteDonatin(int donationId)
        {
            return View();
        }
        public IActionResult Profile()
        {
            ViewBag.BloodGroupList = _dbContext.BloodGroups.ToList();
            ViewBag.DivisionList = _dbContext.Divisions.ToList();
            
            DonorModel donorModel = _dbContext.Donors.Include(x => x.BloodGroup)
               .Include(x => x.Divisions)
               .Include(x => x.Districts)
               .Include(x => x.Upazilas)
               .FirstOrDefault(x => x.UserName == User.Identity.Name);
            ViewBag.DistrictList = _dbContext.Districts.Where(x=>x.DivisionId==donorModel.DivisionId).ToList();
            ViewBag.UpazilaList = _dbContext.Upazilas.Where(x=>x.DivisionId==donorModel.DivisionId && x.DistrictId == donorModel.DistrictId).ToList();

            List<StatusModel> status = new List<StatusModel>() {
                new StatusModel() { Status="Donate blood."},
                new StatusModel() { Status="If urgent, I can donate."},
                new StatusModel() { Status="Not interested yet, Donate in future."}
            };
            ViewBag.StatusList = status;
            ViewBag.Message = "";
            return View(donorModel);
        }
        [HttpPost]
        public IActionResult Profile(DonorModel model)
        {
            if (ModelState.IsValid)
            {
                var donorModel = _dbContext.Donors.FirstOrDefault(x => x.DonorId == model.DonorId);
                if (donorModel != null)
                {
                    donorModel.DonorName = model.DonorName;
                    donorModel.BloodGroupId = model.BloodGroupId;
                    donorModel.Email = model.Email;
                    donorModel.Status = model.Status;
                    donorModel.Gender = model.Gender;
                    donorModel.BloodGroupId = model.BloodGroupId;
                    donorModel.DateOfBirth = model.DateOfBirth;
                    donorModel.ContactNumber = model.ContactNumber;
                    donorModel.LastDonationDate = model.LastDonationDate;
                    donorModel.DivisionId = model.DivisionId;
                    donorModel.DistrictId = model.DistrictId;
                    donorModel.UpazilaId = model.UpazilaId;
                    _dbContext.Donors.Update(donorModel);
                    _dbContext.SaveChanges();
                    ViewBag.Message = "Profile update successfully.";
                    ViewBag.Type = "Success";
                }
            }
            ViewBag.BloodGroupList = _dbContext.BloodGroups.ToList();
            ViewBag.DivisionList = _dbContext.Divisions.ToList();
            DonorModel donor = _dbContext.Donors.Include(x => x.BloodGroup)
               .Include(x => x.Divisions)
               .Include(x => x.Districts)
               .Include(x => x.Upazilas)
               .FirstOrDefault(x => x.UserName == User.Identity.Name);
            ViewBag.DistrictList = _dbContext.Districts.Where(x => x.DivisionId == donor.DivisionId).ToList();
            ViewBag.UpazilaList = _dbContext.Upazilas.Where(x => x.DivisionId == donor.DivisionId && x.DistrictId == donor.DistrictId).ToList();
            List<StatusModel> status = new List<StatusModel>() {
                new StatusModel() { Status="Donate blood."},
                new StatusModel() { Status="If urgent, I can donate."},
                new StatusModel() { Status="Not interested yet, Donate in future."}
            };
            ViewBag.StatusList = status;
            return View(donor);
         
        }
    }
}
