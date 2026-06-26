// Tính chu vi và diện tích hình trong
using System;
namespace ChuVi
{
    class Program
    {
        static void Main(string[] args)
        {
            int r  = int.Parse(Console.ReadLine());
            double cv = r * 2 * 3.14;
            double dt = r * r * 3.14;
            Console.Write($"{cv:F2}" + " " + $"{dt:F2}" );
        }
    }
}