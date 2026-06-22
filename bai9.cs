using System;
namespace TinhGiaTriBieuThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double P = 21.0 * a + 5.0 * b -2009.0;

            double Q = (21.0 * Math.Pow(a, 2) - 5 * b) / (2009.0 * Math.Pow(b, 2));
            double R = (21.0 * a + 5.0 * Math.Pow(b, 2)) / (2009.0 * b + 15);
            Console.Write($"{P} {Q:F4}" );
            Console.WriteLine();
            Console.WriteLine($"{R:F6}");
        }
    }
}