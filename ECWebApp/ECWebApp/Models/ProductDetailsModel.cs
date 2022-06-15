using ECWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.Models
{
    public class ProductDetailsModel
    {
        
        public Product Product { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductAttribute> Attributes { get; set; }
        public List<Category> Categories { get; set; }
    }
}
