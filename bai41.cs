// Kiểm tra hai số nguyên cùng dấu hay khác dấu
using System;
namespace SoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            
            if (a == 0 && b == 0)
            {
                Console.Write("0");
            }
            if (( a > 0 && b > 0) || (a < 0 && b < 0))
            {
                Console.Write("1");
            }
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                Console.Write("-1");
            }
        }
    }
}