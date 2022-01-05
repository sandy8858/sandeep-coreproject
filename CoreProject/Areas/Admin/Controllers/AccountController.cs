using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using CoreProject.Models;
using CoreProject.Areas.Admin.Models.ViewModels;

namespace CoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class AccountController : Controller
    {

        public SignInManager<User> SignInManager;
        public ApplicationContext Context { get; }

        public AccountController(SignInManager<User> inManager, ApplicationContext _context)
        {
            SignInManager = inManager;
            Context = _context;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                //login here
                var user = Context.Users.SingleOrDefault(e => e.Email == model.Email);
                if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result =await  SignInManager.PasswordSignInAsync(model.Email, model.Password, model.Remember, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { @area="Admin"});
                    }
                    else 
                    {
                        ModelState.AddModelError(string.Empty, "Invalid Email or Password !");
                        return View();
                    }


                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid User !");
                    return View();
                }

            }
            else
            {
                return View(model);
            }
            //return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
