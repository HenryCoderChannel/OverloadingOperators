using System;

namespace OverloadingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            Fraction f2 = new Fraction(9, 2);

            Console.WriteLine($"-f: {-f}");

            Console.WriteLine($"{f} + {7} = {f + 7}");
            
            Console.WriteLine($"{f} + {f2} = {f + f2}");

            Console.WriteLine($"{f} == {f2} : {f == f2}");

            Console.WriteLine($"{f} != {f2} : {f != f2}");

            // Implicitly convert Int -> Fraction
            // ==> ALWAYS SUCCEED
            Fraction f3 = 91;
            // f3 = 9/1
            Console.WriteLine($"Convert {91} to Fraction: {f3}");

            // Explicitly convert Fraction -> Int
            // ==> EXCEPTION if denominator != 1 (9/2, 8/3,...)
            int x = (int)f3;
            // x = 91 (because of 91/1 = 91)
            Console.WriteLine($"Convert {f3} to Int: {x}");

            // ==> EXCEPTION
            //Console.WriteLine($"Convert {f2} to Int: {(int)f2}");   

            Console.ReadLine();

        }
    }
}
