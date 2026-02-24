using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Rectangle : IShape
    {  
        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
        public void Area()
        {
           Console.WriteLine($"Area of Rectangle: {Width * Height}");
        }

        public float Perimeter()
        {
         return 2 * (Width + Height);
        }
    }
}
