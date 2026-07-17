// Kiểm tra một số nguyên có là số tam giác
using System;
namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool check = false;
            for (long m = 1; m * (m + 1) / 2 <= n; m++)
            {
                if (m * (m + 1) / 2 == n)
                {
                    check = true;
                    break;
                }
            }
            if (check) 
            Console.Write("Yes");
            else 
            Console.Write("No");
        }
    }
}