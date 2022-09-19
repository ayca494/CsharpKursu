// See https://aka.ms/new-console-template for more information

using CsharpKursu;

Product product = new Product();
product.Id = 1;
product.CategoryId = 2;
product.ProductName = "Masa";
product.UnitPrice = 500;
product.UnitsInStock = 3;

Product product1 = new Product
{
    Id = 2,
    CategoryId = 5,
    UnitsInStock = 5,
    ProductName = "Kalem",
    UnitPrice = 35
};

//PascalCase   //camelCase
ProductManager productManager = new ProductManager();
productManager.Add(product1);

//referans olduğu için değişmiş oldu
Console.WriteLine(product1.ProductName);

Product[] product2 = new Product[] { product, product1};

foreach (var pro in product2)
{
    Console.WriteLine(pro.Id+" "+pro.ProductName +" " +pro.UnitPrice);
}



productManager.AddInfo(product);
productManager.AddInfo(product1);

