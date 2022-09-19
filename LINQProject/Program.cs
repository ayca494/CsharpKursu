using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Acer laptop",QuantityPerUnit="32 gb ram",UnitPrice=10000,UnitInStock=5},
                new Product{ProductId=2, CategoryId=1,ProductName="Asus laptop",QuantityPerUnit="16 gb ram",UnitPrice=8000,UnitInStock=3},
                new Product{ProductId=3, CategoryId=1,ProductName="Hp laptop",QuantityPerUnit="8 gb ram",UnitPrice=10000,UnitInStock=2},
                new Product{ProductId=4, CategoryId=2,ProductName="Samsung Tel",QuantityPerUnit="4 gb ram",UnitPrice=5000,UnitInStock=15},
                new Product{ProductId=5, CategoryId=2,ProductName="Apple Tel",QuantityPerUnit="4 gb ram",UnitPrice=8000,UnitInStock=0}
            };

            //Test(products);

            //NewMethod(products);5

            //foreach (var item in GetProducts(products))
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //bir listenin içerisinde arama yapma bool döner
            var result = products.Any(p => p.ProductName == "Acer laptop");
            Console.WriteLine(result);

            Console.WriteLine("********************************************");
            //Find aradığımız kritere uygun nesnenin kendisini veriyor
            var result1 = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result1.ProductName);
            //gerçek hayatta bir ürünün detayına gitmek için kullanabiliriz


            Console.WriteLine("********************************************");
            //Şarta uyan bütün elemanları getir
            var result2 =products.FindAll(p=>p.ProductName.Contains("top"));
            Console.WriteLine(result2); //liste dönüyor 
            foreach (var item in result2)
            {
                Console.WriteLine(item.ProductName);
            }


            Console.WriteLine("********************************************");
            //hem adında top geçenleri hemde fiyata göre sıraladık 
            var result3 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p=>p.UnitPrice); //OrderByDescending yüksekten düşüğe sıralıyor OrderBy da tam tersi
            foreach (var item in result3)
            {
                Console.WriteLine(item.ProductName);
            }


            Console.WriteLine("********************************************");
            //İki fiyat eşit 10000 diyelim hangisi önce gelecek ThenBy dersek A'dan Z'ye sıralar ThenByDescending 'den A'ya sıralıyor ama incesinde orderby yapıyoruz
            var result4 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p=>p.ProductName);
            foreach (var item in result4)
            {
                Console.WriteLine(item.ProductName);
            }



            Console.WriteLine("********************************************");
            //LINQ şu şekilde de yazabiliyoruz

            var result5 = from p in products
                          where p.UnitPrice>6000
                          orderby p.UnitPrice descending, p.ProductName ascending
                          select p;
            //Dto ile yapmak istersek class oluşturuyoruz ProductDto diye proplar yazıyoruz içine Productta olan fakat Productta olmayan da yazabiliriz onu join yaparak kullanabiliriz
            //select new ProductDto{ProductId = p.ProductId, ProductName=p.ProductName, UnitPrice=p.UnitPrice};


            foreach (var item in result5)
            {
                Console.WriteLine(item.ProductName);
            }


            Console.WriteLine("****************** JOIN **************************");
            var result6 = from p in products
                          join c in categories
                          on p.CategoryId equals c.CategoryId
                          where p.UnitPrice>5000
                          orderby p.UnitPrice ascending
                          select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result6)
            {
                Console.WriteLine("{0}----{1}",productDto.ProductName,productDto.CategoryName);
            }
        }

        private static void Test(List<Product> products)
        {
            //bunun yerine LINQ kullanıyoruz
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }

        private static void NewMethod(List<Product> products)
        {
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}
