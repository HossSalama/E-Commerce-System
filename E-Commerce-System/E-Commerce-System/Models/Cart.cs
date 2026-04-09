using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Models
{
    public class Cart
    {
        private readonly List<CartItem> _items = new List<CartItem>();
        public IEnumerable<CartItem> Items => _items;

        public void AddItem(Product product, int quantity)
        {
            var Item = _items.FirstOrDefault(i => i.Product.Name == product.Name);
            if (Item != null)
            {
                Item.Quantity += quantity;
            }
            else
            {
                _items.Add(new CartItem(product, quantity));
            }
        }
        public void RemoveItem(string  name)
        {
            _items.RemoveAll(i => i.Product.Name == name);
        }
        public decimal CalculateTotal() => _items.Sum(item => item.GetSubTotal());
    }
}
