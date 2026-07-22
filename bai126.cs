// Thay giá trị của số ở vị trí k thành x
using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();

            int[] a = new int[n];

            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(input[i]);
            }

            int k = int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());

            // thay giá trị
            a[k] = x;

            // in mảng
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}