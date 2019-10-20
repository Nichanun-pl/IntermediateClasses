using System;

namespace Access_Modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promoto()
        {
            Console.WriteLine("Promoto logic changed.");
        }

    }
}
