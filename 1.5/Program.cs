using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.5");
            Console.WriteLine();

            int[,] arr = new int[10, 10];
            Random rnd = new Random();
            Console.WriteLine("Before sort: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    arr[i, j] = rnd.Next() % 100;
            }
            Show(arr);
            for (int i = 0; i < 9; i++)
            {
                int k = i;
                while ((k >= 0) && (arr[0, k + 1] < arr[0, k]))
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int tmp = arr[j, k];
                        arr[j, k] = arr[j, k + 1];
                        arr[j, k + 1] = tmp;
                    }
                    k--;
                }
            }
            Console.WriteLine();
            Console.WriteLine("After Sort: ");
            Show(arr);
            Console.ReadKey();
        }
        static void Show(int[,] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

    }
}