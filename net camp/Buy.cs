using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_camp
{
    public class Buy
    {
        public Product product { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public float totalWeight { get; set; }
        public Buy(Product _product, int _quantity)
        {
            product = _product;
            quantity = _quantity;
            price = quantity * product.Price;
            totalWeight = quantity * product.Weighth;
        }
    }
}
