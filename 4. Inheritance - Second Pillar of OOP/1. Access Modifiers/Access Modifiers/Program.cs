using System;

namespace Access_Modifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {

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
