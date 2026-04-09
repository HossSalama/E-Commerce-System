using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Interface
{
    public interface ITaxStrategy
    {
        double ApplyTax(double total);
    }
}
