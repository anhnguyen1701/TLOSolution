using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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

            var categoriesRes = await categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImagePath = x.Imagepath
            }).ToListAsync();

            var postsRes = await posts.Select(x => new PostViewModel
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

            var reponse = new SearchReponseViewModel
            {
                Categories = categoriesRes,
                Posts = postsRes
            };

            return View(reponse);
        }

        [HttpGet]
        public async Task<IActionResult> Search(SearchRequestViewModel request)
        {
            var categories = from c in _context.Category
                             select c;

            var categoriesRes = await categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImagePath = x.Imagepath
            }).ToListAsync();

            var posts = from p in _context.Post
                        select p;

            if(!string.IsNullOrEmpty(request.InputString))
            {
                posts = posts.Where(p => p.Title.Contains(request.InputString));
            }

            if(request.CategoryId != null)
            {
                posts = posts.Where(p => p.CategoryId == request.CategoryId);
            }

            var postsRes = await posts.Select(x => new PostViewModel
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

            var response = new SearchReponseViewModel()
            {
                Categories = categoriesRes,
                Posts = postsRes,
                CategoryId = request.CategoryId,
                CategoryTitle = postsRes[0].CategoryName
            };

            return View(response);
        }

        public async Task<IActionResult> Posts()
        {
            var posts = await _context.Post.ToListAsync();
            return View(posts);
        }
    }
}