using ECWebApp.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<AppContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Amfi"},
                    new Product(){ProductName="Ev Sinema Ses Sistemi"},
                    new Product(){ProductName="SUBWOOFER"},
                    new Product(){ProductName="HD Uydu Alıcısı"},
                    new Product(){ProductName="Optik Mouse"},
                    new Product(){ProductName="Kumanda"},


                };

                context.Products.AddRange(products);

                var categories = new[]
                {
                    new Category(){CategoryName="Ses Sistemleri"},
                    new Category(){CategoryName="Oto Ses Sistemleri"},
                    new Category(){CategoryName="Uydu"},
                    new Category(){CategoryName="Bilgisayar Çevre Birimleri"},
                    new Category(){CategoryName="Diğer Elektronik Ürünler"},
                };

                context.Categories.AddRange(categories);

                var productscategories = new[]
                {
                    new ProductCategory(){Product=products[0],Category=categories[0]},
                    new ProductCategory(){Product=products[1],Category=categories[0]},
                    new ProductCategory(){Product=products[2],Category=categories[1]},
                    new ProductCategory(){Product=products[3],Category=categories[2]},
                    new ProductCategory(){Product=products[4],Category=categories[3]},
                    new ProductCategory(){Product=products[5],Category=categories[4]},

                };

                context.AddRange(productscategories);

                context.SaveChanges();
            }
        }
    }
}
