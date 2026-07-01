// Tính tiền taxi
using System;
namespace TienTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            long  n = long.Parse(Console.ReadLine());
            long tien = 0;
            if (n == 1)
            {
                tien = 12000;
            } else if (n <= 30)
            {
                tien = 12000 + (n -1) * 10000;
            } else if (n > 31)
            {
                tien = 12000 + 29 * 10000 + (n - 30) * 9000;
            }
            Console.WriteLine(tien);
        }
    }
}