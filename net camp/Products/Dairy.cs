using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_camp.Products
{
    public class Dairy : Product
    {
        public int expires_in;
        public override void ChangePrice(int percentage)
        {
            Price = Price * percentage / 100;
        }
    }
}
