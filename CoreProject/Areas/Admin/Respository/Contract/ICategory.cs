using CoreProject.Areas.Admin.Models.ViewModels;
using CoreProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.Respository.Contract
{
   public interface ICategory
    {
        List<Category> GetCategories();
        Category AddCategory(Category model);
        bool DeleteCategory(int id);

        Category GetCategoryById(int id);

        Category UpdateCategory(Category model);

        public void UploadFile(IFormFile file, string path);

    }
}
