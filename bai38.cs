// Tính mùa trong năm
using System;
namespace TinhMua
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            if (t >= 2 && t <= 4)
            {
                Console.Write("Mua Xuan");
            }
            if (t >= 5 && t <= 7)
            {
                Console.Write("Mua Ha");
            }
            if (t >= 8 && t <= 10)
            {
                Console.Write("Mua Thu");
            }
            if (t >= 11 && t <= 12)
            {
                Console.Write("Mua Dong");
            } 
            if (t == 1)
            {
                Console.Write("Mua Dong");
            }
        }
    }
}