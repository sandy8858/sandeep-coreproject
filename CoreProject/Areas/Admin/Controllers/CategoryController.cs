using CoreProject.Areas.Admin.Models.ViewModels;
using CoreProject.Areas.Admin.Respository.Contract;
using CoreProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategory category;

        public IHostingEnvironment Environment { get; }

        public CategoryController(ICategory category, IHostingEnvironment environment)
        {
            this.category = category;
            Environment = environment;
          
        }
        public IActionResult Index()
        {
            var result = category.GetCategories();
            return View(result);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryViewModel model)
        {
            //string path = Environment.WebRootPath;
            //string dbPath = "contents/images/"+model.Image.FileName;
            //string fullpath = Path.Combine(path, dbPath);
            //category.UploadFile(model.Image,fullpath);
          
            //var cate = new Category()
            //{
            //    Name = model.Name,
            //    Description = model.Description,
            //    Image = dbPath,
            //    UpdatedOn = DateTime.Now,
            //    IsActive = model.IsActive,

            //};
            //category.AddCategory(cate);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            var cats = category.GetCategoryById(id);
            return View(cats);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category model)
        {
            category.UpdateCategory(model);
            return RedirectToAction("Index");
        }
    }
}
