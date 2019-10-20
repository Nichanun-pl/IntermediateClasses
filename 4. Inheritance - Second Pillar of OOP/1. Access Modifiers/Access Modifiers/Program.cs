using System;

namespace Access_Modifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            var rsting = this.CalculateRating(excludeOrders: true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}
