// Kiểm tra một số nguyên có là số hoàn hảo
using System;
namespace SoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            for(int i = 1; i <= n - 1; i++)
            {
                if(n % i == 0)
                {
                    tong += i;
                }
            }
            if (tong == n)
            {
                Console.Write("Yes");
            } else
            {
                Console.Write("No");
            }
        }
    }
}