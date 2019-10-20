using System;

namespace Access_Modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promoto()
        {
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("Promoto to Level 1");
            else
                Console.WriteLine("Promoto to Level 2");
        }

        public int CalculateRating()
        {
            return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var rating = customer.CalculateRating();
        }
    }
}
