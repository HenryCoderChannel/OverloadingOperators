using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingOperators
{
    public class Fraction
    {
        private readonly int num;
        private readonly int den;

        public Fraction (int numerator, int denominator)
        {
            if (denominator == 0) throw new Exception("Denominator can't be 0");
            num = numerator;
            den = denominator;
        }

        public static Fraction operator - (Fraction f)
        {
            return new Fraction(-f.num, f.den);
        }

        // Fraction + Int
        public static Fraction operator + (Fraction f, int number)
        {
            return new Fraction(f.num + (number * f.den), f.den);
        }

        // Fraction + Fraction
        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            return new Fraction((f1.num * f2.den + f2.num * f1.den), f1.den * f2.den);
        }

        #region Couple Operators
        public static bool operator == (Fraction f1, Fraction f2)
        {
            return f1.num == f2.num && f1.den == f2.den;
        }

        public static bool operator != (Fraction f1, Fraction f2)
        {
            return !(f1.num == f2.num && f1.den == f2.den);
        }
        #endregion

        public static implicit operator Fraction (int number)
        {
            return new Fraction(number, 1);
        }

        public static explicit operator int (Fraction f)
        {
            if (f.den != 1) throw new Exception("CANNOT Convert");
            return f.num;
        }

        public override string ToString()
        {
            return $"{num}/{den}";
        }

    }
}
