using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Eklendi " + customer.CustomerNumber);
        }
    }
}
