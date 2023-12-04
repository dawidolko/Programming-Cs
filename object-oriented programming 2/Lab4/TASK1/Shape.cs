using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK1
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Shape(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape at X: {0}, Y: {1} with Height: {2} and Width: {3}", X, Y, Height, Width);
        }
    }
}
