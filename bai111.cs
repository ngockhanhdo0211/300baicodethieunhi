// Kiểm tra một số nguyên có là số chen
using System;
namespace SoChen
{
    class Program
    {
        static bool IsPrime(long x)
        {
            if ( x < 2)
            return false;
            for (long i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                return false;
            }
            return true;
        }
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            if (IsPrime(n) && IsPrime(n + 2))
            {
                Console.Write("Yes");
            } else
            {
                Console.Write("No");
            }
        }
    }
}