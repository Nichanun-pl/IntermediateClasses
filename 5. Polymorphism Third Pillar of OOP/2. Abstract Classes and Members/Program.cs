namespace Abstract_Classes
{
    public class Rectangle : Shape
    {

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
