using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.Models.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        public int Id { get; set; }

        public Guid UserId1 { get; set; }

        public string RollId1 { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CreateOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
