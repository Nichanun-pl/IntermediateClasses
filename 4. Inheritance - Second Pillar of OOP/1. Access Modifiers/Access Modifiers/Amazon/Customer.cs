using System;

namespace Amazon
{
    public class RateCalculator
    {
        public int Calculator(Customer customer)
        {
            return 0;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promoto()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculator(this);
            
            Console.WriteLine("Promote logic changed.");
        }

    }
}
