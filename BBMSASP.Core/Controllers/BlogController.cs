using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMSASP.Core.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public BlogController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("/Blog")]
        public IActionResult Index()
        {
           var blogs = _dbContext.Blogs.ToList();
            return View(blogs);
        }
    }
}
