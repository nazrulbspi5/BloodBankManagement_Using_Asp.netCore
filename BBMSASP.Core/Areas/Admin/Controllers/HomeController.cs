using BBMSASP.Core.Areas.Admin.Models;
using BBMSASP.Core.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Donor")]
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _dbContext;
        public HomeController(SignInManager<IdentityUser> signInManager, ApplicationDbContext dbContext)
        {
            _signInManager = signInManager;
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.UserName = User.Identity.Name;
            DonorCounterModel model = new DonorCounterModel();

            model.APositive = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "A+").ToList().Count();
            model.ANegative = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "A-").ToList().Count();
            model.BPositive = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "B+").ToList().Count();
            model.BNegative = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "B-").ToList().Count();
            model.ABPositive = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "AB+").ToList().Count();
            model.ABNegative = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "AB-").ToList().Count();
            model.OPositive = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "O+").ToList().Count();
            model.ONegative = _dbContext.Donors.Include(x => x.BloodGroup).Where(x => x.BloodGroup.GroupName == "O-").ToList().Count();
            model.TotalDonor = _dbContext.Donors.ToList().Count();
            model.TotalRequest = _dbContext.BloodRequests.ToList().Count();
            model.PendingRequest = _dbContext.BloodRequests.Where(x => x.Status == "Pending").ToList().Count();
            model.RejectRequest = _dbContext.BloodRequests.Where(x => x.Status == "Reject").ToList().Count();
            model.ApprovedRequest = _dbContext.BloodRequests.Where(x => x.Status == "Approved").ToList().Count();
            //model.AcceptRequest = _dbContext.BloodRequests.Where(x => x.IsApproved == "Approved").ToList().Count();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //return RedirectToAction("Index", "Home");
            return Redirect("~/login");
        }
    }
}
