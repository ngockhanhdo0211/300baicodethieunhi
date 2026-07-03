// Tính tổng những số từ nhiên từ 1 đến n
using System;
namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.Write(sum);
        }
    }
}