using System;
using Xunit;
using FluentAssertions;
using CheckoutOrderTotal;
using System.Collections;
using System.Collections.Generic;

namespace CheckoutOrderTotalKata
{
    public class CheckoutOrderTotalTest
    {
        Item lob;
        CheckoutItem checkoutObj;
        public CheckoutOrderTotalTest()
        {
            lob = new Product(25, "Bread");
             checkoutObj = new CheckoutItem();
        }

        [Fact]
        public void GetPriceFromProductName()
        {
            double expectedPrice = lob.getPrice();
            double actucalPrice = checkoutObj.ScanItem("Bread");           
            actucalPrice.Should().Be(expectedPrice);

        }

        [Fact]
        public void FindItemFromProductName()
        {
            var actucalItem = checkoutObj.FindItemByName("Bread");
            actucalItem.getName().Should().Be(lob.getName());

        }

        [Fact]
        public void FindOutTotalIncreasedPriceForOneProduct()
        {
            string productName = "Wheat";
            double actualTotalPrice = checkoutObj.CalculateTotalPrice(productName, 2);
            double expectedTotalPrice = 100;
            actualTotalPrice.Should().Be(expectedTotalPrice);
        }
        
        [Fact]
        public void FindOutTotalIncreasedPriceForMultipleProducts()
        {
            List<string> products =new List<string>() { "Wheat", "Bread", "Banana", "Chicken" };
           
            double actualTotalPrice = checkoutObj.CalculateTotalPrice(products);
            double expectedTotalPrice = 150;
            actualTotalPrice.Should().Be(expectedTotalPrice);
        }
        [Fact]
        public void FindOutTotalIncreasedPriceForSimilarProducts()
        {
            List<string> products = new List<string>() { "Wheat", "Wheat", "Wheat", "Wheat" };

            double actualTotalPrice = checkoutObj.CalculateTotalPrice(products);
            double expectedTotalPrice = 200;
            actualTotalPrice.Should().Be(expectedTotalPrice);
        }

        //[Fact]
        //public void FindOutTotalIncreasedPriceForProducts()
        //{
        //    List<string> products = new List<string>() { "Wheat", "Wheat", "Wheat", "Wheat" };

        //    double actualTotalPrice = checkoutObj.CalculateTotalPrice(products);
        //    double expectedTotalPrice = 200;
        //    actualTotalPrice.Should().Be(expectedTotalPrice);
        //}
    }
}
