using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreatyShipptd_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }
    }

    public class FakeShippingCalculator : IshippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
