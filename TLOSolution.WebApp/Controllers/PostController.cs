﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLOSoltuion.Data.EF;
using TLOSoltuion.Data.Entities;
using TLOSolution.WebApp.Models;

namespace TLOSolution.WebApp.Controllers
{
    public class PostController : Controller
    {
        private readonly TLODbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PostController(TLODbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var result = await _context.Post.Where(x => x.Id == id).FirstOrDefaultAsync();
            var user = await _context.Users.Where(x => x.Id == result.UserId).FirstOrDefaultAsync();
            if (result == null)
            {
                return View();
            }

            var categories = from c in _context.Category
                             select c;

            var categoriesRes = await categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImagePath = x.Imagepath
            }).ToListAsync();

            var post = new PostDetailModel()
            {
                Categories = categoriesRes,
                Title = result.Title,
                Description = result.Description,
                DocumentPath = result.DocumentPath,
                DowloadCount = result.DowloadCount,
                PublisherName = user.FirstName + " " + user.LastName,
                ViewCount = result.ViewCount
            };

            result.ViewCount++;
            await _context.SaveChangesAsync();
            return View(post);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async void Create(PostCreateModel request)
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            if (!await UploadFile(request.Document))
            {
                ModelState.AddModelError("", "cannot upload file");
                return;
            }

            var post = new Post()
            {
                Title = request.Title,
                Description = request.Description,
                DocumentPath = request.Document.FileName,
                DocumentType = request.Document.ContentType,
                ViewCount = 0,
                DowloadCount = 0,
                UserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier),
                CategoryId = request.CategoryId
            };

            await _context.Post.AddAsync(post);
            await _context.SaveChangesAsync();
        }

        private async Task<bool> UploadFile(IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\content", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
                return true;
            }
            return false;
        }
    }
}
