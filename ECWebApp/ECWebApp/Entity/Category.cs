using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
         [Required]
        public string CategoryName { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
