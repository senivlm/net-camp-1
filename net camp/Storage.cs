using net_camp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_camp
{
    public class Storage
    {
        private int counter = 0;
        public Product[] Products = new Product[20];
        public Product this[int i]
        {
            get { return Products[i]; }
            set { Products[i] = value; }
        }

        public int GetPercentage(Meat product)
        {
            return (int)product.category;
        }
        public int GetPercentage(Dairy product)
        {
            return product.expires_in * 2;
        }
        public void AddProduct(Product product)
        {
            Products[counter] = product;
            counter++;
        }
        public void ChangePrice(int percentage)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                Products[i].Price = Products[i].Price * percentage / 100;
            }
        }
        public void GetAll()
        {
            for (int i = 0; i < counter; i++)
            {
                if (Products[i].GetType() == typeof(Meat))
                {
                    Meat meat = (Meat)Products[i];
                    Console.WriteLine($"{meat.Name}, costs {meat.Price}, weight {meat.Weighth}, category {meat.category}, type {meat.type}");
                }
                if (Products[i].GetType() == typeof(Dairy))
                {
                    Dairy meat = (Dairy)Products[i];
                    Console.WriteLine($"{meat.Name}, costs {meat.Price}, weight {meat.Weighth}, expires_in {meat.expires_in}");

                }
            }
        }
    }
}

