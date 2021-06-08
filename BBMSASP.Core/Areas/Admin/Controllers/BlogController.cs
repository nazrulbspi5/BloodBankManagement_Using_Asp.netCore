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
    [Authorize(Roles = "Admin, Donor")]
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public BlogController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("/Admin/Blog")]
        public IActionResult Index()
        {
            return View(_dbContext.Blogs.ToList());
        }
        [Route("/Admin/Blog/Add-Blog")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("/Admin/Blog/Add-Blog")]
        public IActionResult Create(BlogModel model)
        {
            if (ModelState.IsValid)
            {
                model.PostDate = DateTime.Now;
                model.EntryBy = User.Identity.Name;
                _dbContext.Blogs.Add(model);
                _dbContext.SaveChanges();
                TempData["saved"] = "Succuessfully added.";
                //ViewBag.Message = "Blog added successfully.";
                //ViewBag.Type = "Success";
                ModelState.Clear();
            }

            return View();
        }

        [Route("/Admin/Blog/Edit/{blogId:int}")]
        public IActionResult Edit(int blogId)
        {
            
            return View(_dbContext.Blogs.FirstOrDefault(x => x.BlogId == blogId));
        }
        [Route("/Admin/Blog/Edit/{blogId:int}")]
        [HttpPost]
        public IActionResult Edit(int blogId, BlogModel model)
        {
            if (ModelState.IsValid)
            {
                model.PostDate = DateTime.Now;
                model.EntryBy = User.Identity.Name;
                _dbContext.Blogs.Update(model);
                _dbContext.SaveChanges();
                ViewBag.Message = "Blog update successfully.";
                ViewBag.Type = "Success";
                ModelState.Clear();
                return RedirectToAction("Index","Blog");
            }
            return View();
        }
        [Route("/Admin/Blog/Delete/{blogId:int}")]
        public IActionResult Delete(int blogId)
        {
            var blog = _dbContext.Blogs.Find(blogId);
            if (blog != null)
            {
                _dbContext.Remove(blog);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Blog");
            }

            return View();
        }
    }
}
