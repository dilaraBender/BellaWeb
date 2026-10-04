using BellaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BellaWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "El Yapımı Çanta",
                Category = "Çanta",
                Description = "Özenle hazırlanan, zarif detaylara sahip el yapımı Bella çanta.",
                Size = "17 × 12 cm",
                MainImage = "/images/products/bag-01.jpeg",
                DetailImage1 = "/images/products/bag-01-detail1.jpeg",
                DetailImage2 = "/images/products/bag-01-detail2.jpeg"
            },

            new Product
            {
                Id = 2,
                Name = "El Yapımı Çanta",
                Category = "Çanta",
                Description = "El emeğiyle özenle hazırlanan Bella çanta.",
                Size = "17 × 12 cm",
                MainImage = "/images/products/bag-02.jpeg",
                DetailImage1 = "/images/products/bag-02-detail1.jpeg",
                DetailImage2 = "/images/products/bag-02-detail2.jpeg"
            },

            new Product
            {
                Id = 3,
                Name = "El Yapımı Çanta",
                Category = "Çanta",
                Description = "El emeğiyle özenle hazırlanan Bella çanta.",
                Size = "17 × 12 cm",
                MainImage = "/images/products/bag-03.jpeg",
                DetailImage1 = "/images/products/bag-03-detail1.jpeg",
                DetailImage2 = "/images/products/bag-03-detail2.jpeg"
            },

            new Product
            {
                Id = 4,
                Name = "El Yapımı Çanta",
                Category = "Çanta",
                Description = "El emeğiyle özenle hazırlanan Bella çanta.",
                Size = "17 × 12 cm",
                MainImage = "/images/products/bag-04.jpeg",
                DetailImage1 = "/images/products/bag-04-detail1.jpeg",
                DetailImage2 = "/images/products/bag-04-detail2.jpeg"
            },
            new Product
{
    Id = 5,
    Name = "El İşi Örtü",
    Category = "Örtü",
    Description = "İnce detaylarla özenle hazırlanan el işi Bella örtü.",
    Size = "Özel ölçü",
    MainImage = "/images/products/cover-01.jpeg",
    DetailImage1 = "/images/products/cover-01-detail1.jpeg",
    DetailImage2 = "/images/products/cover-01-detail2.jpeg"
},
              new Product
{
    Id = 6,
    Name = "El İşi Örtü",
    Category = "Örtü",
    Description = "İnce detaylarla özenle hazırlanan el işi Bella örtü.",
    Size = "Özel ölçü",
    MainImage = "/images/products/cover-02.jpeg",
    DetailImage1 = "/images/products/cover-02-detail1.jpeg",
    DetailImage2 = "/images/products/cover-02-detail2.jpeg"
},
                new Product
{
    Id = 7,
    Name = "El İşi Örtü",
    Category = "Örtü",
    Description = "İnce detaylarla özenle hazırlanan el işi Bella örtü.",
    Size = "Özel ölçü",
    MainImage = "/images/products/cover-03.jpeg",
    DetailImage1 = "/images/products/cover-03-detail1.jpeg",
    DetailImage2 = "/images/products/cover-03-detail2.jpeg"
},
                  new Product
{
    Id = 8,
    Name = "El İşi Örtü",
    Category = "Örtü",
    Description = "İnce detaylarla özenle hazırlanan el işi Bella örtü.",
    Size = "Özel ölçü",
    MainImage = "/images/products/cover-05.jpeg",
    DetailImage1 = "/images/products/cover-04-detail1.jpeg",
    DetailImage2 = "/images/products/cover-04-detail2.jpeg"
},
                    new Product
{
    Id = 9,
    Name = "El İşi Örtü",
    Category = "Örtü",
    Description = "İnce detaylarla özenle hazırlanan el işi Bella örtü.",
    Size = "Özel ölçü",
    MainImage = "/images/products/cover-05.jpeg",
    DetailImage1 = "/images/products/cover-05-detail1.jpeg",
    DetailImage2 = "/images/products/cover-05-detail2.jpeg"
                    },
                    new Product
{
    Id = 10,
    Name = "El Yapımı Çanta ve Örtü Takımı",
    Category = "Takım",
    Description = "Birbiriyle uyumlu çanta ve örtüden oluşan, özenle hazırlanan Bella takımı.",
    Size = "Özel ölçü",
    MainImage = "/images/products/set-01.jpeg",
    DetailImage1 = "/images/products/set-01-detail1.jpeg",
    DetailImage2 = "/images/products/set-01-detail2.jpeg"
},
                    new Product
{
    Id = 11,
    Name = "El Yapımı Çanta ve Örtü Takımı",
    Category = "Takım",
    Description = "Birbiriyle uyumlu çanta ve örtüden oluşan, özenle hazırlanan Bella takımı.",
    Size = "Özel ölçü",
    MainImage = "/images/products/set-02.jpeg",
    DetailImage1 = "/images/products/set-02-detail1.jpeg",
    DetailImage2 = "/images/products/set-02-detail2.jpeg"
}
        };


        public IActionResult Index(string? category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return View(products);
            }

            var filteredProducts = products
                .Where(x => x.Category == category)
                .ToList();

            return View(filteredProducts);
        }

        public IActionResult Detail(int id)
        {
            Product? product = products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}