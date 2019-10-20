using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle");
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a Rectangle");
                        break;

                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a Triangle");
                        break;
                }
            }
        }
    }
}
