using E_Com_Website.Data.Models;
using E_Com_Website.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace E_Com_Website.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ShoppingCart shoppingCartData;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ShoppingCart shoppingCart)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            shoppingCartData = shoppingCart;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                        return RedirectToAction("Index", "Home");

                    return Redirect(loginViewModel.ReturnUrl);
                }
            }

            ModelState.AddModelError("", "Username/Password is incorrect.");
            return View(loginViewModel);

        }

        public IActionResult Register() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser() { UserName = registerViewModel.UserName, 
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Gender = registerViewModel.Gender,
                PhoneNumber = registerViewModel.Number,
                Email = registerViewModel.Email

                };
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(registerViewModel);
        }

        public ViewResult LoggedIn() => View();


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            shoppingCartData.clearCart();
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}