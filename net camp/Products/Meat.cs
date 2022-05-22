using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_camp.Products
{
    public class Meat : Product
    {
        public Category category;
        public Type type;
        public override void ChangePrice(int percentage)
        {
            Price = Price * percentage / 100;
        }
        public enum Category : int
        {
            Type_one = 5,
            Type_two = 3
        }
        public enum Type : int
        {
           Veal = 0,
           Cow = 1,
           Pork = 2,
           Chicken = 3
        }
    }
}
