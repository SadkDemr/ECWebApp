using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.Entity
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }

        public string Attribute { get; set; }
        public string Value { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
