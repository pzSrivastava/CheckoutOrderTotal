using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutOrderTotal
{
    public class ProductByWeight  : Item
    {
        private readonly string productName;
        private readonly double weightInKg;
        private readonly double pricePerKg;
        public ProductByWeight(string productName,double weightInKg, double pricePerKg)
        {
            this.weightInKg = weightInKg;
            this.pricePerKg = pricePerKg;
            this.productName = productName;
        }
     
        public double getPricePerKg()
        {
            return this.pricePerKg;
        }
        
        public double getWeightInKg()
        {
            return this.weightInKg;
        }

        public string getName()
        {
          return  this.productName;
        }

       public double getPrice()
        {
            return this.pricePerKg;
        }
    }
}
