// Kiểm tra số nguyên có phải là số chính phương?
// Số nguyên n được gọi là số chính phương khi n >= 0 và sqrt n là một số nguyên
using System;
namespace SoChinhPhuong
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            if ( n < 0 )
            {
                Console.Write("No");
                return;
            } 
            long sqrt = (long)Math.Sqrt(n);
            if (sqrt * sqrt == n)
            Console.Write("Yes");
            else 
            Console.Write("No");
        }    
    }
}