// Tính niên 
using System;
namespace TinhNien
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            if ( t > 0 && t <= 11)
            {
                Console.Write("Thieu nhi");
            }
            if ( t > 11 && t <= 25)
            {
                Console.Write("Thieu nien");
            }
            if ( t > 25 && t <= 50)
            {
                Console.Write("Trung nien");
            }
            if ( t > 50)
            {
                Console.Write("Lao nien");
            }
        }
    }
}