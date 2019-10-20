using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testability.UnitTest;

namespace Testability.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTION

        [TestMethod]
        public void Process_OrderIsAlreatyShipptd_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
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
