using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_camp
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public float Weighth { get; set; }
        public virtual void ChangePrice(int percentage)
        {
            Price = Price * percentage/100;
        }
    }

   
}
