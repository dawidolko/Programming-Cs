using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK1
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int height, int width) : base(x, y, height, width) { }

        public override void Draw()
        {
            Console.WriteLine("\n\nDrawing a rectangle!");
            base.Draw();
        }
    }

}
