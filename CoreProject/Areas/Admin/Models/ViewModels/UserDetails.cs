using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.Models.ViewModels
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public string RollId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Description { get; set; }

        public DateTime? CreateOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
