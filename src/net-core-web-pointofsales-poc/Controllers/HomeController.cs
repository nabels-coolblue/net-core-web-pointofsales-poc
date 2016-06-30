using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using net_core_web_pointofsales_poc.Models.WebshopViewModels;
namespace net_core_web_pointofsales_poc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<ProductModel>();

            products.Add(new ProductModel() { Id = 1, Name = "HP 15-af122nd ", ImageUrl = "http://tinyurl.com/z2ukhl7", Price = 699.0M });
            products.Add(new ProductModel() { Id = 2, Name = "Acer Aspire ES1-521-83ZG ", ImageUrl = "http://tinyurl.com/hczk5hq", Price = 899.0M });
            products.Add(new ProductModel() { Id = 3, Name = "Apple MacBook Pro Retina 13,3'' 256 GB - 2,7 GHZ  ", ImageUrl = "http://tinyurl.com/jeqkw4w", Price = 1539.0M });
            products.Add(new ProductModel() { Id = 4, Name = "Microsoft Surface Pro 4 - i5 - 8 GB - 256 GB ", ImageUrl = "http://tinyurl.com/gtwtle6", Price = 1449.0M });

            var productsModel = new ProductsModel() { Products = products };

            return View(productsModel);
        }

        public IActionResult ShowProduct(ProductModel product)
        {
            return View("ShowProduct", product);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
