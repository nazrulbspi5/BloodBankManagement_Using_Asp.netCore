using BBMSASP.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BBMSASP.Core.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;

namespace BBMSASP.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(UserManager<IdentityUser> userManager, ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            HomePageModels homePages = _dbContext.HomePage.FirstOrDefault();
            AboutUsModels aboutUs = _dbContext.AboutUs.FirstOrDefault();
            HomePageViewModel model = new HomePageViewModel
            {
                HomePage = homePages,
                AboutUs = aboutUs,
            };
            return View(model);
        }
        [AcceptVerbs("Get", "Post")]
        //[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IsUserNameExist(string userName)
        {
            //var user = _userManager.FindByEmailAsync(email);
            if (userName == "nazrulbspi")
            {
                return Json(data: $"UserName {userName} is already use");
            }
            return Json(data: true);
        }
        [HttpGet]
        public JsonResult GetDistrict(int divisionId)
        {
            //var districtList = _dbContext.Districts.Where(e => e.DivisionId == divisionId).ToList();
           var districtList = (from district in _dbContext.Districts where district.DivisionId == divisionId select district).ToList();
            return Json(new SelectList(districtList, "DistrictId", "DistrictName"));
            //return Json
        }
        [HttpGet]
        public JsonResult GetUpazila(int districtId)
        {
            var upazilaList = _dbContext.Upazilas.Where(e => e.DistrictId == districtId).ToList();
            //var districtList = (from district in _dbContext.Districts where district.DivisionId == divisionId select district).ToList();
            return Json(new SelectList(upazilaList, "UpazilaId", "UpazilaName"));
            //return Json
        }
        public IActionResult Login()
        {
            return View();
        }
        [Route("/About-Us")]
        public IActionResult AboutUs()
        {
            return View(_dbContext.AboutUs.FirstOrDefault());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
