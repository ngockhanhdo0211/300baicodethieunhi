// in số cuối cùng trong mảng
using System;
namespace SoCuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            Console.WriteLine(a[n - 1]);
        }
    }
}