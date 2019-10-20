using System;

namespace Access_Modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promoto()
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
