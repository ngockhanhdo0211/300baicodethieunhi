// Kiểm tra một số nguyên có là số phong phú (Abundant)
using System;
namespace SoPhongPhu
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long sum = 0;
            for (long i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum > n)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }
    }
}