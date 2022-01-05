using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Videos
    {
        [Key]
        public int Id { get; set; }

        public string Url { get; set; }
        public string Thumb { get; set; }

        public string Description { get; set; }

        public DateTime? CreateOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }

        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }

    }
}
