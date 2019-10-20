﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        Console.WriteLine("Draw a Rectangle");
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
    }

    public virtual void Draw()
    {

    }
}