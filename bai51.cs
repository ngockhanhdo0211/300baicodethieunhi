// Tính tiền điện
using System;
namespace TienDien
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long Tien = 0;
            if (n <= 50)
            {
                Tien = n * 600;
            } else if (n > 50 && n <= 100)
            {
                Tien = 50 * 600 + (n - 50) * 800;
            } else if ( n > 100 && n <= 200)
            {
                Tien = 50 * 600 + 50 * 800 + (n - 100) * 1100;
            } else
            {
                Tien = 50 * 600 + 50 * 800 +  100 * 1100 + (n - 200) * 1500;
            }
            Console.WriteLine(Tien);
        }
    }
}