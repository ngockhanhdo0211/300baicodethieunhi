// Tìm chữ số lớn nhất của một số nguyên n
using System;
namespace SoMax
{
    class program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong min = 9;
            while(n > 0)
            {
                ulong digit = n % 10;
                if (digit < min)
                {
                    min = digit;
                }
                n = n / 10;
            }
            Console.WriteLine(min);
        }
    }
}