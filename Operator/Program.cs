using System;
using System.ComponentModel.Design;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Fraction f1 = new Fraction(5,10 );
            Fraction f2 = new Fraction(70, 80  );
            Fraction f3 = new Fraction();
           
            f1.Simplify();
            f1.Display() ;
            f2.Simplify();
            f2.Display();
            Console.WriteLine("Counter of Fraction");
            Console.WriteLine(Fraction.Counter);
            //--------------------------------------operator( + )-------------------------------------------------------

            f3 =  f1 + f2;
            Console.WriteLine($"f1{f1} + f2 {f2} ");
            f3.Display();
            Console.WriteLine("Counter of Fraction");

            Console.WriteLine( Fraction.Counter);
            //--------------------------------------operator( - )-------------------------------------------------------

            f3 = f1 - f2;
            Console.WriteLine( $"f1{f1} - f2 {f2} ");
            f3.Display();
            Console.WriteLine("Counter of Fraction");

            Console.WriteLine(Fraction.Counter);

            //--------------------------------------operator( * )-------------------------------------------------------

            f3 = f1 * f2;
            Console.WriteLine($"f1{f1} * f2 {f2} ");
            f3.Display();
            Console.WriteLine("Counter of Fraction");

            Console.WriteLine(Fraction.Counter);

            //--------------------------------------operator( / )-------------------------------------------------------

            f3 = f1 * f2;
            Console.WriteLine($"f1{f1} / f2 {f2} ");
            f3.Display();
            Console.WriteLine( "Counter of Fraction");
            Console.WriteLine(Fraction.Counter);


            //--------------------------------------operator( == )-------------------------------------------------------

            if (f1 == f2)
            {
                Console.WriteLine($" f1 equale f2 ");
            }
            else
            {
                Console.WriteLine($" f1  not equale f2 ");

            }
            //--------------------------------------operator( != )-------------------------------------------------------

            if (f1 != f2)
            {
                Console.WriteLine($" f1 not equale  f2 ");
            }
            else
            {
                Console.WriteLine($" f1   equale f2 ");

            }



        }
    }
}
