// Đếm số lượng chữ số lẻ của một số nguyên n
using System;
namespace SoLe
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int dem = 0;
            while (n > 0)
            {
                long digit = n % 10;
                if (digit % 2 != 0)
                {
                    dem++;
                }
                n = n / 10;
            }
            Console.Write(dem);

        }
    }
}