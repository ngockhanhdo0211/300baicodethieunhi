// In các chữ số của một số nguyên n
// Nhập vào một số nguyên n
// Hãy in các chữ số của n theo thứ tự xuất hiện
using System;

namespace InChuSo
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool first = true;

            while (n > 0)
            {
                if (!first)
                {
                    Console.Write(" ");
                }

                Console.Write(n % 10);

                first = false;
                n /= 10;
            }
        }
    }
}