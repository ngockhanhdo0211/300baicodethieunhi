// Tính tổng các số chẵn
using System;
namespace TongChuSoChan
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int sum = 0;
            while(n > 0)
            {
                int digit = (int)(n % 10);
                if(digit % 2 == 0)
                {
                    sum += digit;
                }
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}