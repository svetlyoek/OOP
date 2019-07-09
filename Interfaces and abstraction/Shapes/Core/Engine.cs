namespace Shapes.Core
{
    using Shapes.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        public void Run()
        {
            try
            {
                var radius = int.Parse(Console.ReadLine());
                IDrawable circle = new Circle(radius);

                var width = int.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                IDrawable rectangle = new Rectangle(width, height);

                circle.Draw();
                rectangle.Draw();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
