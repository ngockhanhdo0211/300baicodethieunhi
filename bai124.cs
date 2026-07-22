// in mảng vừa nhập
using System;
namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] a = new int [n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}