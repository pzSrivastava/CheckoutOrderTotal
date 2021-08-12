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
            Item item1 = new Product(25, "Bread","PAC");
            Item item2 = new Product(30, "Cockies", "PAC");
            Item item3 = new Product(25, "Banana", "WGT");
            Item item4 = new Product(50, "Wheat", "WGT");
            Item item5 = new Product(120, "Chicken", "WGT");        
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

        public double CalculateTotalPrice(double actucalPrice, string productType, int productQuantity)
        {
            return (actucalPrice * productQuantity);
        }
    }
}