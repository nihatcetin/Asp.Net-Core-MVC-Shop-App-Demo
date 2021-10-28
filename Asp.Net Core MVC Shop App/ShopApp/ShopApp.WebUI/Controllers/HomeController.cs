using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    // localhost:5000
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           

            var productViewModel = new ProductViewModel()
            {
                
                Products = ProductRepository.Products
            };

            return View(productViewModel);

        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
