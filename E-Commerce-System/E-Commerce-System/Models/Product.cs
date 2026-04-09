using E_Commerce_System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name , decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
