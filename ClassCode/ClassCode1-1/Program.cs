using System;

namespace ClassCode1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j = 10;
            Console.WriteLine("{0}plus{1}equals{2}", i, j, i + j);
            Console.WriteLine("{i}plus{j}equals{i+j}");
            int first = 940, second = 89;
            Console.WriteLine("{0,4}\n+{1,4}----\n{2,4}", first, second, first + second);
            Console.WriteLine();
            decimal one = 912329M, two = 88.433M;
            Console.WriteLine("{0,9:C2}\n+{1,9:C2}\n------\n{2,9:C2}", one, two, one + two);
            Console.WriteLine();
            double d = 08.987;
            Console.WriteLine("{0:#0.00}", d);
            Console.Read();
        }
    }
}
