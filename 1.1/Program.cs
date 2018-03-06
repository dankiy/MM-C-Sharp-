using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.1");
            Console.WriteLine();

            Int16 num;
            Console.Write("Enter number to get it's factorial: ");
            num = Convert.ToInt16(Console.ReadLine());
            UInt64 result = Factorial(num);
            if (result == 0)
            {
                Console.WriteLine("Number is less then 0");
            }
            else
            {
                Console.Write("Factorial: ");
                Console.Write(result);
            }
            Console.ReadKey();
        }
        static UInt64 Factorial(Int16 num)
        {
            UInt64 result = 1;
            if (num < 0)
                return 0;
            else
            {
                for (Int16 i = 1; i <= num; i++)
                {
                    result = result * Convert.ToUInt64(i);
                }
                return result;
            }
        }
    }
}
