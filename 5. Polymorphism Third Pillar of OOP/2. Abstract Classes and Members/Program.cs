using System;

namespace Abstract_Classes
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
            
            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
