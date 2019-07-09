using Shapes.Exceptions;
using System;

namespace Shapes.Models
{
    public class Rectangle : IDrawable
    {
        private const int MIN_WIDTH = 1;
        private const int MIN_HEIGHT = 1;

        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < MIN_WIDTH)
                {
                    throw new ArgumentException(ExceptionMessages.invalidWidth);
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < MIN_HEIGHT)
                {
                    throw new ArgumentException(ExceptionMessages.invalidHeight);
                }

                this.height = value;
            }
        }
        public void Draw()
        {
            DrawLine(this.Width, '*', '*');

            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ');
            }

            DrawLine(this.Width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);

            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }

            Console.WriteLine(end);
        }

    }
}
