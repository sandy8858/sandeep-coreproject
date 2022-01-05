using CoreProject.Areas.Admin.Models.ViewModels;
using CoreProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationContext applicationContext;
        private UserManager<User> userManager;
        public HomeController(ApplicationContext _applicationContext, UserManager<User> _userManager)
        {
            this.applicationContext = _applicationContext;
            userManager = _userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(CreateUserViewModel model)
        {
            var user = new User()
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                Email=model.Email,
                PasswordHash=model.Password,
                Gender=model.Gender,
                UserName= model.Email,
            };
           var result= await userManager.CreateAsync(user,user.PasswordHash);
            if (result.Succeeded)
            {
                //
                ViewBag.msg = "User create successfully !";
                return View();
            }
            else {
                foreach(var er in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, er.Description);
                    return View(model);
                }
            }
            return View();
        }
    }
}
