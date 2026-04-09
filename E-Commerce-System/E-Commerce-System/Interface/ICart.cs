using E_Commerce_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Interface
{
    public interface ICart
    {
        IEnumerable<CartItem> Items { get; }
        void AddItem(Product product, int quantity);
        void RemoveItem(string name);
        decimal CalculateTotal();
    }
}
