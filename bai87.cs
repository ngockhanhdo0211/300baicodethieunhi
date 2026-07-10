// In các chữ số chẵn của một số nguyên n
using System;
namespace ChuSoChan
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool check = false;
            while(n > 0)
            {
                int digit = (int)(n % 10);
                if (digit % 2 == 0)
                {
                    Console.Write(digit + " ");
                    check = true;
                }
                n /= 10;
            }
            if(!check)
            {
                Console.Write("-");
            }
        }
    }
}