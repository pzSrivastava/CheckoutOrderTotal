using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutOrderTotal
{
    public class Product : Item
    {
        private double Price;
        private string ProductName;
        public Product(double Price,string name)
        {
            this.Price = Price;
            this.ProductName = name;
        }
        public string getName()
        {
            return ProductName;
        }

        public double getPrice()
        {
            return Price;
        }

    }
}
