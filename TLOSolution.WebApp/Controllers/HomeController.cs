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

        public IActionResult Index()
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
