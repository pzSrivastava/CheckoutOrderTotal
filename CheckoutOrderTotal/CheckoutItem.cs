using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutOrderTotal
{
    public class CheckoutItem
    {
        IList<Item> itemList = new List<Item>();
        public CheckoutItem()
        {
            Item item1 = new Product(25, "Bread");
            Item item2 = new Product(30, "Cockies");
            Item item3 = new Product(25, "Banana");
            Item item4 = new Product(50, "Wheat");
            Item item5 = new Product(50,"Chicken");
            //Item item4 = new ProductByWeight("Wheat",1,50);
            //Item item5 = new ProductByWeight("Chicken",1, 50);
            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);
            itemList.Add(item5);
         
        }


        public double ScanItem(string itemName)
        {
            return FindItemByName(itemName).getPrice();

        }

        public Item FindItemByName(string itemName)
        {
            foreach (var item in itemList)
            {
                if (item.getName().Equals(itemName))
                {
                    return item;
                }
            }

            return null;
        }

        public double CalculateTotalPrice(string productName, int productQuantity)
        {
            var itemDetails = FindItemByName(productName);
            var  actualPrice = itemDetails.getPrice();
            return (actualPrice * productQuantity);
        }
        public double CalculateTotalPrice(List<string> products)
        {
            double totalPrice = 0; 
            double actualPrice;
            
            foreach (var item in products)
            {
                var itemDetails = FindItemByName(item);
                actualPrice = itemDetails.getPrice();
                totalPrice += actualPrice;

            }

            return totalPrice;
        }
    }
}