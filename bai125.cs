// In ngược lại của mảng
using System;
namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int [] a = new int[n];
            for (int i = 0; i < n; i++ )
            {
                a[i] = int.Parse (input [i]);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}