using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLOSoltuion.Data.Entities;
using TLOSolution.WebApp.Models;

namespace TLOSolution.WebApp.Controllers
{
    public class Authentication : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public Authentication(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterModel request)
        {
            if(!ModelState.IsValid)
            {
                return View(request);
            }

            var user = new User()
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if(!result.Succeeded)
            {
                foreach(var e in result.Errors)
                {
                    ModelState.TryAddModelError(e.Code, e.Description);
                }

                return View(request);
            }

            await _userManager.AddToRoleAsync(user, "User");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel request, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "user is not valid");
                return View();
            }

            var res = await _signInManager
                .PasswordSignInAsync(user, request.Password, request.RememberMe, false);

            if (res.Succeeded)
            {
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "password is wrong");
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl)) return Redirect(returnUrl);
            else return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
