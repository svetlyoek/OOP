namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Rectangle : Shape
    {
        private const int invalidHeightValue = 0;
        private const int invalidWidthValue = 0;

        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < invalidHeightValue)
                {
                    throw new InvalidHeightException();
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < invalidWidthValue)
                {
                    throw new InvalidWidthException();
                }

                this.width = value;
            }
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
