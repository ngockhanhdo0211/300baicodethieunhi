// in số ở vị trí k trong mảng
using System;
namespace ViTriMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int [] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(parts[i]);
            }
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(a[k]);

        }
    }
}