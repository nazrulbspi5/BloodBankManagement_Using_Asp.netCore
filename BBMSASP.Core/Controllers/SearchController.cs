using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BBMSASP.Core.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public SearchController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("Search-Donor")]
        public IActionResult Index()
        {
            ViewBag.BloodGroupList = _dbContext.BloodGroups.ToList();
            ViewBag.DivisionList = _dbContext.Divisions.ToList();
            return View();
        }
        [AcceptVerbs("Post","Get")]
        [Produces("application/json")]
        public JsonResult GetDonorDetails(int bloodGroupId,int divisionId,int districtId, int upazilaId)
        {
            IEnumerable<DonorModel> donorList = _dbContext.Donors.Include(x => x.BloodGroup).Include(x => x.Divisions).Include(x => x.Districts).Include(x => x.Upazilas).ToList();
            if (bloodGroupId != 0)
            {
                donorList = donorList.Where(x => x.BloodGroupId == bloodGroupId).ToList();
            }
            if (divisionId != 0)
            {
                donorList = donorList.Where(x => x.DivisionId == divisionId).ToList();
            }
            if (districtId != 0)
            {
                donorList = donorList.Where(x => x.DistrictId == districtId).ToList();
            }
            if (upazilaId != 0)
            {
                donorList = donorList.Where(x => x.UpazilaId == upazilaId).ToList();
            }
           
            return Json(donorList) ;
        }
    }
}
