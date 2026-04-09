using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System
{
    public class FixedDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double total){ return total - 50; }
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double total) { return total * 0.9; }
    }
}
