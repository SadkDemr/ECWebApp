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
                    new Product(){ProductName="Amfi", Image="product1.jpg",IsHome=true,IsApproved=true,IsFeatured=true, Description="Ürün açıklması", HtmlContent="<b> Ürün açıklaması </b", DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ProductName="Ev Sinema Ses Sistemi", Image="product2.jpg",IsHome=false,IsApproved=true,IsFeatured=true, Description="Ürün açıklması", HtmlContent="<b> Ürün açıklaması </b", DateAdded=DateTime.Now.AddDays(-20)},
                    new Product(){ProductName="SUBWOOFER", Image="product3.jpg",IsHome=true,IsApproved=false,IsFeatured=true, Description="Ürün açıklması", HtmlContent="<b> Ürün açıklaması </b", DateAdded=DateTime.Now.AddDays(-30)},
                    new Product(){ProductName="HD Uydu Alıcısı", Image="product4.jpg",IsHome=true,IsApproved=true,IsFeatured=true, Description="Ürün açıklması", HtmlContent="<b> Ürün açıklaması </b", DateAdded=DateTime.Now.AddDays(-5)},
                    new Product(){ProductName="Optik Mouse", Image="mouse.jpg",IsHome=true,IsApproved=true,IsFeatured=true, Description="Ürün açıklması", HtmlContent="<b> Ürün açıklaması </b", DateAdded=DateTime.Now.AddDays(-2)},
                    new Product(){ProductName="Kumanda", Image="kumanda.jpg",IsHome=true,IsApproved=true,IsFeatured=true, Description="Ürün açıklması", HtmlContent="<b> Ürün açıklaması </b", DateAdded=DateTime.Now.AddDays(-3)},


                };

                context.Products.AddRange(products);

                var categories = new[]
                {
                    new Category(){CategoryName="Ses Sistemleri"},
                    new Category(){CategoryName="Oto Ses Sistemleri"},
                    new Category(){CategoryName="Uydu"},
                    new Category(){CategoryName="BilgisAyar Çevre Birimleri"},
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
                var images = new[]
                {
                    new Image(){ImageName="product1.jpg", Product=products[0]},
                    new Image(){ImageName="product1.jpg", Product=products[0]},
                    new Image(){ImageName="product1.jpg", Product=products[0]},
                    new Image(){ImageName="product1.jpg", Product=products[0]},

                    new Image(){ImageName="product2.jpg", Product=products[1]},
                    new Image(){ImageName="product2.jpg", Product=products[1]},
                    new Image(){ImageName="product2.jpg", Product=products[1]},
                    new Image(){ImageName="product2.jpg", Product=products[1]},

                    new Image(){ImageName="product3.jpg", Product=products[2]},
                    new Image(){ImageName="product3.jpg", Product=products[2]},
                    new Image(){ImageName="product3.jpg", Product=products[2]},
                    new Image(){ImageName="product3.jpg", Product=products[2]},

                    new Image(){ImageName="product4.jpg", Product=products[3]},
                    new Image(){ImageName="product4.jpg", Product=products[3]},
                    new Image(){ImageName="product4.jpg", Product=products[3]},
                    new Image(){ImageName="product4.jpg", Product=products[3]},

                    new Image(){ImageName="mouse.jpg", Product=products[4]},
                    new Image(){ImageName="mouse.jpg", Product=products[4]},
                    new Image(){ImageName="mouse.jpg", Product=products[4]},
                    new Image(){ImageName="mouse.jpg", Product=products[4]},

                    new Image(){ImageName="kumanda.jpg", Product=products[5]},
                    new Image(){ImageName="kumanda.jpg", Product=products[5]},
                    new Image(){ImageName="kumanda.jpg", Product=products[5]},
                    new Image(){ImageName="kumanda.jpg", Product=products[5]},
                };

                context.Images.AddRange(images);
                var attiribute = new[]
                {
                    new ProductAttribute(){Attribute="Watt",Value="200w", Product=products[0]},
                    new ProductAttribute(){Attribute="Kolon Sayısı",Value="4+1", Product=products[1]},
                    new ProductAttribute(){Attribute="Watt",Value="200w", Product=products[2]},
                    new ProductAttribute(){Attribute="Wifi",Value="Var", Product=products[3]},
                    new ProductAttribute(){Attribute="Bağlantı",Value="Kablolu", Product=products[4]},
                    new ProductAttribute(){Attribute="Marka",Value="Arçelik", Product=products[5]},
                };

                context.Attributes.AddRange(attiribute);


                context.SaveChanges();
            }
        }
    }
}
