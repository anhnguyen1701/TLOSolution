using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLOSoltuion.Data.Entities;
using TLOSolution.MailService;
using TLOSolution.WebApp.Models;

namespace TLOSolution.WebApp.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IEmailSender _emailSender;

        public AuthenticationController(SignInManager<User> signInManager, UserManager<User> userManager, IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;
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
            if (!ModelState.IsValid)
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
            if (!result.Succeeded)
            {
                foreach (var e in result.Errors)
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

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel request)
        {
            if (!ModelState.IsValid) return View(request);

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return RedirectToAction(nameof(ForgotPasswordConfirmation));
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Authentication", new { token, email = user.Email }, Request.Scheme);

            var message = new EmailMessage(new string[] { user.Email }, "Reset password token", callback, null);
            await _emailSender.SendEmailAsync(message);

            return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordModel { Token = token, Email = email };
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel request)
        {
            if (!ModelState.IsValid) return View(request);

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null) RedirectToAction(nameof(ResetPasswordConfirmation));

            var resetPasswordResult = await _userManager.ResetPasswordAsync(user, request.Token, request.Password);
            if (!resetPasswordResult.Succeeded)
            {
                foreach (var error in resetPasswordResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View();
            }

            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl)) return Redirect(returnUrl);
            else return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
