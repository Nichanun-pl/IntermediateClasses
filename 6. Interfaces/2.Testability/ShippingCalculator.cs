using System;
using System.Collections.Generic;
using System.Text;

namespace Testability
{
    public interface IShippingCalculator
    {
        float CalCalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalCalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
