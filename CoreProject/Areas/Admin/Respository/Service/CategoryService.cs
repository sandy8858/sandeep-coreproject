using CoreProject.Areas.Admin.Models.ViewModels;
using CoreProject.Areas.Admin.Respository.Contract;
using CoreProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.Respository.Service
{
    public class CategoryService:ICategory
    {
        private readonly ApplicationContext context;

        public CategoryService (ApplicationContext context,
            IHostingEnvironment environment
            
            )
        {
            this.context = context;
            Environment = environment;
        }

        public IHostingEnvironment Environment { get; }

        public Category AddCategory(Category model)
        {
          
            context.Categories.Add(model);
            context.SaveChanges();
            return model;
        }

        public bool DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            var cats = context.Categories.ToList();
            return cats;

        }

        public Category GetCategoryById(int id)
        {
            var cat = context.Categories.SingleOrDefault(e => e.Id == id);
            return cat;
        }

        public Category UpdateCategory(Category model)
        {
          
            context.Categories.Update(model);
            context.SaveChanges();
            return model;
        }

        public void UploadFile(IFormFile file, string path)
        {
            // string fullPath = Path.Combine(Webpath, "contents", "images");

            FileStream stream = new FileStream(path,FileMode.Create);
            file.CopyTo(stream);

        }
    }
}
