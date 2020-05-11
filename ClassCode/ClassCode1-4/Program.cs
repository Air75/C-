using System;

namespace ClassCode1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            int sum = 0;
            for(int i = num1; i <= num2; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("{0}到{1}的累加和为：{2}",num1,num2,sum);
            Console.Read();
        }
    }
}
