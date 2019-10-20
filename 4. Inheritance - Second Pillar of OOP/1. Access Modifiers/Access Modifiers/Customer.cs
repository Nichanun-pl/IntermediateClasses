using System;

namespace Access_Modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promoto()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Promoto to Level 1");
            else
                Console.WriteLine("Promoto to Level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }

    }
}
