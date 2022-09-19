using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpKursu
{
    public class ProductManager
    {
        //encapsulation 
        public void Add(Product product)
        {
            //Referans olduğu için değiştirmiş oluyoruz
            //product.ProductName = "Kamera";

            Console.WriteLine(product.ProductName+ " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public void AddInfo(Product product)
        {
            Console.WriteLine("Sepete eklendi:"+product.ProductName);
        }

    }
}
