// Tính tổng những số nguyên từ m đến n
using System;
namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = m; i <= n; i++)
            {
                sum += i;
            }
            Console.Write(sum);
        }
    }
}