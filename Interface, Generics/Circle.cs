using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Circle : IShape

    {
        public float Radius { get; set; }
        public Circle(float radius)
        {
            Radius = radius;
        }
        public void Area()
        {
            Console.WriteLine($"Area of Circle: {Math.PI * Radius * Radius}");
        }

  public float  Perimeter()
        {

           return 2 * (float)Math.PI * Radius;
        }
    }
}
