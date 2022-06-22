using ECWebApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
       
   


        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }

        public List<Category> SelectedCategories { get; set; }
        public List<ProductAttribute> Attributes { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
