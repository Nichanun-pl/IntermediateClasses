using System;
using System.Collections.Generic;
using System.Text;

namespace Testability
{
    public class ShippingCalculator
    {
        public float CalCalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
