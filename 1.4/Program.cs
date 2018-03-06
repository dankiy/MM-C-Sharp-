using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.4");
            Console.WriteLine();

            Console.Write("N: ");
            UInt16 n = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine();
            int[,] arr = new int[n, n];
            for (UInt16 k = 0; k < n; k++)
            {
                for (UInt16 t = 0; t < n; t++)
                {
                    arr[k, t] = k * 10 + t;
                    Console.Write(arr[k, t]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Spiral: ");
            int i = n / 2;
            int j = n / 2;
            while (i >= 0)
            {
                Circle(arr, i, j, n);
                i--;
                j--;
            }
            
            Console.ReadKey();
        }
        static void Circle(int[,] arr, int i, int j, UInt16 n)
        {
            if (i == n / 2)
            {
                Console.Write(arr[i, j]);
                Console.Write(' ');
            }
            else
            {
                n--;
                while (j < n - i)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                    j++;
                }
                while (i < j)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                    i++;
                }
                while (j > n - i)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                    j--;
                }
                while (i > j)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                    i--;
                }
            }
        }
    }
}
