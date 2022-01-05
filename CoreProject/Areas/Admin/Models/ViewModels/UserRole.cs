using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.Models.ViewModels
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        public Guid RollId { get; set; }

        public string RollName { get; set; }
    }
}
