using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            #region View'e Veri Aktarım Yöntemleri
            //ViewBag
            //Model
            //ViewData
            #endregion

            var product = new Product() { Name = "Iphone X", Price = 6000, Description = "Güzel Telefon" };

            #region ViewData
            /*
            ViewData["Category"] = "Telefonlar";
            ViewData["Product"] = product;
            */
            #endregion

            #region ViewBag
            /*
              ViewBag.Category = "Telefonlar";
              ViewBag.Product = product;
             */
            #endregion

            #region Model

           // return View(product);
            #endregion

            return View(product);
        }
        [HttpGet]
        public IActionResult List(int? id,string q)
        {
            //{controller}/{action}/{id?}
            //product/list/3
            //RouteData.Values["controller"]=product
            //RouteData.Values["action"]=list
            //RouteData.Values["id"]=3

            //İki yöntemle QueryStringe erişebiliriz.
            //1-Console.WriteLine(q);
            //2-Console.WriteLine(HttpContext.Request.Query["q"].ToString());
            //2-Console.WriteLine(HttpContext.Request.Query["min_price"].ToString());

            var products = ProductRepository.Products;
            if (id!=null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i => i.Name.Contains(q) || i.Description.Contains(q)).ToList();
            }


            var productViewModel = new ProductViewModel()
            {

                Products = products
            };

            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            //ilk olarak get motedu çalışıyor. Bizim create.cshtml dosyamız post olduğu için ikinci olarak altaki create metodu çalışıyor.
            ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(new Product());
        }
        [HttpPost]
        //public IActionResult Create(string Name, double Price, string Description, string ImgUrl, int CategoryId) iki işlemde aynı
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(p);
                return RedirectToAction("list");
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(p);
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            
                ProductRepository.EditProduct(p);
                return RedirectToAction("list");

        }
        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteRepository(ProductId);
            return RedirectToAction("list");
        }
    }
}
