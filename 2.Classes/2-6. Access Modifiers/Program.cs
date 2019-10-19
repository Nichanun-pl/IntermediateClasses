using System;

namespace Access_Modifiers
{
    public class Person
    {
        private DateTime _birthdate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
        }
    }
}
