namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        public void Run()
        {
            Shape rectangle = new Rectangle(5, 10);
            Shape circle = new Circle(20);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}
