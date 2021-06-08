using BBMSASP.Core.Areas.Admin.Services;
using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using BBMSASP.Core.Services;
using Microsoft.AspNetCore.Authorization;
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
    public class BloodRequestController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IProfileService _profile;
        private readonly IMailService _emailService;
        public BloodRequestController(ApplicationDbContext dbContext, IProfileService profileService, IMailService mailService)
        {
            _dbContext = dbContext;
            _profile = profileService;
            _emailService = mailService;
        }
        [Route("/Admin/BloodRequest/Approved/{requestId:int}")]
        public IActionResult Approved(int requestId)
        {
            var request = _dbContext.BloodRequests.Find(requestId);
            if (request != null)
            {
                request.Status = "Approved";
                _dbContext.BloodRequests.Update(request);
                _dbContext.SaveChanges();
                var bloodGroup = _dbContext.BloodGroups.FirstOrDefault(x => x.BloodGroupId == request.BloodGroupId);
                var donorList = _dbContext.Donors.Include(x => x.BloodGroup)
                    .Include(x => x.Divisions)
                    .Include(x => x.Districts)
                    .Include(x => x.Upazilas)
                    .Where(x => x.BloodGroupId == request.BloodGroupId && x.Districts.DistrictId == request.DistrictId)
                    .Where(x => x.LastDonationDate <= DateTime.Now.AddDays(-120)).ToList();
                foreach (var item in donorList)
                {
                    _emailService.SendEmailAsync(item.Email, "Blood Request for " + bloodGroup.GroupName, "Dear " + item.DonorName + ",<br>Someone requested for " + bloodGroup.GroupName + " blood, Now you are available to donate blood.<br><br><b>Information:</b> <br>Name: " + request.Name + "<br>Contact Number: " + request.ContactNumber + "<br>Hospital Name: " + request.HospitalName + "<br><br>Thanks<br>CTG BLOOD BANK");
                }
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        [Route("/Admin/BloodRequest/Reject/{requestId:int}")]
        public IActionResult Reject(int requestId)
        {
            var request = _dbContext.BloodRequests.Find(requestId);
            if (request != null)
            {
                request.Status = "Reject";
                _dbContext.BloodRequests.Update(request);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        public IActionResult Index()
        {
            var request = _dbContext.BloodRequests.Include(x => x.BloodGroup)
                .Include(x => x.Divisions)
                .Include(x => x.Districts)
                .Include(x => x.Upazilas).ToList();
            if (User.IsInRole("Donor"))
            {
                DonorModel donorModel = _dbContext.Donors.Include(x => x.BloodGroup)
                .Include(x => x.Divisions)
                .Include(x => x.Districts)
                .Include(x => x.Upazilas)
                .FirstOrDefault(x => x.UserName == User.Identity.Name);
               request = request.Where(x => x.BloodGroupId == donorModel.BloodGroupId && x.DivisionId == donorModel.DivisionId && x.DistrictId == donorModel.DistrictId && x.RequiredDate>=DateTime.Now.AddDays(-1)&&x.Status=="Approved").ToList();
            }
            return View(request);
        }
    }
}
