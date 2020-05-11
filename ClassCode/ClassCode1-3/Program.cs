using System;

namespace ClassCode1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double pro = num1 * num2;
            Console.WriteLine("The result is:\n{0}*{1}={2}",num1,num2,pro);
            Console.Read();
        }
    }
}
