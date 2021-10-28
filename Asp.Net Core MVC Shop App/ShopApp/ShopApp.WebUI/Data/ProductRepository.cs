using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository //Static olduğu için nesne oluşturamaz.
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, Name="Iphone 7",Price=3000,Description="iyi telefon",IsApproved=false,ImageUrl="1.jpg",CategoryId=1},
                new Product{ProductId=2, Name="Iphone 8",Price=6000,Description="çok iyi telefon",IsApproved=true,ImageUrl="2.jpg",CategoryId=1},
                new Product{ProductId=3, Name="Iphone 9",Price=8000,Description="iyi telefon",ImageUrl="3.jpg",CategoryId=1},
                new Product{ProductId=4, Name="Iphone 11",Price=9000,Description="çok iyi telefon",IsApproved=true,ImageUrl="4.jpg",CategoryId=1},
                new Product{ProductId=5, Name="Lenova",Price=3000,Description="iyi bilgisayar",IsApproved=false,ImageUrl="1.jpg",CategoryId=2},
                new Product{ProductId=6, Name="Lenova 8",Price=6000,Description="çok iyi bilgisayar",IsApproved=true,ImageUrl="2.jpg",CategoryId=2},
                new Product{ProductId=7, Name="Lenova 9",Price=8000,Description="iyi bilgisayar",ImageUrl="3.jpg",CategoryId=2},
                new Product{ProductId=8, Name="Lenova 11",Price=9000,Description="çok iyi bilgisayar",IsApproved=true,ImageUrl="4.jpg",CategoryId=2},
                new Product{ProductId=9, Name="Lenova 11",Price=9000,Description="çok iyi bilgisayar",IsApproved=true,ImageUrl="2.jpg",CategoryId=1}
            };
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
        public static void EditProduct(Product product)
        {
            foreach (var p in _products)
            {
                if (p.ProductId == product.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.ImageUrl = product.ImageUrl;
                    p.Description = product.Description;
                    p.IsApproved = product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }
       public static void DeleteRepository(int id)
        {
            var product = GetProductById(id);
            if (product!=null)
            {
                _products.Remove(product);
            }
        }
    }
}
