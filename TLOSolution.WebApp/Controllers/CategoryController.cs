using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLOSoltuion.Data.EF;
using TLOSolution.WebApp.Models;

namespace TLOSolution.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly TLODbContext _context;

        public CategoryController(TLODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var result = from p in _context.Post
                         where p.CategoryId == id
                         select p;
            if (result == null)
            {
                return View();
            }

            var posts = await result.Select(x => new PostViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                DocumentPath = x.DocumentPath,
                CategoryName = x.Category.Name,
                PublisherName = x.User.FirstName + " " + x.User.LastName,
                DocumentType = x.DocumentType,
                DowloadCount = x.DowloadCount,
                ViewCount = x.ViewCount,
                ImagePath = x.ImagePath
            }).ToListAsync();

            var categories = from c in _context.Category
                             select c;

            var categoriesRes = await categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImagePath = x.Imagepath
            }).ToListAsync();

            var CategoryDetail = new CategoryDetailViewModel()
            {   Categories = categoriesRes,
                Posts = posts
            };

            return View(CategoryDetail);
        }
    }
}
