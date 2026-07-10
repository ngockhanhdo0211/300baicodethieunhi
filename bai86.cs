// Tính tổng các chữ số của một số nguyên n
using System;
namespace TongChuSo
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int sum = 0;
            while(n > 0 )
            {
                sum += (int)(n % 10);
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}