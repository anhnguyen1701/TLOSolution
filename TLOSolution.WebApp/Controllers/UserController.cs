using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLOSoltuion.Data.EF;

namespace TLOSolution.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly TLODbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(TLODbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Details()
        {
            ViewData["RoleName"] = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            return View();
        }
    }
}
