using System;
using Xunit;
using FluentAssertions;
using CheckoutOrderTotal;

namespace CheckoutOrderTotalKata
{
    public class CheckoutOrderTotalTest
    {
        Item lob;
        public CheckoutOrderTotalTest()
        {
            lob = new Product(25, "Bread","PAC");
        }

        [Fact]
        public void GetPriceFromProductName()
        {
            double expectedPrice = lob.getPrice();
            double actucalPrice = new CheckoutItem().ScanItem("Bread");           
            actucalPrice.Should().Be(expectedPrice);

        }

        [Fact]
        public void FindItemFromProductName()
        {
            var actucalItem = new CheckoutItem().FindItemByName("Bread");
            actucalItem.getName().Should().Be(lob.getName());

        }

        [Fact]
        public void FindOutTotalIncreasedPriceForOneProduct()
        {
            var actucalItem = new CheckoutItem().FindItemByName("Wheat");
            double actualTotalPrice = new CheckoutItem().CalculateTotalPrice(actucalItem.getPrice(), actucalItem.getType(), 2);
            double expectedTotalPrice = 100;
            actualTotalPrice.Should().Be(expectedTotalPrice);
        }
    }
}
