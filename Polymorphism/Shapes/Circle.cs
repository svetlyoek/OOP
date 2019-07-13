namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Circle : Shape
    {
        private const int MIN_RADIUS = 0;

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;

        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value < MIN_RADIUS)
                {
                    throw new InvalidRadiusException();
                }

                this.radius = value;
            }
        }


        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
