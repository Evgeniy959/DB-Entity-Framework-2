using DBCrud.Helpers;
using DBCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DBCrud.Controllers
{
    public class PostController : Controller
    {
        private readonly BlogDbContext blogDbContext;

        public PostController(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            //ModelState.AddModelError("Title", "99999");
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(blogDbContext.Posts.ToList());
        }

        [HttpPost]
        //  [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Post post, IFormFile ImageUrl)
        {
            try
            {
                post.ImageUrl = await FileUploadHelper.Upload(ImageUrl);
            }
            catch (Exception) { }


            if (ModelState.IsValid)
            {
                post.Date = DateTime.Now;

                blogDbContext.Posts.AddAsync(post);
                await blogDbContext.SaveChangesAsync();
                TempData["Status"] = "New post added!";
                return RedirectToAction("Index");
            }

            return View(post);
        }
    }
}
