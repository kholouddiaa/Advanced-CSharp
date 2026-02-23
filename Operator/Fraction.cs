using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public static int Counter { get; private set; }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;

            Simplify();
            Counter++;
        }

        public static int GetFractionCount() => Counter;

        public static int GCD(int a, int b)
        {
            if (b == 0) return Math.Abs(a);
            return GCD(b, a % b);
        }

        public void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        public void Display()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
            => new Fraction(
                f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator,
                f1.Denominator * f2.Denominator);

        public static Fraction operator -(Fraction f1, Fraction f2)
            => new Fraction(
                f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator,
                f1.Denominator * f2.Denominator);

        public static Fraction operator *(Fraction f1, Fraction f2)
            => new Fraction(
                f1.Numerator * f2.Numerator,
                f1.Denominator * f2.Denominator);

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.Numerator == 0)
                throw new DivideByZeroException();

            return new Fraction(
                f1.Numerator * f2.Denominator,
                f1.Denominator * f2.Numerator);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (ReferenceEquals(f1, f2)) return true;
            if (f1 is null || f2 is null) return false;

            return f1.Numerator == f2.Numerator &&
                   f1.Denominator == f2.Denominator;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
            => !(f1 == f2);

        public static bool operator <(Fraction f1, Fraction f2)
            => f1.Numerator * f2.Denominator
               < f2.Numerator * f1.Denominator;

        public static bool operator >(Fraction f1, Fraction f2)
            => f1.Numerator * f2.Denominator
               > f2.Numerator * f1.Denominator;
    }
}