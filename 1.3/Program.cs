using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.3");
            Console.WriteLine();
            int[] arr = new int[50];
            Random rnd = new Random();
            Console.WriteLine("Before sort: ");
            for (int i = 0; i < 50; i++)
            {
                arr[i] = rnd.Next() % 100;
            }
            Show(arr);
            for (int i = 0; i < 49; i++)
            {
                int j = i;
                while ((j >= 0) && (arr[j + 1] < arr[j]))
                {
                    int tmp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = tmp;
                    j--;
                }
            }
            Console.WriteLine();
            Console.WriteLine("After Sort: ");
            Show(arr);
            Console.ReadKey();
        }
        static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
        }

    }
}
