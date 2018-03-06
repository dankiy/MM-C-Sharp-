using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.2");
            Console.WriteLine();

            UInt64 num;
            Console.Write("Enter number to get it's Fibonacci: ");
            num = Convert.ToUInt64(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Number is less then 0");
            }
            else
            {
                UInt64 result = Fibonacci(num);
                Console.Write("Fibonacci: ");
                Console.Write(result);
            }
            Console.ReadKey();
        }
        static UInt64 Fibonacci(UInt64 num)
        {
            if ((num == 1) || (num == 2))
                return 1;
            else
                return Fibonacci(num - 2) + Fibonacci(num - 1);
        }
    }
}
