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
                Name = "Zarif Dokulu Beyaz Çanta",
                Category = "Çanta",
                Description = "Beyaz tonları ve zarif dokusuyla sade şıklığı öne çıkaran, el emeğiyle özenle hazırlanmış özel tasarım çanta.",
                Size = "17 × 12 cm",
                MainImage = "/images/products/bag-01.jpeg",
                DetailImage1 = "/images/products/bag-01-detail2.jpeg",
                DetailImage2 = "/images/products/bag-01-detail1.jpeg"
            },

            new Product
            {
                Id = 2,
                Name = "Gece Motifi Çanta",
                Category = "Çanta",
                Description = "Siyah zemini ve beyaz işlemeleriyle güçlü ve zarif bir görünüm sunan, özel günlere eşlik edecek el yapımı Bella çanta.",
                Size = "15 × 12 cm",
                MainImage = "/images/products/bag-02.jpeg",
                DetailImage1 = "/images/products/bag-02-detail2.png",
                DetailImage2 = "/images/products/bag-02-detail1.jpeg"
            },

            new Product
            {
                Id = 3,
                Name = "Lacivert İşlemeli Yuvarlak Çanta",
                Category = "Çanta",
                Description = "Lacivert işlemeleri ve yuvarlak formuyla zarif, el yapımı özel tasarım çanta.",
                Size = "12 × 12 cm",
                MainImage = "/images/products/bag-03.jpeg",
                DetailImage1 = "/images/products/bag-03-detail2.png",
                DetailImage2 = "/images/products/bag-03-detail1.jpeg"
            },

            new Product
            {
                Id = 4,
                Name = "Sedef Işıltısı Çanta",
                Category = "Çanta",
                Description = "Sedef tonları ve ince işlemeleriyle özel günlere zarif bir dokunuş katan el yapımı çanta.",
                Size = "20 × 12 cm",
                MainImage = "/images/products/bag-04.jpeg",
                DetailImage1 = "/images/products/bag-04-detail02.jpeg",
                DetailImage2 = "/images/products/bag-04-detail1.jpeg"
            },
            new Product
{
    Id = 5,
    Name = "Zarif Detaylı Örtü",
    Category = "Örtü",
    Description = "İnce tül dokusu ve zarif nakış detaylarıyla özel anlara şık bir dokunuş katan, özenle hazırlanmış el emeği Bella örtü.",
    Size = "1 metre",
    MainImage = "/images/products/cover-01.jpeg",
},
              new Product
{
    Id = 6,
    Name = "Dantel Esintisi Örtü",
    Category = "Örtü",
    Description = "Zarif dantel detayları ve hareketli kenar tasarımıyla dikkat çeken, hafif tül dokusuyla özenle hazırlanmış el emeği Bella örtü.",
    Size = "1 metre",
    MainImage = "/images/products/cover-02.jpeg",

},
                new Product
{
    Id = 7,
    Name = "Geometrik Zarafet Örtü",
    Category = "Örtü",
    Description = "Belirgin geometrik işlemeleri ve zarif uç detaylarıyla modern ve şık bir görünüm sunan, el emeğiyle hazırlanmış Bella örtü.",
    Size = "1 metre",
    MainImage = "/images/products/cover-03.jpeg",

},
                  new Product
{
    Id = 8,
    Name = "Gece Çiceği Örtü",
    Category = "Örtü",
    Description = "Derin siyah tonu ve güçlü geometrik detaylarıyla asil ve dikkat çekici bir görünüm sunan, özenle hazırlanmış el emeği Bella örtü.",
    Size = "1 metre",
    MainImage = "/images/products/cover-05.jpeg",

},
                    new Product
{
    Id = 9,
    Name = "Gece Danteli Örtü",
    Category = "Örtü",
    Description = "Siyah tül üzerine işlenen belirgin dantel detaylarıyla klasik zarafeti modern bir görünümle buluşturan el emeği Bella örtü.",
    Size = "1 metre",
    MainImage = "/images/products/cover-05.jpeg",

                    },
                    new Product
{
    Id = 10,
    Name = "Sedef Işıltısı Çanta ve Örtü Takımı",
    Category = "Takım",
    Description = "İnce işlemeleri ve uyumlu tasarımıyla öne çıkan Sedef Işıltısı Seti, çanta ve örtünün zarafetini bir araya getirerek özel anlar için özenle hazırlanmış şık bir Bella dokunuşu sunar.",
    Size = "Örtü: 1 metre | Çanta: 20 x 12 cm",
    MainImage = "/images/products/set-01.png",
    DetailImage1 = "/images/products/bag-04.jpeg",
    DetailImage2 = "/images/products/cover-02.jpeg"
},
                    new Product
{
    Id = 11,
    Name = "Zarif Dokulu Beyaz Çanta ve Örtü Takımı",
    Category = "Takım",
    Description = "Beyaz tonların sade şıklığını ince işçilikle buluşturan Zarif Dokulu Beyaz Set; uyumlu çanta ve örtüsüyle özel günlere zarif, bütünlüklü ve özenli bir dokunuş katar.",
    Size = "Örtü: 1 metre | Çanta: 17 x 12 cm",
    MainImage = "/images/products/set-02.png",
    DetailImage1 = "/images/products/bag-01.jpeg",
    DetailImage2 = "/images/products/cover-03.jpeg"
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