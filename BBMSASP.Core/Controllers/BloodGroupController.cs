using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Controllers
{

    public class BloodGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
