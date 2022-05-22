using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_camp
{
    public class Check
    {
        public void check(Buy buy)
        {
            Console.WriteLine($"Purchased {buy.product.Name}, {buy.quantity} stuck, total price: {buy.price}");
        }
    }
}
