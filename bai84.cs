// Tìm số lượng chữ số của một số nguyên n
using System;
namespace DemChuSo
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}