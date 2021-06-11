using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TLOSoltuion.Data.EF;
using TLOSolution.WebApp.Models;

namespace TLOSolution.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TLODbContext _context;

        public HomeController(TLODbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var posts = from p in _context.Post
                        select p;

            var categories = from c in _context.Category
                             select c;

            var reponse1 = await categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImagePath = x.Imagepath
            }).ToListAsync();

            var reponse = await posts.Select(x => new PostListViewModel
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

            var reponseResult = new IndexCustomViewModel
            {
                CategoryViewModel = reponse1,
                PostListViewModel = reponse
            };
            return View(reponseResult);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string request)
        {
            var posts = from p in _context.Post
                        select p;

            if (String.IsNullOrEmpty(request))
            {
                posts = posts.Where(r => r.Title.Contains(request));
                var reponse = await posts.Select(x => new PostListViewModel()
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
                return View(reponse);
            }
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public async Task<IActionResult> Posts()
        {
            var posts = await _context.Post.ToListAsync();
            return View(posts);
        }
    }
}