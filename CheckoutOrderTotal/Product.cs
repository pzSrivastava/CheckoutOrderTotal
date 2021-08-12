using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutOrderTotal
{
    public class Product : Item
    {
        private double Price;
        private string ProductName;
        private string ProductType;
        public Product(double Price,string name,string type)
        {
            this.Price = Price;
            this.ProductName = name;
            this.ProductType = type;
        }
        public string getName()
        {
            return ProductName;
        }

        public double getPrice()
        {
            return Price;
        }

        public string getType()
        {
            return ProductType;
        }
    }
}
