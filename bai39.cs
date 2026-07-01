// Tính mùa trong 2 năm
using System;
namespace TinhMua
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            if ( t >= 0 && t <= 20)
            {
                Console.Write("Mua Dong");
            }
            if ( t >= 21 && t <= 25)
            {
                Console.Write("Mua Xuan");
            }
            if ( t >= 26 && t <= 30)
            {
                Console.Write("Mua Thu");
            }
            if ( t > 30)
            {
                Console.Write("Mua Ha");
            }
        }
    }
}